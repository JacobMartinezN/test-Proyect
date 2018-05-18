using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using pe.edu.upc.model;
using pe.edu.upc.repository;

namespace pe.edu.upc.service
{
    public class SedeService : ISedeService
    {
        ISedeRepository repositorio;

        public SedeService()
        {
            repositorio = new SedeRepository();
        }
        public List<sede> ListarSedes()
        {
            return repositorio.ListarSedes();
        }

        public void RegistrarSede(sede sed)
        {
            repositorio.RegistrarSede(sed);
        }
    }
}
