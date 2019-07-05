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

namespace SistemaPedidos.VistasPedidos
{
    public partial class PrincipalProductos : Form
    {
        /* ******************************** SISTEMA **************************************
           ******************************************************************************* */
        public PrincipalProductos()
        {
            InitializeComponent();
        }

        /* ******************************** BOTONES **************************************
           ******************************************************************************* */

        //BOTÓN REGISTRO PRODUCTOS
        private void botonRegistro_Click(object sender, EventArgs e)
        {
            PrincipalProductosRegistrar prin = new PrincipalProductosRegistrar();
            prin.ShowDialog();
        }

        //BOTÓN ATRÁS
        private void botonAtras_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void botonVer_Click(object sender, EventArgs e)
        {
            PrincipalProductosVer prin = new PrincipalProductosVer();
            prin.ShowDialog();
        }

        private void PrincipalProductos_Load(object sender, EventArgs e)
        {

        }

        /* ******************************** FUNCIONES **************************************
           ******************************************************************************* */

        /* ******************************** EVENTOS **************************************
           ******************************************************************************* */
        
    }
}
