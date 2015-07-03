using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using CSCInventarios.EL;
using Microsoft.Practices.EnterpriseLibrary.Common.Configuration;
using Microsoft.Practices.EnterpriseLibrary.Data;
using System.Data;
using System.Data.Common;
using Microsoft.Practices.Unity;


namespace CSCInventarios.DAL
{
    public class MaterialDAL:cnx , IMaterialDAL
    {
        [Dependency]
        public IMaterialDAL materialDAL { get; set; }

        public MaterialDAL() { }


        public List<Material> LeerTodosLosMateriales()
        {
            var query = DataBase.ExecuteSprocAccessor<Material>("LeerTodosLosMateriales");            
            var material = query.ToList();
            material.Insert(0, new Material() { material_id = 0, material_nombre= "[ Elegir Material ]" });

            return material;
        }

        public Material LeerMaterialPorMaterialId(int material_id)
        {
            var query = DataBase.ExecuteSprocAccessor<Material>("LeerMaterialPorMaterialId", material_id);
            return query.SingleOrDefault();
        }

        public List<Material> LeerMaterialPorCriterio(string criterio)
        {
            var query = DataBase.ExecuteSprocAccessor<Material>("LeerMaterialPorCriterio", criterio);
            return query.ToList();


        }

        public void CrearMaterial(Material material)
        {
            DbCommand command = DataBase.GetStoredProcCommand("CrearMaterial");

            DataBase.AddInParameter(command, "material_id", DbType.Int32, material.material_id);
            DataBase.AddInParameter(command, "material_nombre", DbType.String, material.material_nombre);
            DataBase.AddInParameter(command, "material_modelo", DbType.String, material.material_modelo);
            DataBase.AddInParameter(command, "material_marca", DbType.String, material.material_marca);
            DataBase.AddInParameter(command, "material_cantidad", DbType.Int32, material.material_cantidad);
            DataBase.AddInParameter(command, "material_observacion", DbType.String, material.material_observacion);
            DataBase.AddInParameter(command, "material_eliminado", DbType.Boolean, material.material_eliminado);

            DataBase.ExecuteNonQuery(command);  
        }

        public void EliminarMaterial(int material_id)
        {
            DbCommand command = DataBase.GetStoredProcCommand("EliminarMaterial");

            DataBase.AddInParameter(command, "material_id", DbType.Int32, material_id);
            DataBase.AddInParameter(command, "material_eliminado", DbType.Boolean, 1);

            DataBase.ExecuteNonQuery(command);  
        }

        public void modificarMaterial(Material material)
        {
            DbCommand command = DataBase.GetStoredProcCommand("modificarMaterial");

            DataBase.AddInParameter(command, "material_id", DbType.Int32, material.material_id);
            DataBase.AddInParameter(command, "material_nombre", DbType.String, material.material_nombre);
            DataBase.AddInParameter(command, "material_modelo", DbType.String, material.material_modelo);
            DataBase.AddInParameter(command, "material_cantidad", DbType.Int32, material.material_cantidad);
            DataBase.AddInParameter(command, "material_observacion", DbType.String, material.material_observacion);
            DataBase.AddInParameter(command, "material_eliminado", DbType.Boolean, material.material_eliminado);

            DataBase.ExecuteNonQuery(command);  
        }
    }
}
