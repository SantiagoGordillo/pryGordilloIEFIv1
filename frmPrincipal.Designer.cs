namespace pryGordilloIEFIv1
{
    partial class frmPrincipal
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmPrincipal));
            this.imgLogo = new System.Windows.Forms.PictureBox();
            this.msInicio = new System.Windows.Forms.MenuStrip();
            this.tsmSocios = new System.Windows.Forms.ToolStripMenuItem();
            this.tsiAgregar = new System.Windows.Forms.ToolStripMenuItem();
            this.tsiModificar = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmConsultas = new System.Windows.Forms.ToolStripMenuItem();
            this.tsiListadoClientes = new System.Windows.Forms.ToolStripMenuItem();
            this.tsiListadoSaldoClientes = new System.Windows.Forms.ToolStripMenuItem();
            this.tsiListadoClientesBarrio = new System.Windows.Forms.ToolStripMenuItem();
            this.tsiListadoClientesActividad = new System.Windows.Forms.ToolStripMenuItem();
            this.tsiListadoClientesDeudores = new System.Windows.Forms.ToolStripMenuItem();
            this.tsSeparador = new System.Windows.Forms.ToolStripSeparator();
            this.tsiConsultaCliente = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmBarrios = new System.Windows.Forms.ToolStripMenuItem();
            this.tsiAgregarBarrio = new System.Windows.Forms.ToolStripMenuItem();
            this.tsiEliminarBarrio = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmActividades = new System.Windows.Forms.ToolStripMenuItem();
            this.tsiAgregarActividad = new System.Windows.Forms.ToolStripMenuItem();
            this.tsiEliminarActividad = new System.Windows.Forms.ToolStripMenuItem();
            ((System.ComponentModel.ISupportInitialize)(this.imgLogo)).BeginInit();
            this.msInicio.SuspendLayout();
            this.SuspendLayout();
            // 
            // imgLogo
            // 
            this.imgLogo.Image = ((System.Drawing.Image)(resources.GetObject("imgLogo.Image")));
            this.imgLogo.Location = new System.Drawing.Point(12, 37);
            this.imgLogo.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.imgLogo.Name = "imgLogo";
            this.imgLogo.Size = new System.Drawing.Size(387, 336);
            this.imgLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.imgLogo.TabIndex = 1;
            this.imgLogo.TabStop = false;
            // 
            // msInicio
            // 
            this.msInicio.GripMargin = new System.Windows.Forms.Padding(2, 2, 0, 2);
            this.msInicio.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.msInicio.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmSocios,
            this.tsmConsultas,
            this.tsmBarrios,
            this.tsmActividades});
            this.msInicio.Location = new System.Drawing.Point(0, 0);
            this.msInicio.Name = "msInicio";
            this.msInicio.Padding = new System.Windows.Forms.Padding(7, 2, 0, 2);
            this.msInicio.Size = new System.Drawing.Size(411, 33);
            this.msInicio.TabIndex = 14;
            this.msInicio.Text = "menuStrip1";
            // 
            // tsmSocios
            // 
            this.tsmSocios.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsiAgregar,
            this.tsiModificar});
            this.tsmSocios.Name = "tsmSocios";
            this.tsmSocios.Size = new System.Drawing.Size(80, 29);
            this.tsmSocios.Text = "Socios";
            // 
            // tsiAgregar
            // 
            this.tsiAgregar.Name = "tsiAgregar";
            this.tsiAgregar.Size = new System.Drawing.Size(238, 34);
            this.tsiAgregar.Text = "Agregar";
            this.tsiAgregar.Click += new System.EventHandler(this.tsiAgregar_Click);
            // 
            // tsiModificar
            // 
            this.tsiModificar.Name = "tsiModificar";
            this.tsiModificar.Size = new System.Drawing.Size(238, 34);
            this.tsiModificar.Text = "Modificar / Baja";
            this.tsiModificar.Click += new System.EventHandler(this.tsiModificar_Click);
            // 
            // tsmConsultas
            // 
            this.tsmConsultas.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsiListadoClientes,
            this.tsiListadoSaldoClientes,
            this.tsiListadoClientesBarrio,
            this.tsiListadoClientesActividad,
            this.tsiListadoClientesDeudores,
            this.tsSeparador,
            this.tsiConsultaCliente});
            this.tsmConsultas.Name = "tsmConsultas";
            this.tsmConsultas.Size = new System.Drawing.Size(105, 29);
            this.tsmConsultas.Text = "Consultas";
            // 
            // tsiListadoClientes
            // 
            this.tsiListadoClientes.Name = "tsiListadoClientes";
            this.tsiListadoClientes.Size = new System.Drawing.Size(380, 34);
            this.tsiListadoClientes.Text = "Listado de todos los clientes...";
            this.tsiListadoClientes.Click += new System.EventHandler(this.tsiListadoClientes_CLick);
            // 
            // tsiListadoSaldoClientes
            // 
            this.tsiListadoSaldoClientes.Name = "tsiListadoSaldoClientes";
            this.tsiListadoSaldoClientes.Size = new System.Drawing.Size(380, 34);
            this.tsiListadoSaldoClientes.Text = "Listado de saldo de clientes...";
            this.tsiListadoSaldoClientes.Click += new System.EventHandler(this.tsiListadoSaldoClientes_Click);
            // 
            // tsiListadoClientesBarrio
            // 
            this.tsiListadoClientesBarrio.Name = "tsiListadoClientesBarrio";
            this.tsiListadoClientesBarrio.Size = new System.Drawing.Size(380, 34);
            this.tsiListadoClientesBarrio.Text = "Listado de clientes por barrio...";
            this.tsiListadoClientesBarrio.Click += new System.EventHandler(this.tsiListadoClientesBarrio_Click);
            // 
            // tsiListadoClientesActividad
            // 
            this.tsiListadoClientesActividad.Name = "tsiListadoClientesActividad";
            this.tsiListadoClientesActividad.Size = new System.Drawing.Size(380, 34);
            this.tsiListadoClientesActividad.Text = "Listado de clientes por actividad...";
            this.tsiListadoClientesActividad.Click += new System.EventHandler(this.tsiListadoClientesActividad_Click);
            // 
            // tsiListadoClientesDeudores
            // 
            this.tsiListadoClientesDeudores.Name = "tsiListadoClientesDeudores";
            this.tsiListadoClientesDeudores.Size = new System.Drawing.Size(380, 34);
            this.tsiListadoClientesDeudores.Text = "Listado de clientes deudores...";
            this.tsiListadoClientesDeudores.Click += new System.EventHandler(this.tsiListadoClientesDeudores_Click);
            // 
            // tsSeparador
            // 
            this.tsSeparador.Name = "tsSeparador";
            this.tsSeparador.Size = new System.Drawing.Size(377, 6);
            // 
            // tsiConsultaCliente
            // 
            this.tsiConsultaCliente.Name = "tsiConsultaCliente";
            this.tsiConsultaCliente.Size = new System.Drawing.Size(380, 34);
            this.tsiConsultaCliente.Text = "Consulta de un cliente...";
            this.tsiConsultaCliente.Click += new System.EventHandler(this.tsiConsultaCliente_Click);
            // 
            // tsmBarrios
            // 
            this.tsmBarrios.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsiAgregarBarrio,
            this.tsiEliminarBarrio});
            this.tsmBarrios.Name = "tsmBarrios";
            this.tsmBarrios.Size = new System.Drawing.Size(82, 29);
            this.tsmBarrios.Text = "Barrios";
            // 
            // tsiAgregarBarrio
            // 
            this.tsiAgregarBarrio.Name = "tsiAgregarBarrio";
            this.tsiAgregarBarrio.Size = new System.Drawing.Size(178, 34);
            this.tsiAgregarBarrio.Text = "Agregar";
            this.tsiAgregarBarrio.Click += new System.EventHandler(this.tsiAgregarBarrio_Click);
            // 
            // tsiEliminarBarrio
            // 
            this.tsiEliminarBarrio.Name = "tsiEliminarBarrio";
            this.tsiEliminarBarrio.Size = new System.Drawing.Size(178, 34);
            this.tsiEliminarBarrio.Text = "Eliminar";
            this.tsiEliminarBarrio.Click += new System.EventHandler(this.tsiEliminarbarrio_Click);
            // 
            // tsmActividades
            // 
            this.tsmActividades.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsiAgregarActividad,
            this.tsiEliminarActividad});
            this.tsmActividades.Name = "tsmActividades";
            this.tsmActividades.Size = new System.Drawing.Size(119, 29);
            this.tsmActividades.Text = "Actividades";
            // 
            // tsiAgregarActividad
            // 
            this.tsiAgregarActividad.Name = "tsiAgregarActividad";
            this.tsiAgregarActividad.Size = new System.Drawing.Size(270, 34);
            this.tsiAgregarActividad.Text = "Agregar";
            this.tsiAgregarActividad.Click += new System.EventHandler(this.tsiAgregarActividad_Click);
            // 
            // tsiEliminarActividad
            // 
            this.tsiEliminarActividad.Name = "tsiEliminarActividad";
            this.tsiEliminarActividad.Size = new System.Drawing.Size(270, 34);
            this.tsiEliminarActividad.Text = "Eliminar";
            this.tsiEliminarActividad.Click += new System.EventHandler(this.tsiEliminarActividad_Click);
            // 
            // frmPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(411, 344);
            this.Controls.Add(this.imgLogo);
            this.Controls.Add(this.msInicio);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.MaximizeBox = false;
            this.Name = "frmPrincipal";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Inicio";
            ((System.ComponentModel.ISupportInitialize)(this.imgLogo)).EndInit();
            this.msInicio.ResumeLayout(false);
            this.msInicio.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.PictureBox imgLogo;
        private System.Windows.Forms.MenuStrip msInicio;
        private System.Windows.Forms.ToolStripMenuItem tsmSocios;
        private System.Windows.Forms.ToolStripMenuItem tsiAgregar;
        private System.Windows.Forms.ToolStripMenuItem tsiModificar;
        private System.Windows.Forms.ToolStripMenuItem tsmConsultas;
        private System.Windows.Forms.ToolStripMenuItem tsiListadoClientes;
        private System.Windows.Forms.ToolStripMenuItem tsiListadoSaldoClientes;
        private System.Windows.Forms.ToolStripMenuItem tsiListadoClientesBarrio;
        private System.Windows.Forms.ToolStripMenuItem tsiListadoClientesActividad;
        private System.Windows.Forms.ToolStripMenuItem tsmBarrios;
        private System.Windows.Forms.ToolStripMenuItem tsiAgregarBarrio;
        private System.Windows.Forms.ToolStripMenuItem tsiEliminarBarrio;
        private System.Windows.Forms.ToolStripMenuItem tsmActividades;
        private System.Windows.Forms.ToolStripMenuItem tsiAgregarActividad;
        private System.Windows.Forms.ToolStripMenuItem tsiEliminarActividad;
        private System.Windows.Forms.ToolStripMenuItem tsiListadoClientesDeudores;
        private System.Windows.Forms.ToolStripSeparator tsSeparador;
        private System.Windows.Forms.ToolStripMenuItem tsiConsultaCliente;
    }
}