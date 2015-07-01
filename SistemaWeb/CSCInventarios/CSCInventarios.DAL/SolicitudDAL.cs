using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using CSCInventarios.EL;

namespace CSCInventarios.DAL
{
    public class SolicitudDAL:cnx,ISolicitudDAL
    {
        public void CrearSolicitud(Solicitud solicitud)
        {
            throw new NotImplementedException();
        }

        public void EliminarSolicitud(int sl_id)
        {
            throw new NotImplementedException();
        }

        public Solicitud LeerSolicitudPorSlId(int sl_id)
        {
            throw new NotImplementedException();
        }

        public List<Solicitud> LeerSolicitudPorUsuarioId(int usuario_id)
        {
            throw new NotImplementedException();
        }

        public List<Solicitud> LeerSolicitudPorEstacionId(int estacion_id)
        {
            throw new NotImplementedException();
        }

        public List<Solicitud> LeerSolicitudEntreFechas(DateTime fechaInicio, DateTime fechaFin)
        {
            throw new NotImplementedException();
        }

        public List<Solicitud> LeerSolicitudesRecepcionadas(bool sl_recepcion)
        {
            throw new NotImplementedException();
        }

        public List<Solicitud> LeerSolicitudesAsignadas(bool sl_asignacion)
        {
            throw new NotImplementedException();
        }

        public List<Solicitud> LeerSolicitudesAtendidas(bool sl_atencion)
        {
            throw new NotImplementedException();
        }

        public List<Solicitud> LeerSolicitudesAceptadas(bool sl_aceptacion)
        {
            throw new NotImplementedException();
        }

        public List<Solicitud> LeerTodasLasSolicitudes()
        {
            throw new NotImplementedException();
        }

        public void ModificarSolicitud(Solicitud solicitud)
        {
            throw new NotImplementedException();
        }

        public void ValidarSilicitudRecepcionada(int sl_id, bool sl_recepcion)
        {
            throw new NotImplementedException();
        }

        public void ValidarSolicitudAsignadas(int sl_id, bool sl_asignacion)
        {
            throw new NotImplementedException();
        }

        public void ValidarSolicitudAtendidas(int sl_id, bool sl_atencion)
        {
            throw new NotImplementedException();
        }

        public void ValidarSolicitudAceptadas(int sl_id, bool sl_aceptacion)
        {
            throw new NotImplementedException();
        }
    }
}
