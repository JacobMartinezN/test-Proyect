using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using pe.edu.upc.model;

namespace pe.edu.upc.repository
{
    public class IpadRepository : IIpadRepository
    {
        IpadsUPCEntities context;

        public IpadRepository()
        {
            context = new IpadsUPCEntities();
        }
        public void ActualizarIapd(ipad tablet)
        {
            var resultado = context.ipad.FirstOrDefault(x => x.id == tablet.id);

            resultado.versionso = tablet.versionso;
            resultado.descripcion = tablet.descripcion;
            resultado.estado = tablet.estado;
            context.SaveChanges();
        }

        public void EliminarIpad(int IdIpad)
        {
            context.ipad.Remove(context.ipad.Where(x => x.id == IdIpad).First());
            context.SaveChanges();
        }

        public IEnumerable<Object> ListarIpad()
        {
            var resultados = (from i in context.ipad
                              join s in context.sede on i.sede_id equals s.id
                              select new
                              {
                                  IpadId = i.id,
                                  Codigo = i.codigo,
                                  VersionSO = i.versionso,
                                  Serial = i.serial,
                                  Estado = i.estado,
                                  Modelo = i.modelo,
                                  Descripcion = i.descripcion,
                                  SedeNombre = s.nombre,
                              }).ToList();
            return resultados;
        }

        public ipad ObtenerDisponible()
        {
            var resultado = context.ipad.Where(x => x.estado == "Disponible").First();
            return resultado;
        }

        public ipad ObtenerporCodigo(string codigo)
        {
            var resultado = context.ipad.FirstOrDefault(x => x.codigo == codigo);
            return resultado;
        }

        public ipad ObtenerporId(int IdIpad)
        {
            var resultado = context.ipad.Find(IdIpad);
            return resultado;
        }

        public void RegistrarIpad(ipad tablet)
        {
            context.ipad.Add(tablet);
            context.SaveChanges();
        }
    }
}
