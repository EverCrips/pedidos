using SistemaPedidos.ClasesSQL;
using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SistemaPedidos.VistasProductos
{
    public partial class PrincipalPedidosRegistrar : Form
    {
        private int creditoCliente = 0, descuentoCliente = 0, auxCodDireccionModificar=0;
        public PrincipalPedidosRegistrar()
        {
            InitializeComponent();
        }

        //BOTÓN SELECCIONAR UN CLIENTE
        private void botonCliente_Click(object sender, EventArgs e)
        {
            PrincipalPedidosSeleccionarCliente prin = new PrincipalPedidosSeleccionarCliente();
            if(prin.ShowDialog() == DialogResult.OK){
                int codCliente = 0;
                codCliente = prin.codCli;

                if(codCliente==0){
                    MessageBox.Show("Error no especificado.");
                }else{
                    limpiar();
                    ClaseClientes cla = new ClaseClientes();
                    ArrayList list = new ArrayList();
                    list = cla.ObtenerDatosCliente(codCliente);
                    cajaNombre.Text = list[0].ToString()+" "+list[1].ToString();
                    cajaRun.Text = list[2].ToString();
                    cajaCelular.Text = list[3].ToString();
                    creditoCliente = Convert.ToInt32(list[4]);
                    descuentoCliente = Convert.ToInt32(list[5]);

                    ArrayList dire = new ArrayList();
                    dire = cla.ObtenerDireccionesCliente(codCliente);

                    int con = dire.Count;
                    //ARRAY AUXILIARES
                    ArrayList cod = new ArrayList();
                    ArrayList direc = new ArrayList();
                    ArrayList ciud = new ArrayList();
                    //GUARDO TODOS LOS VALORES DE DIRECCIONES
                    for (int i = 0; i < con; i = i + 3)
                    {
                        cod.Add(dire[i].ToString());
                        direc.Add(dire[i + 1].ToString());
                        ciud.Add(dire[i + 2].ToString());
                    }
                    //AGREGO AL COMBOBOX
                    int auxcon = cod.Count;
                    for (int i = 0; i < auxcon; i++)
                    {
                        cajaDirecciones.Items.Add(cod[i].ToString() + "-" + ciud[i].ToString() + "-" + direc[i].ToString());
                    }
                    cajaDireccion.Text = dire[1].ToString();
                    cajaCiudad.Text = dire[2].ToString();
                }
                
            }
        }

        //SELECCIONAR UNA DIRECCION
        private void cajaDirecciones_SelectedIndexChanged(object sender, EventArgs e)
        {
            //ARREGLO PARA LA DIRECCION COMPLETA
            String[] separadas;

            //SEPARO MIENTRAS ENCUENTRE UN -
            separadas = cajaDirecciones.Text.Split('-');

            //GUARDO EN NUEVOS STRING
            cajaCiudad.Text = separadas[1];
            cajaDireccion.Text = separadas[2];
            auxCodDireccionModificar = Convert.ToInt32(separadas[0]);
        }

        //LIMPIAR CASILLAS Y CÓDIGOS AL SELECCIONAR UN CLIENTE NUEVO
        public void limpiar(){
            cajaCelular.Text = "";
            cajaCiudad.Text = "";
            cajaDireccion.Text = "";
            cajaDirecciones.Items.Clear();
            cajaNombre.Text = "";
            auxCodDireccionModificar = 0;
            creditoCliente = 0;
            descuentoCliente = 0;

        }

        //AGREGAR PRODUCTO
        private void botonAgregar_Click(object sender, EventArgs e)
        {
            PrincipalPedidosSeleccionarProducto prin = new PrincipalPedidosSeleccionarProducto();
            if (prin.ShowDialog() == DialogResult.OK)
            {
                int codProducto = 0;
                codProducto = prin.codPro;

                //VALIDO QUE NO EXISTA UN PRODUCTO YA INGRESADO (LA ID)
                Boolean exist = datosPedido.Rows.Cast<DataGridViewRow>().Any(row => Convert.ToString(row.Cells["CÓDIGO"].Value) == codProducto.ToString());

                if (exist)
                {
                    MessageBox.Show("El producto ya está ingresado.");
                }
                else
                {
                    limpiar();
                    ClaseProductos pro;
                    pro = new ClaseProductos();
                    ArrayList list = new ArrayList();
                    list = pro.ObtenerDatosProducto(codProducto);

                    //PRECIO VENTA DE LOS PRODUCTOS. SERÁ EL PRECIO DE COMPRA + EL 14%
                    int precioCompra  = Convert.ToInt32(list[2]);
                    int ganancia = (12 * precioCompra) / 100;
                    int precioVenta = precioCompra + ganancia;
                    //AGREGAR LA FILA CON EL PRODUCTO
                    datosPedido.Rows.Add(codProducto, list[0].ToString(), list[1].ToString(), 1, precioVenta, precioVenta);


                }

            }
        }

        //LOAD
        private void PrincipalPedidosRegistrar_Load(object sender, EventArgs e)
        {
            
        }

        //VALIDAR CANTIDAD VENTA
        public Boolean validarCantidadProducto(String num){
            try
            {
                Convert.ToInt32(num);
                return true;
            }
            catch (Exception ex)
            {
                return false;
            }
        }

        //SELECCIONAR UNA FILA
        private void datosPedido_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            int codProducto = 0;
            DataGridViewRow fila = datosPedido.CurrentRow; // obtengo la fila actualmente seleccionada en el dataGridView

            codProducto = Convert.ToInt32(fila.Cells[0].Value); //obtengo el valor de la primer columna

            String resp1 = Microsoft.VisualBasic.Interaction.InputBox(
                            "Seleccione una opción:" + "\n\r" + "\n\r" + " *(1) Quitar Producto" + "\n\r" + " *(2)Modificar Cantidad",
                            "Selección producto",
                            "");
            //DEPENDIENDO DE LA RESPUESTA INGRESADA
            switch (resp1)
            {
                case "1":
                    datosPedido.Rows.RemoveAt(datosPedido.CurrentRow.Index);
                    break;
                case "2":
                    ClaseProductos clas = new ClaseProductos();
                    ArrayList are = new ArrayList();
                    are = clas.ObtenerDatosProducto(codProducto);

                    String cantidad = Microsoft.VisualBasic.Interaction.InputBox(
                            "Agregue la cantidad a vender."+ "\n\r" +"Stock disponible: "+are[3].ToString()+" unidades",
                            "Cantidad a vender",
                            "");
                    int auxStock = Convert.ToInt32(are[3]);

                    if(validarCantidadProducto(cantidad)){
                        //ES UN NÚMERO. SE PROSIGUE
                        if(Convert.ToInt32(cantidad)==0){
                            MessageBox.Show("Cantidad 0 no es una opción.");
                        }else{
                            //SI ES MAYOR AL STOCK DISPONIBLE, ERROR.
                            if(Convert.ToInt32(cantidad) > auxStock )
                            {
                                //ES MAYOR AL STOCK, MENSAJE DE ERROR
                                MessageBox.Show("LA VENTA NO PUEDE SUPERAR AL STOCK DISPONIBLE.");
                            }else{
                                //ES MENOR, SE PUEDE VENDER
                                fila.Cells[3].Value = cantidad;
                                fila.Cells[5].Value = Convert.ToInt32(fila.Cells[3].Value) * Convert.ToInt32(fila.Cells[4].Value);
                            }
 
                        }
                    }else{
                        //NO ES UN NUMÉRO. NO SE PROSIGUE
                        MessageBox.Show("No hubo respuesta o no se respetaron las instrucciones.");
                    }
                    break;
                default:
                    MessageBox.Show("No hubo respuesta o no se respetaron las instrucciones.");
                    break;
            }
        }



    }
}
