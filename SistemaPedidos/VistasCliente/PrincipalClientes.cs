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

namespace SistemaPedidos.VistasCliente
{
    public partial class PrincipalClientes : Form
    {
        /* ******************************** SISTEMA **************************************
           ******************************************************************************* */
        public PrincipalClientes()
        {
            InitializeComponent();
        }

        /* ******************************** BOTONES **************************************
           ******************************************************************************* */

        //BOTÓN VER
        private void botonVer_Click(object sender, EventArgs e)
        {
            PrincipalClientesVer cre = new PrincipalClientesVer();
            cre.ShowDialog();
        }

        //BOTÓN ATRÁS
        private void botonAtras_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        //BOTÓN REGISTRAR CLIENTE
        private void botonRegistro_Click(object sender, EventArgs e)
        {
            PrincipalClientesRegistrar prin = new PrincipalClientesRegistrar();
            prin.ShowDialog();
        }

    }
}
