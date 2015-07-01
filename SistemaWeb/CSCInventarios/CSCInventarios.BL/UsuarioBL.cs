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
        public List<EL.Usuario> LeerTodosLosUsuarios()
        {
            throw new NotImplementedException();
        }

        public EL.Usuario LeerUsuarioPorUsuarioId(int usuario_id)
        {
            throw new NotImplementedException();
        }

        public List<EL.Usuario> LeerUsuarioPorCriterio(string criterio)
        {
            throw new NotImplementedException();
        }

        public void CrearUsuario(EL.Usuario usuario)
        {
            throw new NotImplementedException();
        }

        public void EliminarUsuario(int usuario_id)
        {
            throw new NotImplementedException();
        }

        public void modificarUsuario(EL.Usuario usuario)
        {
            throw new NotImplementedException();
        }
    }
}
