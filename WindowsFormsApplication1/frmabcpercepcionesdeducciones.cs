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
    public partial class ABCPercepcionesDeducciones : Form
    {
        public int idbonificacion = 0;
        public int iddescuento = 0;

        public ABCPercepcionesDeducciones()
        {
            InitializeComponent();
            cmb_tipo();
            cmb_tipoPago();
            showPagoDescuentos();
        }

        public void cmb_tipo()
        {
            List<capa_presentacion_planillas.cbx_tipo> cbx_tipo = capa_negocio_planillas.cbx_tipo();

            txt_tipo.DataSource = cbx_tipo;
            txt_tipo.DisplayMember = "descripcion";
            txt_tipo.ValueMember = "idtipo";

            txt_filtro.DataSource = cbx_tipo;
            txt_filtro.DisplayMember = "descripcion";
            txt_filtro.ValueMember = "idtipo";
        }

        public void cmb_tipoPago()
        {
            List<capa_presentacion_planillas.cbx_tipoPago> cbx_tipoPago = capa_negocio_planillas.cbx_tipoPago();

            txt_tipoPago.DataSource = cbx_tipoPago;
            txt_tipoPago.DisplayMember = "descripcion";
            txt_tipoPago.ValueMember = "idtipopago";
        }

        public void showPagoDescuentos()
        {
            List<capa_presentacion_planillas.showPagoDescuentos> showPercepciones = capa_negocio_planillas.showPercepciones();
            List<capa_presentacion_planillas.showPagoDescuentos> showDeducciones = capa_negocio_planillas.showDeducciones();

            grid_percepciones.DataSource = showPercepciones;
            grid_deducciones.DataSource = showDeducciones;
        }

        private void btn_guardar_Click(object sender, EventArgs e)
        {
            int resultado = 0;
            int tipo = Convert.ToInt32(txt_tipo.SelectedValue.ToString());
            string descripcion = txt_descripcion.Text;
            string porcentaje = txt_porcentaje.Text;
            int tipoPago = Convert.ToInt32(txt_tipoPago.SelectedValue.ToString());

            if (tipo == 1){//Percepciones
                resultado = capa_negocio_planillas.savePercepciones(descripcion, porcentaje, tipoPago);
            }
            if (tipo == 2){//Deducciones
                resultado = capa_negocio_planillas.saveDeducciones(descripcion, porcentaje, tipoPago);
            }

            if (resultado == 1)
            {
                MessageBox.Show("Registro Almacenado con Éxito");
                showPagoDescuentos();
            }
        }

        private void btn_editar_Click(object sender, EventArgs e)
        {
            int resultado = 0;
            int tipo = Convert.ToInt32(txt_tipo.SelectedValue.ToString());
            string descripcion = txt_descripcion.Text;
            string porcentaje = txt_porcentaje.Text;
            int tipoPago = Convert.ToInt32(txt_tipoPago.SelectedValue.ToString());

            if (tipo == 1)
            {//Percepciones
                resultado = capa_negocio_planillas.updatePercepciones(idbonificacion, descripcion, porcentaje, tipoPago);
            }
            if (tipo == 2)
            {//Deducciones
                resultado = capa_negocio_planillas.updateDeducciones(iddescuento, descripcion, porcentaje, tipoPago);
            }

            if (resultado == 1)
            {
                MessageBox.Show("Registro Modificado con Éxito");
                showPagoDescuentos();
            }
        }

        private void grid_percepciones_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            DataGridViewRow row = grid_percepciones.Rows[e.RowIndex];
            //grid_percepciones.Columns["descripcion"].Visible = false;

            txt_tipo.Text = "Percepciones";
            idbonificacion = Convert.ToInt32(row.Cells["id"].Value.ToString());
            txt_descripcion.Text = row.Cells["descripcion"].Value.ToString();
            txt_porcentaje.Text = row.Cells["porcentaje"].Value.ToString();
            txt_tipoPago.Text = row.Cells["tipoPago"].Value.ToString();
        }

        private void grid_deducciones_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            DataGridViewRow row = grid_deducciones.Rows[e.RowIndex];

            txt_tipo.Text = "Deducciones";
            iddescuento = Convert.ToInt32(row.Cells["id"].Value.ToString());
            txt_descripcion.Text = row.Cells["descripcion"].Value.ToString();
            txt_porcentaje.Text = row.Cells["porcentaje"].Value.ToString();
            txt_tipoPago.Text = row.Cells["tipoPago"].Value.ToString();
        }

        private void txt_filtro_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (txt_filtro.SelectedValue.ToString() == "1")
            {
                grid_deducciones.Hide();
                grid_percepciones.Show();
            }
            if (txt_filtro.SelectedValue.ToString() == "2")
            {
                grid_percepciones.Hide();
                grid_deducciones.Show();
            }
        }

        private void btn_nuevo_Click(object sender, EventArgs e)
        {
            txt_descripcion.Clear();
            txt_porcentaje.Value = 0;
        }
    }
}
