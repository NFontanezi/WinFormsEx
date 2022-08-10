using System;
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
    public partial class FrmCalculadora : Form
    {
        public FrmCalculadora()
        {
            InitializeComponent();
        }


        decimal valor1 = 0;
        decimal valor2 = 0;
        decimal resultado = 0;
        string operacao = "";

        private void FrmCalculadora_Load(object sender, EventArgs e)
        {
            lblOperacao.Text = String.Empty;

        }
        private void lblTitulo_Click(object sender, EventArgs e)
        {
            
        }

        private void btnLimpa_Click(object sender, EventArgs e)
        {
            txbTela.Text = String.Empty;
            lblOperacao.Text = String.Empty;
        }

        private void btn1_Click(object sender, EventArgs e)
        {
          
            txbTela.Text += "1";
            
        }

        private void btn2_Click(object sender, EventArgs e)
        {
            txbTela.Text += "2";
        }

        private void btn3_Click(object sender, EventArgs e)
        {
            txbTela.Text += "3";
        }

        private void btn4_Click(object sender, EventArgs e)
        {
            txbTela.Text += "4";
        }

        private void btn5_Click(object sender, EventArgs e)
        {
            txbTela.Text += "5";
        }

        private void btn6_Click(object sender, EventArgs e)
        {
            txbTela.Text += "6";
        }

        private void btn7_Click(object sender, EventArgs e)
        {
            txbTela.Text += "7";
        }

        private void btn8_Click(object sender, EventArgs e)
        {
            txbTela.Text += "8"; 

        }

        private void btn9_Click(object sender, EventArgs e)
        {
            txbTela.Text += "9";

        }

        private void btn0_Click(object sender, EventArgs e)
        {
            txbTela.Text += "0";
        }

        private void btnVirgula_Click(object sender, EventArgs e)
        {
            txbTela.Text += ",";
        }

        private void btnSoma_Click(object sender, EventArgs e)
        {
            valor1 = Convert.ToDecimal(txbTela.Text);
            //txbTela.Text = "";
            txbTela.Text = "+";
            lblOperacao.Text = String.Empty;
            lblOperacao.Text = operacao;
            operacao = "+";
            txbTela.Text = "";
        }

        private void btnMenos_Click(object sender, EventArgs e)
        {
            valor1 = Convert.ToDecimal(txbTela.Text);
            //txbTela.Text = "";
            txbTela.Text = "-";
            operacao = "-";
            lblOperacao.Text = String.Empty;
            lblOperacao.Text = operacao;
            txbTela.Text = "";
        }

        private void btnMult_Click(object sender, EventArgs e)
        {
            valor1 = Convert.ToDecimal(txbTela.Text);
            txbTela.Text = "*";
            operacao = "*";
            lblOperacao.Text = String.Empty;
            lblOperacao.Text = operacao;
            txbTela.Text = "";
        }

        private void btnDiv_Click(object sender, EventArgs e)
        {
            valor1 = Convert.ToDecimal(txbTela.Text);
            //txbTela.Text = "";
            txbTela.Text = "/";
            operacao = "/";
            lblOperacao.Text = String.Empty;
            lblOperacao.Text = operacao;
            txbTela.Text = "";
        }


        private void btnCalcular_Click(object sender, EventArgs e)
        {
            valor2 = Convert.ToDecimal(txbTela.Text);
            txbTela.Text = String.Empty;

            if (operacao == "+")
            {
                resultado = valor1 + valor2;
                txbTela.Text = Convert.ToString(resultado);
            }

            if (operacao == "-")
            {
                resultado = valor1 - valor2;
                txbTela.Text = Convert.ToString(resultado);
            }
            if (operacao == "*")
            {
                resultado = valor1 * valor2;
                txbTela.Text = Convert.ToString(resultado);
            }
            if (operacao == "/")
            {
                resultado = valor1 / valor2;
                txbTela.Text = Convert.ToString(resultado);
            }
        }

        private void pnlModulra_Paint(object sender, PaintEventArgs e)
        {

        }


    }
}
