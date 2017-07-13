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
            combo_periodo();
        }

        public void combo_periodo()
        {
            List<capa_presentacion_planillas.cbx_periodo> periodos = capa_negocio_planillas.cbx_periodo();

            cbx_periodo.DataSource = periodos;
            cbx_periodo.DisplayMember = "mes";
            cbx_periodo.ValueMember = "idperiodo";
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
            int tipoPago = Convert.ToInt32(txt_tipoPago.SelectedValue.ToString());
            string monto = "0";
            string porcentaje = "0";
            int idperiodo = Convert.ToInt32(cbx_periodo.SelectedValue.ToString());

            if (radio_porcentaje.Checked == true)
            {
                porcentaje = txt_porcentaje.Text;
            }
            if (radio_montoF.Checked == true)
            {
                monto = txt_montoF.Text;
            }

            if (tipo == 1){//Percepciones
                resultado = capa_negocio_planillas.savePercepciones(descripcion, porcentaje, monto, tipoPago, idperiodo);
            }
            if (tipo == 2){//Deducciones
                resultado = capa_negocio_planillas.saveDeducciones(descripcion, porcentaje, monto, tipoPago, idperiodo);
            }

            if (resultado == 1)
            {
                MessageBox.Show("Registro Almacenado con Éxito");
                txt_descripcion.Clear();
                txt_porcentaje.Clear();
                txt_montoF.Clear();
                radio_porcentaje.Checked = true;
                showPagoDescuentos();
            }
        }

        private void btn_editar_Click(object sender, EventArgs e)
        {
            int resultado = 0;
            int tipo = Convert.ToInt32(txt_tipo.SelectedValue.ToString());
            string descripcion = txt_descripcion.Text;
            string porcentaje = "0";
            string monto = "0";
            int tipoPago = Convert.ToInt32(txt_tipoPago.SelectedValue.ToString());
            int idperiodo = Convert.ToInt32(cbx_periodo.SelectedValue.ToString());

            if (radio_porcentaje.Checked == true)
            {
                porcentaje = txt_porcentaje.Text;
            }
            if (radio_montoF.Checked == true)
            {
                monto = txt_montoF.Text;
            }

            if (tipo == 1)
            {//Percepciones
                resultado = capa_negocio_planillas.updatePercepciones(idbonificacion, descripcion, porcentaje, monto, tipoPago, idperiodo);
            }
            if (tipo == 2)
            {//Deducciones
                resultado = capa_negocio_planillas.updateDeducciones(iddescuento, descripcion, porcentaje, monto, tipoPago, idperiodo);
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
            txt_porcentaje.Clear();
        }

        private void radio_porcentaje_CheckedChanged(object sender, EventArgs e)
        {
            txt_montoF.Clear();
        }

        private void radio_montoF_CheckedChanged(object sender, EventArgs e)
        {
            txt_porcentaje.Clear();
        }

        private void btn_help_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start(Environment.CurrentDirectory + @"\Manualdeplanillas.pdf");
        }
    }
}
