using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using CSCInventarios.EL;

namespace CSCInventarios.DAL
{
    public interface IDetalleSolicitudDAL
    {
        void CrearDetalleSolicitud(List<DetalleSolicitud> detalleSolicitud, int sl_id);
        void CrearDetalleSolicitud(DetalleSolicitud detalleSolicitud);
        void EliminarDetalleSolicitud(int sl_id);
        List<DetalleSolicitud> LeerDetalleSolicitudPorDsId(int ds_id);
        List<DetalleSolicitud> LeerDetalleSolicitudPorMaterialId(int material_id);
        List<DetalleSolicitud> LeerDetalleSolicitudPorSlId(int sl_id);
        List<DetalleSolicitud> LeerTodosLosDetalleSolicitud();
        void ModificarDetalleSolicitud(DetalleSolicitud detalleSolicitud);
    }
}
