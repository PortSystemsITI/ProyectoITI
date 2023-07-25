
namespace ProjectTesting.Forms
{
    partial class FormViandas
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
            this.dataGridViandas = new System.Windows.Forms.DataGridView();
            this.btnEliminarVianda = new System.Windows.Forms.Button();
            this.btnAgregarVianda = new System.Windows.Forms.Button();
            this.id_vianda = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.descripcion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dietas = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.seleccionar = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViandas)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridViandas
            // 
            this.dataGridViandas.BackgroundColor = System.Drawing.SystemColors.ActiveCaption;
            this.dataGridViandas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViandas.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.id_vianda,
            this.descripcion,
            this.dietas,
            this.seleccionar});
            this.dataGridViandas.Location = new System.Drawing.Point(41, 96);
            this.dataGridViandas.Name = "dataGridViandas";
            this.dataGridViandas.Size = new System.Drawing.Size(540, 421);
            this.dataGridViandas.TabIndex = 0;
            this.dataGridViandas.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // btnEliminarVianda
            // 
            this.btnEliminarVianda.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(51)))), ((int)(((byte)(145)))));
            this.btnEliminarVianda.FlatAppearance.BorderSize = 0;
            this.btnEliminarVianda.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEliminarVianda.Font = new System.Drawing.Font("Calibri", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEliminarVianda.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnEliminarVianda.Location = new System.Drawing.Point(470, 556);
            this.btnEliminarVianda.Name = "btnEliminarVianda";
            this.btnEliminarVianda.Size = new System.Drawing.Size(111, 31);
            this.btnEliminarVianda.TabIndex = 11;
            this.btnEliminarVianda.Text = "Eliminar";
            this.btnEliminarVianda.UseVisualStyleBackColor = false;
            this.btnEliminarVianda.Click += new System.EventHandler(this.btnEliminarVianda_Click);
            // 
            // btnAgregarVianda
            // 
            this.btnAgregarVianda.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(51)))), ((int)(((byte)(145)))));
            this.btnAgregarVianda.FlatAppearance.BorderSize = 0;
            this.btnAgregarVianda.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAgregarVianda.Font = new System.Drawing.Font("Calibri", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAgregarVianda.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnAgregarVianda.Location = new System.Drawing.Point(41, 556);
            this.btnAgregarVianda.Name = "btnAgregarVianda";
            this.btnAgregarVianda.Size = new System.Drawing.Size(111, 31);
            this.btnAgregarVianda.TabIndex = 10;
            this.btnAgregarVianda.Text = "Agregar";
            this.btnAgregarVianda.UseVisualStyleBackColor = false;
            this.btnAgregarVianda.Click += new System.EventHandler(this.btnAgregarVianda_Click);
            // 
            // id_vianda
            // 
            this.id_vianda.HeaderText = "Id";
            this.id_vianda.Name = "id_vianda";
            // 
            // descripcion
            // 
            this.descripcion.HeaderText = "Descripcion";
            this.descripcion.Name = "descripcion";
            this.descripcion.Width = 200;
            // 
            // dietas
            // 
            this.dietas.HeaderText = "Dietas";
            this.dietas.Name = "dietas";
            // 
            // seleccionar
            // 
            this.seleccionar.HeaderText = "Seleccionar";
            this.seleccionar.Name = "seleccionar";
            // 
            // FormViandas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(685, 610);
            this.Controls.Add(this.btnEliminarVianda);
            this.Controls.Add(this.btnAgregarVianda);
            this.Controls.Add(this.dataGridViandas);
            this.Name = "FormViandas";
            this.Text = "FormViandas";
            this.Load += new System.EventHandler(this.FormViandas_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViandas)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridViandas;
        private System.Windows.Forms.Button btnEliminarVianda;
        private System.Windows.Forms.Button btnAgregarVianda;
        private System.Windows.Forms.DataGridViewTextBoxColumn id_vianda;
        private System.Windows.Forms.DataGridViewTextBoxColumn descripcion;
        private System.Windows.Forms.DataGridViewTextBoxColumn dietas;
        private System.Windows.Forms.DataGridViewTextBoxColumn seleccionar;
    }
}