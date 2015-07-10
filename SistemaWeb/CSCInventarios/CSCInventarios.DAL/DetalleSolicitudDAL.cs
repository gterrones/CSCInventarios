using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using CSCInventarios.EL;
using Microsoft.Practices.EnterpriseLibrary.Common.Configuration;
using Microsoft.Practices.EnterpriseLibrary.Data;
using Microsoft.Practices.Unity;

using System.Data;
using System.Data.Common;   


namespace CSCInventarios.DAL
{
    public class DetalleSolicitudDAL:cnx,IDetalleSolicitudDAL
    {
        [Dependency]
        public IMaterialDAL materialDAL { get; set; }
        public Solicitud solicitud;

        public DetalleSolicitudDAL() {
            materialDAL = new MaterialDAL();
            solicitud = new Solicitud();
        }

        public void CrearDetalleSolicitud(List<DetalleSolicitud> detalleSolicitud, int sl_id)
        {
            foreach (var item in detalleSolicitud)
            {
                item.sl_id = sl_id;
                CrearDetalleSolicitud(item);
            }
        }
        public void CrearDetalleSolicitud(DetalleSolicitud detalleSolicitud)
        {
            DbCommand command = DataBase.GetStoredProcCommand("CrearDetalleSolicitud");

            DataBase.AddInParameter(command, "ds_id", DbType.Int32, detalleSolicitud.ds_id);
            DataBase.AddInParameter(command, "sl_id ", DbType.Int32, detalleSolicitud.sl_id);
            DataBase.AddInParameter(command, "material_id", DbType.Int32, detalleSolicitud.material_id);
            DataBase.AddInParameter(command, "ds_cantidad_solicitada", DbType.Decimal, detalleSolicitud.ds_cantidad_solicitada);
            DataBase.AddInParameter(command, "ds_cantidad_asignada", DbType.Decimal, detalleSolicitud.ds_cantidad_asignada);
            DataBase.AddInParameter(command, "ds_cantidad_aceptada", DbType.Decimal, detalleSolicitud.ds_cantidad_aceptada);

            DataBase.ExecuteNonQuery(command); 
        }




        public void EliminarDetalleSolicitud(int sl_id)
        {
            throw new NotImplementedException();
        }

        public List<DetalleSolicitud> LeerDetalleSolicitudPorDsId(int ds_id)
        {
            throw new NotImplementedException();
        }

        public List<DetalleSolicitud> LeerDetalleSolicitudPorMaterialId(int material_id)
        {
            throw new NotImplementedException();
        }

        public List<DetalleSolicitud> LeerDetalleSolicitudPorSlId(int sl_id)
        {
            var rowMapper = MapBuilder<DetalleSolicitud>
                .MapAllProperties()
                //.DoNotMap(m => m.)
                .Map(m => m.material)
                .WithFunc(m => materialDAL.LeerMaterialPorMaterialId(m.GetInt32(m.GetOrdinal("material_id"))))
                .Build();
            var query = DataBase.ExecuteSprocAccessor<DetalleSolicitud>("LeerDetalleSolicitudPorSlId", rowMapper, sl_id);

            return query.ToList();
        }

        public List<DetalleSolicitud> LeerTodosLosDetalleSolicitud()
        {
            throw new NotImplementedException();
        }

        public void ModificarDetalleSolicitud(DetalleSolicitud detalleSolicitud)
        {
            throw new NotImplementedException();
        }
    }
}
