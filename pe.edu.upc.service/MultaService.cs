using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using pe.edu.upc.model;
using pe.edu.upc.repository;

namespace pe.edu.upc.service
{
    public class MultaService : IMultaService
    {
        IMultaRepository repositoryMulta;

        public MultaService()
        {
            repositoryMulta = new MultaRepository();
        }
        public IEnumerable<Object> ListarMultas()
        {
            return repositoryMulta.ListarMultas();
        }

        public IEnumerable<Object> ListarUsuarioxNombre(string nombre)
        {
            return repositoryMulta.ListarUsuarioxNombre(nombre);
        }

        public void RegistrarMulta(multa mult)
        {
            repositoryMulta.RegistrarMulta(mult);
        }
    }
}
