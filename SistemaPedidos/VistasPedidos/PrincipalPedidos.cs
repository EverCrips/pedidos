//Diseñado y programado por Cristopher Pérez V. 18.973.714-9
using SistemaPedidos.VistasPedidos;
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
    public partial class PrincipalPedidos : Form
    {
        /* ******************************** SISTEMA **************************************
         ******************************************************************************* */

        public PrincipalPedidos()
        {
            InitializeComponent();
        }

        /* ******************************** BOTONES **************************************
         ******************************************************************************* */

        //BOTÓN ATRÁS
        private void botonAtras_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        //BOTÓN REGISTRAR UN NEUVO PEDIDO
        private void botonRegistro_Click(object sender, EventArgs e)
        {
            PrincipalPedidosRegistrar prin = new PrincipalPedidosRegistrar();
            prin.ShowDialog();
        }

        /* ******************************** FUNCIONES **************************************
         ******************************************************************************* */


        /* ******************************** EVENTOS **************************************
         ******************************************************************************* */  

        //VER REGISTEOS
        private void botonVer_Click(object sender, EventArgs e)
        {
            PrincipalPedidosVer prin = new PrincipalPedidosVer();
            prin.ShowDialog();
        }
    }
}
