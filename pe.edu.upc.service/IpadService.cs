using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using pe.edu.upc.model;
using pe.edu.upc.repository;

namespace pe.edu.upc.service
{
    public class IpadService : IIpadService
    {

        IIpadRepository repositoryIpad;

        public IpadService()
        {
            repositoryIpad = new IpadRepository();
        }

        public void ActualizarIapd(ipad tablet)
        {
            repositoryIpad.ActualizarIapd(tablet);
            
        }

        public void EliminarIpad(int IdIpad)
        {
            repositoryIpad.EliminarIpad(IdIpad);
        }

        public IEnumerable<Object> ListarIpad()
        {
            return repositoryIpad.ListarIpad();
        }

        public ipad ObtenerDisponible()
        {
            return repositoryIpad.ObtenerDisponible();
        }

        public ipad ObtenerporCodigo(string codigo)
        {
            return repositoryIpad.ObtenerporCodigo(codigo);
        }

        public ipad ObtenerporId(int IdIpad)
        {
            return repositoryIpad.ObtenerporId(IdIpad);
        }

        public void RegistrarIpad(ipad tablet)
        {
            repositoryIpad.RegistrarIpad(tablet);
        }
    }
}
