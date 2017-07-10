﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplication1
{
     class capa_negocio_Empleado
    {

        public System.Data.DataTable GetAll(string sUser)
        {
            return capa_logica_Empleado.ObtenerRegistros(sUser);
        }

        public System.Data.DataTable obtieneRol()
        {
            return capa_logica_Empleado.obtieneRol();
        }
        public System.Data.DataTable obtieneDepto()
        {
            return capa_logica_Empleado.obtieneDepto();
        }
        public System.Data.DataTable obtienePuesto(string dep)
        {
            return capa_logica_Empleado.obtienePuesto(dep);
        }
        public System.Data.DataTable GetEmpleadoGrid()
        {
            return capa_logica_Empleado.GetEmpleadoGrid();
        }
        public System.Data.DataTable GetEmpleadoDatos(string idemp)
        {
            return capa_logica_Empleado.GetEmpleadoDatos(idemp);
        }

        public void Insert_Motivo(capa_presentacion_Empleado pmotivo)
        {
            if (string.IsNullOrWhiteSpace(pmotivo.motivo) || string.IsNullOrWhiteSpace(pmotivo.descripcion))
            {
                MessageBox.Show("Hay Uno o mas Campos Vacios!", "Campos Vacios", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            else
            {

                int resultado = capa_logica_Empleado.Agregar(pmotivo);

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
                resultado = capa_logica_Empleado.LoginD(sUser, sContra);
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


        public int InsertaEmpleado(int? experiencia, int? estudio,int Estado, int CodUsuario, int Empresa,int rol, decimal sueldo, decimal aumento, string puesto, string jornada, string feciniciolaboral, string nombre1, string nombre2, string apellido1, string apellido2, string apellido3, string nacionalidad, string sexo, string fechanacimiento, string direccion, int telefono, string identificacion, string fotografia)
        {
            int resultado = 0;
            //if (string.IsNullOrWhiteSpace(sUser) || string.IsNullOrWhiteSpace(sContra))
            //{
            //    MessageBox.Show("Hay Uno o mas Campos Vacios!", "Campos Vacios!!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            //}
            //else
            //{
            resultado = capa_logica_Empleado.InsertaEmpleado(experiencia,estudio, Estado, CodUsuario, Empresa,rol, sueldo, aumento, puesto, jornada, feciniciolaboral, nombre1, nombre2, apellido1, apellido2, apellido3, nacionalidad, sexo, fechanacimiento, direccion, telefono, identificacion, fotografia);
                if (resultado > 0)
                {
                    resultado = 1;
                }
                else
                {
                    MessageBox.Show("Usuario no Creado", "Fallo!!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
            
            return resultado;
        }
    }
}
