//Diseñado y programado por Cristopher Pérez V. 18.973.714-9
using System;
using System.Collections;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SistemaPedidos.ClasesSQL
{
    class ClaseClientes : Conexion
    {
        //VARIABLES
        //rescatar tabla
        DataTable dt;
        //obetner tabla
        SqlDataAdapter DA;

        /* ************************************************ CLIENTES ************************************************************************
           ************************************************************************************************************************************* */

        /************************* CREAR ************************/

        //CREAR UN REGISTRO NUEVO DE UN CLIENTE
        public String RegistrarCliente(String nombre, String apellidos, String run, String celular, int cred, int desc)
        {
            SqlCommand insert;
            String codi = "";
            try
            {
                String comando = "insert into Clientes (estado_cliente, nombre_cliente, apellidos_cliente, " +
                                    "run_cliente, celular_cliente, lineaCredito_cliente, descuento_cliente) values(1, @nombre, @apellidos, @run, @celular, @lineaCred, @desc);" +
                                        "SELECT SCOPE_IDENTITY();";

                insert = new SqlCommand(comando, con);

                insert.Parameters.Add("@nombre", System.Data.SqlDbType.VarChar, 30).Value = nombre;
                insert.Parameters.Add("@apellidos", System.Data.SqlDbType.VarChar, 50).Value = apellidos;
                insert.Parameters.Add("@run", System.Data.SqlDbType.Char, 12).Value = run;
                insert.Parameters.Add("@celular", System.Data.SqlDbType.Char, 12).Value = celular;
                insert.Parameters.Add("@lineaCred", System.Data.SqlDbType.Int).Value = cred;
                insert.Parameters.Add("@desc", System.Data.SqlDbType.Int).Value = desc;
                
                codi = insert .ExecuteScalar().ToString();

            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al intentar registrar un nuevo cliente... " + ex);
                codi = "";
            }
            return codi;
        }

        /************************* VERIFICAR ************************/

        //VERIFICAR SI EXISTE UN CLIENTE (estado_cliente=1)
        public Boolean VerificarExisteClienteEstado(int codigo)
        {
            SqlCommand select;
            Boolean existe = false;

            try
            {
                String comando = "select count(*) from Clientes where id_cliente=@codigo and estado_cliente=1";
                select = new SqlCommand(comando, con);

                select.Parameters.AddWithValue("@codigo", codigo);

                //guardamos el valor que retorna la consulta en un entero
                int aux = Convert.ToInt32(select.ExecuteScalar());

                if (aux == 0)
                {
                    //si aux es igual a 0, es porque no existe un registro
                    existe = false;
                }
                else
                {
                    //si es distinto de 0, es porque existe un registro
                    existe = true;
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show("No existe dicho cliente... " + ex);
            }
            return existe;
        }

        //VERIFICAR SI EXISTE UN CLIENTE CON UN RUN
        public Boolean VerificarExisteRunCliente(String run)
        {
            SqlCommand select;
            Boolean existe = false;

            try
            {
                String comando = "select count(*) from Clientes where estado_cliente=1 and run_cliente=@run";
                select = new SqlCommand(comando, con);

                select.Parameters.AddWithValue("@run", run);

                //guardamos el valor que retorna la consulta en un entero
                int aux = Convert.ToInt32(select.ExecuteScalar());

                if (aux == 0)
                {
                    //si aux es igual a 0, es porque no existe un registro
                    existe = false;
                }
                else
                {
                    //si es distinto de 0, es porque existe un registro
                    existe = true;
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show("No existe dicho cliente... " + ex);
            }
            return existe;
        }

        /************************* OBTENER DATOS ************************/

        //OBTENER LOS DATOS DE UN CLIENTE ARRAY 
        public ArrayList ObtenerDatosCliente(int codigo)
        {
            SqlDataReader reader;
            ArrayList datosUser = new ArrayList();
            SqlCommand select;

            try
            {
                String comando = "select cl.nombre_cliente, cl.apellidos_cliente, cl.run_cliente, cl.celular_cliente, " +
                                    "cl.lineaCredito_cliente, cl.descuento_cliente from Clientes cl where id_cliente=@codigo " +
                                        "and estado_cliente=1";

                select = new SqlCommand(comando, con);

                select.Parameters.AddWithValue("@codigo", codigo);

                reader = select.ExecuteReader();

                if (reader.Read())
                {
                    datosUser.Add(reader["nombre_cliente"].ToString());
                    datosUser.Add(reader["apellidos_cliente"].ToString());
                    datosUser.Add(reader["run_cliente"].ToString());
                    datosUser.Add(reader["celular_cliente"].ToString());
                    datosUser.Add(reader["lineaCredito_cliente"].ToString());
                    datosUser.Add(reader["descuento_cliente"].ToString());
                }
                else
                {

                }

                reader.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al intentar obtener los datos del cliente... " + ex);
            }

            return datosUser;
        }

        /************************* MOSTRAR DATOS TABLA ************************/

        //MOSTRAR DATOS DEL CLIENTE EN UN DATAGRIEDVIEW
        public void MostrarDatosClientes(DataGridView data, int auxVista)
        {
            String comando = "";
            switch (auxVista)
            {
                case 1:
                    //POR DEFECTO
                    comando = "select cl.id_cliente as 'Código', cl.nombre_cliente+' '+cl.apellidos_cliente as 'Nombre Cliente', cl.run_cliente as 'Run Cliente', " +
                                "cl.celular_cliente as 'Fono Cliente', cl.lineaCredito_cliente as 'Crédito Disponible', descuento_cliente as 'Descuento Aplicable' from Clientes cl where estado_cliente=1";
                    break;
                case 2:
                    //ALFABETICAMENTE A-Z
                    comando = "select cl.id_cliente as 'Código', cl.nombre_cliente+' '+cl.apellidos_cliente as 'Nombre Cliente', cl.run_cliente as 'Run Cliente', " +
                                "cl.celular_cliente as 'Fono Cliente', cl.lineaCredito_cliente as 'Crédito Disponible', descuento_cliente as 'Descuento Aplicable' from Clientes cl where estado_cliente=1 "+
                                    "order by 'Nombre Cliente' asc";
                    break;
                case 3:
                    //ALFABETICAMENTE Z-A
                    comando = "select cl.id_cliente as 'Código', cl.nombre_cliente+' '+cl.apellidos_cliente as 'Nombre Cliente', cl.run_cliente as 'Run Cliente', " +
                                "cl.celular_cliente as 'Fono Cliente', cl.lineaCredito_cliente as 'Crédito Disponible', descuento_cliente as 'Descuento Aplicable' from Clientes cl where estado_cliente=1 "+
                                    "order by 'Nombre Cliente' desc";
                    break;
                case 4:
                    //LINEA CREDITO MAYOR A MENOR
                    comando = "select cl.id_cliente as 'Código', cl.nombre_cliente+' '+cl.apellidos_cliente as 'Nombre Cliente', cl.run_cliente as 'Run Cliente', " +
                                "cl.celular_cliente as 'Fono Cliente', cl.lineaCredito_cliente as 'Crédito Disponible', descuento_cliente as 'Descuento Aplicable' from Clientes cl where estado_cliente=1 "+
                                    "order by 'Crédito Disponible' asc";
                    break;
                case 5:
                    //LINEA CREDITO MENOR A MAYOR
                    comando = "select cl.id_cliente as 'Código', cl.nombre_cliente+' '+cl.apellidos_cliente as 'Nombre Cliente', cl.run_cliente as 'Run Cliente', " +
                                "cl.celular_cliente as 'Fono Cliente', cl.lineaCredito_cliente as 'Crédito Disponible', descuento_cliente as 'Descuento Aplicable' from Clientes cl where estado_cliente=1 "+
                                    "order by 'Crédito Disponible' desc";
                    break;
                case 6:
                    //ELIMINADOS
                    comando = "select cl.id_cliente as 'Código', cl.nombre_cliente+' '+cl.apellidos_cliente as 'Nombre Cliente', cl.run_cliente as 'Run Cliente', " +
                                "cl.celular_cliente as 'Fono Cliente', cl.lineaCredito_cliente as 'Crédito Disponible', descuento_cliente as 'Descuento Aplicable' from Clientes cl where estado_cliente=0";
                    break;
            }
            
            try
            {

                DA = new SqlDataAdapter(comando, con);
                dt = new DataTable();
                DA.Fill(dt);

                data.DataSource = dt;

            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al intentar llenar el datagried. " + ex);

            }

        }

        //MOSTRAR DATOS DEL CLIENTE EN UN DATAGRIEDVIEW CON BUSQUEDA POR TECLADO
        public void MostrarDatosClientesBusqueda(DataGridView data, String texto)
        {
            String comando = "select cl.id_cliente as 'Código', cl.nombre_cliente+' '+cl.apellidos_cliente as 'Nombre Cliente', cl.run_cliente as 'Run Cliente', " +
                                "cl.celular_cliente as 'Fono Cliente', cl.lineaCredito_cliente as 'Crédito Disponible', descuento_cliente as 'Descuento Aplicable' from Clientes cl where estado_cliente=1 " +
                                    " and cl.nombre_cliente LIKE ('%" + texto + "%') or cl.apellidos_cliente LIKE ('%" + texto + "%') or cl.run_cliente LIKE ('%" + texto + "%') ";

            try
            {
                DA = new SqlDataAdapter(comando, con);
                dt = new DataTable();
                DA.Fill(dt);

                data.DataSource = dt;

            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al intentar llenar el datagried. " + ex);

            }

        }

        /************************* MODIFICAR ************************/

        //MODIFICAR LOS DATOS DE UN CLIENTE
        public Boolean ModificarDatosCliente(int codigoCli, String celular, int cred, int desc)
        {
            SqlCommand update;
            Boolean modificar = false;
            try
            {
                String comando = "update Clientes set celular_cliente=@celular, lineaCredito_cliente=@credito," +
                                    "descuento_cliente=@descuento where id_cliente=@codigo";
                update = new SqlCommand(comando, con);

                update.Parameters.Add("@celular", System.Data.SqlDbType.Char, 12).Value = celular;
                update.Parameters.Add("@credito", System.Data.SqlDbType.Int).Value = cred;
                update.Parameters.Add("@descuento", System.Data.SqlDbType.Int).Value = desc;
                update.Parameters.Add("@codigo", System.Data.SqlDbType.Int).Value = codigoCli;

                if (update.ExecuteNonQuery() == 1)
                {
                    modificar = true;
                }
                else
                {
                    modificar = false;
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al intentar modificar los datos del cliente... " + ex);
            }
            return modificar;
        }

        /************************* ELIMINACIÓN & REACTIVACIÓN ************************/

        //REACTIVAR UN CLIENTE
        public Boolean ReactivarCliente(int codigoCli)
        {
            SqlCommand update;
            Boolean modificar = false;
            try
            {
                String comando = "update Clientes set estado_cliente=1 where id_cliente=@codigo";
                update = new SqlCommand(comando, con);

                update.Parameters.Add("@codigo", System.Data.SqlDbType.Int).Value = codigoCli;

                if (update.ExecuteNonQuery() == 1)
                {
                    modificar = true;
                }
                else
                {
                    modificar = false;
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al intentar reactivar un cliente... " + ex);
            }
            return modificar;
        }

        //ELIMINAR CLIENTE
        public Boolean EliminarCliente(int codigoCli)
        {
            SqlCommand update;
            Boolean modificar = false;
            try
            {
                String comando = "update Clientes set estado_cliente=0 where id_cliente=@codigo";

                update = new SqlCommand(comando, con);

                update.Parameters.Add("@codigo", System.Data.SqlDbType.Int).Value = codigoCli;

                if (update.ExecuteNonQuery() == 1)
                {
                    modificar = true;
                }
                else
                {
                    modificar = false;
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al intentar eliminar los datos del cliente... " + ex);
            }
            return modificar;
        }

        /* ************************************************ DIRECCIONES ************************************************************************
           ************************************************************************************************************************************* */

        /************************* CREAR ************************/

        //CREAR UNA DIRECCIÓN NUEVA DE UN CLIENTE
        public Boolean AnexarDireccion(int codCliente, String direccion, String ciudad)
        {
            SqlCommand insert;
            Boolean exito = false;
            try
            {
                String comando = "insert into Direcciones (nombre_direccion, ciudad_direccion, idCliente_direccion) " +
                                            "values(@direccion, @ciudad, @idCli)";

                insert = new SqlCommand(comando, con);

                insert.Parameters.Add("@direccion", System.Data.SqlDbType.VarChar, 100).Value = direccion;
                insert.Parameters.Add("@ciudad", System.Data.SqlDbType.VarChar, 50).Value = ciudad;
                insert.Parameters.Add("@idCli", System.Data.SqlDbType.Int).Value = codCliente;

                if (insert.ExecuteNonQuery() == 1)
                {
                    exito = true;
                }
                else
                {
                    exito = false;
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al intentar anexar una dirección... " + ex);
                exito = false;
            }
            return exito;
        }

        /************************* OBTENER DATOS ************************/

        //OBTENER LOS DATOS DE LAS DIRECCIONES DE UN CLIENTE ARRAY
        public ArrayList ObtenerDireccionesCliente(int codigo)
        {
            SqlDataReader reader;
            ArrayList datosUser = new ArrayList();
            SqlCommand select;

            try
            {
                String comando = "select dir.id_direccion, dir.nombre_direccion, dir.ciudad_direccion from Direcciones dir, " +
                                    "Clientes cl where dir.idCliente_direccion=@codigo and cl.id_cliente=dir.idCliente_direccion";

                select = new SqlCommand(comando, con);

                select.Parameters.AddWithValue("@codigo", codigo);

                reader = select.ExecuteReader();

                while (reader.Read())
                {
                    datosUser.Add(reader["id_direccion"].ToString());
                    datosUser.Add(reader["nombre_direccion"].ToString());
                    datosUser.Add(reader["ciudad_direccion"].ToString());
                }

                reader.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al intentar obtener las direcciones de los clientes... " + ex);
            }

            return datosUser;
        }

        /************************* MODIFICAR ************************/

        //MODIFICAR LOS DATOS DE UNA DIRECCIÓN DE UN CLIENTE
        public Boolean ModificarDireccionCliente(int codDireccion, String direc, String ciud)
        {
            SqlCommand update;
            Boolean modificar = false;
            try
            {
                String comando = "update Direcciones set nombre_direccion=@direc, ciudad_direccion=@ciudad " +
                                    "where id_direccion=@codDire";
                update = new SqlCommand(comando, con);

                update.Parameters.Add("@direc", System.Data.SqlDbType.VarChar, 100).Value = direc;
                update.Parameters.Add("@ciudad", System.Data.SqlDbType.VarChar, 50).Value = ciud;
                update.Parameters.Add("@codDire", System.Data.SqlDbType.Int).Value = codDireccion;

                if (update.ExecuteNonQuery() == 1)
                {
                    modificar = true;
                }
                else
                {
                    modificar = false;
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al intentar modificar los datos de una dirección de un cliente... " + ex);
            }
            return modificar;
        }
    }
}
