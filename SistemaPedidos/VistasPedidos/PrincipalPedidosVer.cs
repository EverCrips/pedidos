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
    public partial class PrincipalPedidosVer : Form
    {

        /* ******************************** SISTEMA **************************************
           ******************************************************************************* */

        public PrincipalPedidosVer()
        {
            InitializeComponent();
        }

        //LOAD
        private void PrincipalPedidosVer_Load(object sender, EventArgs e)
        {
            ClasePedidos pedi = new ClasePedidos();
            pedi.MostrarPedidos(MostrarPedidos);
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

        //BUSCAR UN PEDIDO MEDIANTE TECLADO
        private void cajaBuscar_KeyUp(object sender, KeyEventArgs e)
        {
            ClasePedidos conad = new ClasePedidos();

            conad.MostrarPedidosBusqueda(MostrarPedidos, cajaBuscar.Text);
        }

        //MOSTRAR EL PEDIDO COMPLETO
        private void MostrarPedidos_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            int codiPedi = 0;
            DataGridViewRow fila = MostrarPedidos.CurrentRow; // obtengo la fila actualmente seleccionada en el dataGridView

            codiPedi = Convert.ToInt32(fila.Cells[0].Value); //obtengo el valor de la primer columna

            //SI EL CODIGO ESTA VACIO, ARROJAR ERROR
            if (codiPedi == 0)
            {
                MessageBox.Show("Error no controlado.");
            }
            else
            {
                PrincipalPedidosVerPedidos prin = new PrincipalPedidosVerPedidos(codiPedi);
                prin.ShowDialog();
              
            }
        }
    }
}
