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
    public partial class frmabcmetrica : Form
    {
        string idempresa;
        string metrica;
        public frmabcmetrica(string empresa,string metricaid, string nombremetrica,string descripcionmetrica,string empresametrica,string departamentometrica,string accion)
        {
            InitializeComponent();
            idempresa = empresa;
            metrica = metricaid;
            List<capa_presentacion_formaciones.departamento> depto = capa_negocio_formaciones.departamentos("0");
            cbdepartamento.DataSource = depto;
            cbdepartamento.DisplayMember = "nombredepartamento";
            cbdepartamento.ValueMember = "iddepartamento";

            string iddepartamento = capa_negocio_formaciones.consultaiddepartamento(departamentometrica);


            if (accion == "1") {

                txtnombremetrica.Text = nombremetrica;
                txtdescripcionmetrica.Text = descripcionmetrica;
             
                cbdepartamento.SelectedValue = iddepartamento;

            }


        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            int creacion = 0;

            string nombre = txtnombremetrica.Text;
            string descripcion = txtdescripcionmetrica.Text;
            string departamento = cbdepartamento.SelectedValue.ToString();

            creacion = capa_negocio_formaciones.nuevametrica(idempresa, nombre, descripcion, departamento);

            if (creacion == 1)
            {
                MessageBox.Show("Metrica Creada Exitosamente", "Confirmacion", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else {
                MessageBox.Show("Error Creacion Metrica", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            string nombre="";
            string descripcion="";
            string departamento="";

            nombre = txtnombremetrica.Text;
            descripcion = txtdescripcionmetrica.Text;
            departamento = cbdepartamento.SelectedValue.ToString();

            int modificar = 0;

            DialogResult result;
            result = MessageBox.Show("Desea Modificar Esta Metrica?", "Modificar Metrica", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (result == System.Windows.Forms.DialogResult.Yes) {
                modificar = capa_negocio_formaciones.modificarmetrica(metrica,nombre,descripcion,departamento);

                if (modificar == 1)
                {
                    MessageBox.Show("Modificacion Exitosa", "Modificar Metrica", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else {
                    MessageBox.Show("Error en Modificacion", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }


        }

        private void frmabcmetrica_FormClosed(object sender, FormClosedEventArgs e)
        {
            frmconsultametrica ventanaP = new frmconsultametrica(idempresa);
            ventanaP.MdiParent = this.MdiParent;
            ventanaP.Show();

        }

        private void btnBorrar_Click(object sender, EventArgs e)
        {
            int eliminar = 0;

            DialogResult result;

            result = MessageBox.Show("Desea Eliminar Esta Metrica?", "Eliminar metrica", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (result == System.Windows.Forms.DialogResult.Yes) {
                eliminar = capa_negocio_formaciones.eliminarmetrica(metrica);

                if (eliminar == 1)
                {
                    MessageBox.Show("Metrica Eliminada Exitosamente", "Eliminacion Metrica", MessageBoxButtons.OK, MessageBoxIcon.Information);

                }
                else {
                    MessageBox.Show("Error Eliminar Metrica", "Eliminacion Metrica", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

            }




        }

        private void frmabcmetrica_Load(object sender, EventArgs e)
        {

        }

        private void btnAyuda_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start(Environment.CurrentDirectory + @"\Creación,Modificación,Eliminaciónmetrica-mike.pdf");
        }
    }
}
