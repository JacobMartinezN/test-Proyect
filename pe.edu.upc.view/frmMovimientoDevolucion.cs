using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using pe.edu.upc.model;
using pe.edu.upc.service;

namespace pe.edu.upc.view
{
    public partial class frmMovimientoDevolucion : Form
    {
        private IMovimientoService movimientoService;

        private IIpadService ipadService;

        private IBibliotecarioService bibliotecarioService;

        private IUsuarioService usuarioService;

        private IMultaService multaService;

        public frmMovimientoDevolucion()
        {
            InitializeComponent();
            movimientoService = new MovimientoService();
            ipadService = new IpadService();
            bibliotecarioService = new BibliotecarioService();
            usuarioService = new UsuarioService();
            multaService = new MultaService();
            ListarMovimientos();
        }

        private void btnActualizar_Click(object sender, EventArgs e)
        {
            string codigoUsuario = txtUsuario.Text;
            var usuario=usuarioService.obtenerUsuarioxCodigo(codigoUsuario);

            int idUsuario = usuario.id;

            var movimiento = movimientoService.ObtenerxUsuarioID(idUsuario);

            movimiento.fechadevolucionreal = dtFechaDevolucion.Value;
            movimiento.estado = "Devuelto";




            int diferenciaDeDias=(movimiento.fechadevolucionreal - movimiento.fechaprestamo).Value.Days;

            if (diferenciaDeDias > 3)
            {
                int diasmora = diferenciaDeDias - 3;
                int MontoMora = diasmora * 10;

                var multa = new multa();

                multa.diasmora = diasmora;
                multa.montopagar = MontoMora;
                multa.movimiento_id = movimiento.id;

                multaService.RegistrarMulta(multa);

            }
            

            movimientoService.ActualizarMovimiento(movimiento);
            ListarMovimientos();
        }

        public void ListarMovimientos()
        {
            gvDevolucion.DataSource = movimientoService.ListarMovimientosConDevolucion();
        }
    }
}
