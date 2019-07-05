namespace SistemaPedidos.VistasPedidos
{
    partial class PrincipalProductosRegistrar
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
            this.textoTitulo = new System.Windows.Forms.Label();
            this.textoNombreProducto = new System.Windows.Forms.Label();
            this.textoDescripcionProducto = new System.Windows.Forms.Label();
            this.textoPrecioProducto = new System.Windows.Forms.Label();
            this.textoCantidad = new System.Windows.Forms.Label();
            this.cajaNombreProductos = new System.Windows.Forms.TextBox();
            this.cajaDescripción = new System.Windows.Forms.TextBox();
            this.cajaPrecioCompra = new System.Windows.Forms.TextBox();
            this.cajaCantidad = new System.Windows.Forms.TextBox();
            this.textoDistribuidor = new System.Windows.Forms.Label();
            this.cajaDistribuidor = new System.Windows.Forms.ComboBox();
            this.textoDistribuidorDos = new System.Windows.Forms.Label();
            this.cajaDistribuidorDos = new System.Windows.Forms.TextBox();
            this.botonGuardar = new System.Windows.Forms.Button();
            this.botonLimpiar = new System.Windows.Forms.Button();
            this.botonAtras = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // textoTitulo
            // 
            this.textoTitulo.AutoSize = true;
            this.textoTitulo.BackColor = System.Drawing.Color.Azure;
            this.textoTitulo.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textoTitulo.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textoTitulo.Location = new System.Drawing.Point(180, 7);
            this.textoTitulo.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.textoTitulo.Name = "textoTitulo";
            this.textoTitulo.Size = new System.Drawing.Size(337, 28);
            this.textoTitulo.TabIndex = 1;
            this.textoTitulo.Text = "REGISTRO INSUMOS NUEVOS";
            // 
            // textoNombreProducto
            // 
            this.textoNombreProducto.AutoSize = true;
            this.textoNombreProducto.BackColor = System.Drawing.Color.Azure;
            this.textoNombreProducto.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textoNombreProducto.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textoNombreProducto.Location = new System.Drawing.Point(30, 86);
            this.textoNombreProducto.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.textoNombreProducto.Name = "textoNombreProducto";
            this.textoNombreProducto.Size = new System.Drawing.Size(166, 26);
            this.textoNombreProducto.TabIndex = 16;
            this.textoNombreProducto.Text = "Nombre producto:";
            // 
            // textoDescripcionProducto
            // 
            this.textoDescripcionProducto.AutoSize = true;
            this.textoDescripcionProducto.BackColor = System.Drawing.Color.Azure;
            this.textoDescripcionProducto.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textoDescripcionProducto.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textoDescripcionProducto.Location = new System.Drawing.Point(30, 133);
            this.textoDescripcionProducto.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.textoDescripcionProducto.Name = "textoDescripcionProducto";
            this.textoDescripcionProducto.Size = new System.Drawing.Size(117, 26);
            this.textoDescripcionProducto.TabIndex = 18;
            this.textoDescripcionProducto.Text = "Descripción:";
            // 
            // textoPrecioProducto
            // 
            this.textoPrecioProducto.AutoSize = true;
            this.textoPrecioProducto.BackColor = System.Drawing.Color.Azure;
            this.textoPrecioProducto.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textoPrecioProducto.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textoPrecioProducto.Location = new System.Drawing.Point(30, 180);
            this.textoPrecioProducto.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.textoPrecioProducto.Name = "textoPrecioProducto";
            this.textoPrecioProducto.Size = new System.Drawing.Size(140, 26);
            this.textoPrecioProducto.TabIndex = 19;
            this.textoPrecioProducto.Text = "Precio compra:";
            // 
            // textoCantidad
            // 
            this.textoCantidad.AutoSize = true;
            this.textoCantidad.BackColor = System.Drawing.Color.Azure;
            this.textoCantidad.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textoCantidad.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textoCantidad.Location = new System.Drawing.Point(30, 228);
            this.textoCantidad.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.textoCantidad.Name = "textoCantidad";
            this.textoCantidad.Size = new System.Drawing.Size(91, 26);
            this.textoCantidad.TabIndex = 20;
            this.textoCantidad.Text = "Cantidad:";
            // 
            // cajaNombreProductos
            // 
            this.cajaNombreProductos.Location = new System.Drawing.Point(200, 92);
            this.cajaNombreProductos.Margin = new System.Windows.Forms.Padding(2);
            this.cajaNombreProductos.MaxLength = 50;
            this.cajaNombreProductos.Name = "cajaNombreProductos";
            this.cajaNombreProductos.Size = new System.Drawing.Size(198, 20);
            this.cajaNombreProductos.TabIndex = 0;
            // 
            // cajaDescripción
            // 
            this.cajaDescripción.Location = new System.Drawing.Point(200, 139);
            this.cajaDescripción.Margin = new System.Windows.Forms.Padding(2);
            this.cajaDescripción.MaxLength = 100;
            this.cajaDescripción.Name = "cajaDescripción";
            this.cajaDescripción.Size = new System.Drawing.Size(468, 20);
            this.cajaDescripción.TabIndex = 1;
            // 
            // cajaPrecioCompra
            // 
            this.cajaPrecioCompra.Location = new System.Drawing.Point(200, 186);
            this.cajaPrecioCompra.Margin = new System.Windows.Forms.Padding(2);
            this.cajaPrecioCompra.MaxLength = 30;
            this.cajaPrecioCompra.Name = "cajaPrecioCompra";
            this.cajaPrecioCompra.Size = new System.Drawing.Size(95, 20);
            this.cajaPrecioCompra.TabIndex = 2;
            this.cajaPrecioCompra.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.cajaPrecioCompra_KeyPress);
            // 
            // cajaCantidad
            // 
            this.cajaCantidad.Location = new System.Drawing.Point(200, 233);
            this.cajaCantidad.Margin = new System.Windows.Forms.Padding(2);
            this.cajaCantidad.MaxLength = 30;
            this.cajaCantidad.Name = "cajaCantidad";
            this.cajaCantidad.Size = new System.Drawing.Size(95, 20);
            this.cajaCantidad.TabIndex = 3;
            this.cajaCantidad.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.cajaCantidad_KeyPress);
            // 
            // textoDistribuidor
            // 
            this.textoDistribuidor.AutoSize = true;
            this.textoDistribuidor.BackColor = System.Drawing.Color.Azure;
            this.textoDistribuidor.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textoDistribuidor.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textoDistribuidor.Location = new System.Drawing.Point(30, 273);
            this.textoDistribuidor.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.textoDistribuidor.Name = "textoDistribuidor";
            this.textoDistribuidor.Size = new System.Drawing.Size(111, 26);
            this.textoDistribuidor.TabIndex = 26;
            this.textoDistribuidor.Text = "Distribuidor:";
            // 
            // cajaDistribuidor
            // 
            this.cajaDistribuidor.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cajaDistribuidor.FormattingEnabled = true;
            this.cajaDistribuidor.Location = new System.Drawing.Point(200, 279);
            this.cajaDistribuidor.Name = "cajaDistribuidor";
            this.cajaDistribuidor.Size = new System.Drawing.Size(198, 21);
            this.cajaDistribuidor.TabIndex = 4;
            this.cajaDistribuidor.SelectedIndexChanged += new System.EventHandler(this.cajaDistribuidor_SelectedIndexChanged);
            // 
            // textoDistribuidorDos
            // 
            this.textoDistribuidorDos.AutoSize = true;
            this.textoDistribuidorDos.BackColor = System.Drawing.Color.Azure;
            this.textoDistribuidorDos.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textoDistribuidorDos.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textoDistribuidorDos.Location = new System.Drawing.Point(30, 320);
            this.textoDistribuidorDos.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.textoDistribuidorDos.Name = "textoDistribuidorDos";
            this.textoDistribuidorDos.Size = new System.Drawing.Size(111, 26);
            this.textoDistribuidorDos.TabIndex = 28;
            this.textoDistribuidorDos.Text = "Distribuidor:";
            // 
            // cajaDistribuidorDos
            // 
            this.cajaDistribuidorDos.Enabled = false;
            this.cajaDistribuidorDos.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cajaDistribuidorDos.Location = new System.Drawing.Point(200, 326);
            this.cajaDistribuidorDos.Margin = new System.Windows.Forms.Padding(2);
            this.cajaDistribuidorDos.MaxLength = 30;
            this.cajaDistribuidorDos.Name = "cajaDistribuidorDos";
            this.cajaDistribuidorDos.ReadOnly = true;
            this.cajaDistribuidorDos.Size = new System.Drawing.Size(468, 18);
            this.cajaDistribuidorDos.TabIndex = 5;
            // 
            // botonGuardar
            // 
            this.botonGuardar.BackColor = System.Drawing.Color.Transparent;
            this.botonGuardar.BackgroundImage = global::SistemaPedidos.Properties.Resources.CIRCULO_ACEPTAR;
            this.botonGuardar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.botonGuardar.FlatAppearance.BorderSize = 0;
            this.botonGuardar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.botonGuardar.Location = new System.Drawing.Point(633, 385);
            this.botonGuardar.Margin = new System.Windows.Forms.Padding(2);
            this.botonGuardar.Name = "botonGuardar";
            this.botonGuardar.Size = new System.Drawing.Size(64, 61);
            this.botonGuardar.TabIndex = 11;
            this.botonGuardar.UseVisualStyleBackColor = false;
            this.botonGuardar.Click += new System.EventHandler(this.botonGuardar_Click);
            // 
            // botonLimpiar
            // 
            this.botonLimpiar.BackColor = System.Drawing.Color.Transparent;
            this.botonLimpiar.BackgroundImage = global::SistemaPedidos.Properties.Resources.CIRCULO_LIMPIAR;
            this.botonLimpiar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.botonLimpiar.FlatAppearance.BorderSize = 0;
            this.botonLimpiar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.botonLimpiar.Location = new System.Drawing.Point(323, 385);
            this.botonLimpiar.Margin = new System.Windows.Forms.Padding(2);
            this.botonLimpiar.Name = "botonLimpiar";
            this.botonLimpiar.Size = new System.Drawing.Size(64, 61);
            this.botonLimpiar.TabIndex = 10;
            this.botonLimpiar.UseVisualStyleBackColor = false;
            this.botonLimpiar.Click += new System.EventHandler(this.botonLimpiar_Click);
            // 
            // botonAtras
            // 
            this.botonAtras.BackColor = System.Drawing.Color.Transparent;
            this.botonAtras.BackgroundImage = global::SistemaPedidos.Properties.Resources.VOLVER;
            this.botonAtras.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.botonAtras.FlatAppearance.BorderSize = 0;
            this.botonAtras.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.botonAtras.Location = new System.Drawing.Point(9, 385);
            this.botonAtras.Margin = new System.Windows.Forms.Padding(2);
            this.botonAtras.Name = "botonAtras";
            this.botonAtras.Size = new System.Drawing.Size(64, 61);
            this.botonAtras.TabIndex = 9;
            this.botonAtras.UseVisualStyleBackColor = false;
            this.botonAtras.Click += new System.EventHandler(this.botonAtras_Click);
            // 
            // PrincipalProductosRegistrar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::SistemaPedidos.Properties.Resources.FORMULARIO_REGISTRO_PRODUCTO;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(706, 455);
            this.Controls.Add(this.cajaDistribuidorDos);
            this.Controls.Add(this.textoDistribuidorDos);
            this.Controls.Add(this.cajaDistribuidor);
            this.Controls.Add(this.textoDistribuidor);
            this.Controls.Add(this.cajaCantidad);
            this.Controls.Add(this.cajaPrecioCompra);
            this.Controls.Add(this.cajaDescripción);
            this.Controls.Add(this.cajaNombreProductos);
            this.Controls.Add(this.textoCantidad);
            this.Controls.Add(this.textoPrecioProducto);
            this.Controls.Add(this.textoDescripcionProducto);
            this.Controls.Add(this.textoNombreProducto);
            this.Controls.Add(this.botonGuardar);
            this.Controls.Add(this.botonLimpiar);
            this.Controls.Add(this.botonAtras);
            this.Controls.Add(this.textoTitulo);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Margin = new System.Windows.Forms.Padding(2);
            this.MaximizeBox = false;
            this.Name = "PrincipalProductosRegistrar";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Distribuidora InVicTus";
            this.Load += new System.EventHandler(this.PrincipalProductosRegistrar_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label textoTitulo;
        private System.Windows.Forms.Button botonAtras;
        private System.Windows.Forms.Button botonLimpiar;
        private System.Windows.Forms.Button botonGuardar;
        private System.Windows.Forms.Label textoNombreProducto;
        private System.Windows.Forms.Label textoDescripcionProducto;
        private System.Windows.Forms.Label textoPrecioProducto;
        private System.Windows.Forms.Label textoCantidad;
        private System.Windows.Forms.TextBox cajaNombreProductos;
        private System.Windows.Forms.TextBox cajaDescripción;
        private System.Windows.Forms.TextBox cajaPrecioCompra;
        private System.Windows.Forms.TextBox cajaCantidad;
        private System.Windows.Forms.Label textoDistribuidor;
        private System.Windows.Forms.ComboBox cajaDistribuidor;
        private System.Windows.Forms.Label textoDistribuidorDos;
        private System.Windows.Forms.TextBox cajaDistribuidorDos;
    }
}