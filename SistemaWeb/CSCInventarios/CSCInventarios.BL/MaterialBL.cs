using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using CSCInventarios.EL;
using CSCInventarios.DAL;
using Microsoft.Practices.Unity;

namespace CSCInventarios.BL
{
    public class MaterialBL:IMaterialBL
    {
        [Dependency]
        public IMaterialDAL materialDAL { get; set;}
        public MaterialBL(){}

        public List<Material> LeerTodosLosMateriales()
        {
            return materialDAL.LeerTodosLosMateriales();
        }

        public Material LeerMaterialPorMaterialId(int material_id)
        {
            return materialDAL.LeerMaterialPorMaterialId(material_id);
        }

        public List<Material> LeerMaterialPorCriterio(string criterio)
        {
            return materialDAL.LeerMaterialPorCriterio(criterio);
        }

        public void CrearMaterial(Material material)
        {
            materialDAL.CrearMaterial(material);
        }

        public void EliminarMaterial(int material_id)
        {
            materialDAL.EliminarMaterial(material_id);
        }

        public void modificarMaterial(Material material)
        {
            materialDAL.modificarMaterial(material);
        }
    }
}
