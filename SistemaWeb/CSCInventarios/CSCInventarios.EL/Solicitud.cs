using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CSCInventarios.EL
{
    public class Solicitud
    {
        public Solicitud() { 
        
            sl_id = 0;
            sl_fecha=DateTime.Now.ToShortDateString();
            sl_recepcion = false;
            sl_asignacion = false;
            sl_atencion = false;
            sl_aceptacion = false;
            sl_eliminado = false;

            DetalleSolicitud= new List<DetalleSolicitud>();
            Usuario = new Usuario();
            Estacion = new Estacion();

        }
        /// <remarks>llaveprimaria</remarks>
        public int sl_id{get;set;}
	    public int usuario_id{get;set;}
	    public int estacion_id{get;set;}
	    public String sl_fecha{get;set;}
	    public Boolean sl_recepcion{get;set;}
	    public Boolean sl_asignacion{get;set;}
        public Boolean sl_atencion{get;set;}
        public Boolean sl_aceptacion { get; set; }
        public Boolean sl_eliminado { get; set; }

        public List<DetalleSolicitud> DetalleSolicitud { get; set; }
        public Usuario Usuario { get; set; }
        public Estacion Estacion { get; set; }

        //public override string ToString()
        //    string a = DateTime.Now.ToShortDateString();
        //}
    }
}
