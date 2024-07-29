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
    public partial class frmMM1 : Form
    {
        public frmMM1()
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
            labelPnsDescripcion.Text = "Probabilidad de hallar exactamente " + textBoxN.Text + " clientes en el sistema";
            labelPnqValor.Text = mm1.CalcularPnq().ToString();
            labelPnqDescripcion.Text = "Probabilidad de hallar exactamente " + textBoxN.Text + " clientes en la cola";
            labelPansValor.Text = mm1.CalcularPans().ToString();
            labelPansDescripcion.Text = "Probabilidad de hallar al menos " + textBoxN.Text + " clientes en el sistema";
            labelPanqValor.Text = mm1.CalcularPanq().ToString();
            labelPanqDescripcion.Text = "Probabilidad de hallar al menos " + textBoxN.Text + " clientes en la cola";
            labelLsValor.Text = mm1.CalcularLs().ToString();
            labelLqValor.Text = mm1.CalcularLq().ToString();
            labelWsValor.Text = mm1.CalcularWs().ToString();
            labelWqValor.Text = mm1.CalcularWq().ToString();

            textBoxLambda.Focus();
            textBoxLambda.SelectAll();
        }

        private void textBoxLambda_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyData == Keys.Enter)
            {
                textBoxMu.Select();
                textBoxMu.SelectAll();
            }
        }

        private void textBoxMu_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyData == Keys.Enter)
            {
                textBoxN.Select();
                textBoxN.SelectAll();
            }
        }

        private void textBoxN_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyData == Keys.Enter)
            {
                buttonCalcular_Click(sender, e);
            }
        }
    }
}
