using pe.edu.upc.model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pe.edu.upc.repository
{
    public interface IBibliotecarioRepository
    {
        void RegistrarBibliotecario(bibliotecario bibliot);

        List<bibliotecario> ListarBibliotecarios();

        bibliotecario obtenerBibliotecarioxCodigo(string codigo);
    }
}
