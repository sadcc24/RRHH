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
    
    public partial class Login : Form
    {
        public string usuario;
        public Login()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string sUser = textBox1.Text;
            string sContra = textBox2.Text;
            int result = new capa_negocio().Login(sUser, sContra);
            if (result > 0)
            {
                //Esconde este formulario y muestra el formulario de menu
                this.Hide();
                MDI ventanaP = new MDI(sUser);
                ventanaP.Show();
            }
<<<<<<< HEAD
=======
        }

        private void Login_Load(object sender, EventArgs e)
        {

>>>>>>> fix_2
        }
    }
}
