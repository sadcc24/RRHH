using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data;
using System.Data.SqlClient;

namespace WindowsFormsApplication1
{
    public partial class frmcandidatonuevo : Form
    {
        public frmcandidatonuevo()
        {
            InitializeComponent();
        }
        capa_logica_Reclutamiento ob = new capa_logica_Reclutamiento();

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
        
        private void Candidatonuevo_Load(object sender, EventArgs e)
        {
            //LLENAR COMBOBOX
            capa_logica_Reclutamiento a = new capa_logica_Reclutamiento();
            a.llenaritem(comboBox1);
            a.llenaritem2(comboBox2);
            a.llenaritem4(comboBox3);
            a.llenaritem3(comboBox7);

        }

        private void comboBox1_SelectedIndexChanged_1(object sender, EventArgs e)
        {
            string cadcon = "select idsexo from SEXO where descripcion ='" + comboBox1.Text + "'";
            SqlCommand cm = new SqlCommand(cadcon, conexionbd_Reclutamiento.ObtenerConexion());
            SqlDataReader leer = cm.ExecuteReader();
            if (leer.Read() == true)
            {
                txtsexocandidato.Text = leer["idsexo"].ToString();
            }
            else
            {
                txtsexocandidato.Text = "";
            }
        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            string cadcon = "select idestadocivil from ESTADOCIVIL where descipcion ='" + comboBox2.Text + "'";
            SqlCommand cm = new SqlCommand(cadcon, conexionbd_Reclutamiento.ObtenerConexion());
            SqlDataReader leer = cm.ExecuteReader();
            if (leer.Read() == true)
            {
                txtestadocivilcandidato.Text = leer["idestadocivil"].ToString();
            }
            else
            {
                txtestadocivilcandidato.Text = "";
            }
        }

        private void comboBox3_SelectedIndexChanged(object sender, EventArgs e)
        {
            string cadcon = "select idnacionalidad from NACIONALIDAD where descripcion ='" + comboBox3.Text + "'";
            SqlCommand cm = new SqlCommand(cadcon, conexionbd_Reclutamiento.ObtenerConexion());
            SqlDataReader leer = cm.ExecuteReader();
            if (leer.Read() == true)
            {
                txtnacioncandidato.Text = leer["idnacionalidad"].ToString();
            }
            else
            {
                txtnacioncandidato.Text = "";
            }
        }

        private void comboBox7_SelectedIndexChanged(object sender, EventArgs e)
        {
            string cadcon = "select idestadocandidato from ESTADOCANDIDATO where descipcion ='" + comboBox7.Text + "'";
            SqlCommand cm = new SqlCommand(cadcon, conexionbd_Reclutamiento.ObtenerConexion());
            SqlDataReader leer = cm.ExecuteReader();
            if (leer.Read() == true)
            {
                txtestadocandidato.Text = leer["idestadocandidato"].ToString();
            }
            else
            {
                txtestadocandidato.Text = "";
            }
        }

        private void label13_Click(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (ob.insertarimagen(this.txtcodigocandidato.Text, this.txtestadocandidato.Text, this.txtestadocivilcandidato.Text, this.txtsexocandidato.Text, this.txtnacioncandidato.Text, this.textBox1.Text, this.textBox2.Text, this.textBox4.Text, this.textBox3.Text, this.textBox8.Text, this.textBox6.Text, this.textBox7.Text, this.textBox5.Text, this.dateTimePicker1.Text, this.pictureBox1))
            {
                MessageBox.Show("Datos Ingresados con Exito");
            }
            else
            {
                MessageBox.Show("Datos no Ingresados");
            }
        }

        private void button9_Click(object sender, EventArgs e)
        {
            this.openFileDialog1.ShowDialog();
        }

        private void openFileDialog1_FileOk(object sender, CancelEventArgs e)
        {
            this.pictureBox1.Image = Image.FromFile(this.openFileDialog1.FileName);
        }
    }
}
