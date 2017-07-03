using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplication1
{
    class capa_negocio_Reclutamiento
    {
        //COLOCAR DESHABILITADOS TODOS LOS CAMPOS
        public void camposenabledfalse(Control control, GroupBox gb)
        {
            foreach (var combo in gb.Controls)
            {
                if (combo is TextBox)
                {
                    ((TextBox)combo).Enabled = false;
                }
                else if (combo is ComboBox)
                {
                    ((ComboBox)combo).Enabled = false;
                }
            }
        }

        //COLOCAR HABILITADOS TODOS LOS CAMPOS
        public void camposenabledtrue(Control control, GroupBox gb)
        {
            foreach (var combo in gb.Controls)
            {
                if (combo is TextBox)
                {
                    ((TextBox)combo).Enabled = true;
                }
                else if (combo is ComboBox)
                {
                    ((ComboBox)combo).Enabled = true;
                }
            }
        }

        //LIMPIAR TODOS LOS CAMPOS
        public void camposclear(Control control, GroupBox gb)
        {
            foreach (var combo in gb.Controls)
            {
                if (combo is TextBox)
                {
                    ((TextBox)combo).Clear();
                }
                else if (combo is ComboBox)
                {
                    ((ComboBox)combo).SelectedIndex = 0;
                }
            }
        }
    }
}
