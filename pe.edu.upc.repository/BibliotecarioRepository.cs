using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using pe.edu.upc.model;

namespace pe.edu.upc.repository
{
    public class BibliotecarioRepository : IBibliotecarioRepository
    {
        IpadsUPCEntities context;

        public BibliotecarioRepository()
        {
            context = new IpadsUPCEntities();
        }
        public List<bibliotecario> ListarBibliotecarios()
        {
            var resultados = context.bibliotecario.ToList();
            return resultados;
        }

        public bibliotecario obtenerBibliotecarioxCodigo(string codigo)
        {
            var resultado = context.bibliotecario.FirstOrDefault(x => x.codigo == codigo);
            return resultado;
        }

        public void RegistrarBibliotecario(bibliotecario bibliot)
        {
            context.bibliotecario.Add(bibliot);
            context.SaveChanges();
        }
    }
}
