using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CSCInventarios.EL
{
    public class ESolicitud
    {

        /// <remarks>llaveprimaria</remarks>
        private int estacion_id;

        public int Estacion_id
        {
            get { return estacion_id; }
            set { estacion_id = value; }
        }
        private int usuario_id;

        public int Usuario_id1
        {
            get { return usuario_id; }
            set { usuario_id = value; }
        }
        public int Usuario_id
        {
            get { return Usuario_id1; }
            set { Usuario_id1 = value; }
        }
        private int material_id;

        public int Material_id
        {
            get { return material_id; }
            set { material_id = value; }
        }
        private DateTime sl_fecha;

        public DateTime Sl_fecha
        {
            get { return sl_fecha; }
            set { sl_fecha = value; }
        }
        private int sl_cantidad_solicitada;

        public int Sl_cantidad_solicitada
        {
            get { return sl_cantidad_solicitada; }
            set { sl_cantidad_solicitada = value; }
        }
        private bool sl_recepcion;

        public bool Sl_recepcion
        {
            get { return sl_recepcion; }
            set { sl_recepcion = value; }
        }
        private bool sl_asignacion;

        public bool Sl_asignacion
        {
            get { return sl_asignacion; }
            set { sl_asignacion = value; }
        }
        private int sl_cantidad_asignada;

        public int Sl_cantidad_asignada
        {
            get { return sl_cantidad_asignada; }
            set { sl_cantidad_asignada = value; }
        }
        private bool sl_atencion;

        public bool Sl_atencion
        {
            get { return sl_atencion; }
            set { sl_atencion = value; }
        }
        private bool sl_aceptacion;

        public bool Sl_aceptacion
        {
            get { return sl_aceptacion; }
            set { sl_aceptacion = value; }
        }
        private int sl_cantidad_aceptada;

        public int Sl_cantidad_aceptada
        {
            get { return sl_cantidad_aceptada; }
            set { sl_cantidad_aceptada = value; }
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

        public EEstacion EEstacion
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
