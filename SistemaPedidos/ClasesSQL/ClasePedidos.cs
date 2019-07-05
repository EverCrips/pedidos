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
    class ClasePedidos : Conexion
    {
        //VARIABLES
        //rescatar tabla
        DataTable dt;
        //obetner tabla
        SqlDataAdapter DA;

        /* ************************************************ PRODUCTOS ************************************************************************
           ************************************************************************************************************************************* */

        /* ************************************************ CLIENTES ************************************************************************
           ************************************************************************************************************************************* */

        /************************* MODIFICAR ************************/

        //MODIFICAR EL CREDITO DEL CLIENTE
        public Boolean ModificarCreditoCliente(int codigoCli, int auxCredito)
        {
            SqlCommand update;
            Boolean modificar = false;
            try
            {
                String comando = "update Clientes set lineaCredito_cliente=@credito where id_cliente=@codigo";

                update = new SqlCommand(comando, con);

                update.Parameters.Add("@credito", System.Data.SqlDbType.Int).Value = auxCredito;
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


        /* ************************************************ PEDIDOS ************************************************************************
           ************************************************************************************************************************************* */

        /************************* CREAR ************************/

        //CREAR UN REGISTRO DE PEDIDO
        public String RegistrarPedido(String fecha, int codCliente, String codFormaPago, int codDireccion)
        {
            SqlCommand insert;
            String codi = "";
            try
            {
                String comando = "insert into Pedidos (fecha_pedido, estado_pedido, auxDireccion_pedido, idCliente_pedido, " +
                                    "codigoVendedor_pedido, codigoFormaPago_pedido) values(@fecha, 'REALIZADO', @auxDire, @codCliente, 'VENDE00001', @codFormaPago);" +
                                        "SELECT SCOPE_IDENTITY();";

                insert = new SqlCommand(comando, con);

                insert.Parameters.Add("@fecha", System.Data.SqlDbType.Date).Value = fecha;
                insert.Parameters.Add("@auxDire", System.Data.SqlDbType.Int).Value = codDireccion;
                insert.Parameters.Add("@codCliente", System.Data.SqlDbType.Char, 10).Value = codCliente;
                insert.Parameters.Add("@codFormaPago", System.Data.SqlDbType.Char, 5).Value = codFormaPago;

                codi = insert.ExecuteScalar().ToString();

            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al intentar registrar el pedido... " + ex);
                codi = "";
            }
            return codi;
        }

        /************************* OBTENER DATOS ************************/

        //OBTENER LOS DATOS DE UN PEDIDO ARRAY
        public ArrayList ObtenerDatosPedidos(int codigo)
        {
            SqlDataReader reader;
            ArrayList datosUser = new ArrayList();
            SqlCommand select;

            try
            {
                String comando = "select pd.id_pedido, pd.fecha_pedido, cl.nombre_cliente, cl.apellidos_cliente, cl.run_cliente, cl.celular_cliente, cl.descuento_cliente, " +
                                    "dir.ciudad_direccion, dir.nombre_direccion, fo.nombre_formaPago from Pedidos pd, Clientes cl, Direcciones dir, FormaPago fo " +
                                        "where pd.idCliente_pedido=cl.id_cliente and pd.codigoFormaPago_pedido=fo.codigo_formaPago and dir.idCliente_direccion=cl.id_cliente " +
                                            "and pd.id_pedido=@codPed and dir.id_direccion=pd.auxDireccion_pedido";

                select = new SqlCommand(comando, con);

                select.Parameters.AddWithValue("@codPed", codigo);

                reader = select.ExecuteReader();

                if (reader.Read())
                {
                    datosUser.Add(reader["id_pedido"].ToString());
                    datosUser.Add(reader["fecha_pedido"].ToString());
                    datosUser.Add(reader["nombre_cliente"].ToString());
                    datosUser.Add(reader["apellidos_cliente"].ToString());
                    datosUser.Add(reader["run_cliente"].ToString());
                    datosUser.Add(reader["celular_cliente"].ToString());
                    datosUser.Add(reader["descuento_cliente"].ToString());
                    datosUser.Add(reader["ciudad_direccion"].ToString());
                    datosUser.Add(reader["nombre_direccion"].ToString());
                    datosUser.Add(reader["nombre_formaPago"].ToString());
                }
                else
                {

                }

                reader.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al intentar obtener los datos del pedido... " + ex);
            }

            return datosUser;
        }

        //OBTENER LOS DATOS DE UN PRODUCTO ARRAY 
        public String ObtenerCodigoPedido()
        {
            SqlDataReader reader;
            String codigoPedido = "";
            SqlCommand select;

            try
            {
                String comando = "select top(1) id_pedido from Pedidos order by id_pedido desc";

                select = new SqlCommand(comando, con);

                reader = select.ExecuteReader();

                if (reader.Read())
                {
                    codigoPedido = reader["id_pedido"].ToString();
                }
                else
                {
                    codigoPedido = null;
                }

                reader.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al intentar obtener el codigo del pedido... " + ex);
            }

            return codigoPedido;
        }

        /*************************MOSTRAR DATOS TABLA  ************************/

        //MOSTRAR LOS DATOS DEL PEDIDO EN UN DATAGRIEDVIEW
        public void MostrarPedidos(DataGridView data)
        {
            String comando = "select pd.id_pedido as 'Número Pedido', pd.fecha_pedido as 'Fecha', cl.nombre_cliente as 'Nombre Cliente', cl.apellidos_cliente as 'Apellido Cliente', " +
                                "cl.run_cliente as 'Run Cliente'  from Pedidos pd, Clientes cl where pd.idCliente_pedido=cl.id_cliente";

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

        //MOSTRAR DATOS DEL PEDIDO EN UN DATAGRIEDVIEW CON BUSQUEDA POR TECLADO
        public void MostrarPedidosBusqueda(DataGridView data, String texto)
        {
            String comando = "select pd.id_pedido as 'Número Pedido', pd.fecha_pedido as 'Fecha', cl.nombre_cliente as 'Nombre Cliente', cl.apellidos_cliente as 'Apellido Cliente', " +
                                "cl.run_cliente as 'Run Cliente'  from Pedidos pd, Clientes cl where pd.idCliente_pedido=cl.id_cliente and ( cl.nombre_cliente LIKE ('%" + texto + "%') " +
                                    "or cl.apellidos_cliente LIKE ('%" + texto + "%')  or pd.fecha_pedido LIKE('%" + texto + "%') )  ";

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

        /* ************************************************ DETALLES PEDIDOS ************************************************************************
           ************************************************************************************************************************************* */

        /************************* CREAR ************************/

        //REGISTRAR LOS DETALLES DEL PEDIDO
        public Boolean RegistrarDetallePedido(int cantidadProducto, int total, int idPedido, int idProducto, int precioUni)
        {
            SqlCommand insert;
            Boolean registrar = false;
            try
            {
                String comando = "insert into DetallesPedidos (cantidadProducto_detallePedido, precioUnitario_detallePedido, precioTotal_detallePedido, idPedido_detallePedido, " +
                                    "idProducto_detallePedido) values(@cantidad, @unit, @total, @idPedido, @idProducto)";

                insert = new SqlCommand(comando, con);

                insert.Parameters.Add("@cantidad", System.Data.SqlDbType.Int).Value = cantidadProducto;
                insert.Parameters.Add("@unit", System.Data.SqlDbType.Int).Value = precioUni;
                insert.Parameters.Add("@total", System.Data.SqlDbType.Int).Value = total;
                insert.Parameters.Add("@idPedido", System.Data.SqlDbType.Int).Value = idPedido;
                insert.Parameters.Add("@idProducto", System.Data.SqlDbType.Int).Value = idProducto;

                if (insert.ExecuteNonQuery() == 1)
                {
                    registrar = true;
                }
                else
                {
                    registrar = false;
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al intentar registrar el detalle del pedido... " + ex);
                registrar = false;
            }
            return registrar;
        }

        /************************* MOSTRAR TABLA ************************/

        //MOSTRAR DATOS DEL DETALLE DEL PEDIDO COMO DATAGRIEDVIEW
        public void MostrarDetallesPedido(DataGridView data, int codPedido)
        {
            String comando = "select pro.id_producto as 'CÓDIGO PRODUCTO', pro.nombre_producto as 'NOMBRE PRODUCTO', pro.descripcion_producto as 'DESCRIPCIÓN PRODUCTO', "+       
			                    "dt.cantidadProducto_detallePedido as 'CANTIDAD PRODUCTO', dt.precioUnitario_detallePedido as 'PRECIO UNITARIO', dt.precioTotal_detallePedido as 'PRECIO TOTAL'	"+
                                    "from DetallesPedidos dt, Pedidos pd, Productos pro where dt.idPedido_detallePedido=pd.id_pedido and dt.idProducto_detallePedido=pro.id_producto and dt.idPedido_detallePedido='"+codPedido+"'";

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
    }
}
