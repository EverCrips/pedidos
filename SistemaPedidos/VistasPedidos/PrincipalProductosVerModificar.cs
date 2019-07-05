using SistemaPedidos.ClasesSQL;
using System;
//Diseñado y programado por Cristopher Pérez V. 18.973.714-9
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
    public partial class PrincipalProductosVerModificar : Form
    {
        /* ******************************** SISTEMA **************************************
           ******************************************************************************* */

        private int auxcodiPro=0;

        public PrincipalProductosVerModificar()
        {
            InitializeComponent();
        }

        //CONSTRUCTOR
        public PrincipalProductosVerModificar(int codiPro)
        {
            // TODO: Complete member initialization
            auxcodiPro = codiPro;
            InitializeComponent();
        }

        //LOAD
        private void PrincipalProductosVerModificar_Load(object sender, EventArgs e)
        {
            recuperarDatosProducto();
        }

        /* ******************************** BOTONES **************************************
           ******************************************************************************* */

        // BOTÓN GUARDAR CAMBIOS
        private void botonGuardar_Click(object sender, EventArgs e)
        {
            ClaseProductos pro = new ClaseProductos();
            if (cajaCantidad.Text == "" || cajaDescripción.Text == "" || cajaDistribuidorDos.Text == "" || cajaNombreProductos.Text == "" || cajaPrecioCompra.Text == "")
            {
                MessageBox.Show("Por favor, rellene las casillas antes de modificar los datos del insumo.");
            }
            else
            {
                if (pro.ModificarDatosProducto(auxcodiPro, cajaNombreProductos.Text, cajaDescripción.Text, Convert.ToInt32(cajaPrecioCompra.Text), Convert.ToInt32(cajaCantidad.Text)))
                {
                    MessageBox.Show("Se ha modificado con éxito el insumo.");
                }
                else
                {
                    MessageBox.Show("Ha ocurrido un error al actualizar los datos del insumo. Intente nuevamente por favor.");
                }
            }
        }

        //ELIMINAR PRODUCTO
        private void botonEliminar_Click(object sender, EventArgs e)
        {
            ClaseProductos pro = new ClaseProductos();
            String texto = Microsoft.VisualBasic.Interaction.InputBox(
                            "¿Desea eliminar el insumo actual?" + "\n\r" + "\n\r" + " *(1) SI " + "\n\r" + " *(2) NO",
                            "Eliminación insumo",
                            "");
            //DEPENDIENDO DE LA RESPUESTA INGRESADA
            switch (texto)
            {
                case "1":
                    if (pro.EliminarProducto(auxcodiPro))
                    {
                        MessageBox.Show("Se ha eliminado satisfactoriamente el insumo.");
                        this.Close();
                    }
                    else
                    {
                        MessageBox.Show("Ha ocurrido un error al intentar eliminar el insumo actual. Intente nuevamente por favor.");
                    }
                    break;
                case "2":

                    break;
                default:
                    MessageBox.Show("No hubo respuesta o no se respetaron las instrucciones.");
                    break;
            }
        }

        //BOTÓN ATRÁS
        private void botonAtras_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        /* ******************************** FUNCIONES **************************************
           ******************************************************************************* */

        //FUNCIÓN OBTENER DATOS DEL PRODUCTO
        public void recuperarDatosProducto()
        {

            ClaseProductos pro;
            pro = new ClaseProductos();
            ArrayList list = new ArrayList();
            list = pro.ObtenerDatosProducto(auxcodiPro);
            cajaNombreProductos.Text = list[0].ToString();
            cajaDescripción.Text = list[1].ToString();
            cajaPrecioCompra.Text = list[2].ToString();
            cajaCantidad.Text = list[3].ToString();
            cajaDistribuidorDos.Text = list[4].ToString();

        }

        /* ******************************** EVENTOS **************************************
           ******************************************************************************* */

        //SOLO NUMÉRICOS
        private void cajaPrecioCompra_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!(char.IsNumber(e.KeyChar)) && (e.KeyChar != (char)Keys.Back))
            {
                e.Handled = true;
                return;
            }
        }

        //SOLO NUMÉRICOS
        private void cajaCantidad_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!(char.IsNumber(e.KeyChar)) && (e.KeyChar != (char)Keys.Back))
            {
                e.Handled = true;
                return;
            }
        }
    }
}
