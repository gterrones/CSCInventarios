using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using CSCInventarios.EL;
using CSCInventarios.DAL;
using Microsoft.Practices.Unity;

namespace CSCInventarios.BL
{
    public class SolicitudBL:ISolicitudBL
    {
        [Dependency]
        ISolicitudDAL solicitudDAL { get; set; }

        public SolicitudBL() { }

        public void CrearSolicitud(Solicitud solicitud)
        {
            solicitudDAL.CrearSolicitud(solicitud);
        }

        public void EliminarSolicitud(int sl_id)
        {
            throw new NotImplementedException();
        }

        public Solicitud LeerSolicitudPorSlId(int sl_id)
        {
            return solicitudDAL.LeerSolicitudPorSlId(sl_id);
        }

        public List<Solicitud> LeerSolicitudPorUsuarioId(int usuario_id)
        {
            return solicitudDAL.LeerSolicitudPorUsuarioId(usuario_id);
        }

        public List<Solicitud> LeerSolicitudPorEstacionId(int estacion_id)
        {
            return solicitudDAL.LeerSolicitudPorEstacionId(estacion_id);
        }

        public List<Solicitud> LeerSolicitudEntreFechas(DateTime fechaInicio, DateTime fechaFin)
        {
            return solicitudDAL.LeerSolicitudEntreFechas(fechaInicio,fechaFin);
        }

        public List<EL.Solicitud> LeerSolicitudesRecepcionadas(bool sl_recepcion)
        {
            throw new NotImplementedException();
        }

        public List<EL.Solicitud> LeerSolicitudesAsignadas(bool sl_asignacion)
        {
            throw new NotImplementedException();
        }

        public List<EL.Solicitud> LeerSolicitudesAtendidas(bool sl_atencion)
        {
            throw new NotImplementedException();
        }

        public List<EL.Solicitud> LeerSolicitudesAceptadas(bool sl_aceptacion)
        {
            throw new NotImplementedException();
        }

        public List<EL.Solicitud> LeerTodasLasSolicitudes()
        {
            throw new NotImplementedException();
        }

        public void ModificarSolicitud(EL.Solicitud solicitud)
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
