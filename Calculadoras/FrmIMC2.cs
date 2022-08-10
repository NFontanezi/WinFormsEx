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
    public partial class FrmIMC2 : Form
    {
        public FrmIMC2()
        {
            InitializeComponent();
        }

        private void FrmIMC2_Load(object sender, EventArgs e)
        {

        }

        private void btnLimpar_Click(object sender, EventArgs e)
        {
            tbxPeso.Text = String.Empty;
            tbxAltura.Text = String.Empty;
            lblResultado3.Text = String.Empty;
        }



        private void btnCalcular_Click_1(object sender, EventArgs e)

        {
            double altura, peso;
            peso = Convert.ToDouble(tbxPeso.Text);
            altura = Convert.ToDouble(tbxAltura.Text);

            var (resultIMC, descricaoIMC) = CalcularIMC(peso, altura / 100);

            lblResultado3.Text = ($"IMC = {resultIMC}\n {descricaoIMC}");

        }
        private (double, string) CalcularIMC(double peso, double altura)
        {
            double IMCresult = Math.Round(peso / (altura * altura));

            var textIMCResult = IMCresult switch
            {
                < 20 => "Abaixo do peso",
                >= 20 and < 25 => "Peso Normal",
                >= 25 and < 30 => "Acima do peso",
                >= 30 and < 40 => "Obeso",
                _ => "Obeso Morbido" //_ = default
            };

            return (IMCresult, textIMCResult);
        }

    }
}

