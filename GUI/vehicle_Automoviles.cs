﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GUI
{
    public partial class vehicle_Automoviles : Form
    {
        public vehicle_Automoviles()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            vehicles v = new vehicles();
            this.Hide();
            v.ShowDialog();
            this.Close();
        }
    }
}
