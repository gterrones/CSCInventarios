using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CSCInventarios.EL
{
    public class Requerimiento
    {
	    public int rq_id{get;set;}
	    public int usuario_id{get;set;}
        public DateTime rq_fecha{get;set;}
        public Boolean rq_validacion { get; set; }
        public Boolean rq_eliminado { get; set; }

        public Usuario EUsuario { get; set; }
        public List<DetalleRequerimiento> DetalleRequerimiento { get; set; }
    }
}
