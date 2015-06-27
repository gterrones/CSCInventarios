using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Dominio
{
    public class EInventario
    {
        private int inventario_id;
        private int rq_id;
        private int solicitud_id;
        private int material_id;
        private int inventario_cantidad;
        private int inventario_accion;
        private int inventario_fecha;

        public int Inventario_id
        {
            get { return inventario_id; }
            set { inventario_id = value; }
        }

        public EMaterial EMaterial
        {
            get
            {
                throw new System.NotImplementedException();
            }
            set
            {
            }
        }
    }
}
