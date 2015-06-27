using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Dominio
{
    public class EMaterial
    {
        private int material_id;

        public int Material_id
        {
            get { return material_id; }
            set { material_id = value; }
        }
        private int material_nombre;

        public int Material_nombre
        {
            get { return material_nombre; }
            set { material_nombre = value; }
        }
        private int material_modelo;

        public int Material_modelo
        {
            get { return material_modelo; }
            set { material_modelo = value; }
        }
        private int material_cantidad;

        public int Material_cantidad
        {
            get { return material_cantidad; }
            set { material_cantidad = value; }
        }
        private int material_observacion;

        public int Material_observacion
        {
            get { return material_observacion; }
            set { material_observacion = value; }
        }

    }
}
