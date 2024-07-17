using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Vista.Modales;

namespace Vista
{
    public partial class Inicio : Form
    {
        public Inicio()
        {
            InitializeComponent();
        }

        private void Inicio_Load(object sender, EventArgs e)
        {

        }

        private void mM1ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            using (var modal = new mdMM1())
            {
                var resultado = modal.ShowDialog();
            }
        }

        private void mM2ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            using (var modal = new mdMM1N())
            {
                var resultado = modal.ShowDialog();
            }
        }
    }
}
