using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Vista.Utilidades
{
    public static class Validaciones
    {
        public static bool ValidarCamposVacios(Control.ControlCollection controls)
        {
            var textBoxes = controls.OfType<TextBox>().Where(c => c.Visible).OrderBy(c => c.TabIndex);

            foreach (TextBox textBox in textBoxes)
            {
                if (textBox.Text.Trim() == string.Empty)
                {
                    textBox.Focus();
                    return false;
                }
            }
            return true;
        }
    }
}
