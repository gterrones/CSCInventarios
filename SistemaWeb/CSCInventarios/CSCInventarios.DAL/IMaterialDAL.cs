using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using CSCInventarios.EL;

namespace CSCInventarios.DAL
{
    public interface IMaterialDAL
    {
        List<Material> LeerTodosLosMateriales();
        Material LeerMaterialPorMaterialId(int material_id);
        List<Material> LeerMaterialPorCriterio(string criterio);
        void CrearMaterial(Material material);
        void EliminarMaterial(int material_id);
        void modificarMaterial(Material material);
    }
}
