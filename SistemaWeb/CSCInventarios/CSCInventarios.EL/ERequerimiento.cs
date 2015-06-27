using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CSCInventarios.EL
{
    public class ERequerimiento
    {
        private int rq_id;

        public int Rq_id
        {
            get { return rq_id; }
            set { rq_id = value; }
        }
        private int usuario_id;

        public int Usuario_id
        {
            get { return usuario_id; }
            set { usuario_id = value; }
        }
        private int material_id;

        public int Material_id
        {
            get { return material_id; }
            set { material_id = value; }
        }
        private DateTime rq_fecha;

        public DateTime Rq_fecha
        {
            get { return rq_fecha; }
            set { rq_fecha = value; }
        }
        private int rq_cantidad_rq;

        public int Rq_cantidad_rq
        {
            get { return rq_cantidad_rq; }
            set { rq_cantidad_rq = value; }
        }
        private bool rq_validacion;

        public bool Rq_validacion
        {
            get { return rq_validacion; }
            set { rq_validacion = value; }
        }
        private int rq_cantidad_ingreso;

        public int Rq_cantidad_ingreso
        {
            get { return rq_cantidad_ingreso; }
            set { rq_cantidad_ingreso = value; }
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

        public EUsuario EUsuario
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
