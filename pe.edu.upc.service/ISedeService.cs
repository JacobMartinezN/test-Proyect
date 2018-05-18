using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using pe.edu.upc.model;

namespace pe.edu.upc.service
{
    public interface ISedeService
    {
        void RegistrarSede(sede sed);

        List<sede> ListarSedes();
    }
}
