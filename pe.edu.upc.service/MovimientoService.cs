using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using pe.edu.upc.model;
using pe.edu.upc.repository;

namespace pe.edu.upc.service
{
    public class MovimientoService : IMovimientoService
    {
        IMovimientoRepository repositoryMovimiento;

        public MovimientoService()
        {
            repositoryMovimiento = new MovimientoRepository();
        }

        public void ActualizarMovimiento(movimiento mov)
        {
            repositoryMovimiento.ActualizarMovimiento(mov);
        }

        public void EliminarMovimiento(int IdMovimiento)
        {
            repositoryMovimiento.EliminarMovimiento(IdMovimiento);
        }

        public IEnumerable<Object> ListarMovimientos()
        {
            return repositoryMovimiento.ListarMovimientos();
        }

        public IEnumerable<object> ListarMovimientoxUsuario(string codigoUser)
        {
            return repositoryMovimiento.ListarMovimientoxUsuario(codigoUser);
        }

        public movimiento ObtenerxUsuarioID(int IdUsuario)
        {
            return repositoryMovimiento.ObtenerxUsuarioID(IdUsuario);
        }

        public IEnumerable<Object> ListarMovimientosConDevolucion()
        {
            return repositoryMovimiento.ListarMovimientosConDevolucion();
        }

        public void RegistrarMovimiento(movimiento mov)
        {
            repositoryMovimiento.RegistrarMovimiento(mov);
        }
    }
}
