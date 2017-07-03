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
using System.Diagnostics;

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
            //LLENAR COMBOBOX y DEHABILITAR CAMPOS
            capa_logica_Reclutamiento a = new capa_logica_Reclutamiento();
            capa_negocio_Reclutamiento b = new capa_negocio_Reclutamiento();
            a.llenaritem(comboBox1);
            a.llenaritem2(comboBox2);
            a.llenaritem4(comboBox3);
            a.llenaritem3(comboBox7);
            b.camposenabledfalse(this, groupBox2);
            dateTimePicker1.Enabled = false;
            button9.Enabled = false;
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
            if (ob.insertarimagen(this.txtestadocandidato.Text, this.txtestadocivilcandidato.Text, this.txtsexocandidato.Text, this.txtnacioncandidato.Text, this.textBox1.Text, this.textBox2.Text, this.textBox4.Text, this.textBox3.Text, this.textBox8.Text, this.textBox6.Text, this.textBox7.Text, this.textBox5.Text, this.dateTimePicker1.Text, this.pictureBox1))
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

        private void button1_Click(object sender, EventArgs e)
        {
            capa_negocio_Reclutamiento camposenabled = new capa_negocio_Reclutamiento();
            camposenabled.camposenabledtrue(this, groupBox2);
            dateTimePicker1.Enabled = true;
            dateTimePicker1.Text = "";
            button9.Enabled = true;
            button2.Enabled = false;
            button3.Enabled = false;
            button6.Enabled = false;
            camposenabled.camposclear(this, groupBox2);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            capa_negocio_Reclutamiento campos = new capa_negocio_Reclutamiento();
            campos.camposenabledtrue(this, groupBox2);
            dateTimePicker1.Enabled = true;
            button9.Enabled = true;
            button4.Enabled = false;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show(" Se eliminara la información ¿Está seguro?", "Eliminar", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                ob.borrarimagen(this.txtcodigocandidato.Text);
                this.Close();
            }
            else
            {

            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            if (ob.actualizarimagen(this.txtcodigocandidato.Text, this.txtestadocandidato.Text, this.txtestadocivilcandidato.Text, this.txtsexocandidato.Text, this.txtnacioncandidato.Text, this.textBox1.Text, this.textBox2.Text, this.textBox4.Text, this.textBox3.Text, this.textBox8.Text, this.textBox6.Text, this.textBox7.Text, this.textBox5.Text, this.dateTimePicker1.Text, this.pictureBox1))
            {
                MessageBox.Show("Los Datos se Actualizaron Correctamente");
                this.Close();
            }
            else
            {
                MessageBox.Show("Ocurrio un error al Actualizar Datos");
            }
        }

        private void comboBox1_SelectedIndexChanged_2(object sender, EventArgs e)
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

        private void txtsexocandidato_TextChanged(object sender, EventArgs e)
        {
            ob.llenarCB(this.txtsexocandidato, this.comboBox1, "select descripcion from SEXO where idsexo ='");
        }

        private void comboBox2_SelectedIndexChanged_1(object sender, EventArgs e)
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

        private void txtestadocivilcandidato_TextChanged(object sender, EventArgs e)
        {
            ob.llenarCB2(this.txtestadocivilcandidato, this.comboBox2, "select descipcion from ESTADOCIVIL where idestadocivil ='");
        }

        private void comboBox3_SelectedIndexChanged_1(object sender, EventArgs e)
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

        private void txtnacioncandidato_TextChanged(object sender, EventArgs e)
        {
            ob.llenarCB(this.txtnacioncandidato, this.comboBox3, "select descripcion from NACIONALIDAD where idnacionalidad ='");
        }

        private void comboBox7_SelectedIndexChanged_1(object sender, EventArgs e)
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

        private void txtestadocandidato_TextChanged(object sender, EventArgs e)
        {
            ob.llenarCB2(this.txtestadocandidato, this.comboBox7, "select descipcion from ESTADOCANDIDATO where idestadocandidato ='");
        }

        private void button7_Click(object sender, EventArgs e)
        {
            Process pr = new Process();
            pr.StartInfo.WorkingDirectory = @"C:\Users\VICTOR RODAS\Documents\GitHub\RRHH\WindowsFormsApplication1\ayuda\";
            pr.StartInfo.FileName = "Ayuda Candidato Nuevo.pdf";
            pr.Start();
            
        }
    }
}
