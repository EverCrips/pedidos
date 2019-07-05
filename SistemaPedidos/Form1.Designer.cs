namespace SistemaPedidos
{
    partial class Inicio
    {
        /// <summary>
        /// Variable del diseñador requerida.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén utilizando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben eliminar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido del método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.botonIngresar = new System.Windows.Forms.Button();
            this.BotonSalir = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // botonIngresar
            // 
            this.botonIngresar.BackColor = System.Drawing.Color.Transparent;
            this.botonIngresar.BackgroundImage = global::SistemaPedidos.Properties.Resources.ENTRAR;
            this.botonIngresar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.botonIngresar.FlatAppearance.BorderSize = 0;
            this.botonIngresar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.botonIngresar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.botonIngresar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.botonIngresar.Location = new System.Drawing.Point(147, 77);
            this.botonIngresar.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.botonIngresar.Name = "botonIngresar";
            this.botonIngresar.Size = new System.Drawing.Size(166, 165);
            this.botonIngresar.TabIndex = 0;
            this.botonIngresar.UseVisualStyleBackColor = false;
            this.botonIngresar.Click += new System.EventHandler(this.botonIngresar_Click);
            // 
            // BotonSalir
            // 
            this.BotonSalir.BackColor = System.Drawing.Color.Transparent;
            this.BotonSalir.BackgroundImage = global::SistemaPedidos.Properties.Resources.SALIR;
            this.BotonSalir.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.BotonSalir.FlatAppearance.BorderSize = 0;
            this.BotonSalir.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.BotonSalir.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.BotonSalir.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BotonSalir.Location = new System.Drawing.Point(367, 222);
            this.BotonSalir.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.BotonSalir.Name = "BotonSalir";
            this.BotonSalir.Size = new System.Drawing.Size(61, 55);
            this.BotonSalir.TabIndex = 1;
            this.BotonSalir.UseVisualStyleBackColor = false;
            this.BotonSalir.Click += new System.EventHandler(this.BotonSalir_Click);
            // 
            // Inicio
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::SistemaPedidos.Properties.Resources.INICIO;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(436, 287);
            this.Controls.Add(this.BotonSalir);
            this.Controls.Add(this.botonIngresar);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.MaximizeBox = false;
            this.Name = "Inicio";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Distribuidora InVicTus";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button botonIngresar;
        private System.Windows.Forms.Button BotonSalir;
    }
}

