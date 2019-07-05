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
        public PrincipalPedidos()
        {
            InitializeComponent();
        }

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
    }
}
