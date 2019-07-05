namespace SistemaPedidos
{
    partial class VistaPrincipal
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.textoVendedor = new System.Windows.Forms.Label();
            this.botonAtras = new System.Windows.Forms.Button();
            this.botonProductos = new System.Windows.Forms.Button();
            this.botonPedidos = new System.Windows.Forms.Button();
            this.botonClientes = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // textoVendedor
            // 
            this.textoVendedor.AutoSize = true;
            this.textoVendedor.BackColor = System.Drawing.Color.Azure;
            this.textoVendedor.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textoVendedor.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textoVendedor.Location = new System.Drawing.Point(9, 20);
            this.textoVendedor.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.textoVendedor.Name = "textoVendedor";
            this.textoVendedor.Size = new System.Drawing.Size(121, 28);
            this.textoVendedor.TabIndex = 4;
            this.textoVendedor.Text = "USUARIO:";
            // 
            // botonAtras
            // 
            this.botonAtras.BackColor = System.Drawing.Color.Transparent;
            this.botonAtras.BackgroundImage = global::SistemaPedidos.Properties.Resources.VOLVER;
            this.botonAtras.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.botonAtras.FlatAppearance.BorderSize = 0;
            this.botonAtras.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.botonAtras.Location = new System.Drawing.Point(809, 5);
            this.botonAtras.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.botonAtras.Name = "botonAtras";
            this.botonAtras.Size = new System.Drawing.Size(66, 62);
            this.botonAtras.TabIndex = 3;
            this.botonAtras.UseVisualStyleBackColor = false;
            this.botonAtras.Click += new System.EventHandler(this.botonAtras_Click);
            // 
            // botonProductos
            // 
            this.botonProductos.BackColor = System.Drawing.Color.Transparent;
            this.botonProductos.BackgroundImage = global::SistemaPedidos.Properties.Resources.BOTON_PRODUCTOS;
            this.botonProductos.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.botonProductos.FlatAppearance.BorderSize = 0;
            this.botonProductos.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.botonProductos.Location = new System.Drawing.Point(316, 74);
            this.botonProductos.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.botonProductos.Name = "botonProductos";
            this.botonProductos.Size = new System.Drawing.Size(255, 447);
            this.botonProductos.TabIndex = 1;
            this.botonProductos.UseVisualStyleBackColor = false;
            this.botonProductos.Click += new System.EventHandler(this.botonProductos_Click);
            // 
            // botonPedidos
            // 
            this.botonPedidos.BackColor = System.Drawing.Color.Transparent;
            this.botonPedidos.BackgroundImage = global::SistemaPedidos.Properties.Resources.BOTON_PEDIDO;
            this.botonPedidos.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.botonPedidos.FlatAppearance.BorderSize = 0;
            this.botonPedidos.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.botonPedidos.Location = new System.Drawing.Point(622, 74);
            this.botonPedidos.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.botonPedidos.Name = "botonPedidos";
            this.botonPedidos.Size = new System.Drawing.Size(255, 447);
            this.botonPedidos.TabIndex = 2;
            this.botonPedidos.UseVisualStyleBackColor = false;
            this.botonPedidos.Click += new System.EventHandler(this.botonPedidos_Click);
            // 
            // botonClientes
            // 
            this.botonClientes.BackColor = System.Drawing.Color.Transparent;
            this.botonClientes.BackgroundImage = global::SistemaPedidos.Properties.Resources.BOTON_CLIENTE;
            this.botonClientes.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.botonClientes.FlatAppearance.BorderSize = 0;
            this.botonClientes.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.botonClientes.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.botonClientes.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.botonClientes.Location = new System.Drawing.Point(9, 74);
            this.botonClientes.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.botonClientes.Name = "botonClientes";
            this.botonClientes.Size = new System.Drawing.Size(255, 447);
            this.botonClientes.TabIndex = 0;
            this.botonClientes.UseVisualStyleBackColor = false;
            this.botonClientes.Click += new System.EventHandler(this.botonClientes_Click);
            // 
            // VistaPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::SistemaPedidos.Properties.Resources.MENU_PRINCIPAL;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(886, 531);
            this.Controls.Add(this.textoVendedor);
            this.Controls.Add(this.botonAtras);
            this.Controls.Add(this.botonProductos);
            this.Controls.Add(this.botonPedidos);
            this.Controls.Add(this.botonClientes);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.MaximizeBox = false;
            this.Name = "VistaPrincipal";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Distribuidora InVicTus";
            this.Load += new System.EventHandler(this.VistaPrincipal_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button botonClientes;
        private System.Windows.Forms.Button botonPedidos;
        private System.Windows.Forms.Button botonProductos;
        private System.Windows.Forms.Button botonAtras;
        private System.Windows.Forms.Label textoVendedor;
    }
}