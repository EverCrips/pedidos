//Diseñado y programado por Cristopher Pérez V. 18.973.714-9
using SistemaPedidos.ClasesSQL;
using SistemaPedidos.VistasCliente;
using SistemaPedidos.VistasPedidos;
using SistemaPedidos.VistasProductos;
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

namespace SistemaPedidos
{
    public partial class VistaPrincipal : Form
    {
        /* ******************************** SISTEMA **************************************
           ******************************************************************************* */
        public VistaPrincipal()
        {
            InitializeComponent();
        }

        //LOAD
        private void VistaPrincipal_Load(object sender, EventArgs e)
        {
            ConsultasGenerales cone = new ConsultasGenerales();
            ArrayList arr = new ArrayList();
            arr = cone.ObtenerDatosUsuario();
            String nombre = "", run = "";
            nombre = arr[0].ToString();
            run = arr[1].ToString();

            textoVendedor.Text = "VENDEDOR: " + nombre + "*-*" + run;
        }

        /* ******************************** BOTONES **************************************
           ******************************************************************************* */

        //BOTÓN ATRÁS
        private void botonAtras_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        //BOTÓN PANEL CLIENTES
        private void botonClientes_Click(object sender, EventArgs e)
        {
            this.Hide();
            PrincipalClientes prins = new PrincipalClientes();
            prins.ShowDialog();
            this.Show();
        }

        //BOTÓN PRODUCTOS
        private void botonProductos_Click(object sender, EventArgs e)
        {
            this.Hide();
            PrincipalProductos prins = new PrincipalProductos();
            prins.ShowDialog();
            this.Show();        
        }

        //BOTÓN PEDIDOS
        private void botonPedidos_Click(object sender, EventArgs e)
        {
            this.Hide();
            PrincipalPedidos prins = new PrincipalPedidos();
            prins.ShowDialog();
            this.Show(); 
        }

        /* ******************************** FUNCIONES **************************************
           ******************************************************************************* */


        /* ******************************** EVENTOS **************************************
           ******************************************************************************* */
    }
}
