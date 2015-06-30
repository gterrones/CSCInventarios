using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CSCInventarios.EL
{
    public class EstacionEL
    {
        public int estacion_id {get; set;}
	    public string estacion_nombre {get; set;}
	    public string estacion_zona{get; set;}
	    public string estacion_coordenadas{get; set;}
        public string estacion_referencia { get; set; }
        public Boolean estacion_eliminado { get; set; }

        public override string ToString()
        {
            return estacion_nombre;
        }
           
    }
}
