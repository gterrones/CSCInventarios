using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using CSCInventarios.EL;

namespace CSCInventarios.DAL
{
    public interface IDetalleRequerimientoDAL
    {
        void CrearDetalleRequerimiento(DetalleRequerimiento detalleRequerimiento);
        void EliminarDetalleRequerimiento(int rq_id);
        DetalleRequerimiento LeerDetalleRequerimientoPorDrId(int dr_id);
        List<DetalleRequerimiento> LeerDetalleRequerimientoPorMaterialId(int material_id);
        List<DetalleRequerimiento> LeerDetalleRequerimientoPorRqId(int rq_id);
        List<DetalleRequerimiento> LeerTodosLosDetalleRequerimiento();
        void ModificarDetalleRequerimiento(DetalleRequerimiento detalleRequerimiento);
    }
}
