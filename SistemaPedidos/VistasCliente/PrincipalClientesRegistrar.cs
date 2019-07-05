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

namespace SistemaPedidos.VistasCliente
{
    public partial class PrincipalClientesRegistrar : Form
    {
        /* ******************************** SISTEMA **************************************
           ******************************************************************************* */
        public PrincipalClientesRegistrar()
        {
            InitializeComponent();
        }

        //LOAD
        private void PrincipalClientesRegistrar_Load(object sender, EventArgs e)
        {
            

            //CRÉDITO DISPONIBLE
            cajaCredito.Items.Add("0");
            cajaCredito.Items.Add("200000");
            cajaCredito.Items.Add("500000");
            cajaCredito.Items.Add("1000000");
            cajaCredito.Items.Add("1500000");
            cajaCredito.Items.Add("2000000");
            cajaCredito.Items.Add("3000000");

            //DESCUENTOS APLICABLES
            cajaDescuento.Items.Add("0");
            cajaDescuento.Items.Add("5");
            cajaDescuento.Items.Add("10");
            cajaDescuento.Items.Add("15");
            cajaDescuento.Items.Add("20");
            cajaDescuento.Items.Add("35");
        }

        /* ******************************** BOTONES **************************************
           ******************************************************************************* */

        //BOTON REGISTRAR
        private void botonGuardar_Click(object sender, EventArgs e)
        {
            ClaseClientes cla = new ClaseClientes();
            if(cajaApellidos.Text =="" || cajaCelular.Text == "" || cajaCredito.Text =="" || cajaDireccion.Text =="" || cajaNombre.Text =="" || cajaRun.Text =="" 
                || cajaDescuento.Text =="" || cajaCredito.Text =="" || cajaCiudad.Text ==""){
                MessageBox.Show("Rellene las casillas antes de registrar un cliente.");
            }else{
                //COMPRUEBO QUE NO EXISTA UN CLIENTE CON DICHO RUNS
                if(cla.VerificarExisteRunCliente(cajaRun.Text)){
                    MessageBox.Show("El run ya está registrado. Intente nuevamente por favor.");
                }else{
                    //REALIZO EL INGRESO DEL CLIENTE Y OBTENGO SU ID
                    String auxCod = cla.RegistrarCliente(cajaNombre.Text, cajaApellidos.Text, cajaRun.Text, cajaCelular.Text, Convert.ToInt32(cajaCredito.Text), Convert.ToInt32(cajaDescuento.Text));
                    if (auxCod == "")
                    {
                        //SI EL CODIGO ES "", ALGO OCURRIO
                        MessageBox.Show("Ha ocurrido un error al intentar registrar un cliente. Intente nuevamente por favor.");
                    }
                    else
                    {
                        //SE REALIZO CON ÉXITO EL CLIENTE.
                        if (cla.AnexarDireccion(Convert.ToInt32(auxCod), cajaDireccion.Text, cajaCiudad.Text))
                        {
                            //SE REALIZÓ CON ÉXITO EL ANEXO DE LA DIRECCIÓN Y EL CLIENTE
                            MessageBox.Show("Se ha registro con éxito el cliente.");
                        }
                        else
                        {
                            //ALGO OCURRIÓ
                            MessageBox.Show("Ha ocurrido un error al anexar la dirección al cliente. Intente nuevamente por favor.");
                        }

                    }
                }
                
                limpiarCasillas();
            }
        }

        //BOTÓN ATRÁS
        private void botonAtras_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        //BOTÓN LIMPIAR
        private void botonLimpiar_Click(object sender, EventArgs e)
        {
            limpiarCasillas();
        }

        /* ******************************** FUNCIONES **************************************
           ******************************************************************************* */

        //FUNCION LIMPIAR CASILLAS
        private void limpiarCasillas()
        {
            cajaApellidos.Text = "";
            cajaCelular.Text = "";
            cajaCredito.SelectedIndex = -1;
            cajaDescuento.SelectedIndex = -1;
            cajaCiudad.Text = "";
            cajaDireccion.Text = "";
            cajaNombre.Text = "";
            cajaRun.Text = "";
        }

        //FUNCIÓN FORMATO RUN
        public string formatearRun(string run)
        {
            int cont = 0;
            string format;
            if (run.Length == 0)
            {
                return "";
            }
            else
            {
                run = run.Replace(".", "");
                run = run.Replace("-", "");
                format = "-" + run.Substring(run.Length - 1);
                for (int i = run.Length - 2; i >= 0; i--)
                {
                    format = run.Substring(i, 1) + format;
                    cont++;
                    if (cont == 3 && i != 0)
                    {
                        format = "." + format;
                        cont = 0;
                    }
                }
                return format;
            }
        }

        /* ******************************** EVENTOS **************************************
           ******************************************************************************* */

        //VALIDACIÓN RUN
        private void cajaRun_Validated(object sender, EventArgs e)
        {
           
                cajaRun.Text = formatearRun(cajaRun.Text);
          
        }

        //FORMATO CELULAR
        private void cajaCelular_Validated(object sender, EventArgs e)
        {
            if(cajaCelular.Text ==""){
                cajaCelular.Text ="";
            }else{
                cajaCelular.Text = "+569" + cajaCelular.Text;
            }       
        }

        //SOLO NÚMEROS EN CASILLA CELULAR
        private void cajaCelular_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!(char.IsNumber(e.KeyChar)) && (e.KeyChar != (char)Keys.Back))
            {
                e.Handled = true;
                return;
            }
        }

        //SOLO LETRAS
        private void cajaNombre_KeyPress(object sender, KeyPressEventArgs e)
        {

            if (!(char.IsLetter(e.KeyChar)) && (e.KeyChar != (char)Keys.Back) && (e.KeyChar != (char)Keys.Space))
            {
                e.Handled = true;
                return;
            }

        }

        //SOLO LETRAS
        private void cajaApellidos_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!(char.IsLetter(e.KeyChar)) && (e.KeyChar != (char)Keys.Back) && (e.KeyChar != (char)Keys.Space))
            {
                e.Handled = true;
                return;
            }
        }

        //SOLO LETRAS
        private void cajaCiudad_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!(char.IsLetter(e.KeyChar)) && (e.KeyChar != (char)Keys.Back) && (e.KeyChar != (char)Keys.Space))
            {
                e.Handled = true;
                return;
            }
        }


    }
}
