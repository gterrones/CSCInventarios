using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CSCInventarios.EL
{
    public class DetalleRequerimiento
    {
        public int dr_id {get;set;}
        public int rq_id{get;set;}
	    public int material_id{get;set;}
	    public int dr_cantidad_rq{get;set;}
        public int dr_cantidad_ingreso { get; set; }
    }
}
