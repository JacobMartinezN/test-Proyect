using pe.edu.upc.model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pe.edu.upc.repository
{
    public interface IMovimientoRepository
    {
        void RegistrarMovimiento(movimiento mov);

        void ActualizarMovimiento(movimiento mov);

        void EliminarMovimiento(int IdMovimiento);

        IEnumerable<Object> ListarMovimientos();

        IEnumerable<Object> ListarMovimientosConDevolucion();

        IEnumerable<Object> ListarMovimientoxUsuario(string codigoUser);

        movimiento ObtenerxUsuarioID(int IdUsuario);
    }
}
