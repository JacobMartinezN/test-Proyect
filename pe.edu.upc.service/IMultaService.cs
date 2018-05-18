using pe.edu.upc.model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pe.edu.upc.service
{
    public interface IMultaService
    {
        void RegistrarMulta(multa mult);

        IEnumerable<Object> ListarMultas();

        IEnumerable<Object> ListarUsuarioxNombre(string nombre);

    }
}
