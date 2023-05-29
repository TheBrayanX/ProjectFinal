using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Entities;
using Businesss;

namespace GUI
{
    public partial class panel_Admin : Form
    {
        CB_Business cn = new CB_Business();
        public panel_Admin()
        {
            InitializeComponent();
            CargarData();
        }
        public void CargarData()
        {
            Datos.DataSource = cn.Vista_Pedidos().Tables["lista"];
        }

        private void button2_Click(object sender, EventArgs e)
        {
            CE_Entities cE = new CE_Entities();
            cE.id = txtid.Text;
            cn.MySqlDelete(cE);
            CargarData();
        }

        private void generarReporteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            generarReporte gr = new generarReporte();
            gr.Show();
        }
    }
}
