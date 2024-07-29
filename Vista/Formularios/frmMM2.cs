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
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Vista.Modales
{
    public partial class frmMM2 : Form
    {
        public frmMM2()
        {
            InitializeComponent();
        }

        private void mdMM2_Load(object sender, EventArgs e)
        {
            comboBoxSeleccion.Items.AddRange(new object[] {
                "Sin seleccion",
                "Con seleccion",
            });

            comboBoxSeleccion.SelectedIndex = 0;
        }

        private void buttonCalcular_Click(object sender, EventArgs e)
        {

            bool Seleccion = false;

            if (comboBoxSeleccion.SelectedItem == "Sin seleccion")
            {

                Seleccion = false;
            }
            else if (comboBoxSeleccion.SelectedItem == "Con seleccion")
            {
                Seleccion = true;
            }

            CC_MM2 MM2 = new Controladora.CC_MM2(double.Parse(textBoxLambda.Text), double.Parse(textBoxMu1.Text), double.Parse(textBoxMu2.Text), int.Parse(textBoxN.Text), Seleccion);
            labelRoValor.Text = MM2.CalcularRo().ToString();
            labelP0Valor.Text = MM2.CalcularP0().ToString();
            labelPnValor.Text = MM2.CalcularPn().ToString();
            labelLsValor.Text = MM2.CalcularLs().ToString();
            labelWsValor.Text = MM2.CalcularWs().ToString();
            labelLqValor.Text = MM2.CalcularLq().ToString();
            labelWqValor.Text = MM2.CalcularWq().ToString();
            labelRValor.Text = MM2.CalcularR().ToString();
            labelPcValor.Text = MM2.CalcularPc().ToString();
            labelAValor.Text = MM2.CalcularA().ToString();

            textBoxLambda.Focus();
            textBoxLambda.SelectAll();
        }

        private void comboBoxSeleccion_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBoxSeleccion.SelectedItem == "Sin seleccion")
            {

                labelA.Text = "a";
                labelPc.Text = "Pc";
            }
            else if (comboBoxSeleccion.SelectedItem == "Con seleccion")
            {
                labelA.Text = "a'";
                labelPc.Text = "Pc²";
            }
        }

        private void textBoxLambda_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyData == Keys.Enter)
            {
                textBoxMu1.Select();
                textBoxMu1.SelectAll();
            }
        }

        private void textBoxMu1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyData == Keys.Enter)
            {
                textBoxMu2.Select();
                textBoxMu2.SelectAll();
            }
        }

        private void textBoxMu2_KeyDown(object sender, KeyEventArgs e)
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
                comboBoxSeleccion.Select();
                //buttonCalcular_Click(sender, e);
            }
        }

        private void comboBoxSeleccion_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyData == Keys.Enter)
            {
                buttonCalcular_Click(sender, e);
            }
        }
    }
}
