using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CSCInventarios.EL
{
    public class MaterialEL
    {
        public int material_id {get; set;}
	    public string material_nombre{get; set;}
	    public string material_modelo{get; set;}
	    public int material_cantidad{get; set;}
        public string material_observacion { get; set; }
    }
}
