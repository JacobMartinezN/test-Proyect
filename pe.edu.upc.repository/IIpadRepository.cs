using pe.edu.upc.model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pe.edu.upc.repository
{
    public interface IIpadRepository
    {
        void RegistrarIpad(ipad tablet);

        void ActualizarIapd(ipad tablet);

        void EliminarIpad(int IdIpad);

        IEnumerable<Object> ListarIpad();

        ipad ObtenerporId(int IdIpad);

        ipad ObtenerporCodigo(string codigo);

        ipad ObtenerDisponible();
    }
}
