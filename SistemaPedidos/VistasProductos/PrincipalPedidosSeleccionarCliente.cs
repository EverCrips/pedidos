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

namespace SistemaPedidos.VistasProductos
{
    public partial class PrincipalPedidosSeleccionarCliente : Form
    {
        public int codCli { get; set; }
        public PrincipalPedidosSeleccionarCliente()
        {
            InitializeComponent();
        }

        //LOAD
        private void PrincipalPedidosSeleccionarCliente_Load(object sender, EventArgs e)
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

        //BOTÓN ATRÁS
        private void botonAtras_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        //SELECCIONAR VISTA
        private void cajaVerPor_SelectedIndexChanged(object sender, EventArgs e)
        {
            ClaseClientes conad = new ClaseClientes();
            switch (cajaVerPor.Text)
            {
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
                default:
                    conad.MostrarDatosClientes(MostrarDatosClientes, 1);
                    break;
            }
        }

        //BUSCAR CLIENTE VIA TECLADO
        private void cajaBuscar_KeyUp(object sender, KeyEventArgs e)
        {
            ClaseClientes conad = new ClaseClientes();

            conad.MostrarDatosClientesBusqueda(MostrarDatosClientes, cajaBuscar.Text);
        }

        //SELECCIONAR UN CLIENTE Y ENVIAR LA ID PARA RECUPERAR LOS DATOS EN EL PEDIDO
        private void MostrarDatosClientes_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            int codiCliente = 0;
            DataGridViewRow fila = MostrarDatosClientes.CurrentRow; // obtengo la fila actualmente seleccionada en el dataGridView

            codiCliente = Convert.ToInt32(fila.Cells[0].Value); //obtengo el valor de la primer columna

            if(codiCliente==0){
                MessageBox.Show("Error no controlado. Intente nuevamente por favor.");
            }else{
                codCli = codiCliente;
                DialogResult = DialogResult.OK;
                this.Close();
            }
        }

    }
}
