using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using CSCInventarios.EL;

namespace CSCInventarios.DAL
{
    public class UsuarioDAL:cnx,IUsuarioDAL
    {

        public List<Usuario> LeerTodosLosUsuarios()
        {
            throw new NotImplementedException();
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
