
namespace ProjectTesting.Forms
{
    partial class FormPedidos
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
            this.menusGrid = new System.Windows.Forms.DataGridView();
            this.id_pedido = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.id_menu = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.estado_pedido = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnIngresarPedidos = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.menusGrid)).BeginInit();
            this.SuspendLayout();
            // 
            // menusGrid
            // 
            this.menusGrid.BackgroundColor = System.Drawing.SystemColors.ActiveCaption;
            this.menusGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.menusGrid.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.id_pedido,
            this.id_menu,
            this.estado_pedido});
            this.menusGrid.Location = new System.Drawing.Point(32, 66);
            this.menusGrid.Name = "menusGrid";
            this.menusGrid.Size = new System.Drawing.Size(292, 391);
            this.menusGrid.TabIndex = 2;
            this.menusGrid.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.menusGrid_CellContentClick);
            // 
            // id_pedido
            // 
            this.id_pedido.HeaderText = "Id";
            this.id_pedido.Name = "id_pedido";
            this.id_pedido.Width = 50;
            // 
            // id_menu
            // 
            this.id_menu.HeaderText = "Menu";
            this.id_menu.Name = "id_menu";
            // 
            // estado_pedido
            // 
            this.estado_pedido.HeaderText = "Estado";
            this.estado_pedido.Name = "estado_pedido";
            // 
            // btnIngresarPedidos
            // 
            this.btnIngresarPedidos.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(51)))), ((int)(((byte)(145)))));
            this.btnIngresarPedidos.FlatAppearance.BorderSize = 0;
            this.btnIngresarPedidos.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnIngresarPedidos.Font = new System.Drawing.Font("Calibri", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnIngresarPedidos.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnIngresarPedidos.Location = new System.Drawing.Point(119, 475);
            this.btnIngresarPedidos.Name = "btnIngresarPedidos";
            this.btnIngresarPedidos.Size = new System.Drawing.Size(111, 31);
            this.btnIngresarPedidos.TabIndex = 10;
            this.btnIngresarPedidos.Text = "Ingresar";
            this.btnIngresarPedidos.UseVisualStyleBackColor = false;
            this.btnIngresarPedidos.Click += new System.EventHandler(this.btnIngresarPedidos_Click);
            // 
            // FormPedidos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(549, 517);
            this.Controls.Add(this.btnIngresarPedidos);
            this.Controls.Add(this.menusGrid);
            this.Name = "FormPedidos";
            this.Text = "FormPedidos";
            this.Load += new System.EventHandler(this.FormPedidos_Load);
            ((System.ComponentModel.ISupportInitialize)(this.menusGrid)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.DataGridView menusGrid;
        private System.Windows.Forms.Button btnIngresarPedidos;
        private System.Windows.Forms.DataGridViewTextBoxColumn id_pedido;
        private System.Windows.Forms.DataGridViewTextBoxColumn id_menu;
        private System.Windows.Forms.DataGridViewTextBoxColumn estado_pedido;
    }
}