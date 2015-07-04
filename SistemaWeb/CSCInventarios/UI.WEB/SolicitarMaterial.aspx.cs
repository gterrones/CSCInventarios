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
    public partial class SolicitarMaterial : System.Web.UI.Page
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
        private const string VARESTACION = "estacion";

        public SolicitarMaterial() {
            materialBl = new MaterialBL();
            solicitudBL = new SolicitudBL();
            usuarioBL = new UsuarioBL();
            estacionBL = new EstacionBL();
        }

        protected void Page_Load(object sender, EventArgs e)
        {
            var acc = Request.QueryString["acc"];

            if (!Page.IsPostBack)
            {
                if (acc != string.Empty)
                {
                    if (acc == "editar")
                    {
                        var solicitud_id = Int32.Parse(Request.QueryString["sl_id"].ToString());

                        var solicitud = solicitudBL.LeerSolicitudPorSlId(solicitud_id);

                        SolicitudDataBind(solicitud);

                    }
                    else if (acc == "nuevo")
                    {
                        var solicitud = new Solicitud();
                        SolicitudDataBind(solicitud);
                    }
                }
            }
        }


        private void SolicitudDataBind(Solicitud solicitud)
        {
            txtSolicId.Text = solicitud.sl_id.ToString();
            txtSolicFecha.Text= solicitud.sl_fecha.ToString();
            
            ddlEstaciones.SelectedValue = solicitud.estacion_id.ToString();

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
            txtMatCantidad.Text = material.material_cantidad.ToString();
            txtMatObsevac.Text = material.material_observacion;
            //txtPCantidad.Text = "1";

            Cache.Insert(VARMATERIAL, material);  
        }

        protected void btnAgregar_Click(object sender, EventArgs e)
        {
            var material = Cache.Get(VARMATERIAL) as Material;
            var cantidad_material = int.Parse(txtMatCantidad.Text);

            DetalleSolicitud detalleSolicitud = new DetalleSolicitud()
            {
                material = material,
                material_id = material.material_id,
                ds_cantidad_solicitada = cantidad_material,
            };

            var solicitud = Cache.Get(VARSOLICITUD) as Solicitud;
            //solicitud.DetalleSolicitud.Add(detalleSolicitud);
            //SolicitudDataBind(solicitud);
           
            gvDetalleSolicitud.DataSource = solicitud;
            gvDetalleSolicitud.Visible = true;
            gvDetalleSolicitud.DataBind();
        }



    }
}