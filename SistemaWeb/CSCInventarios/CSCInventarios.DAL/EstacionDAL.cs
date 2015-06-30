using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CSCInventarios.DAL
{
    public class EstacionDAL:cnx,IEstacionDAL
    {
        public List<EL.Estacion> LeerTodasLasEstaciones()
        {
            throw new NotImplementedException();
        }

        public EL.Estacion LeerEstacionesPorEstacionId(int estacion_id)
        {
            throw new NotImplementedException();
        }

        public List<EL.Estacion> LeerEstacionPorCriterio(string criterio)
        {
            throw new NotImplementedException();
        }

        public void CrearEstacion(EL.Estacion estacion)
        {
            throw new NotImplementedException();
        }

        public void EliminarEstacion(int estacion_id)
        {
            throw new NotImplementedException();
        }

        public void modificarEstacion(EL.Estacion estacion)
        {
            throw new NotImplementedException();
        }
    }
}
