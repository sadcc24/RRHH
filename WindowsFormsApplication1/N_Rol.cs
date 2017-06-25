using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace WindowsFormsApplication1
{
    public class N_Rol:D_Rol
    {
        public static SqlCommand SQL_cmd;
        public static SqlConnection SQL_Conexion = new SqlConnection();
        //funcion el cual obtiene los datos del usuario
        //funcion el cual el usuario envia los datos y verifica que el usuario exista en el sistema
        public int Login(string sUser, string sContra)
        {
            //declaramos la variable resultado de tipo entero
            int resultado = 0;
            if (string.IsNullOrWhiteSpace(sUser) || string.IsNullOrWhiteSpace(sContra))
            {
                MessageBox.Show("Hay Uno o mas Campos Vacios!", "Campos Vacios!!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            else
            {

                resultado = D_Rol.LoginD(sUser, sContra);
                //si resulta es mayor a 0 
                if (resultado > 0)
                {
                    //entonces resultado se vuelve 1 y es que existe un dato
                    resultado = 1;
                    
                }
                else
                {
                    //muestra un mensaje de error si la contraseña es incorrecta
                    MessageBox.Show("Usuario o Contraseña Incorrecta", "Fallo!!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    SQL_Conexion.Close();
                    
                }
            }
            //devuelve el resulta 
            return resultado;
        }
        //funcion el cual obtiene los nombre de los modulos
 
    }
}
