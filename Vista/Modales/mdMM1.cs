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
using Controladora;

namespace Vista.Modales
{
    public partial class mdMM1 : Form
    {
        public mdMM1()
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

            CC_MM1 mm1 = new Controladora.CC_MM1(double.Parse(textBoxLambda.Text), double.Parse(textBoxMu.Text), int.Parse(textBoxN.Text));
            labelRoValor.Text = mm1.CalcularRo().ToString();
            labelP0Valor.Text = mm1.CalcularP0().ToString();
            labelPnsValor.Text = mm1.CalcularPns().ToString();
            labelPnqValor.Text = mm1.CalcularPnq().ToString();
            labelPansValor.Text = mm1.CalcularPans().ToString();
            labelPanqValor.Text = mm1.CalcularPanq().ToString();
            labelLsValor.Text = mm1.CalcularLs().ToString();
            labelLqValor.Text = mm1.CalcularLq().ToString();
            labelWsValor.Text = mm1.CalcularWs().ToString();
            labelWqValor.Text = mm1.CalcularWq().ToString();
        }
    }
}
