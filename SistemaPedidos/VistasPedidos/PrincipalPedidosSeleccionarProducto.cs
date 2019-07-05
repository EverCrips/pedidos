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

namespace SistemaPedidos.VistasProductos
{
    public partial class PrincipalPedidosSeleccionarProducto : Form
    {
        /* ******************************** SISTEMA **************************************
           ******************************************************************************* */

        public int codPro { get; set; }
        public PrincipalPedidosSeleccionarProducto()
        {
            InitializeComponent();
        }

        //LOAD
        private void PrincipalPedidosSeleccionarProducto_Load(object sender, EventArgs e)
        {
            //OPCIONES DE VISUALIZACIÓN DE CLIENTES
            cajaVerPor.Items.Add("POR DEFECTO");
            cajaVerPor.Items.Add("NOMBRE PRODUCTO, A -> Z");
            cajaVerPor.Items.Add("NOMBRE PRODUCTO, Z -> A");
            cajaVerPor.Items.Add("STOCK DISPONIBLE, 0 -> XXX");
            cajaVerPor.Items.Add("STOCK DISPONIBLE, XXX -> 0");

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


        /* ******************************** EVENTOS **************************************
           ******************************************************************************* */
       
        //SELECCIONAR COMBOBOX
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
                default:
                    conad.MostrarProductos(MostrarProductos, 1);
                    break;
            }
        }

        //BÚSQUEDA DE PRODUCTO VIA TECLADO
        private void cajaBuscar_KeyUp(object sender, KeyEventArgs e)
        {
            ClaseProductos conad = new ClaseProductos();

            conad.MostrarDatosProductosBusqueda(MostrarProductos, cajaBuscar.Text);
        }

        //SELECCIONAR UN PRODUCTO Y DEVOLVER LA ID PARA AGREGARLO AL PEDIDO
        private void MostrarProductos_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
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
                codPro = codiPro;
                DialogResult = DialogResult.OK;
                this.Close();
            }
        }
    }
}
