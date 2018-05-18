using pe.edu.upc.model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pe.edu.upc.repository
{
    public interface ISedeRepository
    {
        void RegistrarSede(sede sed);

        List<sede> ListarSedes();
    }
}
