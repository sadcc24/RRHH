using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Security.Permissions;
using System.Net.Mail;
using System.Net;
using System.Security.Principal;
using WindowsFormsApplication1;

namespace WindowsFormsApplication1
{
    
    public partial class Login : Form
    {
        private SqlCommand SQL_cmd;
        private SqlConnection SQL_Conexion = new SqlConnection();
        public static String S_usuario;
        public Login()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string sUser = textBox1.Text;
            string sContra = textBox2.Text;
            int result = new N_Rol().Login(sUser, sContra);
            if (result > 0)
            {
                //Esconde este formulario y muestra el formulario de menu
                this.Hide();
                MDI ventanaP = new MDI(sUser);
                ventanaP.Show();
            }
        }
    }
}
