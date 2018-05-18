using pe.edu.upc.model;
using pe.edu.upc.service;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace pe.edu.upc.view
{
    public partial class frmAlumno : Form
    {

        private IUsuarioService usuarioService;

        private ISedeService sedeService;

        

        public frmAlumno()
        {
            InitializeComponent();
            usuarioService = new UsuarioService();
            sedeService = new SedeService();
            CargarSedes();
        }

        private void frmUsuario_Load(object sender, EventArgs e)
        {
            LlenarDatagridViewUsuario();
        }

        private Boolean ValidarDatos()
        {
            var error = "";
            if (String.IsNullOrEmpty(txtNombreUs.Text))
            {

                error += "Debe ingresar un nombre" + Environment.NewLine;
                return false;

            }

            if (String.IsNullOrEmpty(txtApellidoUs.Text))
            {

                error += "Debe ingresar un apellido" + Environment.NewLine;
                return false;
            }

            if (String.IsNullOrEmpty(txtFacultadUS.Text))
            {

                error += "Debe ingresar la facultad" + Environment.NewLine;
                return false;
            }

            if (String.IsNullOrEmpty(txtCorreoUs.Text))
            {

                error += "Debe ingresar un correo" + Environment.NewLine;
                return false;
            }

            if (String.IsNullOrEmpty(txtCodigoUs.Text))
            {

                error += "Debe ingresar un codigo" + Environment.NewLine;
                return false;
            }

            if (String.IsNullOrEmpty(txtDNIUs.Text))
            {

                error += "Debe ingresar un DNI" + Environment.NewLine;
                return false;
            }

            if (String.IsNullOrEmpty(cbSedeUs.Text))
            { 

                error += "Debe ingresar la sede" + Environment.NewLine;
                return false;
            }

            if (String.IsNullOrEmpty(txtTelefonoUs.Text))
            {

                error += "Debe ingresar el telefono" + Environment.NewLine;
                return false;
            }

            if (!String.IsNullOrEmpty(error))
                MessageBox.Show("Ha ocurrido un error,revisar:" + Environment.NewLine + error);


            return String.IsNullOrEmpty(error);

        }

        public void LlenarDatagridViewUsuario()
        {
            gvUsuario.DataSource = usuarioService.ListarAlumno();
        }

        private void btnRegUsu_Click(object sender, EventArgs e)
        {
            if (!ValidarDatos())
                return;

            String resultado;
            var user = new usuario();
            user.nombre = txtNombreUs.Text;
            user.apellido = txtApellidoUs.Text;
            user.facultad = txtFacultadUS.Text;
            user.correo = txtCorreoUs.Text;
            user.codigo = txtCodigoUs.Text;
            user.dni = Convert.ToInt32(txtDNIUs.Text);
            user.sede = cbSedeUs.SelectedValue.ToString();
            user.telefono = Convert.ToInt32(txtTelefonoUs.Text);
            usuarioService.RegistrarUsuario(user);
            resultado = "Se registro correctamente";
            MessageBox.Show(resultado);
            LlenarDatagridViewUsuario();
        }

        private void CargarSedes()
        {
            var sedes = sedeService.ListarSedes();

            cbSedeUs.DataSource = sedes;
            cbSedeUs.DisplayMember = "nombre";
            cbSedeUs.ValueMember = "nombre";
        }
    }
}
