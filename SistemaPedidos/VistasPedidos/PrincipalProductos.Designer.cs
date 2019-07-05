namespace SistemaPedidos.VistasPedidos
{
    partial class PrincipalProductos
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
            this.botonRegistro = new System.Windows.Forms.Button();
            this.botonVer = new System.Windows.Forms.Button();
            this.botonAtras = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // botonRegistro
            // 
            this.botonRegistro.BackColor = System.Drawing.Color.Transparent;
            this.botonRegistro.BackgroundImage = global::SistemaPedidos.Properties.Resources.CIRUCULO_SOLO_AGREGAR;
            this.botonRegistro.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.botonRegistro.FlatAppearance.BorderSize = 0;
            this.botonRegistro.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.botonRegistro.Location = new System.Drawing.Point(87, 130);
            this.botonRegistro.Margin = new System.Windows.Forms.Padding(2);
            this.botonRegistro.Name = "botonRegistro";
            this.botonRegistro.Size = new System.Drawing.Size(126, 125);
            this.botonRegistro.TabIndex = 2;
            this.botonRegistro.UseVisualStyleBackColor = false;
            this.botonRegistro.Click += new System.EventHandler(this.botonRegistro_Click);
            // 
            // botonVer
            // 
            this.botonVer.BackColor = System.Drawing.Color.Transparent;
            this.botonVer.BackgroundImage = global::SistemaPedidos.Properties.Resources.CIRCULO_VISUALIZAR;
            this.botonVer.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.botonVer.FlatAppearance.BorderSize = 0;
            this.botonVer.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.botonVer.Location = new System.Drawing.Point(273, 130);
            this.botonVer.Margin = new System.Windows.Forms.Padding(2);
            this.botonVer.Name = "botonVer";
            this.botonVer.Size = new System.Drawing.Size(126, 125);
            this.botonVer.TabIndex = 3;
            this.botonVer.UseVisualStyleBackColor = false;
            this.botonVer.Click += new System.EventHandler(this.botonVer_Click);
            // 
            // botonAtras
            // 
            this.botonAtras.BackColor = System.Drawing.Color.Transparent;
            this.botonAtras.BackgroundImage = global::SistemaPedidos.Properties.Resources.VOLVER;
            this.botonAtras.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.botonAtras.FlatAppearance.BorderSize = 0;
            this.botonAtras.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.botonAtras.Location = new System.Drawing.Point(434, 9);
            this.botonAtras.Margin = new System.Windows.Forms.Padding(2);
            this.botonAtras.Name = "botonAtras";
            this.botonAtras.Size = new System.Drawing.Size(70, 67);
            this.botonAtras.TabIndex = 4;
            this.botonAtras.UseVisualStyleBackColor = false;
            this.botonAtras.Click += new System.EventHandler(this.botonAtras_Click);
            // 
            // PrincipalProductos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::SistemaPedidos.Properties.Resources.MENU_PRODUCTOS;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(512, 368);
            this.Controls.Add(this.botonAtras);
            this.Controls.Add(this.botonVer);
            this.Controls.Add(this.botonRegistro);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Margin = new System.Windows.Forms.Padding(2);
            this.MaximizeBox = false;
            this.Name = "PrincipalProductos";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Distribuidora InVicTus";
            this.Load += new System.EventHandler(this.PrincipalProductos_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button botonRegistro;
        private System.Windows.Forms.Button botonVer;
        private System.Windows.Forms.Button botonAtras;
    }
}