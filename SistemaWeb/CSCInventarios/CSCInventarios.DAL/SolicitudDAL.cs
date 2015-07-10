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
    public class SolicitudDAL:cnx,ISolicitudDAL
    {
        [Dependency]
        public IUsuarioDAL usuarioDAL { get; set; }
        List<Usuario> listUsuario;

        [Dependency]
        public IEstacionDAL estacionDAL { get; set; }
        List<Estacion> listEstacion;

        [Dependency]
        public IDetalleSolicitudDAL detalleSolicitudDAL { get; set; }


        public SolicitudDAL() {
            estacionDAL = new EstacionDAL();
            usuarioDAL = new UsuarioDAL();
            detalleSolicitudDAL = new DetalleSolicitudDAL();
        }

        public void CrearSolicitud(Solicitud solicitud)
        {
            DbCommand command = DataBase.GetStoredProcCommand("CrearSolicitud");
            
            DbParameter param = command.CreateParameter();
            param.Direction = System.Data.ParameterDirection.InputOutput;
            param.ParameterName = "sl_id";
            param.DbType = System.Data.DbType.Int32;
            param.Value = solicitud.sl_id;

            command.Parameters.Add(param);

            //DataBase.AddInParameter(command, "sl_id", System.Data.DbType.Int32 , solicitud.sl_id);
            DataBase.AddInParameter(command, "usuario_id", System.Data.DbType.Int32, solicitud.usuario_id);
            DataBase.AddInParameter(command, "estacion_id", System.Data.DbType.Int32, solicitud.estacion_id);
            DataBase.AddInParameter(command, "sl_fecha", System.Data.DbType.String, solicitud.sl_fecha);

            DataBase.ExecuteNonQuery(command);

            solicitud.sl_id = Int32.Parse(param.Value.ToString());
            detalleSolicitudDAL.CrearDetalleSolicitud(solicitud.DetalleSolicitud, solicitud.sl_id);
        }

        public void EliminarSolicitud(int sl_id)
        {
            throw new NotImplementedException();
        }

      
        public Solicitud LeerSolicitudPorSlId(int sl_id)
        {
            listEstacion = estacionDAL.LeerTodasLasEstaciones();
            listUsuario = usuarioDAL.LeerTodosLosUsuarios();

            var query = DataBase.ExecuteSprocAccessor<Solicitud>("LeerSolicitudPorSlId", RowMapperSolicitud(), sl_id);
            return query.SingleOrDefault();
        }

        private IRowMapper<Solicitud> RowMapperSolicitud()
        {
            IRowMapper<Solicitud> rowMapper = MapBuilder<Solicitud>
                .MapAllProperties()
                //.DoNotMap(s=>s.Usuario)
                .Map(s => s.Usuario)
                .WithFunc(s =>LeerUsuarioPorUsuarioId(s.GetInt32(s.GetOrdinal("usuario_id"))))

                .Map(s => s.Estacion)
                .WithFunc(s => LeerEstacionesPorEstacionId(s.GetInt32(s.GetOrdinal("estacion_id"))))
                
                .Map(s => s.DetalleSolicitud)
                .WithFunc(s => detalleSolicitudDAL.LeerDetalleSolicitudPorSlId(s.GetInt32(s.GetOrdinal("sl_id"))))
                
                .Build();
            return rowMapper;
        }
        #region funciones para el rouMapper
        private Usuario LeerUsuarioPorUsuarioId(int usuario_id)
        {
            var query = from u in listUsuario
                        where u.usuario_id == usuario_id
                        select u;

            return query.SingleOrDefault();
        }

        private Estacion LeerEstacionesPorEstacionId(int estacion_id)
        {
            var query = from e in listEstacion
                        where e.estacion_id == estacion_id
                        select e;

            return query.SingleOrDefault();
        }
        #endregion

        public List<Solicitud> LeerSolicitudPorUsuarioId(int usuario_id)
        {
            var rowMapper = MapBuilder<Solicitud>
                .MapAllProperties()
                .DoNotMap(u => u.Estacion)
                .DoNotMap(u => u.DetalleSolicitud)
                .Map(u => u.Usuario)
                .WithFunc(u => usuarioDAL.LeerUsuarioPorUsuarioId(u.GetInt32(u.GetOrdinal("usuario_id"))))
                .Build();
            var query = DataBase.ExecuteSprocAccessor<Solicitud>("LeerSolicitudPorUsuarioId", rowMapper, usuario_id);

            return query.ToList();
        }

        public List<Solicitud> LeerSolicitudPorEstacionId(int estacion_id)
        {
            var query = DataBase.ExecuteSprocAccessor<Solicitud>("LeerSolicitudPorUsuarioId", estacion_id);
            return query.ToList();
        }

        public List<Solicitud> LeerSolicitudEntreFechas(DateTime fechaInicio, DateTime fechaFin)
        {
            object[] param = new object[2];
            param[0] = fechaInicio;
            param[1] = fechaFin;

            var query = DataBase.ExecuteSprocAccessor<Solicitud>("LeerSolicitudEntreFechas", param);

            return query.ToList();
        }

        public List<Solicitud> LeerSolicitudesRecepcionadas(bool sl_recepcion)
        {
            var query = DataBase.ExecuteSprocAccessor<Solicitud>("LeerSolicitudesRecepcionadas", sl_recepcion);

            return query.ToList();
        }

        public List<Solicitud> LeerSolicitudesAsignadas(bool sl_asignacion)
        {
            var query = DataBase.ExecuteSprocAccessor<Solicitud>("LeerSolicitudesAsignadas", sl_asignacion);

            return query.ToList();
        }

        public List<Solicitud> LeerSolicitudesAtendidas(bool sl_atencion)
        {
            var query = DataBase.ExecuteSprocAccessor<Solicitud>("LeerSolicitudesAtendidas", sl_atencion);

            return query.ToList();
        }

        public List<Solicitud> LeerSolicitudesAceptadas(bool sl_aceptacion)
        {
            var query = DataBase.ExecuteSprocAccessor<Solicitud>("LeerSolicitudesAceptadas", sl_aceptacion);

            return query.ToList();
        }

        public List<Solicitud> LeerTodasLasSolicitudes()
        {
            var query = DataBase.ExecuteSprocAccessor<Solicitud>("LeerTodasLasSolicitudes");

            return query.ToList();

        }
        /// <summary>
        /// las validaciones quese gestione conla modificacion
        /// </summary>
        /// <param name="solicitud"></param>
        public void ModificarSolicitud(Solicitud solicitud)
        {
            DbCommand command = DataBase.GetStoredProcCommand("ModificarSolicitud");

            DataBase.AddInParameter(command, "sl_id", System.Data.DbType.Int32, solicitud.sl_id);
            DataBase.AddInParameter(command, "usuario_id", System.Data.DbType.Int32, solicitud.usuario_id);
            DataBase.AddInParameter(command, "estacion_id", System.Data.DbType.Int32, solicitud.estacion_id);
            DataBase.AddInParameter(command, "sl_fecha", System.Data.DbType.DateTime, solicitud.sl_fecha);
            DataBase.AddInParameter(command, "sl_recepcion", System.Data.DbType.Decimal, solicitud.sl_recepcion);
            DataBase.AddInParameter(command, "sl_asignacion", System.Data.DbType.Int32, solicitud.sl_asignacion);
            DataBase.AddInParameter(command, "sl_atencion", System.Data.DbType.DateTime, solicitud.sl_atencion);
            DataBase.AddInParameter(command, "sl_aceptacion", System.Data.DbType.Decimal, solicitud.sl_aceptacion);
            DataBase.AddInParameter(command, "sl_eliminado", System.Data.DbType.Int32, solicitud.sl_eliminado);
            DataBase.ExecuteNonQuery(command); 
        }

        #region validaciones

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
        #endregion
    }
}
