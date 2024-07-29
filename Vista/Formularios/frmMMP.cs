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
using Vista.Utilidades;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Vista.Formularios
{
    public partial class frmMMP : Form
    {
        public frmMMP()
        {
            InitializeComponent();
        }

        private void buttonCalcular_Click(object sender, EventArgs e)
        {
            if (!Validaciones.ValidarCamposVacios(panelMM1.Controls))
            {
                MessageBox.Show("Debe completar todos los campos", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            CC_MMP MMP = new Controladora.CC_MMP(double.Parse(textBoxW0.Text), double.Parse(textBoxQ1.Text), double.Parse(textBoxTs1.Text));
            labelWs1Valor.Text = MMP.CalcularW1().ToString();
            labelWq1Valor.Text = MMP.CalcularWq1().ToString();

            textBoxW0.Focus();
            textBoxW0.SelectAll();
        }

        private void textBoxW0_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyData == Keys.Enter)
            {
                textBoxQ1.Select();
                textBoxQ1.SelectAll();
            }
        }

        private void textBoxQ1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyData == Keys.Enter)
            {
                textBoxTs1.Select();
                textBoxTs1.SelectAll();
            }
        }

        private void textBoxTs1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyData == Keys.Enter)
            {
                buttonCalcular_Click(sender, e);
            }
        }
    }
}
