using pe.edu.upc.model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pe.edu.upc.service
{
    public interface IIpadService
    {
        void RegistrarIpad(ipad tablet);

        void ActualizarIapd(ipad tablet);

        void EliminarIpad(int IdIpad);

        IEnumerable<Object> ListarIpad();

        ipad ObtenerporId(int IdIpad);

        ipad ObtenerDisponible();

        ipad ObtenerporCodigo(string codigo);

    }
}
