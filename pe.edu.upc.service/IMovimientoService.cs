using pe.edu.upc.model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pe.edu.upc.service
{
    public interface IMovimientoService
    {
        void RegistrarMovimiento(movimiento mov);

        void ActualizarMovimiento(movimiento mov);

        void EliminarMovimiento(int IdMovimiento);

        IEnumerable<Object> ListarMovimientos();

        IEnumerable<Object> ListarMovimientoxUsuario(string codigoUser);

        IEnumerable<Object> ListarMovimientosConDevolucion();

        movimiento ObtenerxUsuarioID(int IdUsuario);
    }
}
