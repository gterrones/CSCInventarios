using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using CSCInventarios.EL;

namespace CSCInventarios.DAL
{
    public class RequerimientoDAL:cnx,IRequerimientoDAL
    {
        public void CrearRequerimiento(Requerimiento requerimiento)
        {
            throw new NotImplementedException();
        }

        public void EliminarRequerimiento(int rq_id)
        {
            throw new NotImplementedException();
        }

        public Requerimiento LeerRequerimientoPorRqId(int rq_id)
        {
            throw new NotImplementedException();
        }

        public List<Requerimiento> LeerRequerimientoPorUsuarioId(int usuario_id)
        {
            throw new NotImplementedException();
        }

        public List<Requerimiento> LeerRequerimientoEntreFechas(DateTime fechaInicio, DateTime fechaFin)
        {
            throw new NotImplementedException();
        }

        public List<Requerimiento> LeerRequerimientosValidados(bool rq_validacion)
        {
            throw new NotImplementedException();
        }

        public List<Requerimiento> LeerTodosLosRequerimientos()
        {
            throw new NotImplementedException();
        }

        public void ModificarRequerimiento(Requerimiento requerimiento)
        {
            throw new NotImplementedException();
        }

        public void ValidarRequerimiento(int rq_id, bool rq_validacion)
        {
            throw new NotImplementedException();
        }
    }
}
