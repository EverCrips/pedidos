namespace SistemaPedidos.VistasPedidos
{
    partial class PrincipalPedidosVer
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.textoBuscar = new System.Windows.Forms.Label();
            this.cajaBuscar = new System.Windows.Forms.TextBox();
            this.MostrarPedidos = new System.Windows.Forms.DataGridView();
            this.botonAtras = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.MostrarPedidos)).BeginInit();
            this.SuspendLayout();
            // 
            // textoBuscar
            // 
            this.textoBuscar.AutoSize = true;
            this.textoBuscar.BackColor = System.Drawing.Color.Azure;
            this.textoBuscar.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textoBuscar.Font = new System.Drawing.Font("Helvetica", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textoBuscar.Location = new System.Drawing.Point(910, 29);
            this.textoBuscar.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.textoBuscar.Name = "textoBuscar";
            this.textoBuscar.Size = new System.Drawing.Size(87, 27);
            this.textoBuscar.TabIndex = 35;
            this.textoBuscar.Text = "Buscar:";
            // 
            // cajaBuscar
            // 
            this.cajaBuscar.Font = new System.Drawing.Font("Helvetica", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cajaBuscar.Location = new System.Drawing.Point(1001, 27);
            this.cajaBuscar.Margin = new System.Windows.Forms.Padding(2);
            this.cajaBuscar.Name = "cajaBuscar";
            this.cajaBuscar.Size = new System.Drawing.Size(206, 29);
            this.cajaBuscar.TabIndex = 36;
            this.cajaBuscar.KeyUp += new System.Windows.Forms.KeyEventHandler(this.cajaBuscar_KeyUp);
            // 
            // MostrarPedidos
            // 
            this.MostrarPedidos.AllowUserToAddRows = false;
            this.MostrarPedidos.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.MostrarPedidos.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.MostrarPedidos.BackgroundColor = System.Drawing.Color.LightSeaGreen;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Helvetica", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.Padding = new System.Windows.Forms.Padding(2);
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.MostrarPedidos.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.MostrarPedidos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Helvetica", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.Padding = new System.Windows.Forms.Padding(2);
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.MostrarPedidos.DefaultCellStyle = dataGridViewCellStyle2;
            this.MostrarPedidos.Location = new System.Drawing.Point(10, 64);
            this.MostrarPedidos.Margin = new System.Windows.Forms.Padding(4);
            this.MostrarPedidos.Name = "MostrarPedidos";
            this.MostrarPedidos.ReadOnly = true;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Helvetica", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle3.Padding = new System.Windows.Forms.Padding(2);
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.MostrarPedidos.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.MostrarPedidos.RowHeadersVisible = false;
            this.MostrarPedidos.Size = new System.Drawing.Size(1197, 288);
            this.MostrarPedidos.TabIndex = 37;
            this.MostrarPedidos.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.MostrarPedidos_CellContentClick);
            // 
            // botonAtras
            // 
            this.botonAtras.BackColor = System.Drawing.Color.Transparent;
            this.botonAtras.BackgroundImage = global::SistemaPedidos.Properties.Resources.VOLVER;
            this.botonAtras.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.botonAtras.FlatAppearance.BorderSize = 0;
            this.botonAtras.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.botonAtras.Location = new System.Drawing.Point(1138, 373);
            this.botonAtras.Margin = new System.Windows.Forms.Padding(2);
            this.botonAtras.Name = "botonAtras";
            this.botonAtras.Size = new System.Drawing.Size(69, 65);
            this.botonAtras.TabIndex = 38;
            this.botonAtras.UseVisualStyleBackColor = false;
            this.botonAtras.Click += new System.EventHandler(this.botonAtras_Click);
            // 
            // PrincipalPedidosVer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::SistemaPedidos.Properties.Resources.MENU_CLIENTE_VER1;
            this.ClientSize = new System.Drawing.Size(1220, 449);
            this.Controls.Add(this.botonAtras);
            this.Controls.Add(this.MostrarPedidos);
            this.Controls.Add(this.cajaBuscar);
            this.Controls.Add(this.textoBuscar);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.MaximizeBox = false;
            this.Name = "PrincipalPedidosVer";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Distribuidora InVicTus";
            this.Load += new System.EventHandler(this.PrincipalPedidosVer_Load);
            ((System.ComponentModel.ISupportInitialize)(this.MostrarPedidos)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label textoBuscar;
        private System.Windows.Forms.TextBox cajaBuscar;
        private System.Windows.Forms.DataGridView MostrarPedidos;
        private System.Windows.Forms.Button botonAtras;
    }
}