using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using CSCInventarios.EL;

namespace CSCInventarios.DAL
{
    public class DetalleRequerimientoDAL:cnx,IDetalleRequerimientoDAL
    {
        public void CrearDetalleRequerimiento(DetalleRequerimiento detalleRequerimiento)
        {
            throw new NotImplementedException();
        }

        public void EliminarDetalleRequerimiento(int rq_id)
        {
            throw new NotImplementedException();
        }

        public DetalleRequerimiento LeerDetalleRequerimientoPorDrId(int dr_id)
        {
            throw new NotImplementedException();
        }

        public List<DetalleRequerimiento> LeerDetalleRequerimientoPorMaterialId(int material_id)
        {
            throw new NotImplementedException();
        }

        public List<DetalleRequerimiento> LeerDetalleRequerimientoPorRqId(int rq_id)
        {
            throw new NotImplementedException();
        }

        public List<DetalleRequerimiento> LeerTodosLosDetalleRequerimiento()
        {
            throw new NotImplementedException();
        }

        public void ModificarDetalleRequerimiento(DetalleRequerimiento detalleRequerimiento)
        {
            throw new NotImplementedException();
        }
    }
}
