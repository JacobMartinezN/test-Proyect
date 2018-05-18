using pe.edu.upc.model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pe.edu.upc.repository
{
    public class MultaRepository : IMultaRepository
    {
        IpadsUPCEntities context;

        public MultaRepository()
        {
            context = new IpadsUPCEntities();
        }

        public IEnumerable<object> ListarMultas()
        {
            var resultados = (from mu in context.multa
                             join mov in context.movimiento on mu.movimiento_id equals mov.id
                             join u in context.usuario on mov.usuario_id equals u.id
                             select new
                             {
                                 FechaPrestamo = mov.fechaprestamo,
                                 DiasMora = mu.diasmora,
                                 CodigoUsuario = u.codigo,
                                 NombreUsuario = u.nombre,
                                 ApellidoUsuario = u.apellido,
                                 CorreoUsuario = u.correo
                             }).ToList();
            return resultados;
        }

        public IEnumerable<object> ListarUsuarioxNombre(string nombre)
        {

            var resultados = from u in context.usuario
                             where u.nombre.Contains(nombre)
                             join m in context.movimiento on u.id equals m.usuario_id
                             join mu in context.multa on m.id equals mu.movimiento_id
                             select new { Nombre = u.nombre, Multa = mu.montopagar, DiasMora = mu.diasmora };
            return resultados;

        }

        public void RegistrarMulta(multa mult)
        {
            context.multa.Add(mult);
            context.SaveChanges();
        }
    }
}
