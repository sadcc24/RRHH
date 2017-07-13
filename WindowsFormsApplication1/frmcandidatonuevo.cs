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
        capa_logica_Reclutamiento clr = new capa_logica_Reclutamiento();
        capa_negocio_Reclutamiento cnr = new capa_negocio_Reclutamiento();
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
            clr.llenaritem(comboBox1);
            clr.llenaritem2(comboBox2);
            clr.llenaritem4(comboBox3);
            clr.llenaritem5(comboBox4);
            cnr.camposenabledfalse(this, groupBox2);
            dateTimePicker1.Enabled = false;
            button9.Enabled = false;
        }

        private void label13_Click(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged_1(object sender, EventArgs e)
        {
            string cadcon = "select idsexo from SEXO where descripcion ='" + comboBox1.Text + "'";
            SqlCommand cm = new SqlCommand(cadcon, conexionbd.ObtenerConexion());

            SqlDataReader leer = cm.ExecuteReader();
            if (leer.Read() == true)
            {
                txtsexocandidato.Text = leer["idsexo"].ToString();
            }
            else
            {
                txtsexocandidato.Text = "";
            }
            if (comboBox1.SelectedIndex == 0)
            {
                textBox8.Enabled = false;
            }
            else
            {
                textBox8.Enabled = true;
            }
        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            string cadcon = "select idestadocivil from ESTADOCIVIL where descipcion ='" + comboBox2.Text + "'";
            SqlCommand cm = new SqlCommand(cadcon, conexionbd.ObtenerConexion());
            SqlDataReader leer = cm.ExecuteReader();
            if (leer.Read() == true)
            {
                txtestadocivilcandidato.Text = leer["idestadocivil"].ToString();
            }
            else
            {
                txtestadocivilcandidato.Text = "";
            }
            if (comboBox1.SelectedIndex == 0)
            {
                textBox8.Enabled = false;
            }
            else
            {
                textBox8.Enabled = true;
            }

        }

        private void comboBox3_SelectedIndexChanged(object sender, EventArgs e)
        {
            string cadcon = "select idnacionalidad from NACIONALIDAD where descripcion ='" + comboBox3.Text + "'";
            SqlCommand cm = new SqlCommand(cadcon, conexionbd.ObtenerConexion());
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
        }


        private void textBox12_TextChanged(object sender, EventArgs e)
        {

        }

        private void button8_Click(object sender, EventArgs e)
        {
            this.openFileDialog1.ShowDialog();

        }

        private void openFileDialog1_FileOk(object sender, CancelEventArgs e)
        {
            this.pictureBox1.Image = Image.FromFile(this.openFileDialog1.FileName);

        }
        private void button4_Click(object sender, EventArgs e)
        {
            cnr.insertarcandidato(this.txtestadocandidato.Text, this.txtestadocivilcandidato.Text, this.txtsexocandidato.Text, this.txtnacioncandidato.Text, this.textBox1.Text, this.textBox2.Text, this.textBox4.Text, this.textBox3.Text, this.textBox8.Text, this.textBox6.Text, this.textBox7.Text, this.textBox5.Text, this.dateTimePicker1.Text, this.pictureBox1,this.txtidpuesto.Text, txtsexocandidato, txtnacioncandidato, txtestadocandidato, txtestadocivilcandidato, textBox1, textBox2, textBox3, textBox4, textBox5, textBox6, textBox7,pictureBox1,txtidpuesto);
        }

        private void button9_Click(object sender, EventArgs e)
        {
            this.openFileDialog1.ShowDialog();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            cnr.camposenabledtrue(this, groupBox2);
            dateTimePicker1.Enabled = true;
            button3.Enabled = true;
            button6.Enabled = true;
            button9.Enabled = true;
            button8.Enabled = true;
            button10.Enabled = true;


        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show(" Se eliminara la información ¿Está seguro?", "Eliminar", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                clr.borrarimagen(this.txtcodigocandidato.Text);
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
            cnr.actualizarcandidato(this.txtcodigocandidato.Text, this.txtestadocandidato.Text, this.txtestadocivilcandidato.Text, this.txtsexocandidato.Text, this.txtnacioncandidato.Text, this.textBox1.Text, this.textBox2.Text, this.textBox4.Text, this.textBox3.Text, this.textBox8.Text, this.textBox6.Text, this.textBox7.Text, this.textBox5.Text, this.dateTimePicker1.Text, this.pictureBox1, this.txtidpuesto.Text, txtsexocandidato, txtnacioncandidato, txtestadocandidato, txtestadocivilcandidato, textBox1, textBox2, textBox3, textBox4, textBox5, textBox6, textBox7, pictureBox1, txtidpuesto);
        }

        private void button7_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start(Environment.CurrentDirectory + @"\Candidato.pdf");
        }

        private void groupBox8_Enter(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            capa_negocio_Reclutamiento camposenabled = new capa_negocio_Reclutamiento();
            camposenabled.camposenabledtrue(this, groupBox2);
            dateTimePicker1.Enabled = true;
            dateTimePicker1.Text = "";
            button9.Enabled = true;
            button4.Enabled = true;
            camposenabled.camposclear(this, groupBox2);
        }

        private void txtsexocandidato_TextChanged(object sender, EventArgs e)
        {
            clr.llenarCB(this.txtsexocandidato, this.comboBox1, "select descripcion from SEXO where idsexo ='");
        }

        private void txtestadocivilcandidato_TextChanged(object sender, EventArgs e)
        {
            clr.llenarCB2(this.txtestadocivilcandidato, this.comboBox2, "select descipcion from ESTADOCIVIL where idestadocivil ='");

        }

        private void txtnacioncandidato_TextChanged(object sender, EventArgs e)
        {
            clr.llenarCB(this.txtnacioncandidato, this.comboBox3, "select descripcion from NACIONALIDAD where idnacionalidad ='");
        }

        private void txtestadocandidato_TextChanged(object sender, EventArgs e)
        {

        }

        private void groupBox2_Enter(object sender, EventArgs e)
        {

        }

        private void button8_Click_1(object sender, EventArgs e)
        {
            frmEstudios estudios = new frmEstudios();
            estudios.txtidcandidato.Text = txtcodigocandidato.Text;
            estudios.Show();
        }

        private void button10_Click(object sender, EventArgs e)
        {
            frmExperienciaLaboral experiencia = new frmExperienciaLaboral();
            experiencia.txtidcandidato.Text = txtcodigocandidato.Text;
            experiencia.Show();
        }

        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            cnr.sololetras(e);
        }

        private void textBox2_KeyPress(object sender, KeyPressEventArgs e)
        {
            cnr.sololetras(e);
        }

        private void textBox4_KeyPress(object sender, KeyPressEventArgs e)
        {
            cnr.sololetras(e);
        }

        private void textBox3_KeyPress(object sender, KeyPressEventArgs e)
        {
            cnr.sololetras(e);
        }

        private void textBox8_KeyPress(object sender, KeyPressEventArgs e)
        {
            cnr.sololetras(e);
        }

        private void textBox5_KeyPress(object sender, KeyPressEventArgs e)
        {
            cnr.solonumeros(e);
        }

        private void textBox7_KeyPress(object sender, KeyPressEventArgs e)
        {
            cnr.solonumeros(e);
        }

        private void comboBox4_SelectedIndexChanged(object sender, EventArgs e)
        {
            string cadcon = "select idpuestodetrabajo from PUESTODETRABAJO where nombrepuesto ='" + comboBox4.Text + "'";
            SqlCommand cm = new SqlCommand(cadcon, conexionbd.ObtenerConexion());

            SqlDataReader leer = cm.ExecuteReader();
            if (leer.Read() == true)
            {
                txtidpuesto.Text = leer["idpuestodetrabajo"].ToString();
            }
            else
            {
                txtidpuesto.Text = "";
            }

        }

        private void txtidpuesto_TextChanged(object sender, EventArgs e)
        {
            clr.llenarCB3(this.txtidpuesto, this.comboBox4);
        }
    }
}
