using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Dominio
{
    public class ERequerimiento
    {
        private int rq_id;
        private int usuario_id;
        private int material_id;
        private DateTime rq_fecha;
        private int rq_cantidad_rq;
        private Boolean rq_validacion=true;
        private int rq_cantidad_ingreso;
    }
}
