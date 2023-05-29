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
    public partial class forget_password : Form
    {
        CB_Business cn = new CB_Business();
        public forget_password()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            CE_Entities cE_Entities = new CE_Entities();
            cE_Entities.usuario = user.Text;
            cE_Entities.password = password.Text;
            cE_Entities.passwordtwo = password2.Text;

            if (cE_Entities.password == cE_Entities.passwordtwo)
            {
                cn.MySqlUpdate(cE_Entities);
                MessageBox.Show("Has cambiado la contraseña. ");
                login_up lp = new login_up();
                this.Hide();
                lp.ShowDialog();
                this.Close();
                
            } else
            {
                MessageBox.Show("Las contraseñas no coinciden. ");
            }
        }

        private void forget_password_Load(object sender, EventArgs e)
        {
            password.PasswordChar = '*';
            password2.PasswordChar = '*';
        }

        private void button1_Click(object sender, EventArgs e)
        {
            login_up lp = new login_up();
            this.Hide();
            lp.ShowDialog();
            this.Close();   
        }
    }
}
