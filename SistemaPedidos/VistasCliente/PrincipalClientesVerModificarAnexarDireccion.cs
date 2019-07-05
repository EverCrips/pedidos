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
    public partial class PrincipalClientesVerModificarAnexarDireccion : Form
    {
        /* ******************************** SISTEMA **************************************
           ******************************************************************************* */

        private int auxCod = 0;
        public PrincipalClientesVerModificarAnexarDireccion()
        {
            InitializeComponent();
        }

        //CONSTRUCTOR
        public PrincipalClientesVerModificarAnexarDireccion(int cod)
        {
            auxCod = cod;
            InitializeComponent();
        }

        /* ******************************** BOTONES **************************************
           ******************************************************************************* */

        //BOTÓN ATRÁS
        private void botonAtras_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        //BOTÓN REGISTRAR NUEVA DIRECCIÓN
        private void botonRegistrar_Click(object sender, EventArgs e)
        {
            ClaseClientes cl = new ClaseClientes();
            if(cajaCiudad.Text =="" || cajaDireccion.Text==""){
                MessageBox.Show("Rellene las casillas antes de registrar una nueva dirección.");
            }else{
                if(cl.AnexarDireccion(auxCod, cajaDireccion.Text, cajaCiudad.Text)){
                    //SE REALIZÓ CON ÉXITO EL ANEXO DE LA DIRECCIÓN
                    MessageBox.Show("Se ha registro con éxito una nueva dirección al cliente.");
                }
                else
                {
                    //ALGO OCURRIÓ
                    MessageBox.Show("Ha ocurrido un error al anexar la dirección al cliente. Intente nuevamente por favor.");
                }
            }
            limpiarCasillas();
        }

        //BOTÓN LIMPIAR CASILLAS
        private void botonLimpiar_Click(object sender, EventArgs e)
        {
            limpiarCasillas();
        }

        /* ******************************** FUNCIONES **************************************
           ******************************************************************************* */

        //FUNCIÓN LIMPIAR CASILLAS
        private void limpiarCasillas(){
            cajaCiudad.Text = "";
            cajaDireccion.Text = "";
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



        /* ******************************** EVENTOS **************************************
           ******************************************************************************* */
    }
}
