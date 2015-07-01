using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using CSCInventarios.EL;
using Microsoft.Practices.EnterpriseLibrary.Common.Configuration;
using Microsoft.Practices.EnterpriseLibrary.Data;
using System.Data;
using System.Data.Common;

namespace CSCInventarios.DAL
{
    public class EstacionDAL:cnx,IEstacionDAL
    {
        public List<Estacion> LeerTodasLasEstaciones()
        {
            var query = DataBase.ExecuteSprocAccessor<Estacion>("LeerTodasLasEstaciones");
            return query.ToList(); 
        }

        public Estacion LeerEstacionesPorEstacionId(int estacion_id)
        {
            var query = DataBase.ExecuteSprocAccessor<Estacion>("LeerEstacionesPorEstacionId", estacion_id);
            return query.SingleOrDefault();
        }

        public List<Estacion> LeerEstacionPorCriterio(string criterio)
        {
            var query = DataBase.ExecuteSprocAccessor<Estacion>("LeerEstacionPorCriterio", criterio);
            return query.ToList(); 
        }

        public void CrearEstacion(Estacion estacion)
        {
            DbCommand command = DataBase.GetStoredProcCommand("CrearEstacion");

            DataBase.AddInParameter(command, "estacion_id", DbType.Int32, estacion.estacion_id);
            DataBase.AddInParameter(command, "estacion_nombre", DbType.String, estacion.estacion_nombre);
            DataBase.AddInParameter(command, "estacion_zona", DbType.String, estacion.estacion_zona);
            DataBase.AddInParameter(command, "estacion_coordenadas", DbType.String, estacion.estacion_coordenadas);
            DataBase.AddInParameter(command, "estacion_referencia", DbType.String, estacion.estacion_referencia);
            DataBase.AddInParameter(command, "estacion_eliminado", DbType.Boolean, estacion.estacion_eliminado);

            DataBase.ExecuteNonQuery(command);  
        }

        public void EliminarEstacion(int estacion_id)
        {
            DbCommand command = DataBase.GetStoredProcCommand("EliminarEstacion");

            DataBase.AddInParameter(command, "estacion_id", DbType.Int32, estacion_id);
            DataBase.AddInParameter(command, "estacion_eliminado", DbType.Boolean, 1);

            DataBase.ExecuteNonQuery(command);  
        }

        public void modificarEstacion(Estacion estacion)
        {
            DbCommand command = DataBase.GetStoredProcCommand("modificarEstacion");

            DataBase.AddInParameter(command, "estacion_id", DbType.Int32, estacion.estacion_id);
            DataBase.AddInParameter(command, "estacion_nombre", DbType.String, estacion.estacion_nombre);
            DataBase.AddInParameter(command, "estacion_zona", DbType.String, estacion.estacion_zona);
            DataBase.AddInParameter(command, "estacion_coordenadas", DbType.String, estacion.estacion_coordenadas);
            DataBase.AddInParameter(command, "estacion_referencia", DbType.String, estacion.estacion_referencia);
            DataBase.AddInParameter(command, "estacion_eliminado", DbType.Boolean, estacion.estacion_eliminado);

            DataBase.ExecuteNonQuery(command);  
        }
    }
}
