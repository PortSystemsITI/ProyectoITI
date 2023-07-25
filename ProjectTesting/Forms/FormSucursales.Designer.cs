
namespace ProjectTesting.Forms
{
    partial class FormSucursales
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
            this.btnEliminarSucursal = new System.Windows.Forms.Button();
            this.btnAgregarSucursal = new System.Windows.Forms.Button();
            this.sucursalesGrid = new System.Windows.Forms.DataGridView();
            this.id_vianda = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cantidad_vehiculos = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.capacidad_vehiculos = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.direccion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.departamento = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.gerente = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnModificarSucursal = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.sucursalesGrid)).BeginInit();
            this.SuspendLayout();
            // 
            // btnEliminarSucursal
            // 
            this.btnEliminarSucursal.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(51)))), ((int)(((byte)(145)))));
            this.btnEliminarSucursal.FlatAppearance.BorderSize = 0;
            this.btnEliminarSucursal.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEliminarSucursal.Font = new System.Drawing.Font("Calibri", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEliminarSucursal.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnEliminarSucursal.Location = new System.Drawing.Point(528, 357);
            this.btnEliminarSucursal.Name = "btnEliminarSucursal";
            this.btnEliminarSucursal.Size = new System.Drawing.Size(113, 31);
            this.btnEliminarSucursal.TabIndex = 14;
            this.btnEliminarSucursal.Text = "Eliminar";
            this.btnEliminarSucursal.UseVisualStyleBackColor = false;
            // 
            // btnAgregarSucursal
            // 
            this.btnAgregarSucursal.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(51)))), ((int)(((byte)(145)))));
            this.btnAgregarSucursal.FlatAppearance.BorderSize = 0;
            this.btnAgregarSucursal.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAgregarSucursal.Font = new System.Drawing.Font("Calibri", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAgregarSucursal.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnAgregarSucursal.Location = new System.Drawing.Point(52, 357);
            this.btnAgregarSucursal.Name = "btnAgregarSucursal";
            this.btnAgregarSucursal.Size = new System.Drawing.Size(113, 31);
            this.btnAgregarSucursal.TabIndex = 13;
            this.btnAgregarSucursal.Text = "Agregar";
            this.btnAgregarSucursal.UseVisualStyleBackColor = false;
            this.btnAgregarSucursal.Click += new System.EventHandler(this.btnAgregarSucursal_Click);
            // 
            // sucursalesGrid
            // 
            this.sucursalesGrid.BackgroundColor = System.Drawing.SystemColors.ActiveCaption;
            this.sucursalesGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.sucursalesGrid.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.id_vianda,
            this.cantidad_vehiculos,
            this.capacidad_vehiculos,
            this.direccion,
            this.departamento,
            this.gerente});
            this.sucursalesGrid.Location = new System.Drawing.Point(29, 80);
            this.sucursalesGrid.Name = "sucursalesGrid";
            this.sucursalesGrid.Size = new System.Drawing.Size(645, 247);
            this.sucursalesGrid.TabIndex = 12;
            // 
            // id_vianda
            // 
            this.id_vianda.HeaderText = "Id";
            this.id_vianda.Name = "id_vianda";
            // 
            // cantidad_vehiculos
            // 
            this.cantidad_vehiculos.HeaderText = "Vehiculos";
            this.cantidad_vehiculos.Name = "cantidad_vehiculos";
            // 
            // capacidad_vehiculos
            // 
            this.capacidad_vehiculos.HeaderText = "Capacidad Vehiculos";
            this.capacidad_vehiculos.Name = "capacidad_vehiculos";
            // 
            // direccion
            // 
            this.direccion.HeaderText = "Direccion";
            this.direccion.Name = "direccion";
            // 
            // departamento
            // 
            this.departamento.HeaderText = "Departamento";
            this.departamento.Name = "departamento";
            // 
            // gerente
            // 
            this.gerente.HeaderText = "Gerente";
            this.gerente.Name = "gerente";
            // 
            // btnModificarSucursal
            // 
            this.btnModificarSucursal.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(51)))), ((int)(((byte)(145)))));
            this.btnModificarSucursal.FlatAppearance.BorderSize = 0;
            this.btnModificarSucursal.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnModificarSucursal.Font = new System.Drawing.Font("Calibri", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnModificarSucursal.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnModificarSucursal.Location = new System.Drawing.Point(293, 357);
            this.btnModificarSucursal.Name = "btnModificarSucursal";
            this.btnModificarSucursal.Size = new System.Drawing.Size(113, 31);
            this.btnModificarSucursal.TabIndex = 15;
            this.btnModificarSucursal.Text = "Modificar";
            this.btnModificarSucursal.UseVisualStyleBackColor = false;
            this.btnModificarSucursal.Click += new System.EventHandler(this.btnModificarSucursal_Click);
            // 
            // FormSucursales
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnModificarSucursal);
            this.Controls.Add(this.btnEliminarSucursal);
            this.Controls.Add(this.btnAgregarSucursal);
            this.Controls.Add(this.sucursalesGrid);
            this.Name = "FormSucursales";
            this.Text = "sin";
            ((System.ComponentModel.ISupportInitialize)(this.sucursalesGrid)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnEliminarSucursal;
        private System.Windows.Forms.Button btnAgregarSucursal;
        private System.Windows.Forms.DataGridView sucursalesGrid;
        private System.Windows.Forms.DataGridViewTextBoxColumn id_vianda;
        private System.Windows.Forms.DataGridViewTextBoxColumn cantidad_vehiculos;
        private System.Windows.Forms.DataGridViewTextBoxColumn capacidad_vehiculos;
        private System.Windows.Forms.DataGridViewTextBoxColumn direccion;
        private System.Windows.Forms.DataGridViewTextBoxColumn departamento;
        private System.Windows.Forms.DataGridViewTextBoxColumn gerente;
        private System.Windows.Forms.Button btnModificarSucursal;
    }
}