namespace SistemaPedidos.VistasCliente
{
    partial class PrincipalClientesVerModificarAnexarDireccion
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
            this.label1 = new System.Windows.Forms.Label();
            this.botonAtras = new System.Windows.Forms.Button();
            this.botonRegistrar = new System.Windows.Forms.Button();
            this.botonLimpiar = new System.Windows.Forms.Button();
            this.textoCiudad = new System.Windows.Forms.Label();
            this.textoDireccion = new System.Windows.Forms.Label();
            this.cajaDireccion = new System.Windows.Forms.TextBox();
            this.cajaCiudad = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Azure;
            this.label1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label1.Font = new System.Drawing.Font("Helvetica", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(84, 9);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(319, 33);
            this.label1.TabIndex = 0;
            this.label1.Text = "Agregar Dirección Nueva";
            // 
            // botonAtras
            // 
            this.botonAtras.BackColor = System.Drawing.Color.Transparent;
            this.botonAtras.BackgroundImage = global::SistemaPedidos.Properties.Resources.VOLVER;
            this.botonAtras.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.botonAtras.FlatAppearance.BorderSize = 0;
            this.botonAtras.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.botonAtras.Location = new System.Drawing.Point(11, 201);
            this.botonAtras.Margin = new System.Windows.Forms.Padding(2);
            this.botonAtras.Name = "botonAtras";
            this.botonAtras.Size = new System.Drawing.Size(63, 61);
            this.botonAtras.TabIndex = 2;
            this.botonAtras.UseVisualStyleBackColor = false;
            this.botonAtras.Click += new System.EventHandler(this.botonAtras_Click);
            // 
            // botonRegistrar
            // 
            this.botonRegistrar.BackColor = System.Drawing.Color.Transparent;
            this.botonRegistrar.BackgroundImage = global::SistemaPedidos.Properties.Resources.CIRCULO_ACEPTAR;
            this.botonRegistrar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.botonRegistrar.FlatAppearance.BorderSize = 0;
            this.botonRegistrar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.botonRegistrar.Location = new System.Drawing.Point(425, 201);
            this.botonRegistrar.Margin = new System.Windows.Forms.Padding(2);
            this.botonRegistrar.Name = "botonRegistrar";
            this.botonRegistrar.Size = new System.Drawing.Size(63, 61);
            this.botonRegistrar.TabIndex = 4;
            this.botonRegistrar.UseVisualStyleBackColor = false;
            this.botonRegistrar.Click += new System.EventHandler(this.botonRegistrar_Click);
            // 
            // botonLimpiar
            // 
            this.botonLimpiar.BackColor = System.Drawing.Color.Transparent;
            this.botonLimpiar.BackgroundImage = global::SistemaPedidos.Properties.Resources.CIRCULO_LIMPIAR;
            this.botonLimpiar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.botonLimpiar.FlatAppearance.BorderSize = 0;
            this.botonLimpiar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.botonLimpiar.Location = new System.Drawing.Point(208, 201);
            this.botonLimpiar.Margin = new System.Windows.Forms.Padding(2);
            this.botonLimpiar.Name = "botonLimpiar";
            this.botonLimpiar.Size = new System.Drawing.Size(63, 61);
            this.botonLimpiar.TabIndex = 3;
            this.botonLimpiar.UseVisualStyleBackColor = false;
            this.botonLimpiar.Click += new System.EventHandler(this.botonLimpiar_Click);
            // 
            // textoCiudad
            // 
            this.textoCiudad.AutoSize = true;
            this.textoCiudad.BackColor = System.Drawing.Color.Azure;
            this.textoCiudad.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textoCiudad.Font = new System.Drawing.Font("Helvetica", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textoCiudad.Location = new System.Drawing.Point(31, 76);
            this.textoCiudad.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.textoCiudad.Name = "textoCiudad";
            this.textoCiudad.Size = new System.Drawing.Size(88, 27);
            this.textoCiudad.TabIndex = 35;
            this.textoCiudad.Text = "Ciudad:";
            // 
            // textoDireccion
            // 
            this.textoDireccion.AutoSize = true;
            this.textoDireccion.BackColor = System.Drawing.Color.Azure;
            this.textoDireccion.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textoDireccion.Font = new System.Drawing.Font("Helvetica", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textoDireccion.Location = new System.Drawing.Point(31, 124);
            this.textoDireccion.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.textoDireccion.Name = "textoDireccion";
            this.textoDireccion.Size = new System.Drawing.Size(110, 27);
            this.textoDireccion.TabIndex = 36;
            this.textoDireccion.Text = "Dirección:";
            // 
            // cajaDireccion
            // 
            this.cajaDireccion.Font = new System.Drawing.Font("Helvetica", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cajaDireccion.Location = new System.Drawing.Point(156, 124);
            this.cajaDireccion.Margin = new System.Windows.Forms.Padding(2);
            this.cajaDireccion.MaxLength = 100;
            this.cajaDireccion.Name = "cajaDireccion";
            this.cajaDireccion.Size = new System.Drawing.Size(291, 29);
            this.cajaDireccion.TabIndex = 1;
            // 
            // cajaCiudad
            // 
            this.cajaCiudad.Font = new System.Drawing.Font("Helvetica", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cajaCiudad.Location = new System.Drawing.Point(156, 76);
            this.cajaCiudad.Margin = new System.Windows.Forms.Padding(2);
            this.cajaCiudad.MaxLength = 50;
            this.cajaCiudad.Name = "cajaCiudad";
            this.cajaCiudad.Size = new System.Drawing.Size(131, 29);
            this.cajaCiudad.TabIndex = 0;
            this.cajaCiudad.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.cajaCiudad_KeyPress);
            // 
            // PrincipalClientesVerModificarAnexarDireccion
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::SistemaPedidos.Properties.Resources.FORMULARIO_NUEVA_DIRECCION;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(499, 271);
            this.Controls.Add(this.cajaCiudad);
            this.Controls.Add(this.cajaDireccion);
            this.Controls.Add(this.textoDireccion);
            this.Controls.Add(this.textoCiudad);
            this.Controls.Add(this.botonLimpiar);
            this.Controls.Add(this.botonRegistrar);
            this.Controls.Add(this.botonAtras);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Margin = new System.Windows.Forms.Padding(2);
            this.MaximizeBox = false;
            this.Name = "PrincipalClientesVerModificarAnexarDireccion";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Distribuidora InVicTus";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button botonAtras;
        private System.Windows.Forms.Button botonRegistrar;
        private System.Windows.Forms.Button botonLimpiar;
        private System.Windows.Forms.Label textoCiudad;
        private System.Windows.Forms.Label textoDireccion;
        private System.Windows.Forms.TextBox cajaDireccion;
        private System.Windows.Forms.TextBox cajaCiudad;
    }
}