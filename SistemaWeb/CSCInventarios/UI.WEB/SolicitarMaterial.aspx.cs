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
            var material_id = Int32.Parse(gvMateriales.SelectedValue.ToString());
            
            var material = materialBl.LeerMaterialPorMaterialId(material_id);

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
            var producto = Cache.Get(VARMATERIAL) as Material;
            var cantidad = Int32.Parse(txtMatCantidad.Text);


            DetalleSolicitud newDetalle = new DetalleSolicitud()
            {
                Producto = producto,
                ProductoId = producto.Id,
                Precio = precio,
                Cantidad = cantidad
            };

            var pedido = Cache.Get(VARPEDIDO) as Pedido;

            pedido.DetallePedido.Add(newDetalle);

            pedido.Total = pedido.DetallePedido.Sum(m => m.Monto);

            PedidoDataBind(pedido);
        }


    }
}