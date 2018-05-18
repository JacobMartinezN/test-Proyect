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
    public partial class frmIpadEdit : Form
    {
        private IIpadService ipadService;

        public int IpadId { get; set; }

        public frmIpadEdit(int ipadId)
        {
            InitializeComponent();
            ipadService = new IpadService();
            IpadId = ipadId;
            CargarDatosDeIpad();
            
        }

        private void btnGuardarIpad_Click(object sender, EventArgs e)
        {
            if( IpadId >0)
            {
                var ipads = ipadService.ObtenerporId(IpadId);

                ipads.versionso = txtVersioIpad.Text;
                ipads.descripcion = txtDescription.Text;
                ipads.estado = cbEstadoIpad.Text;
                ipads.id = IpadId;
                ipadService.ActualizarIapd(ipads);
                this.Close();

            }
        }

        public void CargarDatosDeIpad()
        {
            if (IpadId > 0)
            {
                var ipad = ipadService.ObtenerporId(IpadId);

                
                txtDescription.Text = ipad.descripcion;
                txtVersioIpad.Text = ipad.versionso;
            }
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }
    }
}
