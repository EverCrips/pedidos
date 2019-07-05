namespace SistemaPedidos.VistasPedidos
{
    partial class PrincipalProductosVer
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.MostrarProductos = new System.Windows.Forms.DataGridView();
            this.textoBuscar = new System.Windows.Forms.Label();
            this.cajaBuscar = new System.Windows.Forms.TextBox();
            this.textoVerPor = new System.Windows.Forms.Label();
            this.cajaVerPor = new System.Windows.Forms.ComboBox();
            this.botonAtras = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.MostrarProductos)).BeginInit();
            this.SuspendLayout();
            // 
            // MostrarProductos
            // 
            this.MostrarProductos.AllowUserToAddRows = false;
            this.MostrarProductos.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.MostrarProductos.BackgroundColor = System.Drawing.Color.LightSeaGreen;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.MostrarProductos.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.MostrarProductos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.MostrarProductos.DefaultCellStyle = dataGridViewCellStyle2;
            this.MostrarProductos.Location = new System.Drawing.Point(12, 58);
            this.MostrarProductos.Margin = new System.Windows.Forms.Padding(4);
            this.MostrarProductos.Name = "MostrarProductos";
            this.MostrarProductos.ReadOnly = true;
            this.MostrarProductos.RowHeadersVisible = false;
            this.MostrarProductos.Size = new System.Drawing.Size(940, 288);
            this.MostrarProductos.TabIndex = 31;
            this.MostrarProductos.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.MostrarProductos_CellContentClick);
            // 
            // textoBuscar
            // 
            this.textoBuscar.AutoSize = true;
            this.textoBuscar.BackColor = System.Drawing.Color.Azure;
            this.textoBuscar.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textoBuscar.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textoBuscar.Location = new System.Drawing.Point(671, 26);
            this.textoBuscar.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.textoBuscar.Name = "textoBuscar";
            this.textoBuscar.Size = new System.Drawing.Size(75, 26);
            this.textoBuscar.TabIndex = 35;
            this.textoBuscar.Text = "Buscar:";
            // 
            // cajaBuscar
            // 
            this.cajaBuscar.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cajaBuscar.Location = new System.Drawing.Point(747, 29);
            this.cajaBuscar.Margin = new System.Windows.Forms.Padding(2);
            this.cajaBuscar.Name = "cajaBuscar";
            this.cajaBuscar.Size = new System.Drawing.Size(206, 23);
            this.cajaBuscar.TabIndex = 36;
            this.cajaBuscar.KeyUp += new System.Windows.Forms.KeyEventHandler(this.cajaBuscar_KeyUp);
            // 
            // textoVerPor
            // 
            this.textoVerPor.AutoSize = true;
            this.textoVerPor.BackColor = System.Drawing.Color.Azure;
            this.textoVerPor.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textoVerPor.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textoVerPor.Location = new System.Drawing.Point(12, 353);
            this.textoVerPor.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.textoVerPor.Name = "textoVerPor";
            this.textoVerPor.Size = new System.Drawing.Size(81, 26);
            this.textoVerPor.TabIndex = 37;
            this.textoVerPor.Text = "Ver Por:";
            // 
            // cajaVerPor
            // 
            this.cajaVerPor.BackColor = System.Drawing.Color.Azure;
            this.cajaVerPor.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cajaVerPor.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cajaVerPor.FormattingEnabled = true;
            this.cajaVerPor.Location = new System.Drawing.Point(104, 357);
            this.cajaVerPor.Name = "cajaVerPor";
            this.cajaVerPor.Size = new System.Drawing.Size(266, 25);
            this.cajaVerPor.TabIndex = 38;
            this.cajaVerPor.SelectedIndexChanged += new System.EventHandler(this.cajaVerPor_SelectedIndexChanged);
            // 
            // botonAtras
            // 
            this.botonAtras.BackColor = System.Drawing.Color.Transparent;
            this.botonAtras.BackgroundImage = global::SistemaPedidos.Properties.Resources.VOLVER;
            this.botonAtras.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.botonAtras.FlatAppearance.BorderSize = 0;
            this.botonAtras.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.botonAtras.Location = new System.Drawing.Point(884, 375);
            this.botonAtras.Margin = new System.Windows.Forms.Padding(2);
            this.botonAtras.Name = "botonAtras";
            this.botonAtras.Size = new System.Drawing.Size(69, 65);
            this.botonAtras.TabIndex = 39;
            this.botonAtras.UseVisualStyleBackColor = false;
            this.botonAtras.Click += new System.EventHandler(this.botonAtras_Click);
            // 
            // PrincipalProductosVer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::SistemaPedidos.Properties.Resources.REGISTRO_PRODUCTOS;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(962, 449);
            this.Controls.Add(this.botonAtras);
            this.Controls.Add(this.cajaVerPor);
            this.Controls.Add(this.textoVerPor);
            this.Controls.Add(this.cajaBuscar);
            this.Controls.Add(this.textoBuscar);
            this.Controls.Add(this.MostrarProductos);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Margin = new System.Windows.Forms.Padding(2);
            this.MaximizeBox = false;
            this.Name = "PrincipalProductosVer";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Distribuidora InVictus";
            this.Load += new System.EventHandler(this.PrincipalProductosVer_Load);
            ((System.ComponentModel.ISupportInitialize)(this.MostrarProductos)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView MostrarProductos;
        private System.Windows.Forms.Label textoBuscar;
        private System.Windows.Forms.TextBox cajaBuscar;
        private System.Windows.Forms.Label textoVerPor;
        private System.Windows.Forms.ComboBox cajaVerPor;
        private System.Windows.Forms.Button botonAtras;
    }
}