using pe.edu.upc.model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pe.edu.upc.service
{
    public interface IUsuarioService
    {
        void RegistrarUsuario(usuario user);

        IEnumerable<Object> ListarAlumno();

        IEnumerable<Object> ListarDocente();

        usuario obtenerUsuarioxCodigo(string codigo);

        usuario obtenerUsuarioxID(int IdUsuario);
    }
}
