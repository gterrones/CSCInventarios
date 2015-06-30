using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using CSCInventarios.EL;

namespace CSCInventarios.DAL
{
    public interface IUsuarioDAL
    {
        List<Usuario> LeerTodosLosUsuarios();
        Usuario LeerUsuarioPorUsuarioId(int usuario_id);
        List<Usuario> LeerUsuarioPorCriterio(string criterio);
        void CrearUsuario(Usuario usuario);
        void EliminarUsuario(int usuario_id);
        void modificarUsuario(Usuario usuario);
    }
}
