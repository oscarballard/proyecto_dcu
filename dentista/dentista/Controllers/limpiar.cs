using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace dentista.Controllers
{
    class limpiar
    {
        public static void borrar(Control control)
        {
            foreach (var txt in control.Controls)
            {
                if (txt is TextBox)
                {
                    ((TextBox)txt).Clear();

                }
                else if (txt is MaskedTextBox)
                {
                    ((MaskedTextBox)txt).Clear();
                }


            }
        }
    }
}
