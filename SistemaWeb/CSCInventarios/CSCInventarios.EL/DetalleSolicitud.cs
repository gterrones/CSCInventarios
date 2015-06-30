using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CSCInventarios.EL
{
    public class DetalleSolicitud
    {
        public int ds_id{get;set;}
	    public int sl_id{get;set;}
	    public int material_id{get;set;}
	    public int ds_cantidad_solicitada{get;set;}
	    public int ds_cantidad_asignada{get;set;}
        public int ds_cantidad_aceptada { get; set; }
    }
}
