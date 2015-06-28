using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CSCInventarios.EL
{
    public class EstacionEL
    {
        private int estacion_id=0;

        public int Estacion_id
        {
            get { return estacion_id; }
            set { estacion_id = value; }
        }
        private String estacion_nombre="";

        public String Estacion_nombre
        {
            get { return estacion_nombre; }
            set { estacion_nombre = value; }
        }
        private String estacion_zona="";

        public String Estacion_zona
        {
            get { return estacion_zona; }
            set { estacion_zona = value; }
        }
        private String estacion_cordenadas="";

        public String Estacion_cordenadas
        {
            get { return estacion_cordenadas; }
            set { estacion_cordenadas = value; }
        }
        private String estacion_referencia="";

        public String Estacion_referencia
        {
            get { return estacion_referencia; }
            set { estacion_referencia = value; }
        }
    }
}
