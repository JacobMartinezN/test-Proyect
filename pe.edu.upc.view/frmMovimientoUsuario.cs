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
    public partial class frmMovimientoUsuario : Form
    {
        private IUsuarioService usuarioService;

        private IIpadService ipadService;

        private IMovimientoService movimientoService;


        public frmMovimientoUsuario()
        {
            InitializeComponent();
            usuarioService = new UsuarioService();
            ipadService = new IpadService();
            movimientoService = new MovimientoService();
        }

        void listar()
        {
            gvMovimientoUs.DataSource = movimientoService.ListarMovimientos();
        }
        // xddddddddddddddd
        private void btnRegistrarMovimiento_Click(object sender, EventArgs e)
        {
            var ipad = ipadService.ObtenerDisponible();

            if (ipad == null)
            {
                MessageBox.Show("No hay Ipads Disponibles");
                return;
            }else
            {
                string codigousuario;
                codigousuario = txtCodigoUsuario.Text;

                var usuario = usuarioService.obtenerUsuarioxCodigo(codigousuario);

                var movimiento = new movimiento();

                DateTime fechaprestamo = this.dtFechaPrestamoUsuario.Value.Date;
                DateTime fechadevolucion = fechaprestamo.AddDays(3);

                movimiento.fechaprestamo = fechaprestamo;
                movimiento.fechadevolucion = fechadevolucion;
                movimiento.usuario_id = usuario.id;
                movimiento.estado = "En Proceso";
                movimiento.ipad_id = ipad.id;

                var frmMovimiento = new frmMovimiento(movimiento);

                frmMovimiento.ShowDialog();
            }

        }

        private void gvMovimientoUs_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void frmMovimientoUsuario_Load(object sender, EventArgs e)
        {
            listar();
        }
    }
}
