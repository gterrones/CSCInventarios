using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using CSCInventarios.EL;
namespace CSCInventarios.BL
{
    public interface ISolicitudBL
    {
        void CrearSolicitud(Solicitud solicitud);
        void EliminarSolicitud(int sl_id);
        Solicitud LeerSolicitudPorSlId(int sl_id);
        List<Solicitud> LeerSolicitudPorUsuarioId(int usuario_id);
        List<Solicitud> LeerSolicitudPorEstacionId(int estacion_id);
        List<Solicitud> LeerSolicitudEntreFechas(DateTime fechaInicio, DateTime fechaFin);
        List<Solicitud> LeerSolicitudesRecepcionadas(Boolean sl_recepcion);
        List<Solicitud> LeerSolicitudesAsignadas(Boolean sl_asignacion);
        List<Solicitud> LeerSolicitudesAtendidas(Boolean sl_atencion);
        List<Solicitud> LeerSolicitudesAceptadas(Boolean sl_aceptacion);
        List<Solicitud> LeerTodasLasSolicitudes();
        void ModificarSolicitud(Solicitud solicitud);
        void ValidarSilicitudRecepcionada(int sl_id, Boolean sl_recepcion);
        void ValidarSolicitudAsignadas(int sl_id,Boolean sl_asignacion);
        void ValidarSolicitudAtendidas(int sl_id,Boolean sl_atencion);
        void ValidarSolicitudAceptadas(int sl_id, Boolean sl_aceptacion);
    }
}
