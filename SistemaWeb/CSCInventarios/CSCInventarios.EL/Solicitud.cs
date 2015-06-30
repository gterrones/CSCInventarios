using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CSCInventarios.EL
{
    public class Solicitud
    {

        /// <remarks>llaveprimaria</remarks>
        public int sl_id{get;set;}
	    public int usuario_id{get;set;}
	    public int estacion_id{get;set;}
	    public DateTime sl_feha{get;set;}
	    public Boolean sl_recepcion{get;set;}
	    public Boolean sl_asignacion{get;set;}
        public Boolean sl_atencion{get;set;}
        public Boolean sl_aceptacion { get; set; }
        public Boolean sl_eliminado { get; set; }

        public List<DetalleSolicitud> DetalleSolicitud { get; set; }
        public Usuario UsuarioEL { get; set; }
        public Estacion EstacionEL { get; set; }
    }
}
