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

namespace SistemaPedidos.VistasCliente
{
    public partial class PrincipalClientesVerModificar : Form
    {
        /* ******************************** SISTEMA **************************************
           ******************************************************************************* */
        private int auxcodi=0;
        private int auxCodDireccionModificar = 0;

        public PrincipalClientesVerModificar()
        {
            InitializeComponent();
        }
        
        //CONSTRUCTOR PARA OBTENER CODIGO CLIENTE
        public PrincipalClientesVerModificar(int codiCliente)
        {
            // TODO: Complete member initialization
            auxcodi = codiCliente;
            InitializeComponent();
        }

        //LOAD
        private void PrincipalClientesVerModificar_Load(object sender, EventArgs e)
        {
            //CAJAS DESABILITADAS
            cajaNombre.ReadOnly=true;
            cajaNombre.Enabled = false;
            cajaApellidos.ReadOnly = true;
            cajaApellidos.Enabled = false;
            cajaRun.ReadOnly = true;
            cajaRun.Enabled = false;

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

            //RECUPERO DATOS CLIENTE
            recuperarDatosCliente();

            //RECUPERO DATOS DIRECCIONES DEL CLIENTE
            recuperarDirecciones();
            
        }

        /* ******************************** BOTONES **************************************
           ******************************************************************************* */

        //BOTÓN ELIMINAR EL CLIENTE ACTUAL
        private void botonEliminar_Click(object sender, EventArgs e)
        {
            /*
             * INPUT BOX PARA IMPORTAR, IR A REFERENCES DEL PROYECTO, BUSCAR Microsoft.VisualBasic Y AGREGAR. PLANTILLA:
            string texto = Microsoft.VisualBasic.Interaction.InputBox(
                            "Texto de la pregunta",
                            "Titulo del diálogo",
                            "Respuesta por defecto");
                                                        */

            ClaseClientes cl = new ClaseClientes();
            String texto = Microsoft.VisualBasic.Interaction.InputBox(
                            "¿Desea eliminar el usuario actual?"+ "\n\r" + "\n\r" +" *(1) SI "+ "\n\r" +" *(2) NO",
                            "Eliminación registro cliente",
                            "");
            //DEPENDIENDO DE LA RESPUESTA INGRESADA
            switch(texto){
                case "1":
                    if(cl.EliminarCliente(auxcodi)){
                        MessageBox.Show("Se ha eliminado satisfactoriamente el cliente.");
                        this.Close();
                    }
                    else{
                        MessageBox.Show("Ha ocurrido un error al intentar eliminar el cliente actual. Intente nuevamente por favor.");
                    }
                    break;
                case "2":

                    break;
                default:
                        MessageBox.Show("No hubo respuesta o no se respetaron las instrucciones.");
                    break;
            }
        }

        //BOTÓN ANEXAR UNA NUEVA DIRECCIÓN AL CLIENTE ACTUAL
        private void botonAnexarDireccion_Click(object sender, EventArgs e)
        {
            PrincipalClientesVerModificarAnexarDireccion pra = new PrincipalClientesVerModificarAnexarDireccion(auxcodi);
            pra.ShowDialog();
            recuperarDatosCliente();
            cajaDirecciones.Items.Clear();
            recuperarDirecciones();
        }

        //GUARDAR CAMBIOS EFECTUADOS TANTO EN EL CLIENTE COMO EN LA DIRECCIÓN MISMA
        private void botonGuardar_Click(object sender, EventArgs e)
        {
            ClaseClientes cl = new ClaseClientes();
            if (cajaApellidos.Text == "" || cajaCelular.Text == "" || cajaCiudad.Text == "" || cajaCredito.Text == "" || cajaDescuento.Text == ""
                || cajaDireccion.Text == "" || cajaNombre.Text == "" || cajaRun.Text == "" || cajaDirecciones.Text == "")
            {
                MessageBox.Show("Por favor, rellene las casillas antes de modificar los datos del cliente.");
            }
            else
            {
                if (cl.ModificarDatosCliente(auxcodi, cajaCelular.Text, Convert.ToInt32(cajaCredito.Text), Convert.ToInt32(cajaDescuento.Text)))
                {
                    //SE MODIFICO EL CLIENTE, AHORA VAMOS CON LA DIRECCION ACTUAL
                    if (cl.ModificarDireccionCliente(auxCodDireccionModificar, cajaDireccion.Text, cajaCiudad.Text))
                    {
                        MessageBox.Show("Se han actualizado correctamente los datos del cliente.");
                        recuperarDatosCliente();
                        cajaDirecciones.Items.Clear();
                        recuperarDirecciones();
                    }
                    else
                    {
                        MessageBox.Show("Ha ocurrido un error al actualizar los datos del cliente (Dirección). Intente nuevamente por favor.");
                    }
                }
                else
                {
                    MessageBox.Show("Ha ocurrido un error al actualizar los datos del cliente. Intente nuevamente por favor.");
                }
            }
        }

        //BOTÓN ATRÁS
        private void botonAtras_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        /* ******************************** FUNCIONES **************************************
           ******************************************************************************* */

        //FUNCION LIMPIAR CASILLAS
        private void limpiarCasillas()
        {
            cajaApellidos.Text = "";
            cajaCelular.Text = "";
            cajaCredito.Items.Clear();
            cajaDescuento.Items.Clear();
            cajaCiudad.Text = "";
            cajaDireccion.Text = "";
            cajaNombre.Text = "";
            cajaRun.Text = "";
        }

        //FUNCIÓN OBTENER DIRECCIONES
        public void recuperarDirecciones()
        {
            ClaseClientes cl = new ClaseClientes();
            ArrayList dire = new ArrayList();
            dire = cl.ObtenerDireccionesCliente(auxcodi);

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

        //FUNCIÓN OBTENER DATOS DEL CLIENTE
        public void recuperarDatosCliente()
        {

            ClaseClientes cl;
            cl = new ClaseClientes();
            ArrayList list = new ArrayList();
            list = cl.ObtenerDatosCliente(auxcodi);
            cajaNombre.Text = list[0].ToString();
            cajaApellidos.Text = list[1].ToString();
            cajaRun.Text = list[2].ToString();
            cajaCelular.Text = list[3].ToString();
            cajaCredito.Text = list[4].ToString();
            cajaDescuento.Text = list[5].ToString();

        }

        /* ******************************** EVENTOS **************************************
           ******************************************************************************* */
       
        //AL MOMENTO DE SELECCIONAR UNA OPCIÓN
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

        //SOLO NUMERICOS
        private void cajaCelular_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!(char.IsNumber(e.KeyChar)) && (e.KeyChar != (char)Keys.Back))
            {
                e.Handled = true;
                return;
            }
        }

        //FORMATO DEL NUMERO
        private void cajaCelular_Validated(object sender, EventArgs e)
        {
            if (cajaCelular.Text == "")
            {
                cajaCelular.Text = "";
            }
            else
            {
                if(cajaCelular.Text.Length==12){
                    cajaCelular.Text = cajaCelular.Text;
                }else{
                    cajaCelular.Text = "+569"+cajaCelular.Text;
                }
                
            }   
        }

        //SOLO NÚMEROS EN CASILLA
        private void botonEliminar_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!(char.IsNumber(e.KeyChar)) && (e.KeyChar != (char)Keys.Back))
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
