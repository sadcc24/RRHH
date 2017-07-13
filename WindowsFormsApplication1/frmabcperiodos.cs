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
    public partial class frmabcperiodos : Form
    {

        string id_periodo;
        public frmabcperiodos(string idperio,string per,string accion)
        {
            id_periodo = idperio;
            string periodo = per;


            InitializeComponent();
            if (accion == "1") {
                txtperiodo.Text = periodo;
            }



        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            int creacion = 0;
            string periodo = txtperiodo.Text;
            creacion = capa_negocio_formaciones.nuevoperiodo(periodo);

            if (creacion == 1)
            {
                MessageBox.Show("Creacion Exitosa", "Nuevo Periodo", MessageBoxButtons.OK, MessageBoxIcon.Information);

            }
            else {
                MessageBox.Show("Error en Creacion Periodo", "Nuevo Periodo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            
        }

        private void frmabcperiodos_FormClosed(object sender, FormClosedEventArgs e)
        {
              frmperiodos ventana = new frmperiodos();
                ventana.MdiParent = this.MdiParent;
                ventana.Show();
                 
        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            int modificar = 0;
            string per = id_periodo;
            string periodo = txtperiodo.Text;

            
            DialogResult result;

            result = MessageBox.Show("Desea Modificar Este Periodo?", "Modificar Periodo", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (result == System.Windows.Forms.DialogResult.Yes) {
                modificar = capa_negocio_formaciones.modificar_periodo(per, periodo);
                if (modificar == 1)
                {
                    MessageBox.Show("Modificacion Exitosa", "Confirmacion", MessageBoxButtons.OK, MessageBoxIcon.Information);

                }
                else {
                    MessageBox.Show("Error Modificacion Periodo", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }


            }
        }

        private void btnBorrar_Click(object sender, EventArgs e)
        {
            int eliminar = 0;

            DialogResult result;

            result = MessageBox.Show("Desea Eliminar Este Periodo?", "Eliminar Periodo", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (result == System.Windows.Forms.DialogResult.Yes)
            {
                eliminar = capa_negocio_formaciones.eliminarperiodo(id_periodo);
                if (eliminar == 1)
                {
                    MessageBox.Show("Eliminacion Exitosa", "Confirmacion", MessageBoxButtons.OK, MessageBoxIcon.Information);

                }
                else
                {
                    MessageBox.Show("Error Eliminar Periodo", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }


            }
        }

        private void btnAyuda_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start(Environment.CurrentDirectory + @"\Creación,Modificación,Eliminaciónperiodo-mike.pdf");
            
        }
    }
}
