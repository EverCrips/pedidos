//Diseñado y programado por Cristopher Pérez V. 18.973.714-9
using SistemaPedidos.ClasesSQL;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SistemaPedidos.VistasPedidos
{
    public partial class PrincipalProductosVer : Form
    {
        /* ******************************** SISTEMA **************************************
           ******************************************************************************* */
        public PrincipalProductosVer()
        {
            InitializeComponent();
        }


        //LOAD
        private void PrincipalProductosVer_Load(object sender, EventArgs e)
        {
            //OPCIONES DE VISUALIZACIÓN DE CLIENTES
            cajaVerPor.Items.Add("POR DEFECTO");
            cajaVerPor.Items.Add("NOMBRE PRODUCTO, A -> Z");
            cajaVerPor.Items.Add("NOMBRE PRODUCTO, Z -> A");
            cajaVerPor.Items.Add("STOCK DISPONIBLE, 0 -> XXX");
            cajaVerPor.Items.Add("STOCK DISPONIBLE, XXX -> 0");
            cajaVerPor.Items.Add("PRODUCTOS SIN STOCK");
            cajaVerPor.Items.Add("PRODUCTOS ELIMINADOS");

            ClaseProductos conad = new ClaseProductos();
            conad.MostrarProductos(MostrarProductos, 1);
        }

        /* ******************************** BOTONES **************************************
           ******************************************************************************* */

        //BOTÓN ATRÁS
        private void botonAtras_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        /* ******************************** FUNCIONES **************************************
           ******************************************************************************* */

        //FUNCIÓN VALIDACIÓN INGRESO DE STOCK
        private Boolean validacionStock(String stock)
        {
            int num;
            try
            {
                num = Convert.ToInt32(stock);
                return true;
            }
            catch (Exception ex)
            {
                return false;
            }
        }

        /* ******************************** EVENTOS **************************************
           ******************************************************************************* */

        //SELECCIÓN DE VER PRODUCTOS POR
        private void cajaVerPor_SelectedIndexChanged(object sender, EventArgs e)
        {
            ClaseProductos conad = new ClaseProductos();
            switch (cajaVerPor.Text)
            {
                case "POR DEFECTO":
                    conad.MostrarProductos(MostrarProductos, 1);
                    break;
                case "NOMBRE PRODUCTO, A -> Z":
                    conad.MostrarProductos(MostrarProductos, 2);
                    break;
                case "NOMBRE PRODUCTO, Z -> A":
                    conad.MostrarProductos(MostrarProductos, 3);
                    break;
                case "STOCK DISPONIBLE, 0 -> XXX":
                    conad.MostrarProductos(MostrarProductos, 4);
                    break;
                case "STOCK DISPONIBLE, XXX -> 0":
                    conad.MostrarProductos(MostrarProductos, 5);
                    break;
                case "PRODUCTOS SIN STOCK":
                    conad.MostrarProductos(MostrarProductos, 6);
                    break;
                case "PRODUCTOS ELIMINADOS":
                    conad.MostrarProductos(MostrarProductos, 7);
                    break;
                default:
                    conad.MostrarProductos(MostrarProductos, 1);
                    break;
            }
        }

        //CLICKEAR EN UN PRODUCTO
        private void MostrarProductos_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            int codiPro = 0;
            DataGridViewRow fila = MostrarProductos.CurrentRow; // obtengo la fila actualmente seleccionada en el dataGridView

            codiPro = Convert.ToInt32(fila.Cells[0].Value); //obtengo el valor de la primer columna

            //SI EL CODIGO ESTA VACIO, ARROJAR ERROR
            if (codiPro == 0)
            {
                MessageBox.Show("Error no controlado.");
            }
            else
            {
                //COMPRUEBO QUE EL PRODUCTO EXISTA Y QUE SU STOCK SEA MAYOR A 0
                ClaseProductos pro = new ClaseProductos();
                if (pro.VerificarExisteProducto(codiPro))
                {
                    PrincipalProductosVerModificar prin = new PrincipalProductosVerModificar(codiPro);
                    prin.ShowDialog();
                    ClaseProductos conad = new ClaseProductos();
                    conad.MostrarProductos(MostrarProductos, 1);
                }
                else
                {
                    //COMPRUEBO QUE EL PRODUCTO EXISTA Y SU STOCK SEA IGUAL A 0
                    if(pro.VerificarStockProducto(codiPro)){
                        //SI EXISTE, SE PODRÁ ACTUALIZAR SU STOCK
                        ClaseProductos conad = new ClaseProductos();
                        //SI NO EXISTE EL PRODUCTO, SE PODRÁ ACTUALIZAR EL STOCK
                        String texto = Microsoft.VisualBasic.Interaction.InputBox(
                                        "¿Desea agregar stock al producto seleccionado?" + "\n\r" + "\n\r" + " *(1) SI " + "\n\r" + " *(2) NO",
                                        "Reposición stock",
                                        "");
                        //DEPENDIENDO DE LA RESPUESTA INGRESADA
                        switch (texto)
                        {
                            case "1":
                                //SE PODRÁ ACTUALIZAR EL STOCK
                                String stock = Microsoft.VisualBasic.Interaction.InputBox(
                                                "Ingrese cantidad de stock a reponer",
                                                "Reposición stock",
                                                "");
                                if (validacionStock(stock))
                                {
                                    //STRING INGRESADO ES NUMÉRICO
                                    if (conad.AgregarStock(codiPro, Convert.ToInt32(stock)))
                                    {
                                        MessageBox.Show("Stock actualizado correctamente.");
                                        conad.MostrarProductos(MostrarProductos, 1);
                                    }
                                    else
                                    {
                                        MessageBox.Show("Ha ocurrido un error al intentar actualizar el stock del producto. Intente nuevamente por favor.");
                                    }
                                }
                                else
                                {
                                    //STRING INGRESADO NO ES NUMÉRICO
                                    MessageBox.Show("Stock basado en solo números. Ingrese un número válido");
                                }
                                break;
                            case "2":

                                break;
                            default:
                                MessageBox.Show("No hubo respuesta o no se respetaron las instrucciones.");
                                break;
                        }
                    }else{
                        //NO EXISTE, SE PODRÁ ACTIVAR NUEVAMENTE
                        ClaseProductos p = new ClaseProductos();
                        String texto = Microsoft.VisualBasic.Interaction.InputBox(
                                    "¿Desea reactivar el producto seleccionado?" + "\n\r" + "\n\r" + " *(1) SI " + "\n\r" + " *(2) NO",
                                    "Reactivación Producto",
                                    "");
                        //DEPENDIENDO DE LA RESPUESTA INGRESADA
                        switch (texto)
                        {
                            case "1":
                                if (p.ReactivarProducto(codiPro))
                                {
                                    MessageBox.Show("Producto reactivado nuevamente.");
                                    p.MostrarProductos(MostrarProductos, 1);
                                }
                                else
                                {
                                    MessageBox.Show("Ha ocurrido un error al intentar reactivar el producto actual. Intente nuevamente por favor.");
                                }
                                break;
                            case "2":

                                break;
                            default:
                                MessageBox.Show("No hubo respuesta o no se respetaron las instrucciones.");
                                break;
                        }
  
                    }
                    
                }
            }
        }

        //BÚSQUEDA DE PRODUCTOS
        private void cajaBuscar_KeyUp(object sender, KeyEventArgs e)
        {
            ClaseProductos conad = new ClaseProductos();

            conad.MostrarDatosProductosBusqueda(MostrarProductos, cajaBuscar.Text);
        }
    }
}
