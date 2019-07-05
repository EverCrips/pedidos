//Diseñado y programado por Cristopher Pérez V. 18.973.714-9
using System;
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
    public partial class Inicio : Form
    {
        /* ******************************** SISTEMA **************************************
           ******************************************************************************* */
        public Inicio()
        {
            InitializeComponent();
        }

        /* ******************************** BOTONES **************************************
           ******************************************************************************* */

        //BOTÓN SALIR
        private void BotonSalir_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        //BOTÓN INGRESAR
        private void botonIngresar_Click(object sender, EventArgs e)
        {
            this.Hide();
            VistaPrincipal prins = new VistaPrincipal();
            prins.ShowDialog();
            this.Show();
        }

        /* ******************************** FUNCIONES **************************************
           ******************************************************************************* */


        /* ******************************** EVENTOS **************************************
           ******************************************************************************* */
    }
}
