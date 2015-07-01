using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using CSCInventarios.EL;
using CSCInventarios.DAL;
using Microsoft.Practices.Unity;

namespace CSCInventarios.BL
{
    public class RequerimientoBL:IRequerimientoBL
    {
        public void CrearRequerimiento(EL.Requerimiento requerimiento)
        {
            throw new NotImplementedException();
        }

        public void EliminarRequerimiento(int rq_id)
        {
            throw new NotImplementedException();
        }

        public EL.Requerimiento LeerRequerimientoPorRqId(int rq_id)
        {
            throw new NotImplementedException();
        }

        public List<EL.Requerimiento> LeerRequerimientoPorUsuarioId(int usuario_id)
        {
            throw new NotImplementedException();
        }

        public List<EL.Requerimiento> LeerRequerimientoEntreFechas(DateTime fechaInicio, DateTime fechaFin)
        {
            throw new NotImplementedException();
        }

        public List<EL.Requerimiento> LeerRequerimientosValidados(bool rq_validacion)
        {
            throw new NotImplementedException();
        }

        public List<EL.Requerimiento> LeerTodosLosRequerimientos()
        {
            throw new NotImplementedException();
        }

        public void ModificarRequerimiento(EL.Requerimiento requerimiento)
        {
            throw new NotImplementedException();
        }

        public void ValidarRequerimiento(int rq_id, bool rq_validacion)
        {
            throw new NotImplementedException();
        }
    }
}
