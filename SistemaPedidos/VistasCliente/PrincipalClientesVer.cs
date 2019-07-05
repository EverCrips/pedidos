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
    public partial class PrincipalClientesVer : Form
    {
        /* ******************************** SISTEMA **************************************
           ******************************************************************************* */
        public PrincipalClientesVer()
        {
            InitializeComponent();
        }

        //LOAD
        private void PrincipalClientesVer_Load(object sender, EventArgs e)
        {
            //OPCIONES DE VISUALIZACIÓN DE CLIENTES
            cajaVerPor.Items.Add("POR DEFECTO");
            cajaVerPor.Items.Add("NOMBRE CLIENTE, A -> Z");
            cajaVerPor.Items.Add("NOMBRE CLIENTE, Z -> A");
            cajaVerPor.Items.Add("CRÉDITO DISPONIBLE, 0 -> 3000000");
            cajaVerPor.Items.Add("CRÉDITO DISPONIBLE, 3000000 -> 0");
            cajaVerPor.Items.Add("CLIENTES ELIMINADOS");

            ClaseClientes conad = new ClaseClientes();
            conad.MostrarDatosClientes(MostrarDatosClientes, 1);
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


        /* ******************************** ENVENTOS **************************************
           ******************************************************************************* */
        //SELECCIONAR FILA
        private void MostrarDatosClientes_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            int codiCliente = 0;
            DataGridViewRow fila = MostrarDatosClientes.CurrentRow; // obtengo la fila actualmente seleccionada en el dataGridView

            codiCliente = Convert.ToInt32(fila.Cells[0].Value); //obtengo el valor de la primer columna

            //SI EL CODIGO ESTA VACIO, ARROJAR ERROR
            if(codiCliente==0){
                MessageBox.Show("Error no controlado.");
            }else{
                //COMPRUEBO QUE EL CLIENTE EXISTA Y NO ESTÉ ELIMINADO
                ClaseClientes cl = new ClaseClientes();
                if(cl.VerificarExisteClienteEstado(codiCliente)){
                    PrincipalClientesVerModificar prin = new PrincipalClientesVerModificar(codiCliente);
                    prin.ShowDialog();
                    ClaseClientes conad = new ClaseClientes();
                    conad.MostrarDatosClientes(MostrarDatosClientes, 1);
                }else{
                    ClaseClientes conad = new ClaseClientes();
                    //SI NO EXISTE EL CLIENTE, SE PODRÁ REACTIVAR
                    String texto = Microsoft.VisualBasic.Interaction.InputBox(
                                    "¿Desea reactivar al usuario seleccionado?" + "\n\r" + "\n\r" + " *(1) SI " + "\n\r" + " *(2) NO",
                                    "Reactivación Cliente",
                                    "");
                    //DEPENDIENDO DE LA RESPUESTA INGRESADA
                    switch (texto)
                    {
                        case "1":
                            if (conad.ReactivarCliente(codiCliente))
                            {
                                MessageBox.Show("Cliente reactivado nuevamente.");
                                conad.MostrarDatosClientes(MostrarDatosClientes, 1);
                            }
                            else
                            {
                                MessageBox.Show("Ha ocurrido un error al intentar reactivar el cliente actual. Intente nuevamente por favor.");
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

        //SELECCIONAR OPCIÓN COMBOBOX
        private void cajaVerPor_SelectedIndexChanged(object sender, EventArgs e)
        {
            ClaseClientes conad = new ClaseClientes();
            switch(cajaVerPor.Text){
                case "POR DEFECTO":
                    conad.MostrarDatosClientes(MostrarDatosClientes, 1);
                    break;
                case "NOMBRE CLIENTE, A -> Z":
                    conad.MostrarDatosClientes(MostrarDatosClientes, 2);
                    break;
                case "NOMBRE CLIENTE, Z -> A":
                    conad.MostrarDatosClientes(MostrarDatosClientes, 3);
                    break;
                case "CRÉDITO DISPONIBLE, 0 -> 3000000":
                    conad.MostrarDatosClientes(MostrarDatosClientes, 4);
                    break;
                case "CRÉDITO DISPONIBLE, 3000000 -> 0":
                    conad.MostrarDatosClientes(MostrarDatosClientes, 5);
                    break;
                case "CLIENTES ELIMINADOS":
                    conad.MostrarDatosClientes(MostrarDatosClientes, 6);
                    break;
                default:
                    conad.MostrarDatosClientes(MostrarDatosClientes, 1);
                    break;
            }
        }

        //EVENTO PARA CAPTURAR CADA CARACTER INGRESADO
        private void cajaBuscar_KeyUp(object sender, KeyEventArgs e)
        {
            ClaseClientes conad = new ClaseClientes();

            conad.MostrarDatosClientesBusqueda(MostrarDatosClientes, cajaBuscar.Text);
            
      
        }
    }
}
