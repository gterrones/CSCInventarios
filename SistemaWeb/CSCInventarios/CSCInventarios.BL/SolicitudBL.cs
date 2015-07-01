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
        public void CrearSolicitud(EL.Solicitud solicitud)
        {
            throw new NotImplementedException();
        }

        public void EliminarSolicitud(int sl_id)
        {
            throw new NotImplementedException();
        }

        public EL.Solicitud LeerSolicitudPorSlId(int sl_id)
        {
            throw new NotImplementedException();
        }

        public List<EL.Solicitud> LeerSolicitudPorUsuarioId(int usuario_id)
        {
            throw new NotImplementedException();
        }

        public List<EL.Solicitud> LeerSolicitudPorEstacionId(int estacion_id)
        {
            throw new NotImplementedException();
        }

        public List<EL.Solicitud> LeerSolicitudEntreFechas(DateTime fechaInicio, DateTime fechaFin)
        {
            throw new NotImplementedException();
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
