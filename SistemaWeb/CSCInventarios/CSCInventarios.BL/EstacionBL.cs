using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using CSCInventarios.EL;
using CSCInventarios.DAL;
using Microsoft.Practices.Unity;

namespace CSCInventarios.BL
{
    public class EstacionBL:IEstacionBL
    {

        [Dependency]
        public IEstacionDAL estacionDAL { get; set; }

        public EstacionBL() {

            estacionDAL = new EstacionDAL();
        }

        public List<Estacion> LeerTodasLasEstaciones()
        {
            return estacionDAL.LeerTodasLasEstaciones();
        }

        public Estacion LeerEstacionesPorEstacionId(int estacion_id)
        {
            return estacionDAL.LeerEstacionesPorEstacionId(estacion_id);
        }

        public List<Estacion> LeerEstacionPorCriterio(string criterio)
        {
            return estacionDAL.LeerEstacionPorCriterio(criterio);
        }

        public void CrearEstacion(Estacion estacion)
        {
            estacionDAL.CrearEstacion(estacion);
        }

        public void EliminarEstacion(int estacion_id)
        {
            estacionDAL.EliminarEstacion(estacion_id);
        }

        public void modificarEstacion(Estacion estacion)
        {
            estacionDAL.modificarEstacion(estacion);
        }
    }
}
