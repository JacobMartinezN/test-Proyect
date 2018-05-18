using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using pe.edu.upc.model;
using pe.edu.upc.repository;

namespace pe.edu.upc.service
{
    public class UsuarioService : IUsuarioService
    {
        IUsuarioRepository repositoryUsuario;

        public UsuarioService()
        {
            repositoryUsuario = new UsuarioRepository();
        }

        public IEnumerable<object> ListarAlumno()
        {
            return repositoryUsuario.ListarAlumno();
        }

        public IEnumerable<object> ListarDocente()
        {
            return repositoryUsuario.ListarDocente();
        }

        public usuario obtenerUsuarioxCodigo(string codigo)
        {
            return repositoryUsuario.obtenerUsuarioxCodigo(codigo);
        }

        public usuario obtenerUsuarioxID(int IdUsuario)
        {
            return repositoryUsuario.obtenerUsuarioxID(IdUsuario);
        }

        public void RegistrarUsuario(usuario user)
        {
            repositoryUsuario.RegistrarUsuario(user);
        }
    }
}
