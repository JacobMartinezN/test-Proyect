using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using pe.edu.upc.model;

namespace pe.edu.upc.repository
{
    public class MovimientoRepository : IMovimientoRepository
    {
        IpadsUPCEntities context;
        public MovimientoRepository()
        {
            context = new IpadsUPCEntities();
        }

        public void ActualizarMovimiento(movimiento mov)
        {
            var resultado = context.movimiento
                            .Where(x => x.estado == "Aprobado").First();
            resultado.fechadevolucionreal = mov.fechadevolucionreal;
            resultado.estado= mov.estado;
            context.SaveChanges();
        }

        public void EliminarMovimiento(int IdMovimiento)
        {
            context.movimiento.Remove(context.movimiento.Where(x => x.id == IdMovimiento).First());
            context.SaveChanges();
        }

        public IEnumerable<Object> ListarMovimientosConDevolucion()
        {
            var resultado = (from u in context.usuario
                            join m in context.movimiento on u.id equals m.usuario_id
                            join b in context.bibliotecario on m.bibliotecario_id equals b.id
                            join i in context.ipad on m.ipad_id equals i.id
                            select new
                            {
                                FechaPrestamo = m.fechaprestamo,
                                FechaDevolucionReal = m.fechadevolucionreal,
                                IpadCodigo = i.codigo,
                                UsuarioCodigo = u.codigo,
                                BibliotecarioCodigo = b.codigo,
                                EstadoMovimiento = m.estado
                            }).ToList();
            return resultado;
        }

        public IEnumerable<Object> ListarMovimientos()
        {
            var resultado = (from u in context.usuario
                             join m in context.movimiento on u.id equals m.usuario_id
                             join b in context.bibliotecario on m.bibliotecario_id equals b.id
                             join i in context.ipad on m.ipad_id equals i.id
                             select new
                             {
                                 FechaPrestamo = m.fechaprestamo,
                                 FechaDevolucion = m.fechadevolucion,
                                 IpadCodigo = i.codigo,
                                 UsuarioCodigo = u.codigo,
                                 BibliotecarioCodigo = b.codigo,
                                 EstadoMovimiento = m.estado
                             }).ToList();
            return resultado;
        }

        public IEnumerable<object> ListarMovimientoxUsuario(string codigoUser)
        {
           

            var resultado= (from m in context.movimiento
                            join u in context.usuario
                            on m.usuario_id equals u.id
                           where u.codigo == codigoUser
                           select new
                            {
                                FechaPrestamo = m.fechaprestamo,
                                FechaDevolucion = m.fechadevolucionreal,
                                Ipad = m.ipad.codigo,
                                Usuario = m.usuario.nombre,
                                Bilbiotecario = m.bibliotecario.nombre,
                                Estado = m.estado}).ToList();
            return resultado;

        }

        public movimiento ObtenerxUsuarioID(int IdUsuario)
        {
            var resultado = context.movimiento.Where(x => x.usuario_id == IdUsuario && x.fechadevolucionreal != null).First();
            return resultado;
        }

        public void RegistrarMovimiento(movimiento mov)
        {
            context.movimiento.Add(mov);
            context.SaveChanges();
        }
    }
}
