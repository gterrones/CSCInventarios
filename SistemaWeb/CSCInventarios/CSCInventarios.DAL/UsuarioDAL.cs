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
    public class UsuarioDAL:cnx,IUsuarioDAL
    {
        [Dependency]
        public IUsuarioDAL usuarioDAL { get; set; }

        public UsuarioDAL() {
            
        }

        public List<Usuario> LeerTodosLosUsuarios()
        {
            var query = DataBase.ExecuteSprocAccessor<Usuario>("LeerTodosLosUsuarios");
            var usuario = query.ToList();
            usuario.Insert(0, new Usuario() { usuario_id = 0, usuario_nombre = "[ Elegir usuario ]" });

            return usuario;
        }

        public Usuario LeerUsuarioPorUsuarioId(int usuario_id)
        {
            throw new NotImplementedException();
        }

        public List<Usuario> LeerUsuarioPorCriterio(string criterio)
        {
            throw new NotImplementedException();
        }

        public void CrearUsuario(Usuario usuario)
        {
            throw new NotImplementedException();
        }

        public void EliminarUsuario(int usuario_id)
        {
            throw new NotImplementedException();
        }

        public void modificarUsuario(Usuario usuario)
        {
            throw new NotImplementedException();
        }
    }
}
