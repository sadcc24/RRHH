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
            int result = new capa_negocio_Empleado().Login(sUser, sContra);
            if (result > 0)
            {
                DataTable data = new capa_negocio_Empleado().GetAll(sUser);
                string usuario = (string)data.Rows[0][0];
                string empresa = (string)data.Rows[0][1];
                //Esconde este formulario y muestra el formulario de menu
                this.Hide();
                MDI ventanaP = new MDI(usuario,empresa);
                ventanaP.Show();
            }
        }


        private void Login_Load(object sender, EventArgs e)
        {

            
            //string message = "12345678";
            //classEncryptD keys = new classEncryptD();
            //string encr = keys.EncryptString(message);
            //MessageBox.Show(encr);

            //// later
            //string desencr = keys.DecryptString(encr);
            //MessageBox.Show(desencr);
        }
    }
}
