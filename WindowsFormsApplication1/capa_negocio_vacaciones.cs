using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplication1
{
     public class capa_negocio_vacaciones
    {
        public void Insert_Motivo(capa_presentacion_vacaciones pmotivo)
        {
            if (string.IsNullOrWhiteSpace(pmotivo.motivo) || string.IsNullOrWhiteSpace(pmotivo.descripcion))
            {
                MessageBox.Show("Hay Uno o mas Campos Vacios!", "Campos Vacios", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            else
            {

                int resultado = capa_logica_vacaciones.Agregar(pmotivo);

                if (resultado > 0)
                {
                    MessageBox.Show("Registro Guardado", "Guardado", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("No se pudo guardar el registro", "Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
            }
         }
        public void modificar_motivo(capa_presentacion_vacaciones pmotivo)
        {
            if (string.IsNullOrWhiteSpace(pmotivo.motivo) || string.IsNullOrWhiteSpace(pmotivo.descripcion))
            {
                MessageBox.Show("Hay Uno o mas Campos Vacios!", "Campos Vacios!!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            else
            {
                int resultado = capa_logica_vacaciones.modificarmotivo(pmotivo);
                if (resultado > 0)
                {
                    MessageBox.Show("Los datos del motivo se actualizaron", "Datos Actualizados", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("No se pudo actualizar", "Error al Actualizar", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
            }
        }

        //---------------------------------------------------Solicitud-----------------------------------------------------------------
        public void Insert_solicitud(capa_presentacion_solicitud psolicitud)
        {
            int resultado = capa_logica_vacaciones.Agregarsolicitud(psolicitud);

            if (resultado > 0)
            {
                MessageBox.Show("Registro Guardado", "Guardado", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("No se pudo guardar el registro", "Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

        //-------------------------------------------festivos....................................................
        public void Insert_festivo(capa_presentacion_festivos pfestivo)
        {
            if (string.IsNullOrWhiteSpace(pfestivo.fecha) || string.IsNullOrWhiteSpace(pfestivo.descripcion))
            {
                MessageBox.Show("Hay Uno o mas Campos Vacios!", "Campos Vacios", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            else
            {

                int resultado = capa_logica_vacaciones.Agregarfestivos(pfestivo);

                if (resultado > 0)
                {
                    MessageBox.Show("Registro Guardado", "Guardado", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("No se pudo guardar el registro", "Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
            }
        }



        public void modificar_festivo(capa_presentacion_festivos pfes)
        {
            if (string.IsNullOrWhiteSpace(pfes.fecha) || string.IsNullOrWhiteSpace(pfes.descripcion))
            {
                MessageBox.Show("Hay Uno o mas Campos Vacios!", "Campos Vacios!!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            else
            {
                int resultado = capa_logica_vacaciones.modificarfestivo(pfes);
                if (resultado > 0)
                {
                    MessageBox.Show("Los datos del motivo se actualizaron", "Datos Actualizados", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("No se pudo actualizar", "Error al Actualizar", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
            }
        }



        //-----------------------periodo--------------------------------------------------------

        public void Insert_periodoo(capa_presentacion_periodo pper)
        {
            if (string.IsNullOrWhiteSpace(pper.perdescripcion) || string.IsNullOrWhiteSpace(pper.perestatus))
            {
                MessageBox.Show("Hay Uno o mas Campos Vacios!", "Campos Vacios", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            else
            {

                int resultado = capa_logica_vacaciones.Agregarperiodoo(pper);

                if (resultado > 0)
                {
                    MessageBox.Show("Registro Guardado", "Guardado", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("No se pudo guardar el registro", "Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
            }
        }
        public void modificar_periodoo(capa_presentacion_periodo pmotivo)
        {
            if (string.IsNullOrWhiteSpace(pmotivo.perdescripcion) || string.IsNullOrWhiteSpace(pmotivo.perestatus))
            {
                MessageBox.Show("Hay Uno o mas Campos Vacios!", "Campos Vacios!!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            else
            {
                int resultado = capa_logica_vacaciones.modificarperiodoo(pmotivo);
                if (resultado > 0)
                {
                    MessageBox.Show("Los datos del motivo se actualizaron", "Datos Actualizados", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("No se pudo actualizar", "Error al Actualizar", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
            }
        }

        //----------------------------------------------------------
        public void Insert_dias(capa_presentacion_diasvac pdia)
        {
            if (string.IsNullOrWhiteSpace(pdia.diarestantes) || string.IsNullOrWhiteSpace(pdia.diasacumulados))
            {
                MessageBox.Show("Hay Uno o mas Campos Vacios!", "Campos Vacios", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            else
            {

                int resultado = capa_logica_vacaciones.Agregardias(pdia);

                if (resultado > 0)
                {
                    MessageBox.Show("Registro Guardado", "Guardado", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("No se pudo guardar el registro", "Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
            }
        }

        public int Login(string sUser, string sContra)
        {
            int resultado = 0;
            if (string.IsNullOrWhiteSpace(sUser) || string.IsNullOrWhiteSpace(sContra))
            {
                MessageBox.Show("Hay Uno o mas Campos Vacios!", "Campos Vacios!!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            else
            {
                resultado = capa_logica_vacaciones.LoginD(sUser, sContra);
                if (resultado > 0)
                {
                    resultado = 1;
                }
                else
                {
                    MessageBox.Show("Usuario o Contraseña Incorrecta", "Fallo!!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
            }
            return resultado;
        }
    }
}
