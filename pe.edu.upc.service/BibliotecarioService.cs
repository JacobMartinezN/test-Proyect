using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using pe.edu.upc.model;
using pe.edu.upc.repository;

namespace pe.edu.upc.service
{
    public class BibliotecarioService : IBibliotecarioService
    {
        IBibliotecarioRepository repositoryBibliotecario;

        public BibliotecarioService()
        {
            repositoryBibliotecario = new BibliotecarioRepository();
        }
        public List<bibliotecario> ListarBibliotecarios()
        {
            return repositoryBibliotecario.ListarBibliotecarios();
        }

        public bibliotecario obtenerBibliotecarioxCodigo(string codigo)
        {
            return repositoryBibliotecario.obtenerBibliotecarioxCodigo(codigo);
        }

        public void RegistrarBibliotecario(bibliotecario bibliot)
        {
            repositoryBibliotecario.RegistrarBibliotecario(bibliot);
        }
    }
}
