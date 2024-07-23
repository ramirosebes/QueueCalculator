using Controladora;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Vista.Modales
{
    public partial class frmMG1MD1 : Form
    {
        bool SigmaBool = false;

        public frmMG1MD1()
        {
            InitializeComponent();
        }

        private void mdMG1MD1_Load(object sender, EventArgs e)
        {

        }

        private void checkBoxSigma_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBoxSigma.Checked == true)
            {
                textBoxSigma.Enabled = true;
                SigmaBool = true;

            }
            else
            {
                textBoxSigma.Enabled = false;
                SigmaBool = false;
            }
        }

        private void buttonCalcular_Click(object sender, EventArgs e)
        {
            CC_MG1MD1 MG1_MG1 = new CC_MG1MD1(double.Parse(textBoxLambda.Text), double.Parse(textBoxMu.Text));
            labelRoValor.Text = MG1_MG1.CalcularRo().ToString();
            labelP0Valor.Text = MG1_MG1.CalcularP0().ToString();
            labelSigmaValor.Text = MG1_MG1.CalcularSigma(double.Parse(textBoxSigma.Text), SigmaBool).ToString();
            labelSigmaCuadradoValor.Text = MG1_MG1.CalcularSigmaCuadrado(double.Parse(textBoxSigma.Text), SigmaBool).ToString();
            labelLsValor.Text = MG1_MG1.CalcularLs(double.Parse(textBoxSigma.Text), SigmaBool).ToString();
            labelLqValor.Text = MG1_MG1.CalcularLq(double.Parse(textBoxSigma.Text), SigmaBool).ToString();
            labelWsValor.Text = MG1_MG1.CalcularWs(double.Parse(textBoxSigma.Text), SigmaBool).ToString();
            labelWqValor.Text = MG1_MG1.CalcularWq(double.Parse(textBoxSigma.Text), SigmaBool).ToString();
        }
    }
}
