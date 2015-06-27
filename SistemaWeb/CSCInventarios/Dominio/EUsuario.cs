using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Dominio
{
    public class EUsuario
    {
        private int usuario_id;
        private int usuario_nombres;

        public int Usuario_nombres
        {
            get { return usuario_nombres; }
            set { usuario_nombres = value; }
        }
        private int usuario_apellidos;

        public int Usuario_apellidos
        {
            get { return usuario_apellidos; }
            set { usuario_apellidos = value; }
        }
        private int usuario_telefono;

        public int Usuario_telefono
        {
            get { return usuario_telefono; }
            set { usuario_telefono = value; }
        }
        private int usuario_ususario;

        public int Usuario_ususario
        {
            get { return usuario_ususario; }
            set { usuario_ususario = value; }
        }
        private int usuario_clave;

        public int Usuario_clave
        {
            get { return usuario_clave; }
            set { usuario_clave = value; }
        }

        public int Usuario_id
        {
            get { return usuario_id; }
            set { usuario_id = value; }
        }
    }
}
