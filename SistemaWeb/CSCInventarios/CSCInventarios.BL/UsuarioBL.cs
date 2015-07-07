using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using CSCInventarios.EL;
using CSCInventarios.DAL;
using Microsoft.Practices.Unity;

namespace CSCInventarios.BL
{
    public class UsuarioBL:IUsuarioBL
    {
        [Dependency]
        public IUsuarioDAL usuarioBL { get; set; }

        public UsuarioBL() {
            usuarioBL = new UsuarioDAL();
        }

        public List<Usuario> LeerTodosLosUsuarios()
        {
            return usuarioBL.LeerTodosLosUsuarios();
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
