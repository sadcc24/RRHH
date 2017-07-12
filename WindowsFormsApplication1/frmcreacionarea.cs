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
    public partial class frmcreacionarea : Form
    {
        string accion;

        string area;

        public frmcreacionarea(string mod,string id,string nombre,string descripcion)
        {

            area = id;
            accion = mod;
            InitializeComponent();


            if (accion == "1")
            {
                txtnombrearea.Text = nombre;
                txtdescripcion.Text = descripcion;
            }
            else if (accion=="0") {
                txtnombrearea.Clear();
                txtdescripcion.Clear();
            }
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            string nombre="";
            string descripcion="";
            int nueva_area=0;
            nombre = txtnombrearea.Text;
            descripcion = txtdescripcion.Text;
            nueva_area = capa_negocio_formaciones.nueva_area(descripcion, nombre);

            if (nueva_area == 1)
            {
                MessageBox.Show("Ingreso Exitoso", "Creacion Area", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else {
                MessageBox.Show("Error al Crear Area", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            


        }

        private void frmcreacionarea_FormClosed(object sender, FormClosedEventArgs e)
        {
            frmconsultaarea ventanaP = new frmconsultaarea();
            ventanaP.MdiParent = this.MdiParent;
            ventanaP.Show();
        }

        private void btnBorrar_Click(object sender, EventArgs e)
        {
            int eliminar =0 ;
            DialogResult respuesta;

            respuesta = MessageBox.Show("Realmente Desea Eliminar esta Area", "Confirmacion Eliminacion", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (respuesta == System.Windows.Forms.DialogResult.Yes) {
                eliminar = capa_negocio_formaciones.eliminar_area(area);

                if (eliminar == 1) {
                    MessageBox.Show("Eliminacion Exitosa", "Eliminacion", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else if (eliminar == 0){
                    MessageBox.Show("Eliminacion Error", "Eliminacion", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
           
            string descripcion;
            string nombre;

            descripcion = txtdescripcion.Text;
            nombre = txtnombrearea.Text;

            DialogResult pregunta;
            pregunta = MessageBox.Show("Desea Modificar esta Area", "Modificar Area", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (pregunta == System.Windows.Forms.DialogResult.Yes) {

                int modificar = capa_negocio_formaciones.modificararea(area, nombre, descripcion);

                if (modificar == 1)
                {
                    MessageBox.Show("Modificacion Exitosa", "Confirmacion", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else {
                    MessageBox.Show("Error en Modificacion", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }

            
        }

        private void frmcreacionarea_Load(object sender, EventArgs e)
        {

        }
    }
}
