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

namespace SistemaPedidos.VistasPedidos
{
    public partial class PrincipalProductosRegistrar : Form
    {
        /* ******************************** SISTEMA **************************************
           ******************************************************************************* */
        private int auxEmpresa = 0;
        public PrincipalProductosRegistrar()
        {
            InitializeComponent();
        }

        //LOAD
        private void PrincipalProductosRegistrar_Load(object sender, EventArgs e)
        {
            cajaDistribuidor.Items.Add("FasTell");
            cajaDistribuidor.Items.Add("Enterprise Comunication");
            cajaDistribuidor.Items.Add("AdopT");
            cajaDistribuidor.Items.Add("Comercializadora Ismael");
            cajaDistribuidor.Items.Add("Los Duendes");
            cajaDistribuidor.Items.Add("Importadora y Exportadora Luis Jara");
            cajaDistribuidor.Items.Add("Incruspit");
            cajaDistribuidor.Items.Add("Casette");
            cajaDistribuidor.Items.Add("Importadora LOST");
            cajaDistribuidor.Items.Add("Family Inter");
            cajaDistribuidor.Items.Add("El Ñatito");
            cajaDistribuidor.Items.Add("Confecciones Clara");
            cajaDistribuidor.Items.Add("Caza & Rompe");
            cajaDistribuidor.Items.Add("Los Hipoteca");
            cajaDistribuidor.Items.Add("Fast 12");
            cajaDistribuidor.Items.Add("Muebles Manuel");
            cajaDistribuidor.Items.Add("Importadora Canarios Ltda.");
            cajaDistribuidor.Items.Add("Casa Anhis");
            cajaDistribuidor.Items.Add("Vida Social Ltda.");
            cajaDistribuidor.Items.Add("Ban Ban & Sus Secuases");
        }

        /* ******************************** BOTONES **************************************
           ******************************************************************************* */

        //BOTÓN REGISTRAR UN PRODUCTO NUEVO
        private void botonGuardar_Click(object sender, EventArgs e)
        {
            if (cajaCantidad.Text == "" || cajaDescripción.Text == "" || cajaDistribuidor.Text == "" || cajaDistribuidorDos.Text == "" ||
                cajaNombreProductos.Text == "" || cajaPrecioCompra.Text == "")
            {
                MessageBox.Show("Rellene las casillas antes de registrar un insumo nuevo.");
            }
            else
            {
                ClaseProductos cl = new ClaseProductos();
                if (cl.RegistrarProducto(cajaNombreProductos.Text, cajaDescripción.Text, Convert.ToInt32(cajaPrecioCompra.Text), Convert.ToInt32(cajaCantidad.Text), auxEmpresa))
                {
                    MessageBox.Show("Se ha registro con éxito un nuevo insumo");
                }
                else
                {
                    MessageBox.Show("Ha ocurrido un error al intentar registrar un nuevo insumo. Intente nuevamente por favor.");
                }
            }
            limpiarCasillas();
        }

        // BOTÓN ATRÁS
        private void botonAtras_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        //BOTÓN LIMPIAR CASILLAS
        private void botonLimpiar_Click(object sender, EventArgs e)
        {
            limpiarCasillas();
        }

        /* ******************************** FUNCIONES **************************************
           ******************************************************************************* */

        //FUNCION LIMPIAR CASILLAS
        private void limpiarCasillas()
        {
            cajaCantidad.Text = "";
            cajaDescripción.Text = "";
            cajaDistribuidor.SelectedIndex = -1;
            cajaNombreProductos.Text = "";
            cajaPrecioCompra.Text = "";
            cajaDistribuidorDos.Text = "";
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

        //SELECCIONAR UNA EMPRESA
        private void cajaDistribuidor_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch(cajaDistribuidor.Text){
                case "FasTell":
                    cajaDistribuidorDos.Text = "FABRICACIÓN DE MUEBLES PRINCIPALMENTE DE MADERA";
                    auxEmpresa = 1;
                    break;
                case "Enterprise Comunication":
                    cajaDistribuidorDos.Text = "VENTA AL POR MENOR DE APARATOS, ARTÍCULOS, EQUIPO DE USO DOMÉSTICO N.C.P.";
                    auxEmpresa = 2;
                    break;
                case "AdopT":
                    cajaDistribuidorDos.Text = "PREPARACIÓN DE HILATURA DE FIBRAS TEXTILES; TEJEDURA PROD. TEXTILES";
                    auxEmpresa = 3;
                    break;
                case "Comercializadora Ismael":
                    cajaDistribuidorDos.Text = "FABRICACIÓN DE TAPICES Y ALFOMBRA";
                    auxEmpresa = 4;
                    break;
                case "Los Duendes":
                    cajaDistribuidorDos.Text = "COMERCIO DE ARTÍCULOS DE SUMINISTROS DE OFICINAS Y ARTÍCULOS DE ESCRITORIO EN GENERAL";
                    auxEmpresa = 5;
                    break;
                case "Importadora y Exportadora Luis Jara":
                    cajaDistribuidorDos.Text = "COMERCIO AL POR MENOR DE ARTÍCULOS DEPORTIVOS";
                    auxEmpresa = 6;
                    break;
                case "Incruspit":
                    cajaDistribuidorDos.Text = "COMERCIO AL POR MENOR DE ARTÍCULOS DEPORTIVOS";
                    auxEmpresa = 7;
                    break;
                case "Casette":
                    cajaDistribuidorDos.Text = "FABRICACIÓN DE ROPA DE TRABAJO";
                    auxEmpresa = 8;
                    break;
                case "Importadora LOST":
                    cajaDistribuidorDos.Text = "FABRICACIÓN DE CALZADO";
                    auxEmpresa = 9;
                    break;
                case "Family Inter":
                    cajaDistribuidorDos.Text = "COMERCIO AL POR MENOR DE ARTÍCULOS DE JOYERÍA, FANTASÍAS Y RELOJERÍAS";
                    auxEmpresa = 10;
                    break;
                case "El Ñatito":
                    cajaDistribuidorDos.Text = "FABRICACIÓN DE MUEBLES PRINCIPALMENTE DE MADERA";
                    auxEmpresa = 11;
                    break;
                case "Confecciones Clara":
                    cajaDistribuidorDos.Text = "FABRICACIONES DE JABONES Y DETERGENTES, PREPARADOS PARA LIMPIAR, PERFUMES Y PREPARADOS DE TOCADOR";
                    auxEmpresa = 12;
                    break;
                case "Caza & Rompe":
                    cajaDistribuidorDos.Text = "FABRICACIÓN DE MUEBLES PRINCIPALMENTE DE MADERA";
                    auxEmpresa = 13;
                    break;
                case "Los Hipoteca":
                    cajaDistribuidorDos.Text = "VENTA AL POR MAYOR DE PAPEL Y CARTÓN";
                    auxEmpresa = 14;
                    break;
                case "Fast 12":
                    cajaDistribuidorDos.Text = "COMERCIO AL POR MENOR DE COMPUTADORAS, SOFTWARES Y SUMINISTROS";
                    auxEmpresa = 15;
                    break;
                case "Muebles Manuel":
                    cajaDistribuidorDos.Text = "COMERCIO AL POR MENOR DE COMPUTADORAS, SOFTWARES Y SUMINISTROS";
                    auxEmpresa = 16;
                    break;
                case "Importadora Canarios Ltda.":
                    cajaDistribuidorDos.Text = "COMERCIO DE ARTÍCULOS DE SUMINISTROS DE OFICINAS Y ARTÍCULOS DE ESCRITORIO EN GENERAL";
                    auxEmpresa = 17;
                    break;
                case "Casa Anhis":
                    cajaDistribuidorDos.Text = "FABRICACIÓN DE MUEBLES PRINCIPALMENTE DE MADERA";
                    auxEmpresa = 18;
                    break;
                case "Vida Social Ltda.":
                    cajaDistribuidorDos.Text = "VENTA AL POR MAYOR DE MUEBLES";
                    auxEmpresa = 19;
                    break;
                case "Ban Ban & Sus Secuases":
                    cajaDistribuidorDos.Text = "FABRICACIÓN DE MUEBLES PRINCIPALMENTE DE MADERA";
                    auxEmpresa = 20;
                    break;

            }
        }

        
    }
}
