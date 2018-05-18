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
    public partial class frmMovimiento : Form
    {
        private IMovimientoService movimientoService;

        private IIpadService ipadService;

        private IBibliotecarioService bibliotecarioService;

        private IUsuarioService usuarioService;

        private movimiento mov;

        public frmMovimiento()
        {
            InitializeComponent();
            movimientoService = new MovimientoService();
            ipadService = new IpadService();
            bibliotecarioService = new BibliotecarioService();
            usuarioService = new UsuarioService();
            ListarMovimientos();
        }

        public frmMovimiento(movimiento Movimiento)
        {
            InitializeComponent();
            mov = new movimiento();
            mov = Movimiento;
            movimientoService = new MovimientoService();
            ipadService = new IpadService();
            bibliotecarioService = new BibliotecarioService();
            usuarioService = new UsuarioService();
            cargarMovimientoPrevio();
            ListarMovimientos();
        }

        private void btnRegMov_Click(object sender, EventArgs e)
        {
            try
            {
                var movimiento = new movimiento();
                string codigoUsuario = txtUsuarioCod.Text;
                string codigoIpad = txtIpadCod.Text;
                string codigoBibliotecario = txtBibliotecarioCod.Text;


                var usuario = usuarioService.obtenerUsuarioxCodigo(codigoUsuario);
                var ipad = ipadService.ObtenerporCodigo(codigoIpad);
                var bibliotecario = bibliotecarioService.obtenerBibliotecarioxCodigo(codigoBibliotecario);

                movimiento.fechaprestamo = dtFechaPrestamo.Value;
                movimiento.fechadevolucion = dtFechaDevo.Value;
                movimiento.estado = cbEstadoMov.Text;


                movimiento.ipad_id = ipad.id;
                movimiento.usuario_id = usuario.id;
                movimiento.bibliotecario_id = bibliotecario.id;

                if (movimiento.estado == "Aprobado")
                {
                    movimientoService.RegistrarMovimiento(movimiento);
                    ListarMovimientos();
                    MessageBox.Show("Se ha puesto en prestamo el IPad");
                    ipad.estado = "En Uso";
                    ipadService.ActualizarIapd(ipad);
                }
                else
                {
                    MessageBox.Show("Se ha denegado tu prestamo del IPad");
                }  
            }
            catch(Exception ex)
            {
                MessageBox.Show("Ocurrio un error",ex.Message);
            }
           
            
        }

        public void cargarMovimientoPrevio()
        {
            int idIpad, idUsuario;
            idIpad = mov.ipad_id;
            idUsuario = mov.usuario_id;

            var ipad = ipadService.ObtenerporId(idIpad);
            var usuario = usuarioService.obtenerUsuarioxID(idUsuario);

            txtUsuarioCod.Text = usuario.codigo;
            txtIpadCod.Text = ipad.codigo;

            dtFechaPrestamo.Value = mov.fechaprestamo;
            dtFechaDevo.Value = mov.fechadevolucion;
        }

        public void ListarMovimientos()
        {
            gvMovimiento.DataSource = movimientoService.ListarMovimientos();
        }
    }
}
