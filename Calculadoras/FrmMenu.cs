﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace Calculadoras
{
    public partial class FrmMenu : Form
    {
        public FrmMenu()
        {
            InitializeComponent();
        }



        private void FrmMenu_Load(object sender, EventArgs e)
        {

        }


        private void btnMenuIMC_Click(object sender, EventArgs e)
        {

            var form = new FrmIMC2();
            form.Show();
        }

        private void btnCalculadoraSimples_Click(object sender, EventArgs e)
        {

            var form = new FrmCalculadora();
            form.Show();
        }
    }
}
