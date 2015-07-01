using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using CSCInventarios.EL;

namespace CSCInventarios.BL
{
    public interface IRequerimientoBL
    {
        void CrearRequerimiento(Requerimiento requerimiento);
        void EliminarRequerimiento(int rq_id);
        Requerimiento LeerRequerimientoPorRqId(int rq_id);
        List<Requerimiento> LeerRequerimientoPorUsuarioId(int usuario_id);
        List<Requerimiento> LeerRequerimientoEntreFechas(DateTime fechaInicio, DateTime fechaFin);
        List<Requerimiento> LeerRequerimientosValidados(Boolean rq_validacion);
        List<Requerimiento> LeerTodosLosRequerimientos();
        void ModificarRequerimiento(Requerimiento requerimiento);
        void ValidarRequerimiento(int rq_id, Boolean rq_validacion);
    }
}
