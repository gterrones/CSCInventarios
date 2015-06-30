using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using CSCInventarios.EL;

namespace CSCInventarios.DAL
{
    public class MaterialDAL:cnx , IMaterialDAL
    {

        public List<Material> LeerTodosLosMateriales()
        {
            throw new NotImplementedException();
        }

        public Material LeerMaterialPorMaterialId(int material_id)
        {
            throw new NotImplementedException();
        }

        public List<Material> LeerMaterialPorCriterio(string criterio)
        {
            throw new NotImplementedException();
        }

        public void CrearMaterial(Material material)
        {
            throw new NotImplementedException();
        }

        public void EliminarMaterial(int material_id)
        {
            throw new NotImplementedException();
        }

        public void modificarMaterial(Material material)
        {
            throw new NotImplementedException();
        }
    }
}
