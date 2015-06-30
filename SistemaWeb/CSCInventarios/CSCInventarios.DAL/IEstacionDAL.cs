using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using CSCInventarios.EL;

namespace CSCInventarios.DAL
{
    public interface IEstacionDAL
    {
        List<Estacion> LeerTodasLasEstaciones();
        Estacion LeerEstacionesPorEstacionId(int estacion_id);
        List<Estacion> LeerEstacionPorCriterio(string criterio);
        void CrearEstacion (Estacion estacion);
        void EliminarEstacion(int estacion_id);
        void modificarEstacion(Estacion estacion);

    }
}
