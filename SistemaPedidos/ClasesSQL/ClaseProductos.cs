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
    class ClaseProductos : Conexion
    {
        //VARIABLES
        //rescatar tabla
        DataTable dt;
        //obetner tabla
        SqlDataAdapter DA;

        /* ************************************************ PRODUCTOS ************************************************************************
           ************************************************************************************************************************************* */

        /************************* CREAR ************************/

        //CREAR UN REGISTRO NUEVO PRODUCTO
        public Boolean RegistrarProducto(String nombrePro, String descripcionPro, int precioCompra, int cantidad, int empresa)
        {
            SqlCommand insert;
            Boolean registrar = false;
            try
            {
                String comando = "insert into Productos (estado_producto, nombre_producto, descripcion_producto, " +
                                    "precioCompra_producto, stock_producto, idProveedor_producto) values(1, @nombre, @descrip, @precio, @cantidad, @empresa)";

                insert = new SqlCommand(comando, con);

                insert.Parameters.Add("@nombre", System.Data.SqlDbType.VarChar, 50).Value = nombrePro;
                insert.Parameters.Add("@descrip", System.Data.SqlDbType.VarChar, 100).Value = descripcionPro;
                insert.Parameters.Add("@precio", System.Data.SqlDbType.Int).Value = precioCompra;
                insert.Parameters.Add("@cantidad", System.Data.SqlDbType.Int).Value = cantidad;
                insert.Parameters.Add("@empresa", System.Data.SqlDbType.Int).Value = empresa;

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
                MessageBox.Show("Error al intentar registrar un nuevo producto... " + ex);
                registrar = false;
            }
            return registrar;
        }

        /************************* VERIFICAR ************************/

        //VERIFICAR SI EXISTE UN PRODUCTO (estado_producto=1 & stock_producto>0)
        public Boolean VerificarExisteProducto(int codigo)
        {
            SqlCommand select;
            Boolean existe = false;

            try
            {
                String comando = "select count(*) from Productos where id_producto=@codigo and estado_producto=1 and stock_producto>0";
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
                MessageBox.Show("No existe dicho producto... " + ex);
            }
            return existe;
        }

        //VERIFICAR SI EXISTE UN PRODUCTO (estado_producto=1 & stock_productor=0)
        public Boolean VerificarStockProducto(int codigo)
        {
            SqlCommand select;
            Boolean existe = false;

            try
            {
                String comando = "select count(*) from Productos where id_producto=@codigo and estado_producto=1 and stock_producto=0";
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
                MessageBox.Show("No existe dicho producto... " + ex);
            }
            return existe;
        }

        /************************* OBTENER DATOS ************************/

        //OBTENER LOS DATOS DE UN PRODUCTO ARRAY 
        public ArrayList ObtenerDatosProducto(int codigo)
        {
            SqlDataReader reader;
            ArrayList datosUser = new ArrayList();
            SqlCommand select;

            try
            {
                String comando = "select pro.nombre_producto, pro.descripcion_producto, pro.precioCompra_producto, pro.stock_producto, " +
                                    "prov.nombre_proveedor from Productos pro, Proveedores prov where id_producto=@codigo and pro.idProveedor_producto=prov.id_proveedor " +
                                        "and estado_producto=1 and stock_producto>0";

                select = new SqlCommand(comando, con);

                select.Parameters.AddWithValue("@codigo", codigo);

                reader = select.ExecuteReader();

                if (reader.Read())
                {
                    datosUser.Add(reader["nombre_producto"].ToString());
                    datosUser.Add(reader["descripcion_producto"].ToString());
                    datosUser.Add(reader["precioCompra_producto"].ToString());
                    datosUser.Add(reader["stock_producto"].ToString());
                    datosUser.Add(reader["nombre_proveedor"].ToString());
                }
                else
                {

                }

                reader.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al intentar obtener los datos del producto... " + ex);
            }

            return datosUser;
        }

        /*************************MOSTRAR DATOS TABLA  ************************/

        //MOSTRAR DATOS DEL CLIENTE EN UN DATAGRIEDVIEW
        public void MostrarProductos(DataGridView data, int auxVista)
        {
            String comando = "";
            switch (auxVista)
            {
                case 1:
                    //POR DEFECTO
                    comando = "select pro.id_producto as 'Codigo Producto', pro.nombre_producto as 'Nombre Producto', pro.descripcion_producto as 'Descripción Producto', pro.precioCompra_producto as 'Precio Compra ', " +
                                "pro.stock_producto as 'Stock Producto', prov.nombre_proveedor as 'Proveedor' from Productos pro, Proveedores prov where pro.estado_producto=1 and pro.stock_producto>0 " +
                                    "and pro.idProveedor_producto=prov.id_proveedor";
                    break;
                case 2:
                    //ALFABETICAMENTE A-Z
                    comando = "select pro.id_producto as 'Codigo Producto', pro.nombre_producto as 'Nombre Producto', pro.descripcion_producto as 'Descripción Producto', pro.precioCompra_producto as 'Precio Compra ', " +
                                "pro.stock_producto as 'Stock Producto', prov.nombre_proveedor as 'Proveedor' from Productos pro, Proveedores prov where pro.estado_producto=1 and pro.stock_producto>0 " +
                                    "and pro.idProveedor_producto=prov.id_proveedor order by 'Nombre Producto' asc";
                    break;
                case 3:
                    //ALFABETICAMENTE Z-A
                    comando = "select pro.id_producto as 'Codigo Producto', pro.nombre_producto as 'Nombre Producto', pro.descripcion_producto as 'Descripción Producto', pro.precioCompra_producto as 'Precio Compra ', " +
                                "pro.stock_producto as 'Stock Producto', prov.nombre_proveedor as 'Proveedor' from Productos pro, Proveedores prov where pro.estado_producto=1 and pro.stock_producto>0 " +
                                    "and pro.idProveedor_producto=prov.id_proveedor order by 'Nombre Producto' desc";
                    break;
                case 4:
                    //STOCK MAYOR A MENOR
                    comando = "select pro.id_producto as 'Codigo Producto', pro.nombre_producto as 'Nombre Producto', pro.descripcion_producto as 'Descripción Producto', pro.precioCompra_producto as 'Precio Compra ', " +
                                "pro.stock_producto as 'Stock Producto', prov.nombre_proveedor as 'Proveedor' from Productos pro, Proveedores prov where pro.estado_producto=1 and pro.stock_producto>0 " +
                                    "and pro.idProveedor_producto=prov.id_proveedor order by 'Stock Producto' asc";
                    break;
                case 5:
                    //STOCK MENOR A MAYOR
                    comando = "select pro.id_producto as 'Codigo Producto', pro.nombre_producto as 'Nombre Producto', pro.descripcion_producto as 'Descripción Producto', pro.precioCompra_producto as 'Precio Compra ', " +
                                "pro.stock_producto as 'Stock Producto', prov.nombre_proveedor as 'Proveedor' from Productos pro, Proveedores prov where pro.estado_producto=1 and pro.stock_producto>0 " +
                                    "and pro.idProveedor_producto=prov.id_proveedor order by 'Stock Producto' desc";
                    break;
                case 6:
                    //ACTUALIZAR STOCK
                    comando = "select pro.id_producto as 'Codigo Producto', pro.nombre_producto as 'Nombre Producto', pro.descripcion_producto as 'Descripción Producto', pro.precioCompra_producto as 'Precio Compra ', " +
                                "pro.stock_producto as 'Stock Producto', prov.nombre_proveedor as 'Proveedor' from Productos pro, Proveedores prov where pro.estado_producto=1 and stock_producto=0 " +
                                    "and pro.idProveedor_producto=prov.id_proveedor";
                    break;
                case 7:
                    //REACTIVAR PRODUCTO
                    comando = "select pro.id_producto as 'Codigo Producto', pro.nombre_producto as 'Nombre Producto', pro.descripcion_producto as 'Descripción Producto', pro.precioCompra_producto as 'Precio Compra ', " +
                                "pro.stock_producto as 'Stock Producto', prov.nombre_proveedor as 'Proveedor' from Productos pro, Proveedores prov where pro.estado_producto=0 "+
                                    "and pro.idProveedor_producto=prov.id_proveedor";
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

        //MOSTRAR DATOS DE UN PRODUCTO EN UN DATAGRIEDVIEW CON BUSQUEDA POR TECLADO
        public void MostrarDatosProductosBusqueda(DataGridView data, String texto)
        {
            String comando = "select pro.id_producto as 'Codigo Producto', pro.nombre_producto as 'Nombre Producto', pro.descripcion_producto as 'Descripción Producto', pro.precioCompra_producto as 'Precio Compra', " +
                                "pro.stock_producto as 'Stock Producto', prov.nombre_proveedor as 'Proveedor' from Productos pro, Proveedores prov where pro.estado_producto=1 and pro.stock_producto>0 " +
                                    "and pro.idProveedor_producto=prov.id_proveedor and ( pro.descripcion_producto LIKE ('%" + texto + "%') or pro.nombre_producto LIKE ('%" + texto + "%') or prov.nombre_proveedor LIKE ('%" + texto + "%'))";

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

        //MODIFICAR LOS DATOS DE UN PRODUCTO
        public Boolean ModificarDatosProducto(int codigoPro, String nombre, String descrip, int precio, int canti)
        {
            SqlCommand update;
            Boolean modificar = false;
            try
            {
                String comando = "update Productos set nombre_producto=@nombre, descripcion_producto=@des," +
                                    "precioCompra_producto=@preci, stock_producto=@canti where id_producto=@codigo";
                update = new SqlCommand(comando, con);

                update.Parameters.Add("@nombre", System.Data.SqlDbType.VarChar, 50).Value = nombre;
                update.Parameters.Add("@des", System.Data.SqlDbType.VarChar, 100).Value = descrip;
                update.Parameters.Add("@preci", System.Data.SqlDbType.Int).Value = precio;
                update.Parameters.Add("@canti", System.Data.SqlDbType.Int).Value = canti;
                update.Parameters.Add("@codigo", System.Data.SqlDbType.Int).Value = codigoPro;

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

        //ACTUALIZAR STOCK PRODUCTO
        public Boolean AgregarStock(int codigoPro, int stock)
        {
            SqlCommand update;
            Boolean modificar = false;
            try
            {
                String comando = "update Productos set stock_producto=@stock where id_producto=@codigo";
                update = new SqlCommand(comando, con);

                update.Parameters.Add("@codigo", System.Data.SqlDbType.Int).Value = codigoPro;
                update.Parameters.Add("@stock", System.Data.SqlDbType.Int).Value = stock;

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
                MessageBox.Show("Error al intentar actualizar el stock de un producto... " + ex);
            }
            return modificar;
        }

        /************************* ELIMINACIÓN & REACTIVACIÓN ************************/

        //REACTIVAR PRODUCTO
        public Boolean ReactivarProducto(int codigoPro)
        {
            SqlCommand update;
            Boolean modificar = false;
            try
            {
                String comando = "update Productos set estado_producto=1 where id_producto=@codigo";
                update = new SqlCommand(comando, con);

                update.Parameters.Add("@codigo", System.Data.SqlDbType.Int).Value = codigoPro;
  
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
                MessageBox.Show("Error al intentar actualizar el stock de un producto... " + ex);
            }
            return modificar;
        }

        //ELIMINAR PRODUCTO
        public Boolean EliminarProducto(int codigoPro)
        {
            SqlCommand update;
            Boolean modificar = false;
            try
            {
                String comando = "update Productos set estado_producto=0 where id_producto=@codigo";

                update = new SqlCommand(comando, con);

                update.Parameters.Add("@codigo", System.Data.SqlDbType.Int).Value = codigoPro;

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
                MessageBox.Show("Error al intentar eliminar un producto... " + ex);
            }
            return modificar;
        }
    }
}
