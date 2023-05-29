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
    public partial class create_account : Form
    {
        CB_Business cn = new CB_Business();
        public create_account()
        {
            InitializeComponent();
        }

        public void Limpiar()
        {
            user.Text = string.Empty;
            dni.Text = string.Empty;
            password.Text = string.Empty;
        }
        private void button2_Click(object sender, EventArgs e)
        {
            CE_Entities cE_Entities = new CE_Entities();
            cE_Entities.usuario = user.Text;
            cE_Entities.cedula = dni.Text;
            cE_Entities.password = password.Text;
            Limpiar();

            if (cE_Entities.usuario == "" || cE_Entities.cedula == "" || cE_Entities.password == "")
            {
                MessageBox.Show("Estimado gerente/empleado, deben de llenar los campos. ");
            }
            else
            {
                cn.MySqlCreate(cE_Entities);
                login_up lp = new login_up();
                this.Hide();
                lp.ShowDialog();
                this.Close();
            }
        }

        private void create_account_Load(object sender, EventArgs e)
        {
            password.PasswordChar = '*';
        }
    }
}
