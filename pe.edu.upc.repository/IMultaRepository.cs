using pe.edu.upc.model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pe.edu.upc.repository
{
    public interface IMultaRepository
    {

        void RegistrarMulta(multa mult);

        IEnumerable<object> ListarMultas();

        IEnumerable<object> ListarUsuarioxNombre(string nombre);
   
        
    }
}
