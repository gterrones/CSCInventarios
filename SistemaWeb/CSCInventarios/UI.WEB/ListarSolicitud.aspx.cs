using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;


using Microsoft.Practices.Unity;
using CSCInventarios.BL;
using CSCInventarios.EL;  

namespace UI.WEB
{
    public partial class ListarSolicitud : BasePage<ListarSolicitud>// System.Web.UI.Page
    {

        [Dependency]
        public IEstacionBL estacionBL { get; set; }
        [Dependency]
        public ISolicitudBL solicitudBL { get; set; }

        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnNuevaSolicitud_Click(object sender, EventArgs e)
        {
            Response.Redirect("SolicitarMaterial.aspx?acc=nuevo");
        }

        protected void odsLeerTodasLasEstaciones_ObjectCreating(object sender, ObjectDataSourceEventArgs e)
        {
            e.ObjectInstance = estacionBL;
        }



    }
}