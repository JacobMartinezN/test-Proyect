using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using pe.edu.upc.model;

namespace pe.edu.upc.repository
{
    public class SedeRepository : ISedeRepository
    {
        IpadsUPCEntities context;

        public SedeRepository()
        {
            context = new IpadsUPCEntities();
        }
        public List<sede> ListarSedes()
        {
            var resultado = context.sede.ToList();
            return resultado;
        }

        public void RegistrarSede(sede sed)
        {
            context.sede.ToList();
            context.SaveChanges();
        }
    }
}