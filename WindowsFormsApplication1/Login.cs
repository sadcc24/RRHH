using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Data;

namespace WindowsFormsApplication1
{
    
    public partial class Login : Form
    {
        public static SqlConnection SQL_Conexion = new SqlConnection();
        //public string usuario;
        public int idempleado;
        public int idempresa;
        public string usuario;
        public string rol;
        public string empresa;
        public string nombre_moneda;
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
                idempleado = (int)data.Rows[0][0];
                usuario = (string)data.Rows[0][1];
                rol = (string)data.Rows[0][2];
                nombre_moneda = (string)data.Rows[0][3];
                //Esconde este formulario y muestra el formulario de menu
                fncCargacmb1();
                comboBox1.Visible = true;
                button2.Visible = true;
                //this.Hide();
                //MDI ventanaP = new MDI(usuario,empresa);
                //ventanaP.Show();
            }
        }

        private void fncCargacmb1()
        {
            try
            {

                SqlDataAdapter SQL_da = new SqlDataAdapter("select distinct B.idempresa,B.nombre_empresa from EMPLEADO A inner join Empresa B on a.idempresa = b.idempresa inner join USUARIO_1 C on a.codusuario = c.codusuario where c.usuario ='" + usuario + "';", conexionbd.ObtenerConexion());
                DataTable DT_dat = new DataTable();
                SQL_da.Fill(DT_dat);
                foreach (DataRow row in DT_dat.Rows)
                {
                    string rowz = row.ItemArray.ToString();
                }
                comboBox1.DataSource = DT_dat;
               comboBox1.DisplayMember = "nombre_empresa";
               comboBox1.ValueMember = "idempresa";
                SQL_Conexion.Close();
            }

            catch
            {
                MessageBox.Show("Problema en BD");
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

        private void button2_Click(object sender, EventArgs e)
        {
            empresa = comboBox1.Text;
            idempresa = Convert.ToInt32(comboBox1.SelectedValue);
            this.Hide();
            MDI ventanaP = new MDI(idempleado, empresa, idempresa, usuario,rol,nombre_moneda);
            ventanaP.Show();
        }
    }
}
