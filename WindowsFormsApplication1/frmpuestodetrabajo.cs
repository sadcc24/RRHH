using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Diagnostics;

namespace WindowsFormsApplication1
{
    public partial class Nuevo_Puesto : Form
    {
        public Nuevo_Puesto()
        {
            InitializeComponent();
        }
        capa_logica_Reclutamiento clr = new capa_logica_Reclutamiento();
        capa_negocio_Reclutamiento cnr = new capa_negocio_Reclutamiento();
        private void Nuevo_Puesto_Load(object sender, EventArgs e)
        {
            cnr.camposenabledfalse(this, groupBox1);
            button4.Enabled = false;
            button6.Enabled = false;

        }

        private void txtempresa_TextChanged(object sender, EventArgs e)
        {
            clr.llenarCB3(this.txtempresa, this.comboBox1, "select nombre_empresa from EMPRESA where idempresa ='","nombre_empresa");
        }

        private void txtdepartamento_TextChanged(object sender, EventArgs e)
        {
            clr.llenarCB3(this.txtdepartamento, this.comboBox2, "select nombredeptoempresa from DEPARTAMENTOEMPRESA where iddepartamentoempresa ='","nombredeptoempresa");
        }

        private void txtestadopuesto_TextChanged(object sender, EventArgs e)
        {
            clr.llenarCB3(this.txtdepartamento, this.comboBox3, "select descripcion from ESTADOPUESTO where idestadopuesto ='", "descripcion");
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            clr.llenartxt("select idempresa from EMPRESA where nombre_empresa ='", "idempresa", comboBox1, txtempresa);
        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            clr.llenartxt("select iddepartamentoempresa from DEPARTAMENTOEMPRESA where nombredeptoempresa ='", "iddepartamentoempresa", comboBox2, txtdepartamento);
        }

        private void comboBox3_SelectedIndexChanged(object sender, EventArgs e)
        {
            clr.llenartxt("select idestadopuesto from ESTADOPUESTO where descripcion ='", "idestadopuesto", comboBox3, txtestadopuesto);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            clr.llenarcombobox("select nombre_empresa from EMPRESA", "nombre_empresa", comboBox1);
            clr.llenarcombobox("select nombredeptoempresa from DEPARTAMENTOEMPRESA", "nombredeptoempresa", comboBox2);
            clr.llenarcombobox("Select descripcion from ESTADOPUESTO", "descripcion", comboBox3);
            clr.generarid(textBox2, textBox1, txtidpuesto);
            cnr.camposenabledtrue(this, groupBox1);
            button2.Enabled = false;
            button3.Enabled = false;
            button4.Enabled = true;
            button6.Enabled = false;
        }

        private void button4_Click(object sender, EventArgs e)
        {
          if(  clr.insertarPuesto(this.txtempresa.Text, this.txtdepartamento.Text, this.txtnombrepuesto.Text,this.txtestadopuesto.Text))
            
                {
                    MessageBox.Show("La Información se Guardo Correctamente");
                    this.Close();
                }
            else
            {
                    MessageBox.Show("La Información No se Guardo Correctamente");
                }

            }

        private void button6_Click(object sender, EventArgs e)
        {
            if (clr.ModificarPuesto(this.txtidpuesto.Text, this.txtempresa.Text, this.txtdepartamento.Text, this.txtnombrepuesto.Text, this.txtestadopuesto.Text))

            {
                MessageBox.Show("La Información se Modifico Correctamente");
                this.Close();
            }
            else
            {
                MessageBox.Show("La Información No se Modifico Correctamente");
            }

        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show(" Se eliminara la información ¿Está seguro?", "Eliminar", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                clr.borrarpuesto(this.txtidpuesto.Text);
                this.Close();
            }
            else
            {

            }

        }

        private void button2_Click(object sender, EventArgs e)
        {
            clr.llenarcombobox("select nombre_empresa from EMPRESA", "nombre_empresa", comboBox1);
            clr.llenarcombobox("select nombredeptoempresa from DEPARTAMENTOEMPRESA", "nombredeptoempresa", comboBox2);
            clr.llenarcombobox("Select descripcion from ESTADOPUESTO", "descripcion", comboBox3);

            cnr.camposenabledtrue(this, groupBox1);
            button4.Enabled = false;
            button6.Enabled = true;
        }

        private void button5_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start(Environment.CurrentDirectory + @"\PuestodeTrabajo.pdf");
        }
    }
}

