﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CSCInventarios.DAL
{
    public class DetalleSolicitudDAL:cnx,IDetalleSolicitudDAL
    {
        public void CrearDetalleSolicitud(EL.DetalleSolicitud detalleSolicitud)
        {
            throw new NotImplementedException();
        }

        public void EliminarDetalleSolicitud(int sl_id)
        {
            throw new NotImplementedException();
        }

        public List<EL.DetalleSolicitud> LeerDetalleSolicitudPorDsId(int ds_id)
        {
            throw new NotImplementedException();
        }

        public List<EL.DetalleSolicitud> LeerDetalleSolicitudPorMaterialId(int material_id)
        {
            throw new NotImplementedException();
        }

        public List<EL.DetalleSolicitud> LeerDetalleSolicitudPorSlId(int sl_id)
        {
            throw new NotImplementedException();
        }

        public List<EL.DetalleSolicitud> LeerTodosLosDetalleSolicitud()
        {
            throw new NotImplementedException();
        }

        public void ModificarDetalleSolicitud(EL.DetalleSolicitud detalleSolicitud)
        {
            throw new NotImplementedException();
        }
    }
}
