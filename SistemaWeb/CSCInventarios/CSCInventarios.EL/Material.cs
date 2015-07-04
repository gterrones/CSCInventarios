using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CSCInventarios.EL
{
    public class Material
    {
        public int material_id {get; set;}
	    public string material_nombre{get; set;}
	    public string material_modelo{get; set;}
        public string material_marca { get; set; }
	    public int material_cantidad{get; set;}
        public string material_observacion { get; set; }
        public Boolean material_eliminado { get; set; }

        public override string ToString()
        {
            return material_nombre;
        }
    }
}
