using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

using CSCInventarios.EL;
using CSCInventarios.BL;

using Microsoft.Practices.Unity;    

namespace UI.WEB
{
    public partial class SolicitarMaterial : System.Web.UI.Page//:  BasePage<SolicitarMaterial> 
    {
        [Dependency]
        ISolicitudBL solicitudBL { get; set; }
        [Dependency]
        public IMaterialBL materialBl { get; set; }
        [Dependency]
        public IUsuarioBL usuarioBL { get; set; }
        [Dependency]
        public IEstacionBL estacionBL { get; set; }

        private const string VARSOLICITUD = "solicitud";
        private const string VARMATERIAL = "material";


        public SolicitarMaterial() {
            materialBl = new MaterialBL();
            solicitudBL = new SolicitudBL();
        }

        protected void Page_Load(object sender, EventArgs e)
        {

        }


        private void SolicitudDataBind(Solicitud solicitud)
        {
            
            txtSolicId.Text = solicitud.sl_id.ToString();
            txtSolicFecha.Text= solicitud.sl_fecha.ToString();
            
            ddlEstaciones.SelectedValue = solicitud.estacion_id.ToString();
            ddlUsuarios.SelectedValue = solicitud.usuario_id.ToString();

            gvDetalleSolicitud.DataSource = solicitud.DetalleSolicitud;
            gvDetalleSolicitud.DataBind();

            Cache.Insert(VARSOLICITUD, solicitud);
        }
 
        protected void lbBuscarMaterial_Click(object sender, EventArgs e)
        {

        }

        protected void btnBuscMaterial_Click(object sender, EventArgs e)
        {

        }

        protected void gvMateriales_SelectedIndexChanged(object sender, EventArgs e)
        {
            GridViewRow row = gvMateriales.SelectedRow;
            var mat_id = int.Parse(row.Cells[1].Text);
                
            var material = materialBl.LeerMaterialPorMaterialId(mat_id);

            txtMatNom.Text = material.material_nombre;
            txtMatMarca.Text = material.material_marca;
            txtMatModel.Text = material.material_modelo;
            //txtMatCantidad.Text = material.material_cantidad.ToString();
            txtMatObsevac.Text = material.material_observacion;
            txtMatCantidad.Text = "1";

            Cache.Insert(VARMATERIAL, material);  
        }

        
        protected void btnAgregar_Click(object sender, EventArgs e)
        {
            Material material = Cache.Get(VARMATERIAL) as Material;
            material.material_cantidad = int.Parse(txtMatCantidad.Text);

            DetalleSolicitud newDetalleSolicitud = new DetalleSolicitud()
            {
                material = material,
                material_id = material.material_id,
                ds_cantidad_solicitada = material.material_cantidad,
            };

            Solicitud solicitud =  (Solicitud)Cache.Get(VARSOLICITUD);

            solicitud.DetalleSolicitud.Add(newDetalleSolicitud);

            SolicitudDataBind(solicitud); 

        }

        protected void btnRegistrarSolicitud_Click(object sender, EventArgs e)
        {
            Solicitud solicitud = Cache.Get(VARSOLICITUD) as Solicitud;

            solicitud.sl_fecha = txtSolicFecha.Text.Trim();
            solicitud.estacion_id = Int32.Parse(ddlEstaciones.SelectedValue);
            solicitud.usuario_id = Int32.Parse(ddlUsuarios.SelectedValue);

            solicitudBL.CrearSolicitud(solicitud);
        }

        protected void btnIniciarSolicitud_Click(object sender, EventArgs e)
        {
            Solicitud solicitud = new Solicitud();//
            SolicitudDataBind(solicitud);
        }

        protected void odsLeerTodasLasEstaciones_ObjectCreating(object sender, ObjectDataSourceEventArgs e)
        {
            e.ObjectInstance = estacionBL;
        }



    }
}