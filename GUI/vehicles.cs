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
    public partial class vehicles : Form
    {
        CB_Business cn = new CB_Business(); 
        public vehicles()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            menu m = new menu();
            this.Hide();
            m.ShowDialog();
            this.Close();
        }

        private void camionetasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            vehicle_Camionetas vc = new vehicle_Camionetas();
            this.Hide();
            vc.ShowDialog();
            this.Close(); 
        }

        private void automovilesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            vehicle_Automoviles va = new vehicle_Automoviles();
            this.Hide();
            va.ShowDialog();
            this.Close();
        }

        private void perfomanceToolStripMenuItem_Click(object sender, EventArgs e)
        {
            vehicle_Perfomance vp = new vehicle_Perfomance();
            this.Hide();
            vp.ShowDialog();
            this.Close();
        }

        private void híbridosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            vehicle_Hibridos vh = new vehicle_Hibridos();
            this.Hide();
            vh.ShowDialog();
            this.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            CE_Entities cE = new CE_Entities();
            cE.cbVehiclecoti = cbvehicle.Text;
            cE.namecoti = txtname.Text;
            cE.telefonocoti = txtphone.Text;
            cE.emailcoti = txtemail.Text;
            Limpiar();
            cn.MySqCreateTwo(cE);
        }
        public void Limpiar()
        {
            cbvehicle.Text = string.Empty;
            txtname.Text = string.Empty;
            txtphone.Text = string.Empty;
            txtemail.Text = string.Empty;
        }
    }
}
