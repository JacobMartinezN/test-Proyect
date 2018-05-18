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
    public partial class frmMulta : Form
    {
        IMultaService multaService;

        public frmMulta()
        {
            InitializeComponent();
            multaService = new MultaService();
            LlenarMultas();
        }

        private void frmMulta_Load(object sender, EventArgs e)
        {

        }

        private void btnListarMultas_Click(object sender, EventArgs e)
        {
            LlenarMultas();
        }

        void LlenarMultas()
        {
            dgvMulta.DataSource = multaService.ListarMultas();
        }
    }
}
