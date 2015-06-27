using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CSCInventarios.EL
{
    public class EUsuario
    {
        private int usuario_id;

        public int Usuario_id1
        {
            get { return usuario_id; }
            set { usuario_id = value; }
        }
        private string usuario_nombres;

        public string Usuario_nombres
        {
            get { return usuario_nombres; }
            set { usuario_nombres = value; }
        }
        private string usuario_apellidos;

        public string Usuario_apellidos
        {
            get { return usuario_apellidos; }
            set { usuario_apellidos = value; }
        }
        private string usuario_telefono;

        public string Usuario_telefono
        {
            get { return usuario_telefono; }
            set { usuario_telefono = value; }
        }
        private string usuario_ususario;

        public string Usuario_ususario
        {
            get { return usuario_ususario; }
            set { usuario_ususario = value; }
        }
        private string usuario_clave;

        public string Usuario_clave
        {
            get { return usuario_clave; }
            set { usuario_clave = value; }
        }

        public int Usuario_id
        {
            get { return Usuario_id1; }
            set { Usuario_id1 = value; }
        }
    }
}
