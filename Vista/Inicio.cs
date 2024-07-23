using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Vista.Formularios;
using Vista.Modales;

namespace Vista
{
    public partial class Inicio : Form
    {
        private static ToolStripMenuItem _menuActivo = null;
        private static Form _formularioActivo = null;

        public Inicio()
        {
            InitializeComponent();
        }

        private void Inicio_Load(object sender, EventArgs e)
        {

        }

        private void abrirFormulario(ToolStripMenuItem menu, Form formulario, int nuevoAncho, int nuevoAlto)
        {
            if (_menuActivo != null)
            {
                //_menuActivo.BackColor = Color.Silver;
            }
            //menu.BackColor = Color.Silver;
            _menuActivo = menu;

            if (_formularioActivo != null)
            {
                _formularioActivo.Close();
            }

            _formularioActivo = formulario;
            formulario.TopLevel = false;
            formulario.FormBorderStyle = FormBorderStyle.None;
            formulario.Dock = DockStyle.Fill;
            panelContenedor.Controls.Add(formulario);
            formulario.Show();

            this.ClientSize = new Size(nuevoAncho, nuevoAlto);
        }

        private void mM1ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            abrirFormulario(menuMM1, new frmMM1(), 865, 545);

            //using (var modal = new mdMM1())
            //{
            //    var resultado = modal.ShowDialog();
            //}
        }

        private void mM2ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            abrirFormulario(menuMM1N, new frmMM1N(), 1380, 625);

            //using (var modal = new mdMM1N())
            //{
            //    var resultado = modal.ShowDialog();
            //}
        }

        private void mM2ToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            abrirFormulario(menuMM2, new frmMM2(), 865, 545);
            //using (var modal = new mdMM2())
            //{
            //    var resultado = modal.ShowDialog();
            //}
        }

        private void mG1MD1ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            abrirFormulario(menuMG1_MD1, new frmMG1MD1(), 865, 465);

            //using (var modal = new mdMG1MD1())
            //{
            //    var resultado = modal.ShowDialog();
            //}
        }

        private void menuMMP_Click(object sender, EventArgs e)
        {
            abrirFormulario(menuMMP, new frmMMP(), 610, 340);
        }
    }
}
