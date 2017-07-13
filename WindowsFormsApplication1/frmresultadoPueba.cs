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
    public partial class Resultado_Pueba : Form
    {
        public Resultado_Pueba()
        {
            InitializeComponent();
        }

        capa_negocio_Reclutamiento cnr = new capa_negocio_Reclutamiento();
        capa_logica_Reclutamiento clr = new capa_logica_Reclutamiento();
        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void textBox7_TextChanged(object sender, EventArgs e)
        {
        }

        private void txtresultado_TextChanged(object sender, EventArgs e)
        {
            cnr.resultado(txtresultado, lblresultado);
        }

        private void txtresultadoT_TextChanged(object sender, EventArgs e)
        {
            cnr.trasladarR(txtresultadoT, txtresultado);
        }

        private void txtresultado3_TextChanged(object sender, EventArgs e)
        {
            cnr.rango(txtresultado3);
            cnr.resultadoT(txtresultado1, txtresultado2, txtresultado3, txtresultadoT);
        }

        private void txtresultado1_TextChanged(object sender, EventArgs e)
        {
            cnr.rango(txtresultado1);
            cnr.resultadoT(txtresultado1, txtresultado2, txtresultado3, txtresultadoT);
        }

        private void txtresultado2_TextChanged(object sender, EventArgs e)
        {
            cnr.rango(txtresultado2);
            cnr.resultadoT(txtresultado1, txtresultado2, txtresultado3, txtresultadoT);
        }

        private void txtresultado1_KeyPress(object sender, KeyPressEventArgs e)
        {
            cnr.solonumeros(e);
        }

        private void txtresultado2_KeyPress(object sender, KeyPressEventArgs e)
        {
            cnr.solonumeros(e);
        }

        private void txtresultado3_KeyPress(object sender, KeyPressEventArgs e)
        {
            cnr.solonumeros(e);
        }

        private void Resultado_Pueba_Load(object sender, EventArgs e)
        {
            cnr.tamano(this, txtidcandidato);
            clr.concatenar(txtidcandidato, txtnombrecandidato);
            clr.llenartxt2(textBox6, txtetapaentrevista);
            button8.Enabled = false;

            cnr.etiquetapreba(lblresultado1, lblresultado2, lblresultado3, txtetapaentrevista);
        }

        private void button8_Click(object sender, EventArgs e)
        {
            frmbusquedeentrevista busqueda = new frmbusquedeentrevista();
            this.Close();
            busqueda.Show();
        }

        private void txtetapaentrevista_TextChanged(object sender, EventArgs e)
        {
           
        }

        private void button1_Click(object sender, EventArgs e)
        {
            txtidcandidato.Text = "";
            txtidentrevista.Text = "";
            txtetapaentrevista.Text = "";
            txtresultado1.Text = "";
            txtresultado2.Text = "";
            txtresultado3.Text = "";
            cnr.tamano(this, txtidcandidato);
            button8.Enabled = true;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            cnr.insertardetalleentrevista(this.txtidentrevista.Text, this.txtcomentario.Text, this.txtresultado1.Text, this.txtresultado2.Text, this.txtresultado3.Text, this.txtresultadoT.Text, this.txtresultado.Text,txtresultado1, txtresultado2, txtresultado3,txtcomentario);
            if (txtetapaentrevista.Text == ("1") && txtresultado.Text == ("2"))
            {
                clr.updatecandidato6(this.txtidcandidato.Text);
                this.Close();
            }
            else if (txtetapaentrevista.Text == ("1") && txtresultado.Text == ("1"))
            {
                clr.updatecandidato8(this.txtidcandidato.Text);
                this.Close();
            }
            else if (txtetapaentrevista.Text == ("2") && txtresultado.Text == ("2"))
            {
                clr.updatecandidato7(this.txtidcandidato.Text);
                this.Close();
            }
            else if (txtetapaentrevista.Text == ("2") && txtresultado.Text == ("1"))
            {
                clr.updatecandidato5(this.txtidcandidato.Text);
                this.Close();
            }            
        }

        private void button2_Click(object sender, EventArgs e)
        {
            txtresultado1.Enabled = true;
            txtresultado2.Enabled = true;
            txtresultado3.Enabled = true;
            txtcomentario.Enabled = true;
            button6.Enabled = true;
        }

        private void button6_Click(object sender, EventArgs e)
        { 

            cnr.modificardetalleentrevista(this.txtiddetalle.Text, this.txtidentrevista.Text, this.txtcomentario.Text, this.txtresultado1.Text, this.txtresultado2.Text, this.txtresultado3.Text, this.txtresultadoT.Text, this.txtresultado.Text, txtresultado1, txtresultado2, txtresultado3, txtcomentario);
        }

        private void button5_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start(Environment.CurrentDirectory + @"\Prueba.pdf");
        }
    }
}
