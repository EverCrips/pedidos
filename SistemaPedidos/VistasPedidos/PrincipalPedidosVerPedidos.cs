//Diseñado y programado por Cristopher Pérez V. 18.973.714-9
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

namespace SistemaPedidos.VistasPedidos
{
    public partial class PrincipalPedidosVerPedidos : Form
    {
        /* ******************************** SISTEMA **************************************
           ******************************************************************************* */

        private int codiPedi = 0, descuentoCliente = 0;

        public PrincipalPedidosVerPedidos()
        {
            InitializeComponent();
        }

        public PrincipalPedidosVerPedidos(int cod)
        {
            // TODO: Complete member initialization
            codiPedi = cod;
            InitializeComponent();
        }


        //LOAD
        private void PrincipalPedidosVerPedidos_Load(object sender, EventArgs e)
        {
            ClasePedidos pc = new ClasePedidos();
            ArrayList are = new ArrayList();
            are = pc.ObtenerDatosPedidos(codiPedi);

            cajaNumeroPedido.Text = are[0].ToString();
            cajaFecha.Text = are[1].ToString();
            cajaNombre.Text = are[2].ToString() + " " + are[3].ToString(); ;
            cajaRun.Text = are[4].ToString();
            cajaCelular.Text = are[5].ToString();
            descuentoCliente = Convert.ToInt32(are[6]);
            cajaCiudad.Text = are[7].ToString();
            cajaDireccion.Text = are[8].ToString();
            cajaFormaPago.Text = are[9].ToString();

            pc.MostrarDetallesPedido(datosPedido, codiPedi);

            cajaNeto.Text = sumaNeto().ToString();
            cajaIva.Text = sumaIVA().ToString();
            cajaSubtotal.Text = sumaSubtotal().ToString();
            cajaDescuento.Text = sumaDescuento().ToString();
            cajaTotal.Text = sumaTotal().ToString();
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

        //OBTENER NETO
        private int sumaNeto()
        {
            int suma = 0;

            foreach (DataGridViewRow row in datosPedido.Rows)
            {
                suma = suma + Convert.ToInt32(row.Cells["PRECIO TOTAL"].Value);
            }

            return suma;
        }

        //OBTENER IVA
        private int sumaIVA()
        {
            int suma = 0;

            suma = (Convert.ToInt32(cajaNeto.Text) * 19) / 100;

            return suma;
        }

        //OBTENER SUBTOTAL
        private int sumaSubtotal()
        {
            int suma = 0;

            suma = Convert.ToInt32(cajaNeto.Text) + Convert.ToInt32(cajaIva.Text);

            return suma;
        }

        //OBTENER DESCUENTO
        private int sumaDescuento()
        {
            int suma = 0;

            suma = (Convert.ToInt32(cajaSubtotal.Text) * descuentoCliente) / 100;

            return suma;
        }

        //OBTENER TOTAL
        private int sumaTotal()
        {
            int suma = 0;

            suma = Convert.ToInt32(cajaSubtotal.Text) - Convert.ToInt32(cajaDescuento.Text);

            return suma;
        }


        /* ******************************** EVENTOS **************************************
           ******************************************************************************* */ 
    }
}
