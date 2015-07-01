using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using CSCInventarios.EL;

namespace CSCInventarios.BL
{
    public interface IEstacionBL
    {
        List<Estacion> LeerTodasLasEstaciones();
        Estacion LeerEstacionesPorEstacionId(int estacion_id);
        List<Estacion> LeerEstacionPorCriterio(string criterio);
        void CrearEstacion (Estacion estacion);
        void EliminarEstacion(int estacion_id);
        void modificarEstacion(Estacion estacion);
    }
}
