using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using pe.edu.upc.service;
using pe.edu.upc.model;

namespace pe.edu.upc.view
{
    public partial class frmDocente : Form
    {
        private IUsuarioService usuarioService;

        
        public frmDocente()
        {

            InitializeComponent();
            usuarioService = new UsuarioService();
            
        }

        private void btnRegDocente_Click(object sender, EventArgs e)
        {
            var docente = new usuario();
            docente.codigo = txtCodigoDocente.Text;
            docente.apellido = txtApellidoDocente.Text;
            docente.nombre = txtNombreDocente.Text;
            docente.dni = Convert.ToInt32(txtDNIDocente.Text);
            docente.telefono = Convert.ToInt32(txtTelefonoDocente.Text);
            docente.correo = txtCorreoDocente.Text;
            docente.facultad = cmbFacultadDocente.Text;

            usuarioService.RegistrarUsuario(docente);
            llenarDocente();


        }

        void llenarDocente()
        {
            dgvDocente.DataSource = usuarioService.ListarDocente();
        }
    }
}
