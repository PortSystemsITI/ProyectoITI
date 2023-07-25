
namespace ProjectTesting.Forms.SubFormsPedidos
{
    partial class FormIngresarPedido
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
            this.checkPersonalizado = new System.Windows.Forms.CheckBox();
            this.btnAgregarMenu = new System.Windows.Forms.Button();
            this.menusGrid = new System.Windows.Forms.DataGridView();
            this.id_menu = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nombreMenu = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tipo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.stock = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.labelMenuComun = new System.Windows.Forms.Label();
            this.viandasGrid = new System.Windows.Forms.DataGridView();
            this.id_vianda = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dietas = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.descripcion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.labelViandas = new System.Windows.Forms.Label();
            this.labelCantidadViandas = new System.Windows.Forms.Label();
            this.radioSemanal = new System.Windows.Forms.RadioButton();
            this.radioQuincenal = new System.Windows.Forms.RadioButton();
            this.radioMensual = new System.Windows.Forms.RadioButton();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.labelCantViandasText = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.menusGrid)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.viandasGrid)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // checkPersonalizado
            // 
            this.checkPersonalizado.AutoSize = true;
            this.checkPersonalizado.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkPersonalizado.Location = new System.Drawing.Point(6, 108);
            this.checkPersonalizado.Name = "checkPersonalizado";
            this.checkPersonalizado.Size = new System.Drawing.Size(105, 19);
            this.checkPersonalizado.TabIndex = 2;
            this.checkPersonalizado.Text = "Personalizado";
            this.checkPersonalizado.UseVisualStyleBackColor = true;
            this.checkPersonalizado.CheckedChanged += new System.EventHandler(this.checkPersonalizado_CheckedChanged);
            // 
            // btnAgregarMenu
            // 
            this.btnAgregarMenu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(51)))), ((int)(((byte)(145)))));
            this.btnAgregarMenu.FlatAppearance.BorderSize = 0;
            this.btnAgregarMenu.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAgregarMenu.Font = new System.Drawing.Font("Calibri", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAgregarMenu.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnAgregarMenu.Location = new System.Drawing.Point(378, 423);
            this.btnAgregarMenu.Name = "btnAgregarMenu";
            this.btnAgregarMenu.Size = new System.Drawing.Size(111, 31);
            this.btnAgregarMenu.TabIndex = 11;
            this.btnAgregarMenu.Text = "Agregar";
            this.btnAgregarMenu.UseVisualStyleBackColor = false;
            this.btnAgregarMenu.Click += new System.EventHandler(this.btnAgregarMenu_Click);
            // 
            // menusGrid
            // 
            this.menusGrid.BackgroundColor = System.Drawing.SystemColors.ActiveCaption;
            this.menusGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.menusGrid.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.id_menu,
            this.nombreMenu,
            this.tipo,
            this.stock});
            this.menusGrid.Location = new System.Drawing.Point(12, 63);
            this.menusGrid.Name = "menusGrid";
            this.menusGrid.Size = new System.Drawing.Size(343, 391);
            this.menusGrid.TabIndex = 10;
            // 
            // id_menu
            // 
            this.id_menu.HeaderText = "Id";
            this.id_menu.Name = "id_menu";
            this.id_menu.Width = 50;
            // 
            // nombreMenu
            // 
            this.nombreMenu.HeaderText = "Nombre";
            this.nombreMenu.Name = "nombreMenu";
            // 
            // tipo
            // 
            this.tipo.HeaderText = "Tipo";
            this.tipo.Name = "tipo";
            // 
            // stock
            // 
            this.stock.HeaderText = "En Stock";
            this.stock.Name = "stock";
            this.stock.Width = 50;
            // 
            // labelMenuComun
            // 
            this.labelMenuComun.AutoSize = true;
            this.labelMenuComun.Location = new System.Drawing.Point(9, 47);
            this.labelMenuComun.Name = "labelMenuComun";
            this.labelMenuComun.Size = new System.Drawing.Size(100, 13);
            this.labelMenuComun.TabIndex = 12;
            this.labelMenuComun.Text = "Seleccione el menú";
            // 
            // viandasGrid
            // 
            this.viandasGrid.BackgroundColor = System.Drawing.SystemColors.ActiveCaption;
            this.viandasGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.viandasGrid.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.id_vianda,
            this.dietas,
            this.descripcion});
            this.viandasGrid.Location = new System.Drawing.Point(12, 63);
            this.viandasGrid.Name = "viandasGrid";
            this.viandasGrid.Size = new System.Drawing.Size(343, 391);
            this.viandasGrid.TabIndex = 13;
            // 
            // id_vianda
            // 
            this.id_vianda.HeaderText = "Id";
            this.id_vianda.Name = "id_vianda";
            // 
            // dietas
            // 
            this.dietas.HeaderText = "Dietas";
            this.dietas.Name = "dietas";
            // 
            // descripcion
            // 
            this.descripcion.HeaderText = "Descripcion";
            this.descripcion.Name = "descripcion";
            // 
            // labelViandas
            // 
            this.labelViandas.AutoSize = true;
            this.labelViandas.Location = new System.Drawing.Point(9, 47);
            this.labelViandas.Name = "labelViandas";
            this.labelViandas.Size = new System.Drawing.Size(119, 13);
            this.labelViandas.TabIndex = 14;
            this.labelViandas.Text = "Seleccione las viandas:";
            // 
            // labelCantidadViandas
            // 
            this.labelCantidadViandas.AutoSize = true;
            this.labelCantidadViandas.Location = new System.Drawing.Point(381, 319);
            this.labelCantidadViandas.Name = "labelCantidadViandas";
            this.labelCantidadViandas.Size = new System.Drawing.Size(13, 13);
            this.labelCantidadViandas.TabIndex = 15;
            this.labelCantidadViandas.Text = "5";
            // 
            // radioSemanal
            // 
            this.radioSemanal.AutoSize = true;
            this.radioSemanal.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radioSemanal.Location = new System.Drawing.Point(6, 16);
            this.radioSemanal.Name = "radioSemanal";
            this.radioSemanal.Size = new System.Drawing.Size(72, 19);
            this.radioSemanal.TabIndex = 16;
            this.radioSemanal.TabStop = true;
            this.radioSemanal.Text = "Semanal";
            this.radioSemanal.UseVisualStyleBackColor = true;
            this.radioSemanal.CheckedChanged += new System.EventHandler(this.radioSemanal_CheckedChanged);
            // 
            // radioQuincenal
            // 
            this.radioQuincenal.AutoSize = true;
            this.radioQuincenal.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radioQuincenal.Location = new System.Drawing.Point(6, 44);
            this.radioQuincenal.Name = "radioQuincenal";
            this.radioQuincenal.Size = new System.Drawing.Size(82, 19);
            this.radioQuincenal.TabIndex = 17;
            this.radioQuincenal.TabStop = true;
            this.radioQuincenal.Text = "Quincenal";
            this.radioQuincenal.UseVisualStyleBackColor = true;
            this.radioQuincenal.CheckedChanged += new System.EventHandler(this.radioQuincenal_CheckedChanged);
            // 
            // radioMensual
            // 
            this.radioMensual.AutoSize = true;
            this.radioMensual.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radioMensual.Location = new System.Drawing.Point(6, 72);
            this.radioMensual.Name = "radioMensual";
            this.radioMensual.Size = new System.Drawing.Size(73, 19);
            this.radioMensual.TabIndex = 18;
            this.radioMensual.TabStop = true;
            this.radioMensual.Text = "Mensual";
            this.radioMensual.UseVisualStyleBackColor = true;
            this.radioMensual.CheckedChanged += new System.EventHandler(this.radioMensual_CheckedChanged);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.radioMensual);
            this.groupBox1.Controls.Add(this.radioQuincenal);
            this.groupBox1.Controls.Add(this.radioSemanal);
            this.groupBox1.Controls.Add(this.checkPersonalizado);
            this.groupBox1.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(378, 63);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(128, 145);
            this.groupBox1.TabIndex = 19;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Tipo de menú";
            // 
            // labelCantViandasText
            // 
            this.labelCantViandasText.AutoSize = true;
            this.labelCantViandasText.Location = new System.Drawing.Point(375, 295);
            this.labelCantViandasText.Name = "labelCantViandasText";
            this.labelCantViandasText.Size = new System.Drawing.Size(110, 13);
            this.labelCantViandasText.TabIndex = 20;
            this.labelCantViandasText.Text = "Cantidad de viandas: ";
            // 
            // FormIngresarPedido
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(581, 470);
            this.Controls.Add(this.labelCantViandasText);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.labelCantidadViandas);
            this.Controls.Add(this.labelViandas);
            this.Controls.Add(this.viandasGrid);
            this.Controls.Add(this.labelMenuComun);
            this.Controls.Add(this.btnAgregarMenu);
            this.Controls.Add(this.menusGrid);
            this.Name = "FormIngresarPedido";
            this.Text = "Ingresar nuevo pedido";
            ((System.ComponentModel.ISupportInitialize)(this.menusGrid)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.viandasGrid)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.CheckBox checkPersonalizado;
        private System.Windows.Forms.Button btnAgregarMenu;
        private System.Windows.Forms.DataGridView menusGrid;
        private System.Windows.Forms.DataGridViewTextBoxColumn id_menu;
        private System.Windows.Forms.DataGridViewTextBoxColumn nombreMenu;
        private System.Windows.Forms.DataGridViewTextBoxColumn tipo;
        private System.Windows.Forms.DataGridViewTextBoxColumn stock;
        private System.Windows.Forms.Label labelMenuComun;
        private System.Windows.Forms.DataGridView viandasGrid;
        private System.Windows.Forms.DataGridViewTextBoxColumn id_vianda;
        private System.Windows.Forms.DataGridViewTextBoxColumn dietas;
        private System.Windows.Forms.DataGridViewTextBoxColumn descripcion;
        private System.Windows.Forms.Label labelViandas;
        private System.Windows.Forms.Label labelCantidadViandas;
        private System.Windows.Forms.RadioButton radioSemanal;
        private System.Windows.Forms.RadioButton radioQuincenal;
        private System.Windows.Forms.RadioButton radioMensual;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label labelCantViandasText;
    }
}