﻿namespace SistemaPedidos.VistasProductos
{
    partial class PrincipalPedidosSeleccionarProducto
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
            this.textoVerPor = new System.Windows.Forms.Label();
            this.cajaVerPor = new System.Windows.Forms.ComboBox();
            this.botonAtras = new System.Windows.Forms.Button();
            this.MostrarProductos = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.MostrarProductos)).BeginInit();
            this.SuspendLayout();
            // 
            // textoBuscar
            // 
            this.textoBuscar.AutoSize = true;
            this.textoBuscar.BackColor = System.Drawing.Color.Azure;
            this.textoBuscar.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textoBuscar.Font = new System.Drawing.Font("Helvetica", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textoBuscar.Location = new System.Drawing.Point(900, 30);
            this.textoBuscar.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.textoBuscar.Name = "textoBuscar";
            this.textoBuscar.Size = new System.Drawing.Size(87, 27);
            this.textoBuscar.TabIndex = 36;
            this.textoBuscar.Text = "Buscar:";
            // 
            // cajaBuscar
            // 
            this.cajaBuscar.Font = new System.Drawing.Font("Helvetica", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cajaBuscar.Location = new System.Drawing.Point(991, 29);
            this.cajaBuscar.Margin = new System.Windows.Forms.Padding(2);
            this.cajaBuscar.Name = "cajaBuscar";
            this.cajaBuscar.Size = new System.Drawing.Size(206, 29);
            this.cajaBuscar.TabIndex = 37;
            this.cajaBuscar.KeyUp += new System.Windows.Forms.KeyEventHandler(this.cajaBuscar_KeyUp);
            // 
            // textoVerPor
            // 
            this.textoVerPor.AutoSize = true;
            this.textoVerPor.BackColor = System.Drawing.Color.Azure;
            this.textoVerPor.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textoVerPor.Font = new System.Drawing.Font("Helvetica", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textoVerPor.Location = new System.Drawing.Point(11, 359);
            this.textoVerPor.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.textoVerPor.Name = "textoVerPor";
            this.textoVerPor.Size = new System.Drawing.Size(92, 27);
            this.textoVerPor.TabIndex = 38;
            this.textoVerPor.Text = "Ver Por:";
            // 
            // cajaVerPor
            // 
            this.cajaVerPor.BackColor = System.Drawing.Color.Azure;
            this.cajaVerPor.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cajaVerPor.Font = new System.Drawing.Font("Helvetica", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cajaVerPor.FormattingEnabled = true;
            this.cajaVerPor.Location = new System.Drawing.Point(108, 358);
            this.cajaVerPor.Name = "cajaVerPor";
            this.cajaVerPor.Size = new System.Drawing.Size(370, 30);
            this.cajaVerPor.TabIndex = 39;
            this.cajaVerPor.SelectedIndexChanged += new System.EventHandler(this.cajaVerPor_SelectedIndexChanged);
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
            this.botonAtras.TabIndex = 40;
            this.botonAtras.UseVisualStyleBackColor = false;
            this.botonAtras.Click += new System.EventHandler(this.botonAtras_Click);
            // 
            // MostrarProductos
            // 
            this.MostrarProductos.AllowUserToAddRows = false;
            this.MostrarProductos.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.MostrarProductos.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.MostrarProductos.BackgroundColor = System.Drawing.Color.LightSeaGreen;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Helvetica", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.Padding = new System.Windows.Forms.Padding(2);
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.MostrarProductos.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.MostrarProductos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Helvetica", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.Padding = new System.Windows.Forms.Padding(2);
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.MostrarProductos.DefaultCellStyle = dataGridViewCellStyle2;
            this.MostrarProductos.Location = new System.Drawing.Point(10, 64);
            this.MostrarProductos.Margin = new System.Windows.Forms.Padding(4);
            this.MostrarProductos.Name = "MostrarProductos";
            this.MostrarProductos.ReadOnly = true;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Helvetica", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle3.Padding = new System.Windows.Forms.Padding(2);
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.MostrarProductos.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.MostrarProductos.RowHeadersVisible = false;
            this.MostrarProductos.Size = new System.Drawing.Size(1197, 288);
            this.MostrarProductos.TabIndex = 41;
            this.MostrarProductos.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.MostrarProductos_CellContentClick_1);
            // 
            // PrincipalPedidosSeleccionarProducto
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::SistemaPedidos.Properties.Resources.REGISTRO_PEDIDOS_PRODUCTOS;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1220, 449);
            this.Controls.Add(this.MostrarProductos);
            this.Controls.Add(this.botonAtras);
            this.Controls.Add(this.cajaVerPor);
            this.Controls.Add(this.textoVerPor);
            this.Controls.Add(this.cajaBuscar);
            this.Controls.Add(this.textoBuscar);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.MaximizeBox = false;
            this.Name = "PrincipalPedidosSeleccionarProducto";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Distribuidora InVicTus";
            this.Load += new System.EventHandler(this.PrincipalPedidosSeleccionarProducto_Load);
            ((System.ComponentModel.ISupportInitialize)(this.MostrarProductos)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label textoBuscar;
        private System.Windows.Forms.TextBox cajaBuscar;
        private System.Windows.Forms.Label textoVerPor;
        private System.Windows.Forms.ComboBox cajaVerPor;
        private System.Windows.Forms.Button botonAtras;
        private System.Windows.Forms.DataGridView MostrarProductos;
    }
}