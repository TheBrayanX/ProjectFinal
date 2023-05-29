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
    public partial class login_up : Form
    {
        CB_Business cn = new CB_Business();
        public login_up()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            create_account ca = new create_account();
            this.Hide();
            ca.ShowDialog();
            this.Close();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            forget_password fp = new forget_password(); 
            this.Hide();
            fp.ShowDialog();
            this.Close();
        }

        private void login_up_Load(object sender, EventArgs e)
        {
            password.PasswordChar = '*';
        }

        private void button2_Click(object sender, EventArgs e)
        {
            CE_Entities cE_Entities = new CE_Entities();
            cE_Entities.usuario = user.Text;
            cE_Entities.password = password.Text;

            if (cn.MySqlRead(cE_Entities) == 1)
            {
                panel_Admin pa = new panel_Admin();
                this.Hide();
                pa.ShowDialog();
                this.Close();
            } else
            {
                MessageBox.Show("Usuario no existente en la base de datos. ");
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            menu m = new menu();
            this.Hide();
            m.ShowDialog();
            this.Close();
        }
    }
}
