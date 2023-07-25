
namespace ProjectTesting
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.panelMenu = new System.Windows.Forms.Panel();
            this.btnClientes = new System.Windows.Forms.Button();
            this.btnZonas = new System.Windows.Forms.Button();
            this.btnSalir = new System.Windows.Forms.Button();
            this.btnSucursales = new System.Windows.Forms.Button();
            this.btnDietas = new System.Windows.Forms.Button();
            this.btnViandas = new System.Windows.Forms.Button();
            this.btnPedidos = new System.Windows.Forms.Button();
            this.btnMenus = new System.Windows.Forms.Button();
            this.panelButton = new System.Windows.Forms.Panel();
            this.panelOpciones = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.lblTitulo = new System.Windows.Forms.Label();
            this.fileSystemWatcher1 = new System.IO.FileSystemWatcher();
            this.btnEstadisticas = new System.Windows.Forms.Button();
            this.panelMenu.SuspendLayout();
            this.panelOpciones.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.fileSystemWatcher1)).BeginInit();
            this.SuspendLayout();
            // 
            // panelMenu
            // 
            this.panelMenu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(51)))), ((int)(((byte)(145)))));
            this.panelMenu.Controls.Add(this.btnEstadisticas);
            this.panelMenu.Controls.Add(this.btnClientes);
            this.panelMenu.Controls.Add(this.btnZonas);
            this.panelMenu.Controls.Add(this.btnSalir);
            this.panelMenu.Controls.Add(this.btnSucursales);
            this.panelMenu.Controls.Add(this.btnDietas);
            this.panelMenu.Controls.Add(this.btnViandas);
            this.panelMenu.Controls.Add(this.btnPedidos);
            this.panelMenu.Controls.Add(this.btnMenus);
            this.panelMenu.Controls.Add(this.panelButton);
            this.panelMenu.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelMenu.Location = new System.Drawing.Point(0, 0);
            this.panelMenu.Name = "panelMenu";
            this.panelMenu.Size = new System.Drawing.Size(194, 700);
            this.panelMenu.TabIndex = 0;
            // 
            // btnClientes
            // 
            this.btnClientes.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(51)))), ((int)(((byte)(145)))));
            this.btnClientes.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnClientes.FlatAppearance.BorderSize = 0;
            this.btnClientes.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClientes.Font = new System.Drawing.Font("Calibri", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClientes.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnClientes.Image = ((System.Drawing.Image)(resources.GetObject("btnClientes.Image")));
            this.btnClientes.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnClientes.Location = new System.Drawing.Point(0, 405);
            this.btnClientes.Name = "btnClientes";
            this.btnClientes.Padding = new System.Windows.Forms.Padding(0, 0, 0, 3);
            this.btnClientes.Size = new System.Drawing.Size(194, 50);
            this.btnClientes.TabIndex = 9;
            this.btnClientes.Text = "Clientes";
            this.btnClientes.UseVisualStyleBackColor = false;
            this.btnClientes.Click += new System.EventHandler(this.btnClientes_Click);
            // 
            // btnZonas
            // 
            this.btnZonas.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(51)))), ((int)(((byte)(145)))));
            this.btnZonas.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnZonas.FlatAppearance.BorderSize = 0;
            this.btnZonas.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnZonas.Font = new System.Drawing.Font("Calibri", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnZonas.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnZonas.Image = ((System.Drawing.Image)(resources.GetObject("btnZonas.Image")));
            this.btnZonas.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnZonas.Location = new System.Drawing.Point(0, 355);
            this.btnZonas.Name = "btnZonas";
            this.btnZonas.Padding = new System.Windows.Forms.Padding(0, 0, 0, 3);
            this.btnZonas.Size = new System.Drawing.Size(194, 50);
            this.btnZonas.TabIndex = 8;
            this.btnZonas.Text = "Zonas";
            this.btnZonas.UseVisualStyleBackColor = false;
            this.btnZonas.Click += new System.EventHandler(this.btnZonas_Click);
            // 
            // btnSalir
            // 
            this.btnSalir.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(51)))), ((int)(((byte)(145)))));
            this.btnSalir.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.btnSalir.FlatAppearance.BorderSize = 0;
            this.btnSalir.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSalir.Font = new System.Drawing.Font("Calibri", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSalir.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnSalir.Location = new System.Drawing.Point(0, 650);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(194, 50);
            this.btnSalir.TabIndex = 7;
            this.btnSalir.Text = "Salir";
            this.btnSalir.UseVisualStyleBackColor = false;
            this.btnSalir.Click += new System.EventHandler(this.btnSalir_Click);
            // 
            // btnSucursales
            // 
            this.btnSucursales.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(51)))), ((int)(((byte)(145)))));
            this.btnSucursales.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnSucursales.FlatAppearance.BorderSize = 0;
            this.btnSucursales.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSucursales.Font = new System.Drawing.Font("Calibri", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSucursales.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnSucursales.Image = ((System.Drawing.Image)(resources.GetObject("btnSucursales.Image")));
            this.btnSucursales.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnSucursales.Location = new System.Drawing.Point(0, 305);
            this.btnSucursales.Name = "btnSucursales";
            this.btnSucursales.Padding = new System.Windows.Forms.Padding(0, 0, 0, 3);
            this.btnSucursales.Size = new System.Drawing.Size(194, 50);
            this.btnSucursales.TabIndex = 5;
            this.btnSucursales.Text = "Sucursales";
            this.btnSucursales.UseVisualStyleBackColor = false;
            this.btnSucursales.Click += new System.EventHandler(this.btnSucursales_Click);
            // 
            // btnDietas
            // 
            this.btnDietas.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(51)))), ((int)(((byte)(145)))));
            this.btnDietas.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnDietas.FlatAppearance.BorderSize = 0;
            this.btnDietas.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDietas.Font = new System.Drawing.Font("Calibri", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDietas.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnDietas.Image = ((System.Drawing.Image)(resources.GetObject("btnDietas.Image")));
            this.btnDietas.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnDietas.Location = new System.Drawing.Point(0, 255);
            this.btnDietas.Name = "btnDietas";
            this.btnDietas.Padding = new System.Windows.Forms.Padding(0, 0, 0, 3);
            this.btnDietas.Size = new System.Drawing.Size(194, 50);
            this.btnDietas.TabIndex = 4;
            this.btnDietas.Text = "Dietas";
            this.btnDietas.UseVisualStyleBackColor = false;
            this.btnDietas.Click += new System.EventHandler(this.btnDietas_Click);
            this.btnDietas.MouseEnter += new System.EventHandler(this.btnClientes_MouseEnter);
            this.btnDietas.MouseLeave += new System.EventHandler(this.btnClientes_MouseLeave);
            // 
            // btnViandas
            // 
            this.btnViandas.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(51)))), ((int)(((byte)(145)))));
            this.btnViandas.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnViandas.FlatAppearance.BorderSize = 0;
            this.btnViandas.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnViandas.Font = new System.Drawing.Font("Calibri", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnViandas.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnViandas.Image = ((System.Drawing.Image)(resources.GetObject("btnViandas.Image")));
            this.btnViandas.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnViandas.Location = new System.Drawing.Point(0, 205);
            this.btnViandas.Name = "btnViandas";
            this.btnViandas.Padding = new System.Windows.Forms.Padding(0, 0, 0, 3);
            this.btnViandas.Size = new System.Drawing.Size(194, 50);
            this.btnViandas.TabIndex = 3;
            this.btnViandas.Text = "Viandas";
            this.btnViandas.UseVisualStyleBackColor = false;
            this.btnViandas.Click += new System.EventHandler(this.btnViandas_Click);
            this.btnViandas.MouseEnter += new System.EventHandler(this.btnViandas_MouseEnter);
            this.btnViandas.MouseLeave += new System.EventHandler(this.btnViandas_MouseLeave);
            // 
            // btnPedidos
            // 
            this.btnPedidos.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(51)))), ((int)(((byte)(145)))));
            this.btnPedidos.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnPedidos.FlatAppearance.BorderSize = 0;
            this.btnPedidos.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPedidos.Font = new System.Drawing.Font("Calibri", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPedidos.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnPedidos.Image = ((System.Drawing.Image)(resources.GetObject("btnPedidos.Image")));
            this.btnPedidos.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnPedidos.Location = new System.Drawing.Point(0, 155);
            this.btnPedidos.Name = "btnPedidos";
            this.btnPedidos.Padding = new System.Windows.Forms.Padding(0, 0, 0, 3);
            this.btnPedidos.Size = new System.Drawing.Size(194, 50);
            this.btnPedidos.TabIndex = 2;
            this.btnPedidos.Text = "Pedidos";
            this.btnPedidos.UseVisualStyleBackColor = false;
            this.btnPedidos.Click += new System.EventHandler(this.btnPedidos_Click);
            this.btnPedidos.MouseEnter += new System.EventHandler(this.btnPedidos_MouseEnter);
            this.btnPedidos.MouseLeave += new System.EventHandler(this.btnPedidos_MouseLeave);
            // 
            // btnMenus
            // 
            this.btnMenus.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(51)))), ((int)(((byte)(145)))));
            this.btnMenus.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnMenus.FlatAppearance.BorderSize = 0;
            this.btnMenus.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMenus.Font = new System.Drawing.Font("Calibri", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMenus.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnMenus.Image = ((System.Drawing.Image)(resources.GetObject("btnMenus.Image")));
            this.btnMenus.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnMenus.Location = new System.Drawing.Point(0, 105);
            this.btnMenus.Name = "btnMenus";
            this.btnMenus.Padding = new System.Windows.Forms.Padding(0, 0, 0, 3);
            this.btnMenus.Size = new System.Drawing.Size(194, 50);
            this.btnMenus.TabIndex = 1;
            this.btnMenus.Text = "Menus";
            this.btnMenus.UseVisualStyleBackColor = false;
            this.btnMenus.Click += new System.EventHandler(this.btnMenus_Click);
            this.btnMenus.MouseEnter += new System.EventHandler(this.btnMenus_MouseEnter);
            this.btnMenus.MouseLeave += new System.EventHandler(this.btnMenus_MouseLeave);
            // 
            // panelButton
            // 
            this.panelButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(51)))), ((int)(((byte)(148)))));
            this.panelButton.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelButton.Location = new System.Drawing.Point(0, 0);
            this.panelButton.Name = "panelButton";
            this.panelButton.Size = new System.Drawing.Size(194, 105);
            this.panelButton.TabIndex = 0;
            // 
            // panelOpciones
            // 
            this.panelOpciones.Controls.Add(this.panel1);
            this.panelOpciones.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelOpciones.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.panelOpciones.Location = new System.Drawing.Point(194, 0);
            this.panelOpciones.Name = "panelOpciones";
            this.panelOpciones.Size = new System.Drawing.Size(771, 700);
            this.panelOpciones.TabIndex = 1;
            this.panelOpciones.Paint += new System.Windows.Forms.PaintEventHandler(this.panelOpciones_Paint);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(64)))), ((int)(((byte)(174)))));
            this.panel1.Controls.Add(this.lblTitulo);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(771, 55);
            this.panel1.TabIndex = 10;
            // 
            // lblTitulo
            // 
            this.lblTitulo.AutoSize = true;
            this.lblTitulo.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitulo.Location = new System.Drawing.Point(22, 18);
            this.lblTitulo.Name = "lblTitulo";
            this.lblTitulo.Size = new System.Drawing.Size(68, 24);
            this.lblTitulo.TabIndex = 0;
            this.lblTitulo.Text = "Menus";
            // 
            // fileSystemWatcher1
            // 
            this.fileSystemWatcher1.EnableRaisingEvents = true;
            this.fileSystemWatcher1.SynchronizingObject = this;
            // 
            // btnEstadisticas
            // 
            this.btnEstadisticas.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(51)))), ((int)(((byte)(145)))));
            this.btnEstadisticas.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnEstadisticas.FlatAppearance.BorderSize = 0;
            this.btnEstadisticas.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEstadisticas.Font = new System.Drawing.Font("Calibri", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEstadisticas.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnEstadisticas.Image = ((System.Drawing.Image)(resources.GetObject("btnEstadisticas.Image")));
            this.btnEstadisticas.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnEstadisticas.Location = new System.Drawing.Point(0, 455);
            this.btnEstadisticas.Name = "btnEstadisticas";
            this.btnEstadisticas.Padding = new System.Windows.Forms.Padding(0, 0, 0, 3);
            this.btnEstadisticas.Size = new System.Drawing.Size(194, 50);
            this.btnEstadisticas.TabIndex = 10;
            this.btnEstadisticas.Text = "Estadísticas";
            this.btnEstadisticas.UseVisualStyleBackColor = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(965, 700);
            this.Controls.Add(this.panelOpciones);
            this.Controls.Add(this.panelMenu);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Name = "Form1";
            this.Text = "SysViandas ";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.panelMenu.ResumeLayout(false);
            this.panelOpciones.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.fileSystemWatcher1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelMenu;
        private System.Windows.Forms.Button btnMenus;
        private System.Windows.Forms.Panel panelButton;
        private System.Windows.Forms.Button btnSalir;
        private System.Windows.Forms.Button btnSucursales;
        private System.Windows.Forms.Button btnDietas;
        private System.Windows.Forms.Button btnViandas;
        private System.Windows.Forms.Button btnPedidos;
        private System.Windows.Forms.Panel panelOpciones;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lblTitulo;
        private System.IO.FileSystemWatcher fileSystemWatcher1;
        private System.Windows.Forms.Button btnZonas;
        private System.Windows.Forms.Button btnClientes;
        private System.Windows.Forms.Button btnEstadisticas;
    }
}

