namespace SistemaPedidos.VistasPedidos
{
    partial class PrincipalProductosVerModificar
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
            this.botonAtras = new System.Windows.Forms.Button();
            this.botonGuardar = new System.Windows.Forms.Button();
            this.textoNombreProducto = new System.Windows.Forms.Label();
            this.textoDescripcionProducto = new System.Windows.Forms.Label();
            this.textoPrecioProducto = new System.Windows.Forms.Label();
            this.textoDistribuidorDos = new System.Windows.Forms.Label();
            this.textoCantidad = new System.Windows.Forms.Label();
            this.cajaNombreProductos = new System.Windows.Forms.TextBox();
            this.cajaDescripción = new System.Windows.Forms.TextBox();
            this.cajaPrecioCompra = new System.Windows.Forms.TextBox();
            this.cajaCantidad = new System.Windows.Forms.TextBox();
            this.cajaDistribuidorDos = new System.Windows.Forms.TextBox();
            this.botonEliminar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // textoTitulo
            // 
            this.textoTitulo.AutoSize = true;
            this.textoTitulo.BackColor = System.Drawing.Color.Azure;
            this.textoTitulo.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textoTitulo.Font = new System.Drawing.Font("Helvetica", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textoTitulo.Location = new System.Drawing.Point(180, 7);
            this.textoTitulo.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.textoTitulo.Name = "textoTitulo";
            this.textoTitulo.Size = new System.Drawing.Size(384, 33);
            this.textoTitulo.TabIndex = 2;
            this.textoTitulo.Text = "REGISTRO ACTUAL INSUMO";
            // 
            // botonAtras
            // 
            this.botonAtras.BackColor = System.Drawing.Color.Transparent;
            this.botonAtras.BackgroundImage = global::SistemaPedidos.Properties.Resources.VOLVER;
            this.botonAtras.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.botonAtras.FlatAppearance.BorderSize = 0;
            this.botonAtras.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.botonAtras.Location = new System.Drawing.Point(9, 343);
            this.botonAtras.Margin = new System.Windows.Forms.Padding(2);
            this.botonAtras.Name = "botonAtras";
            this.botonAtras.Size = new System.Drawing.Size(64, 61);
            this.botonAtras.TabIndex = 10;
            this.botonAtras.UseVisualStyleBackColor = false;
            this.botonAtras.Click += new System.EventHandler(this.botonAtras_Click);
            // 
            // botonGuardar
            // 
            this.botonGuardar.BackColor = System.Drawing.Color.Transparent;
            this.botonGuardar.BackgroundImage = global::SistemaPedidos.Properties.Resources.CIRCULO_ACEPTAR;
            this.botonGuardar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.botonGuardar.FlatAppearance.BorderSize = 0;
            this.botonGuardar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.botonGuardar.Location = new System.Drawing.Point(682, 343);
            this.botonGuardar.Margin = new System.Windows.Forms.Padding(2);
            this.botonGuardar.Name = "botonGuardar";
            this.botonGuardar.Size = new System.Drawing.Size(64, 61);
            this.botonGuardar.TabIndex = 12;
            this.botonGuardar.UseVisualStyleBackColor = false;
            this.botonGuardar.Click += new System.EventHandler(this.botonGuardar_Click);
            // 
            // textoNombreProducto
            // 
            this.textoNombreProducto.AutoSize = true;
            this.textoNombreProducto.BackColor = System.Drawing.Color.Azure;
            this.textoNombreProducto.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textoNombreProducto.Font = new System.Drawing.Font("Helvetica", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textoNombreProducto.Location = new System.Drawing.Point(37, 84);
            this.textoNombreProducto.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.textoNombreProducto.Name = "textoNombreProducto";
            this.textoNombreProducto.Size = new System.Drawing.Size(185, 27);
            this.textoNombreProducto.TabIndex = 17;
            this.textoNombreProducto.Text = "Nombre producto:";
            // 
            // textoDescripcionProducto
            // 
            this.textoDescripcionProducto.AutoSize = true;
            this.textoDescripcionProducto.BackColor = System.Drawing.Color.Azure;
            this.textoDescripcionProducto.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textoDescripcionProducto.Font = new System.Drawing.Font("Helvetica", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textoDescripcionProducto.Location = new System.Drawing.Point(37, 132);
            this.textoDescripcionProducto.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.textoDescripcionProducto.Name = "textoDescripcionProducto";
            this.textoDescripcionProducto.Size = new System.Drawing.Size(133, 27);
            this.textoDescripcionProducto.TabIndex = 19;
            this.textoDescripcionProducto.Text = "Descripción:";
            // 
            // textoPrecioProducto
            // 
            this.textoPrecioProducto.AutoSize = true;
            this.textoPrecioProducto.BackColor = System.Drawing.Color.Azure;
            this.textoPrecioProducto.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textoPrecioProducto.Font = new System.Drawing.Font("Helvetica", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textoPrecioProducto.Location = new System.Drawing.Point(37, 179);
            this.textoPrecioProducto.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.textoPrecioProducto.Name = "textoPrecioProducto";
            this.textoPrecioProducto.Size = new System.Drawing.Size(158, 27);
            this.textoPrecioProducto.TabIndex = 20;
            this.textoPrecioProducto.Text = "Precio compra:";
            // 
            // textoDistribuidorDos
            // 
            this.textoDistribuidorDos.AutoSize = true;
            this.textoDistribuidorDos.BackColor = System.Drawing.Color.Azure;
            this.textoDistribuidorDos.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textoDistribuidorDos.Font = new System.Drawing.Font("Helvetica", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textoDistribuidorDos.Location = new System.Drawing.Point(37, 273);
            this.textoDistribuidorDos.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.textoDistribuidorDos.Name = "textoDistribuidorDos";
            this.textoDistribuidorDos.Size = new System.Drawing.Size(129, 27);
            this.textoDistribuidorDos.TabIndex = 29;
            this.textoDistribuidorDos.Text = "Distribuidor:";
            // 
            // textoCantidad
            // 
            this.textoCantidad.AutoSize = true;
            this.textoCantidad.BackColor = System.Drawing.Color.Azure;
            this.textoCantidad.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textoCantidad.Font = new System.Drawing.Font("Helvetica", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textoCantidad.Location = new System.Drawing.Point(37, 226);
            this.textoCantidad.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.textoCantidad.Name = "textoCantidad";
            this.textoCantidad.Size = new System.Drawing.Size(106, 27);
            this.textoCantidad.TabIndex = 21;
            this.textoCantidad.Text = "Cantidad:";
            // 
            // cajaNombreProductos
            // 
            this.cajaNombreProductos.Font = new System.Drawing.Font("Helvetica", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cajaNombreProductos.Location = new System.Drawing.Point(233, 84);
            this.cajaNombreProductos.Margin = new System.Windows.Forms.Padding(2);
            this.cajaNombreProductos.MaxLength = 50;
            this.cajaNombreProductos.Name = "cajaNombreProductos";
            this.cajaNombreProductos.Size = new System.Drawing.Size(198, 29);
            this.cajaNombreProductos.TabIndex = 30;
            // 
            // cajaDescripción
            // 
            this.cajaDescripción.Font = new System.Drawing.Font("Helvetica", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cajaDescripción.Location = new System.Drawing.Point(233, 132);
            this.cajaDescripción.Margin = new System.Windows.Forms.Padding(2);
            this.cajaDescripción.MaxLength = 100;
            this.cajaDescripción.Name = "cajaDescripción";
            this.cajaDescripción.Size = new System.Drawing.Size(473, 29);
            this.cajaDescripción.TabIndex = 31;
            // 
            // cajaPrecioCompra
            // 
            this.cajaPrecioCompra.Font = new System.Drawing.Font("Helvetica", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cajaPrecioCompra.Location = new System.Drawing.Point(233, 179);
            this.cajaPrecioCompra.Margin = new System.Windows.Forms.Padding(2);
            this.cajaPrecioCompra.MaxLength = 30;
            this.cajaPrecioCompra.Name = "cajaPrecioCompra";
            this.cajaPrecioCompra.Size = new System.Drawing.Size(95, 29);
            this.cajaPrecioCompra.TabIndex = 32;
            this.cajaPrecioCompra.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.cajaPrecioCompra_KeyPress);
            // 
            // cajaCantidad
            // 
            this.cajaCantidad.Font = new System.Drawing.Font("Helvetica", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cajaCantidad.Location = new System.Drawing.Point(233, 226);
            this.cajaCantidad.Margin = new System.Windows.Forms.Padding(2);
            this.cajaCantidad.MaxLength = 30;
            this.cajaCantidad.Name = "cajaCantidad";
            this.cajaCantidad.Size = new System.Drawing.Size(95, 29);
            this.cajaCantidad.TabIndex = 33;
            this.cajaCantidad.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.cajaCantidad_KeyPress);
            // 
            // cajaDistribuidorDos
            // 
            this.cajaDistribuidorDos.Enabled = false;
            this.cajaDistribuidorDos.Font = new System.Drawing.Font("Helvetica", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cajaDistribuidorDos.Location = new System.Drawing.Point(233, 273);
            this.cajaDistribuidorDos.Margin = new System.Windows.Forms.Padding(2);
            this.cajaDistribuidorDos.MaxLength = 30;
            this.cajaDistribuidorDos.Name = "cajaDistribuidorDos";
            this.cajaDistribuidorDos.ReadOnly = true;
            this.cajaDistribuidorDos.Size = new System.Drawing.Size(198, 29);
            this.cajaDistribuidorDos.TabIndex = 34;
            // 
            // botonEliminar
            // 
            this.botonEliminar.BackColor = System.Drawing.Color.Transparent;
            this.botonEliminar.BackgroundImage = global::SistemaPedidos.Properties.Resources.CIRCULO_ELIMINAR;
            this.botonEliminar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.botonEliminar.FlatAppearance.BorderSize = 0;
            this.botonEliminar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.botonEliminar.Location = new System.Drawing.Point(559, 337);
            this.botonEliminar.Margin = new System.Windows.Forms.Padding(2);
            this.botonEliminar.Name = "botonEliminar";
            this.botonEliminar.Size = new System.Drawing.Size(69, 65);
            this.botonEliminar.TabIndex = 35;
            this.botonEliminar.UseVisualStyleBackColor = false;
            this.botonEliminar.Click += new System.EventHandler(this.botonEliminar_Click);
            // 
            // PrincipalProductosVerModificar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::SistemaPedidos.Properties.Resources.FORMULARIO_MODIFICAR_PRODUCTO;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(757, 413);
            this.Controls.Add(this.botonEliminar);
            this.Controls.Add(this.cajaDistribuidorDos);
            this.Controls.Add(this.cajaCantidad);
            this.Controls.Add(this.cajaPrecioCompra);
            this.Controls.Add(this.cajaDescripción);
            this.Controls.Add(this.cajaNombreProductos);
            this.Controls.Add(this.textoDistribuidorDos);
            this.Controls.Add(this.textoCantidad);
            this.Controls.Add(this.textoPrecioProducto);
            this.Controls.Add(this.textoDescripcionProducto);
            this.Controls.Add(this.textoNombreProducto);
            this.Controls.Add(this.botonGuardar);
            this.Controls.Add(this.botonAtras);
            this.Controls.Add(this.textoTitulo);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Margin = new System.Windows.Forms.Padding(2);
            this.MaximizeBox = false;
            this.Name = "PrincipalProductosVerModificar";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Distribuidora InVicTus";
            this.Load += new System.EventHandler(this.PrincipalProductosVerModificar_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label textoTitulo;
        private System.Windows.Forms.Button botonAtras;
        private System.Windows.Forms.Button botonGuardar;
        private System.Windows.Forms.Label textoNombreProducto;
        private System.Windows.Forms.Label textoDescripcionProducto;
        private System.Windows.Forms.Label textoPrecioProducto;
        private System.Windows.Forms.Label textoDistribuidorDos;
        private System.Windows.Forms.Label textoCantidad;
        private System.Windows.Forms.TextBox cajaNombreProductos;
        private System.Windows.Forms.TextBox cajaDescripción;
        private System.Windows.Forms.TextBox cajaPrecioCompra;
        private System.Windows.Forms.TextBox cajaCantidad;
        private System.Windows.Forms.TextBox cajaDistribuidorDos;
        private System.Windows.Forms.Button botonEliminar;
    }
}