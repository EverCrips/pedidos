//Diseñado y programado por Cristopher Pérez V. 18.973.714-9
using System;
using System.Collections;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SistemaPedidos.ClasesSQL
{
    class ConsultasGenerales : Conexion
    {
        //Método para obtener todos los datos del usuario
        public ArrayList ObtenerDatosUsuario()
        {
            SqlDataReader reader;
            ArrayList datosUser = new ArrayList();
            SqlCommand select;

            try
            {
                Conectar();
                String comando = "select ve.nombre_vendedor, ve.run_vendedor from Vendedores ve";

                select = new SqlCommand(comando, con);

                reader = select.ExecuteReader();

                if (reader.Read())
                {
                    datosUser.Add(reader["nombre_vendedor"].ToString());
                    datosUser.Add(reader["run_vendedor"].ToString());
                }
                else
                {

                }

                reader.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al intentar buscar un usuario... " + ex);
            }

            return datosUser;
        }

    }
}
