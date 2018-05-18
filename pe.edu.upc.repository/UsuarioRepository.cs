using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using pe.edu.upc.model;

namespace pe.edu.upc.repository
{
    public class UsuarioRepository : IUsuarioRepository
    {
        IpadsUPCEntities context;

        public UsuarioRepository()
        {
            context = new IpadsUPCEntities();
        }

        public IEnumerable<object> ListarAlumno()
        {
            var resultados = context
                  .usuario
                  .Select(x => new
                  {
                      Codigo = x.codigo,
                      Nombre = x.nombre,
                      Apellido = x.apellido,
                      Facultad = x.facultad,
                      Sede = x.sede,
                      Correo = x.correo
                  }).ToList();
            return resultados;
        }

        public IEnumerable<object> ListarDocente()
        {
            var resultados = context
                  .usuario
                  .Select(x => new
                  {
                      Codigo = x.codigo,
                      Nombre = x.nombre,
                      Apellido = x.apellido,
                      Facultad = x.facultad,
                      Correo = x.correo
                  }).ToList();
            return resultados;
        }

        public usuario obtenerUsuarioxCodigo(string codigo)
        {
            var resultado = context.usuario.FirstOrDefault(x => x.codigo == codigo);
            return resultado;
        }

        public usuario obtenerUsuarioxID(int IdUsuario)
        {
            var resultado = context.usuario.FirstOrDefault(x => x.id == IdUsuario);
            return resultado;
        }

        public void RegistrarUsuario(usuario user)
        {
            context.usuario.Add(user);
            context.SaveChanges();
        }
    }
}
