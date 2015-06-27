using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CSCInventarios.EL
{
    public class EInventario
    {
        private int inventario_id;

        public int Inventario_id1
        {
            get { return inventario_id; }
            set { inventario_id = value; }
        }
        private int rq_id;

        public int Rq_id
        {
            get { return rq_id; }
            set { rq_id = value; }
        }
        private int solicitud_id;

        public int Solicitud_id
        {
            get { return solicitud_id; }
            set { solicitud_id = value; }
        }
        private int material_id;

        public int Material_id
        {
            get { return material_id; }
            set { material_id = value; }
        }
        private int inventario_cantidad;

        public int Inventario_cantidad
        {
            get { return inventario_cantidad; }
            set { inventario_cantidad = value; }
        }
        private int inventario_accion;

        public int Inventario_accion
        {
            get { return inventario_accion; }
            set { inventario_accion = value; }
        }
        private int inventario_fecha;

        public int Inventario_fecha
        {
            get { return inventario_fecha; }
            set { inventario_fecha = value; }
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

        public ESolicitud ESolicitud
        {
            get
            {
                throw new System.NotImplementedException();
            }
            set
            {
            }
        }

        public ERequerimiento ERequerimiento
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
