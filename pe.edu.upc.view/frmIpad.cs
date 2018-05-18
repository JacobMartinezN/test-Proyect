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
    public partial class frmIpad : Form
    {
        private IIpadService ipadService;

        private ISedeService sedeService;

        public frmIpad()
        {
            InitializeComponent();
            ipadService = new IpadService();
            sedeService = new SedeService();
            LlenarSede();
            LlenarIpads();
        }

        private void btnRegIpad_Click(object sender, EventArgs e)
        {
            var ipads = new ipad();
            ipads.codigo = txtCodigoIpad.Text;
            ipads.modelo = txtModeloIpad.Text;
            ipads.serial = txtSerialIpad.Text;
            ipads.versionso = txtVersioIpad.Text;
            ipads.descripcion = txtDescription.Text;
            ipads.estado = cbEstadoIpad.Text;
            ipads.sede_id = Convert.ToInt32(cmbSede.SelectedValue);

            ipadService.RegistrarIpad(ipads);
            LlenarIpads();
        }

        private void LlenarIpads()
        {
            gvIpad.DataSource = ipadService.ListarIpad();
        }

        private void LlenarSede()
        {
            var sedes = sedeService.ListarSedes();

            cmbSede.DataSource = sedes;
            cmbSede.DisplayMember = "nombre";
            cmbSede.ValueMember = "id";
        }

        private void btnActualizarIpad_Click(object sender, EventArgs e)
        {
            
            var ipadid = Convert.ToInt32(gvIpad.CurrentRow.Cells["IpadId"].Value);
            var frmIpadEdit = new frmIpadEdit(ipadid);
            frmIpadEdit.ShowDialog();

        }

        private void btnEliminarIpad_Click(object sender, EventArgs e)
        {
            var ipadid = Convert.ToInt32(gvIpad.CurrentRow.Cells["IpadId"].Value);
            ipadService.EliminarIpad(ipadid);
            LlenarIpads();
        }
    }
}
