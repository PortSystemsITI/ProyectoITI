
namespace ProjectTesting.Forms
{
    partial class FormZonas
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
            this.btnEliminarZona = new System.Windows.Forms.Button();
            this.btnAgregarZona = new System.Windows.Forms.Button();
            this.sucursalesGrid = new System.Windows.Forms.DataGridView();
            this.id_vianda = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.departamento = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sucursal = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.sucursalesGrid)).BeginInit();
            this.SuspendLayout();
            // 
            // btnEliminarZona
            // 
            this.btnEliminarZona.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(51)))), ((int)(((byte)(145)))));
            this.btnEliminarZona.FlatAppearance.BorderSize = 0;
            this.btnEliminarZona.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEliminarZona.Font = new System.Drawing.Font("Calibri", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEliminarZona.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnEliminarZona.Location = new System.Drawing.Point(265, 360);
            this.btnEliminarZona.Name = "btnEliminarZona";
            this.btnEliminarZona.Size = new System.Drawing.Size(111, 31);
            this.btnEliminarZona.TabIndex = 17;
            this.btnEliminarZona.Text = "Eliminar";
            this.btnEliminarZona.UseVisualStyleBackColor = false;
            this.btnEliminarZona.Click += new System.EventHandler(this.btnEliminarZona_Click);
            // 
            // btnAgregarZona
            // 
            this.btnAgregarZona.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(51)))), ((int)(((byte)(145)))));
            this.btnAgregarZona.FlatAppearance.BorderSize = 0;
            this.btnAgregarZona.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAgregarZona.Font = new System.Drawing.Font("Calibri", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAgregarZona.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnAgregarZona.Location = new System.Drawing.Point(34, 360);
            this.btnAgregarZona.Name = "btnAgregarZona";
            this.btnAgregarZona.Size = new System.Drawing.Size(111, 31);
            this.btnAgregarZona.TabIndex = 16;
            this.btnAgregarZona.Text = "Agregar";
            this.btnAgregarZona.UseVisualStyleBackColor = false;
            this.btnAgregarZona.Click += new System.EventHandler(this.btnAgregarZona_Click);
            // 
            // sucursalesGrid
            // 
            this.sucursalesGrid.BackgroundColor = System.Drawing.SystemColors.ActiveCaption;
            this.sucursalesGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.sucursalesGrid.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.id_vianda,
            this.departamento,
            this.sucursal});
            this.sucursalesGrid.Location = new System.Drawing.Point(34, 69);
            this.sucursalesGrid.Name = "sucursalesGrid";
            this.sucursalesGrid.Size = new System.Drawing.Size(342, 247);
            this.sucursalesGrid.TabIndex = 15;
            // 
            // id_vianda
            // 
            this.id_vianda.HeaderText = "Id";
            this.id_vianda.Name = "id_vianda";
            // 
            // departamento
            // 
            this.departamento.HeaderText = "Departamento";
            this.departamento.Name = "departamento";
            // 
            // sucursal
            // 
            this.sucursal.HeaderText = "Sucursal";
            this.sucursal.Name = "sucursal";
            // 
            // FormZonas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnEliminarZona);
            this.Controls.Add(this.btnAgregarZona);
            this.Controls.Add(this.sucursalesGrid);
            this.Name = "FormZonas";
            this.Text = "FormZonas";
            ((System.ComponentModel.ISupportInitialize)(this.sucursalesGrid)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnEliminarZona;
        private System.Windows.Forms.Button btnAgregarZona;
        private System.Windows.Forms.DataGridView sucursalesGrid;
        private System.Windows.Forms.DataGridViewTextBoxColumn id_vianda;
        private System.Windows.Forms.DataGridViewTextBoxColumn departamento;
        private System.Windows.Forms.DataGridViewTextBoxColumn sucursal;
    }
}