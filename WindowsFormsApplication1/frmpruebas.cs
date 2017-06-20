using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplication1
{
    public partial class frmpruebas : Form
    {
        public frmpruebas()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Resultado_Pueba ventanaP = new Resultado_Pueba();
            ventanaP.Show();
        }
    }
}
