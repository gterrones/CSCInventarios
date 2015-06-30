using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CSCInventarios.EL
{
    public class SolicitudEL
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

        public List<DetalleSolicitudEL> DetalleSolicitud { get; set; }
        public UsuarioEL UsuarioEL { get; set; }
        public EstacionEL EstacionEL { get; set; }
    }
}
