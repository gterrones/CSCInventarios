using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CSCInventarios.EL
{
    public class InventarioEL
    {
	    public int inventario_id {get;set;}
	    public int sl_id{get;set;}
	    public int rq_id{get;set;}
	    public int inventario_cantidad{get;set;}
	    public Boolean inventario_accion{get;set;}
	    public DateTime inventario_fecha{get;set;}
    }
}
