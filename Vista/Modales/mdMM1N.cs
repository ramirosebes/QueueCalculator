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
using System.Reflection.Emit;
using Modelo;

namespace Vista.Modales
{
    public partial class mdMM1N : Form
    {
        public mdMM1N()
        {
            InitializeComponent();
        }

        private void buttonCalcular_Click(object sender, EventArgs e)
        {
            if (!Validaciones.ValidarCamposVacios(panelMM1N.Controls))
            {
                MessageBox.Show("Debe completar todos los campos", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            CC_MM1N mm1n = new Controladora.CC_MM1N(double.Parse(textBoxLambda.Text), double.Parse(textBoxMu.Text), double.Parse(textBoxM.Text), double.Parse(textBoxN.Text));
            labelLambdaEfectivaValor.Text = mm1n.CalcularLambdaEfectiva().ToString();
            labelRoValor.Text = mm1n.CalcularRo().ToString();
            labelRoEfectivoValor.Text = mm1n.CalcularRoEfectivo().ToString();
            labelTauValor.Text = mm1n.CalcularTau().ToString();
            labelTauEfectivoValor.Text = mm1n.CalcularTauEfectivo().ToString();
            labelTauEntradaValor.Text = mm1n.CalcularTauEntrada().ToString();
            labelTauSalidaValor.Text = mm1n.CalcularTauSalida().ToString();
            labelP0Valor.Text = mm1n.CalcularP0().ToString();
            labelLsValor.Text = mm1n.CalcularLs().ToString();
            labelLqValor.Text = mm1n.CalcularLq().ToString();
            labelPbValor.Text = mm1n.CalcularPb().ToString();
            labelWqValor.Text = mm1n.CalcularWq().ToString();
            labelWqEfectivoValor.Text = mm1n.CalcularWqEfectivo().ToString();
            labelWsValor.Text = mm1n.CalcularWs().ToString();
            labelWsEfectivoValor.Text = mm1n.CalcularWsEfectivo().ToString();
            labelWbValor.Text = mm1n.CalcularWb().ToString();
            labelLbValor.Text = mm1n.CalcularLb().ToString();
            labelPnsValor.Text = mm1n.CalcularPns().ToString();
            labelPnsDescripcion.Text = "Probabilidad de hallar exactamente " + textBoxN.Text + " clientes en el sistema";
            labelPnqValor.Text = mm1n.CalcularPnq().ToString();
            labelPnqDescripcion.Text = "Probabilidad de hallar exactamente " + textBoxN.Text + " clientes en la cola";
            labelPansValor.Text = mm1n.CalcularPans().ToString();
            labelPansDescripcion.Text = "Probabilidad de hallar al menos " + textBoxN.Text + " clientes en el sistema";
            labelPanqValor.Text = mm1n.CalcularPanq().ToString();
            labelPanqDescripcion.Text = "Probabilidad de hallar al menos " + textBoxN.Text + " clientes en la cola";
            labelLsValor.Text = mm1n.CalcularLs().ToString();
        }
    }
}
