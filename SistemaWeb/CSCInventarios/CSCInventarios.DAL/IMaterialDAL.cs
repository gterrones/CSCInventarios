using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using CSCInventarios.EL;

namespace CSCInventarios.DAL
{
    public interface IMaterialDAL
    {
        List<Material> LeerTodosLosMateriales();//procedimiento PROBADO
        Material LeerMaterialPorMaterialId(int material_id);//procedimiento PROBADO
        List<Material> LeerMaterialPorCriterio(string criterio);//procedimiento PROBADO
        void CrearMaterial(Material material);//procedimiento PROBADO
        void EliminarMaterial(int material_id);//procedimiento PROBADO
        void modificarMaterial(Material material);//procedimiento PROBADO
    }
}
