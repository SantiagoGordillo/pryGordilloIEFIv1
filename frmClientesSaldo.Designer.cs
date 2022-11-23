namespace pryGordilloIEFIv1
{
    partial class frmClientesSaldo
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmClientesSaldo));
            this.pnlMenu = new System.Windows.Forms.Panel();
            this.cmdCerrar = new System.Windows.Forms.PictureBox();
            this.lblListado = new System.Windows.Forms.Label();
            this.mrcConsulta = new System.Windows.Forms.GroupBox();
            this.lblPromedio = new System.Windows.Forms.Label();
            this.lblClientes = new System.Windows.Forms.Label();
            this.lblPromedioDeSaldos = new System.Windows.Forms.Label();
            this.cmdListar = new System.Windows.Forms.Button();
            this.lblTotal = new System.Windows.Forms.Label();
            this.lblCantidadDeClientes = new System.Windows.Forms.Label();
            this.lblTotaldeSaldos = new System.Windows.Forms.Label();
            this.dgvDuedas = new System.Windows.Forms.DataGridView();
            this.pnlMenu.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.cmdCerrar)).BeginInit();
            this.mrcConsulta.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDuedas)).BeginInit();
            this.SuspendLayout();
            // 
            // pnlMenu
            // 
            this.pnlMenu.BackColor = System.Drawing.Color.Silver;
            this.pnlMenu.Controls.Add(this.cmdCerrar);
            this.pnlMenu.Controls.Add(this.lblListado);
            this.pnlMenu.Location = new System.Drawing.Point(-20, -18);
            this.pnlMenu.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.pnlMenu.Name = "pnlMenu";
            this.pnlMenu.Size = new System.Drawing.Size(870, 71);
            this.pnlMenu.TabIndex = 0;
            // 
            // cmdCerrar
            // 
            this.cmdCerrar.Image = ((System.Drawing.Image)(resources.GetObject("cmdCerrar.Image")));
            this.cmdCerrar.Location = new System.Drawing.Point(621, 29);
            this.cmdCerrar.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.cmdCerrar.Name = "cmdCerrar";
            this.cmdCerrar.Size = new System.Drawing.Size(34, 28);
            this.cmdCerrar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.cmdCerrar.TabIndex = 2;
            this.cmdCerrar.TabStop = false;
            this.cmdCerrar.Click += new System.EventHandler(this.cmdCerrar_Click);
            // 
            // lblListado
            // 
            this.lblListado.AutoSize = true;
            this.lblListado.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblListado.Location = new System.Drawing.Point(34, 29);
            this.lblListado.Name = "lblListado";
            this.lblListado.Size = new System.Drawing.Size(223, 26);
            this.lblListado.TabIndex = 1;
            this.lblListado.Text = "Listado de Clientes ";
            // 
            // mrcConsulta
            // 
            this.mrcConsulta.Controls.Add(this.lblPromedio);
            this.mrcConsulta.Controls.Add(this.lblClientes);
            this.mrcConsulta.Controls.Add(this.lblPromedioDeSaldos);
            this.mrcConsulta.Controls.Add(this.cmdListar);
            this.mrcConsulta.Controls.Add(this.lblTotal);
            this.mrcConsulta.Controls.Add(this.lblCantidadDeClientes);
            this.mrcConsulta.Controls.Add(this.lblTotaldeSaldos);
            this.mrcConsulta.Controls.Add(this.dgvDuedas);
            this.mrcConsulta.Location = new System.Drawing.Point(18, 81);
            this.mrcConsulta.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.mrcConsulta.Name = "mrcConsulta";
            this.mrcConsulta.Padding = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.mrcConsulta.Size = new System.Drawing.Size(616, 453);
            this.mrcConsulta.TabIndex = 1;
            this.mrcConsulta.TabStop = false;
            this.mrcConsulta.Text = "Consulta de datos";
            // 
            // lblPromedio
            // 
            this.lblPromedio.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblPromedio.Location = new System.Drawing.Point(195, 382);
            this.lblPromedio.Name = "lblPromedio";
            this.lblPromedio.Size = new System.Drawing.Size(197, 39);
            this.lblPromedio.TabIndex = 7;
            // 
            // lblClientes
            // 
            this.lblClientes.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblClientes.Location = new System.Drawing.Point(195, 320);
            this.lblClientes.Name = "lblClientes";
            this.lblClientes.Size = new System.Drawing.Size(197, 39);
            this.lblClientes.TabIndex = 6;
            // 
            // lblPromedioDeSaldos
            // 
            this.lblPromedioDeSaldos.AutoSize = true;
            this.lblPromedioDeSaldos.Location = new System.Drawing.Point(20, 394);
            this.lblPromedioDeSaldos.Name = "lblPromedioDeSaldos";
            this.lblPromedioDeSaldos.Size = new System.Drawing.Size(151, 20);
            this.lblPromedioDeSaldos.TabIndex = 5;
            this.lblPromedioDeSaldos.Text = "Promedio de Saldos";
            // 
            // cmdListar
            // 
            this.cmdListar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(56)))), ((int)(((byte)(56)))), ((int)(((byte)(56)))));
            this.cmdListar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cmdListar.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmdListar.ForeColor = System.Drawing.Color.White;
            this.cmdListar.Location = new System.Drawing.Point(461, 382);
            this.cmdListar.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.cmdListar.Name = "cmdListar";
            this.cmdListar.Size = new System.Drawing.Size(137, 50);
            this.cmdListar.TabIndex = 4;
            this.cmdListar.Text = "Listar";
            this.cmdListar.UseVisualStyleBackColor = false;
            this.cmdListar.Click += new System.EventHandler(this.cmdListar_Click);
            // 
            // lblTotal
            // 
            this.lblTotal.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblTotal.Location = new System.Drawing.Point(195, 257);
            this.lblTotal.Name = "lblTotal";
            this.lblTotal.Size = new System.Drawing.Size(197, 39);
            this.lblTotal.TabIndex = 3;
            // 
            // lblCantidadDeClientes
            // 
            this.lblCantidadDeClientes.AutoSize = true;
            this.lblCantidadDeClientes.Location = new System.Drawing.Point(20, 330);
            this.lblCantidadDeClientes.Name = "lblCantidadDeClientes";
            this.lblCantidadDeClientes.Size = new System.Drawing.Size(153, 20);
            this.lblCantidadDeClientes.TabIndex = 2;
            this.lblCantidadDeClientes.Text = "Cantidad de clientes";
            // 
            // lblTotaldeSaldos
            // 
            this.lblTotaldeSaldos.AutoSize = true;
            this.lblTotaldeSaldos.Location = new System.Drawing.Point(20, 267);
            this.lblTotaldeSaldos.Name = "lblTotaldeSaldos";
            this.lblTotaldeSaldos.Size = new System.Drawing.Size(116, 20);
            this.lblTotaldeSaldos.TabIndex = 1;
            this.lblTotaldeSaldos.Text = "Total de saldos";
            // 
            // dgvDuedas
            // 
            this.dgvDuedas.AllowUserToAddRows = false;
            this.dgvDuedas.AllowUserToDeleteRows = false;
            this.dgvDuedas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDuedas.Location = new System.Drawing.Point(22, 41);
            this.dgvDuedas.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.dgvDuedas.Name = "dgvDuedas";
            this.dgvDuedas.ReadOnly = true;
            this.dgvDuedas.RowHeadersWidth = 51;
            this.dgvDuedas.RowTemplate.Height = 24;
            this.dgvDuedas.Size = new System.Drawing.Size(576, 199);
            this.dgvDuedas.TabIndex = 0;
            // 
            // frmClientesSaldo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(648, 553);
            this.Controls.Add(this.mrcConsulta);
            this.Controls.Add(this.pnlMenu);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "frmClientesSaldo";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Listado de Clientes Deudores";
            this.pnlMenu.ResumeLayout(false);
            this.pnlMenu.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.cmdCerrar)).EndInit();
            this.mrcConsulta.ResumeLayout(false);
            this.mrcConsulta.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDuedas)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel pnlMenu;
        private System.Windows.Forms.Label lblListado;
        private System.Windows.Forms.GroupBox mrcConsulta;
        private System.Windows.Forms.DataGridView dgvDuedas;
        private System.Windows.Forms.Label lblPromedio;
        private System.Windows.Forms.Label lblClientes;
        private System.Windows.Forms.Label lblPromedioDeSaldos;
        private System.Windows.Forms.Button cmdListar;
        private System.Windows.Forms.Label lblTotal;
        private System.Windows.Forms.Label lblCantidadDeClientes;
        private System.Windows.Forms.Label lblTotaldeSaldos;
        private System.Windows.Forms.PictureBox cmdCerrar;
    }
}