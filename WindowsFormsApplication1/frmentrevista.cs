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
    public partial class frmentrevista : Form
    {
        public frmentrevista()
        {
            InitializeComponent();
        }

        capa_logica_Reclutamiento clr = new capa_logica_Reclutamiento();
        capa_negocio_Reclutamiento cnr = new capa_negocio_Reclutamiento();
        private void PrimeraEtapa_Load(object sender, EventArgs e)
        {
            clr.llenarcombobox("Select descripcion from ETAPAENTREVISTA where idetapaentrevista in (1,2)", "descripcion", comboBox9);

            clr.concatenar(txtidcandidato, txtnombrecandidato);
            button6.Enabled = false;
            button8.Enabled = false;
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void comboBox5_SelectedIndexChanged(object sender, EventArgs e)
        {
        }

        private void comboBox9_SelectedIndexChanged(object sender, EventArgs e)
        {
            clr.llenartxt("select idetapaentrevista from ETAPAENTREVISTA where descripcion ='", "idetapaentrevista", comboBox9, txtetapaentrevista);

        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void txtidcandidato_TextChanged(object sender, EventArgs e)
        {
        }

        private void txtidpuestodetrabajo_TextChanged(object sender, EventArgs e)
        {
            clr.llenartxt3(txtpuesto, txtidpuestodetrabajo);
        }

        private void txtetapaentrevista_TextChanged(object sender, EventArgs e)
        {
            clr.llenarCB3(this.txtetapaentrevista, this.comboBox9, "select descripcion from ETAPAENTREVISTA where idetapaentrevista ='", "descripcion");
        }

        private void button1_Click(object sender, EventArgs e)
        {
            clr.llenarcombobox("Select descripcion from ETAPAENTREVISTA", "descripcion", comboBox9);
            txtidcandidato.Text = "";
            txtetapaentrevista.Text = "";
            txtidempleado2.Text = "";
            txtidentrevista.Text = "";
            button2.Enabled = false;
            button3.Enabled = false;
            button4.Enabled = true;
            button6.Enabled = false;
            button8.Enabled = true;

        }

        private void button2_Click(object sender, EventArgs e)
        {
            clr.llenarcombobox("Select descripcion from ETAPAENTREVISTA", "descripcion", comboBox9);
            cnr.camposenabledtrue(this, groupBox1);
            cnr.camposenabledtrue(this, groupBox4);
            button4.Enabled = false;
            button6.Enabled = true;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show(" Se eliminara la información ¿Está seguro?", "Eliminar", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                clr.borrarentrevista(this.txtidentrevista.Text);
                if (txtetapaentrevista.Text == ("1") && txtidcandidato.Text == ("3"))
                {
                    clr.updatecandidato1(this.txtidcandidato.Text);
                    this.Close();

                }
                else if (txtetapaentrevista.Text == ("2") && txtidcandidato.Text == ("4"))
                {
                    clr.updatecandidato8(this.txtidcandidato.Text);
                    this.Close();
                }
              
            }
            else
            {

            }

        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (txtestadocandidato.Text == ("1") && txtetapaentrevista.Text == ("2"))
            {
                MessageBox.Show("Candidato no ha Aprobado Etapa 1 Asigne correctamente la Etapa");

            }
            else if (txtestadocandidato.Text == ("8") && txtetapaentrevista.Text == ("1"))
            {
                MessageBox.Show("Candidato ya Aprobado Etapa 1 Asigne correctamente la Etapa");
            }
            else
            {
                if (clr.insertarEntrevista(this.txtidcandidato.Text, this.txtidpuestodetrabajo.Text, this.txtetapaentrevista.Text, this.dateTimefecha.Text, this.dateTimehora.Text))

                {
                    MessageBox.Show("La Información se Guardo Correctamente");
                    if (txtetapaentrevista.Text == ("1") || txtidcandidato.Text == ("1"))
                    {
                        clr.updatecandidato3(this.txtidcandidato.Text);
                        this.Close();
                    }
                    else if(txtetapaentrevista.Text == ("2") || txtidcandidato.Text == ("8"))
                    {
                        clr.updatecandidato4(this.txtidcandidato.Text);
                        this.Close();
                    }
                }
                else
                {
                    MessageBox.Show("La Información No se Guardo Correctamente");
                }
            }

            }
            


  
        private void button5_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            if (txtestadocandidato.Text == ("3") && txtetapaentrevista.Text == ("2"))
            {
                MessageBox.Show("Candidato no ha Aprobado Etapa 1 Asigne correctamente la Etapa");

            }
            else if (txtestadocandidato.Text == ("8") && txtetapaentrevista.Text == ("1"))
            {
                MessageBox.Show("Candidato ya Aprobado Etapa 1 Asigne correctamente la Etapa");
            }
            else
            {
                if (clr.ModificarEntrevista(this.txtidentrevista.Text, this.txtidcandidato.Text, this.txtidpuestodetrabajo.Text, this.txtetapaentrevista.Text, this.dateTimefecha.Text, this.dateTimehora.Text))
                {
                    MessageBox.Show("La Información se Modifico Correctamente");
                    this.Close();
                }
                else
                {
                    MessageBox.Show("La Información No se Modifico Correctamente");
                }
            }

        }

        private void button8_Click(object sender, EventArgs e)
        {
            frmbusqueda busqueda = new frmbusqueda();
            busqueda.Show();
            this.Close();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start(Environment.CurrentDirectory + @"\Entrevista.pdf");
        }
    }
}

