
namespace ProjectTesting.Forms
{
    partial class FormMenus
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            this.menusGrid = new System.Windows.Forms.DataGridView();
            this.id_menu = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nombreMenu = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.viandas = new System.Windows.Forms.DataGridViewButtonColumn();
            this.tipo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.stock = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tiempoCoccion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.seleccionar = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.btnAgregarMenu = new System.Windows.Forms.Button();
            this.btnEliminarMenu = new System.Windows.Forms.Button();
            this.btnModificar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.menusGrid)).BeginInit();
            this.SuspendLayout();
            // 
            // menusGrid
            // 
            this.menusGrid.BackgroundColor = System.Drawing.SystemColors.ActiveCaption;
            this.menusGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.menusGrid.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.id_menu,
            this.nombreMenu,
            this.viandas,
            this.tipo,
            this.stock,
            this.tiempoCoccion,
            this.seleccionar});
            this.menusGrid.GridColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.menusGrid.Location = new System.Drawing.Point(28, 100);
            this.menusGrid.Name = "menusGrid";
            this.menusGrid.Size = new System.Drawing.Size(644, 391);
            this.menusGrid.TabIndex = 1;
            this.menusGrid.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.menusGrid_CellContentClick);
            // 
            // id_menu
            // 
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.Black;
            this.id_menu.DefaultCellStyle = dataGridViewCellStyle1;
            this.id_menu.HeaderText = "Id";
            this.id_menu.Name = "id_menu";
            this.id_menu.ReadOnly = true;
            this.id_menu.Width = 50;
            // 
            // nombreMenu
            // 
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.Black;
            this.nombreMenu.DefaultCellStyle = dataGridViewCellStyle2;
            this.nombreMenu.HeaderText = "Nombre";
            this.nombreMenu.Name = "nombreMenu";
            this.nombreMenu.ReadOnly = true;
            // 
            // viandas
            // 
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.Black;
            this.viandas.DefaultCellStyle = dataGridViewCellStyle3;
            this.viandas.HeaderText = "Viandas";
            this.viandas.Name = "viandas";
            this.viandas.ReadOnly = true;
            this.viandas.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.viandas.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.viandas.Text = " Ver viandas";
            this.viandas.Width = 101;
            // 
            // tipo
            // 
            dataGridViewCellStyle4.ForeColor = System.Drawing.Color.Black;
            this.tipo.DefaultCellStyle = dataGridViewCellStyle4;
            this.tipo.HeaderText = "Tipo";
            this.tipo.Name = "tipo";
            this.tipo.ReadOnly = true;
            // 
            // stock
            // 
            dataGridViewCellStyle5.ForeColor = System.Drawing.Color.Black;
            this.stock.DefaultCellStyle = dataGridViewCellStyle5;
            this.stock.HeaderText = "En Stock";
            this.stock.Name = "stock";
            this.stock.ReadOnly = true;
            this.stock.Width = 50;
            // 
            // tiempoCoccion
            // 
            dataGridViewCellStyle6.ForeColor = System.Drawing.Color.Black;
            this.tiempoCoccion.DefaultCellStyle = dataGridViewCellStyle6;
            this.tiempoCoccion.HeaderText = "Tiempo Coccion";
            this.tiempoCoccion.Name = "tiempoCoccion";
            // 
            // seleccionar
            // 
            this.seleccionar.HeaderText = "Seleccionar";
            this.seleccionar.Name = "seleccionar";
            // 
            // btnAgregarMenu
            // 
            this.btnAgregarMenu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(51)))), ((int)(((byte)(145)))));
            this.btnAgregarMenu.FlatAppearance.BorderSize = 0;
            this.btnAgregarMenu.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAgregarMenu.Font = new System.Drawing.Font("Calibri", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAgregarMenu.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnAgregarMenu.Location = new System.Drawing.Point(38, 529);
            this.btnAgregarMenu.Name = "btnAgregarMenu";
            this.btnAgregarMenu.Size = new System.Drawing.Size(111, 31);
            this.btnAgregarMenu.TabIndex = 9;
            this.btnAgregarMenu.Text = "Agregar";
            this.btnAgregarMenu.UseVisualStyleBackColor = false;
            this.btnAgregarMenu.Click += new System.EventHandler(this.btnAgregarMenu_Click);
            // 
            // btnEliminarMenu
            // 
            this.btnEliminarMenu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(51)))), ((int)(((byte)(145)))));
            this.btnEliminarMenu.FlatAppearance.BorderSize = 0;
            this.btnEliminarMenu.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEliminarMenu.Font = new System.Drawing.Font("Calibri", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEliminarMenu.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnEliminarMenu.Location = new System.Drawing.Point(291, 529);
            this.btnEliminarMenu.Name = "btnEliminarMenu";
            this.btnEliminarMenu.Size = new System.Drawing.Size(111, 31);
            this.btnEliminarMenu.TabIndex = 10;
            this.btnEliminarMenu.Text = "Eliminar";
            this.btnEliminarMenu.UseVisualStyleBackColor = false;
            // 
            // btnModificar
            // 
            this.btnModificar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(51)))), ((int)(((byte)(145)))));
            this.btnModificar.FlatAppearance.BorderSize = 0;
            this.btnModificar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnModificar.Font = new System.Drawing.Font("Calibri", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnModificar.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnModificar.Location = new System.Drawing.Point(561, 529);
            this.btnModificar.Name = "btnModificar";
            this.btnModificar.Size = new System.Drawing.Size(111, 31);
            this.btnModificar.TabIndex = 11;
            this.btnModificar.Text = "Modificar";
            this.btnModificar.UseVisualStyleBackColor = false;
            // 
            // FormMenus
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(893, 585);
            this.Controls.Add(this.btnModificar);
            this.Controls.Add(this.btnEliminarMenu);
            this.Controls.Add(this.btnAgregarMenu);
            this.Controls.Add(this.menusGrid);
            this.Name = "FormMenus";
            this.Text = "FormMenus";
            this.Load += new System.EventHandler(this.FormMenus_Load);
            ((System.ComponentModel.ISupportInitialize)(this.menusGrid)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView menusGrid;
        private System.Windows.Forms.Button btnAgregarMenu;
        private System.Windows.Forms.Button btnEliminarMenu;
        private System.Windows.Forms.DataGridViewTextBoxColumn id_menu;
        private System.Windows.Forms.DataGridViewTextBoxColumn nombreMenu;
        private System.Windows.Forms.DataGridViewButtonColumn viandas;
        private System.Windows.Forms.DataGridViewTextBoxColumn tipo;
        private System.Windows.Forms.DataGridViewTextBoxColumn stock;
        private System.Windows.Forms.DataGridViewTextBoxColumn tiempoCoccion;
        private System.Windows.Forms.DataGridViewCheckBoxColumn seleccionar;
        private System.Windows.Forms.Button btnModificar;
    }
}