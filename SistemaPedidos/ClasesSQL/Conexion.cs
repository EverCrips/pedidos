//Diseñado y programado por Cristopher Pérez V. 18.973.714-9
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SistemaPedidos.ClasesSQL
{
    class Conexion
    {

        //variable connection
        protected static SqlConnection con;
        //cadena de conexion
        String cadena_conexion = "Data Source=DESKTOP-KIDHD2A\\MSI;Initial Catalog=Pedidos;Integrated Security=True";

        //Conectar a la base de datos     
        public Boolean Conectar()
        {
            try
            {
                con = new SqlConnection(cadena_conexion);
                con.Open();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al intentar conectar a la base de datos." + ex);
            }
            return true;
        }

        //Desconectarse de la base de datos
        public Boolean Desconectar()
        {
            try
            {
                con = new SqlConnection(cadena_conexion);
                con.Close();
                MessageBox.Show("Se ha desconectado de la base de datos.");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al intentar desconectar a la base de datos." + ex);
            }
            return true;
        }
    }
}
