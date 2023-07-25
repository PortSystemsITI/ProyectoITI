
namespace ProjectTesting.Forms
{
    partial class FormDietas
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
            this.btnIngresarDieta = new System.Windows.Forms.Button();
            this.dietasGrid = new System.Windows.Forms.DataGridView();
            this.id_pedido = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nombre = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.descripcion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnEliminarDieta = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dietasGrid)).BeginInit();
            this.SuspendLayout();
            // 
            // btnIngresarDieta
            // 
            this.btnIngresarDieta.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(51)))), ((int)(((byte)(145)))));
            this.btnIngresarDieta.FlatAppearance.BorderSize = 0;
            this.btnIngresarDieta.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnIngresarDieta.Font = new System.Drawing.Font("Calibri", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnIngresarDieta.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnIngresarDieta.Location = new System.Drawing.Point(28, 484);
            this.btnIngresarDieta.Name = "btnIngresarDieta";
            this.btnIngresarDieta.Size = new System.Drawing.Size(111, 31);
            this.btnIngresarDieta.TabIndex = 12;
            this.btnIngresarDieta.Text = "Ingresar";
            this.btnIngresarDieta.UseVisualStyleBackColor = false;
            this.btnIngresarDieta.Click += new System.EventHandler(this.btnIngresarDieta_Click);
            // 
            // dietasGrid
            // 
            this.dietasGrid.BackgroundColor = System.Drawing.SystemColors.ActiveCaption;
            this.dietasGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dietasGrid.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.id_pedido,
            this.nombre,
            this.descripcion});
            this.dietasGrid.Location = new System.Drawing.Point(28, 74);
            this.dietasGrid.Name = "dietasGrid";
            this.dietasGrid.Size = new System.Drawing.Size(292, 391);
            this.dietasGrid.TabIndex = 11;
            this.dietasGrid.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.menusGrid_CellContentClick);
            // 
            // id_pedido
            // 
            this.id_pedido.HeaderText = "Id";
            this.id_pedido.Name = "id_pedido";
            this.id_pedido.Width = 50;
            // 
            // nombre
            // 
            this.nombre.HeaderText = "Nombre";
            this.nombre.Name = "nombre";
            // 
            // descripcion
            // 
            this.descripcion.HeaderText = "Descripcion";
            this.descripcion.Name = "descripcion";
            // 
            // btnEliminarDieta
            // 
            this.btnEliminarDieta.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(51)))), ((int)(((byte)(145)))));
            this.btnEliminarDieta.FlatAppearance.BorderSize = 0;
            this.btnEliminarDieta.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEliminarDieta.Font = new System.Drawing.Font("Calibri", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEliminarDieta.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnEliminarDieta.Location = new System.Drawing.Point(209, 484);
            this.btnEliminarDieta.Name = "btnEliminarDieta";
            this.btnEliminarDieta.Size = new System.Drawing.Size(111, 31);
            this.btnEliminarDieta.TabIndex = 13;
            this.btnEliminarDieta.Text = "Eliminar";
            this.btnEliminarDieta.UseVisualStyleBackColor = false;
            // 
            // FormDietas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(390, 575);
            this.Controls.Add(this.btnEliminarDieta);
            this.Controls.Add(this.btnIngresarDieta);
            this.Controls.Add(this.dietasGrid);
            this.Name = "FormDietas";
            this.Text = "FormDietas";
            ((System.ComponentModel.ISupportInitialize)(this.dietasGrid)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnIngresarDieta;
        private System.Windows.Forms.DataGridView dietasGrid;
        private System.Windows.Forms.DataGridViewTextBoxColumn id_pedido;
        private System.Windows.Forms.DataGridViewTextBoxColumn nombre;
        private System.Windows.Forms.DataGridViewTextBoxColumn descripcion;
        private System.Windows.Forms.Button btnEliminarDieta;
    }
}