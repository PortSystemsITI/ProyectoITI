
namespace ProjectTesting.Forms.SubFormsMenus
{
    partial class FormAgregarMenu
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
            this.radioSemanal = new System.Windows.Forms.RadioButton();
            this.radioQuincenal = new System.Windows.Forms.RadioButton();
            this.radioMensual = new System.Windows.Forms.RadioButton();
            this.btnAgregarMenu = new System.Windows.Forms.Button();
            this.checkedListDietas = new System.Windows.Forms.CheckedListBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.textTiempoCoccionHoras = new System.Windows.Forms.TextBox();
            this.textTiempoCoccionMinutos = new System.Windows.Forms.TextBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.labelNombre = new System.Windows.Forms.Label();
            this.textNombre = new System.Windows.Forms.TextBox();
            this.panelViandas = new System.Windows.Forms.Panel();
            this.itemVianda1 = new ProjectTesting.ItemVianda();
            this.groupBoxStock = new System.Windows.Forms.GroupBox();
            this.textStockMax = new System.Windows.Forms.TextBox();
            this.textStockColchon = new System.Windows.Forms.TextBox();
            this.labelMax = new System.Windows.Forms.Label();
            this.labelColchon = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.panel1.SuspendLayout();
            this.panelViandas.SuspendLayout();
            this.groupBoxStock.SuspendLayout();
            this.SuspendLayout();
            // 
            // radioSemanal
            // 
            this.radioSemanal.AutoSize = true;
            this.radioSemanal.Location = new System.Drawing.Point(15, 29);
            this.radioSemanal.Name = "radioSemanal";
            this.radioSemanal.Size = new System.Drawing.Size(79, 22);
            this.radioSemanal.TabIndex = 7;
            this.radioSemanal.TabStop = true;
            this.radioSemanal.Text = "Semanal";
            this.radioSemanal.UseVisualStyleBackColor = true;
            // 
            // radioQuincenal
            // 
            this.radioQuincenal.AutoSize = true;
            this.radioQuincenal.Location = new System.Drawing.Point(15, 52);
            this.radioQuincenal.Name = "radioQuincenal";
            this.radioQuincenal.Size = new System.Drawing.Size(89, 22);
            this.radioQuincenal.TabIndex = 8;
            this.radioQuincenal.TabStop = true;
            this.radioQuincenal.Text = "Quincenal";
            this.radioQuincenal.UseVisualStyleBackColor = true;
            // 
            // radioMensual
            // 
            this.radioMensual.AutoSize = true;
            this.radioMensual.Location = new System.Drawing.Point(15, 75);
            this.radioMensual.Name = "radioMensual";
            this.radioMensual.Size = new System.Drawing.Size(79, 22);
            this.radioMensual.TabIndex = 9;
            this.radioMensual.TabStop = true;
            this.radioMensual.Text = "Mensual";
            this.radioMensual.UseVisualStyleBackColor = true;
            // 
            // btnAgregarMenu
            // 
            this.btnAgregarMenu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(51)))), ((int)(((byte)(145)))));
            this.btnAgregarMenu.FlatAppearance.BorderSize = 0;
            this.btnAgregarMenu.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAgregarMenu.Font = new System.Drawing.Font("Calibri", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAgregarMenu.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnAgregarMenu.Location = new System.Drawing.Point(616, 610);
            this.btnAgregarMenu.Name = "btnAgregarMenu";
            this.btnAgregarMenu.Size = new System.Drawing.Size(140, 46);
            this.btnAgregarMenu.TabIndex = 12;
            this.btnAgregarMenu.Text = "Agregar";
            this.btnAgregarMenu.UseVisualStyleBackColor = false;
            this.btnAgregarMenu.Click += new System.EventHandler(this.btnAgregarMenu_Click);
            // 
            // checkedListDietas
            // 
            this.checkedListDietas.BackColor = System.Drawing.SystemColors.Control;
            this.checkedListDietas.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.checkedListDietas.FormattingEnabled = true;
            this.checkedListDietas.Location = new System.Drawing.Point(1, 3);
            this.checkedListDietas.Name = "checkedListDietas";
            this.checkedListDietas.Size = new System.Drawing.Size(203, 135);
            this.checkedListDietas.TabIndex = 14;
            this.checkedListDietas.SelectedIndexChanged += new System.EventHandler(this.checkedListBox1_SelectedIndexChanged);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.radioMensual);
            this.groupBox1.Controls.Add(this.radioQuincenal);
            this.groupBox1.Controls.Add(this.radioSemanal);
            this.groupBox1.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(544, 78);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(148, 117);
            this.groupBox1.TabIndex = 15;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Opciones";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(19, 31);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(38, 13);
            this.label3.TabIndex = 19;
            this.label3.Text = "Horas:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(115, 31);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(47, 13);
            this.label4.TabIndex = 20;
            this.label4.Text = "Minutos:";
            // 
            // textTiempoCoccionHoras
            // 
            this.textTiempoCoccionHoras.Location = new System.Drawing.Point(63, 28);
            this.textTiempoCoccionHoras.Name = "textTiempoCoccionHoras";
            this.textTiempoCoccionHoras.Size = new System.Drawing.Size(42, 20);
            this.textTiempoCoccionHoras.TabIndex = 21;
            this.textTiempoCoccionHoras.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textTiempoCoccionHoras_KeyPress);
            // 
            // textTiempoCoccionMinutos
            // 
            this.textTiempoCoccionMinutos.Location = new System.Drawing.Point(168, 28);
            this.textTiempoCoccionMinutos.Name = "textTiempoCoccionMinutos";
            this.textTiempoCoccionMinutos.Size = new System.Drawing.Size(42, 20);
            this.textTiempoCoccionMinutos.TabIndex = 22;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.textTiempoCoccionMinutos);
            this.groupBox2.Controls.Add(this.textTiempoCoccionHoras);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Location = new System.Drawing.Point(536, 400);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(221, 69);
            this.groupBox2.TabIndex = 23;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Tiempo de cocción";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(547, 208);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(54, 18);
            this.label1.TabIndex = 16;
            this.label1.Text = "Dietas: ";
            // 
            // panel1
            // 
            this.panel1.AutoScroll = true;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.checkedListDietas);
            this.panel1.ForeColor = System.Drawing.SystemColors.ControlText;
            this.panel1.Location = new System.Drawing.Point(550, 229);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(206, 141);
            this.panel1.TabIndex = 24;
            // 
            // labelNombre
            // 
            this.labelNombre.AutoSize = true;
            this.labelNombre.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelNombre.Location = new System.Drawing.Point(19, 46);
            this.labelNombre.Name = "labelNombre";
            this.labelNombre.Size = new System.Drawing.Size(66, 18);
            this.labelNombre.TabIndex = 25;
            this.labelNombre.Text = "Nombre: ";
            // 
            // textNombre
            // 
            this.textNombre.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textNombre.Location = new System.Drawing.Point(92, 43);
            this.textNombre.Name = "textNombre";
            this.textNombre.Size = new System.Drawing.Size(267, 26);
            this.textNombre.TabIndex = 26;
            this.textNombre.TextChanged += new System.EventHandler(this.textNombre_TextChanged);
            // 
            // panelViandas
            // 
            this.panelViandas.AutoScroll = true;
            this.panelViandas.Controls.Add(this.itemVianda1);
            this.panelViandas.Location = new System.Drawing.Point(11, 80);
            this.panelViandas.Name = "panelViandas";
            this.panelViandas.Size = new System.Drawing.Size(497, 536);
            this.panelViandas.TabIndex = 27;
            // 
            // itemVianda1
            // 
            this.itemVianda1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.itemVianda1.Dock = System.Windows.Forms.DockStyle.Top;
            this.itemVianda1.Location = new System.Drawing.Point(0, 0);
            this.itemVianda1.Name = "itemVianda1";
            this.itemVianda1.Size = new System.Drawing.Size(497, 114);
            this.itemVianda1.TabIndex = 0;
            // 
            // groupBoxStock
            // 
            this.groupBoxStock.Controls.Add(this.textStockMax);
            this.groupBoxStock.Controls.Add(this.textStockColchon);
            this.groupBoxStock.Controls.Add(this.labelMax);
            this.groupBoxStock.Controls.Add(this.labelColchon);
            this.groupBoxStock.Location = new System.Drawing.Point(535, 495);
            this.groupBoxStock.Name = "groupBoxStock";
            this.groupBoxStock.Size = new System.Drawing.Size(221, 69);
            this.groupBoxStock.TabIndex = 24;
            this.groupBoxStock.TabStop = false;
            this.groupBoxStock.Text = "Stock";
            // 
            // textStockMax
            // 
            this.textStockMax.Location = new System.Drawing.Point(168, 28);
            this.textStockMax.Name = "textStockMax";
            this.textStockMax.Size = new System.Drawing.Size(42, 20);
            this.textStockMax.TabIndex = 22;
            // 
            // textStockColchon
            // 
            this.textStockColchon.Location = new System.Drawing.Point(63, 28);
            this.textStockColchon.Name = "textStockColchon";
            this.textStockColchon.Size = new System.Drawing.Size(42, 20);
            this.textStockColchon.TabIndex = 21;
            // 
            // labelMax
            // 
            this.labelMax.AutoSize = true;
            this.labelMax.Location = new System.Drawing.Point(115, 31);
            this.labelMax.Name = "labelMax";
            this.labelMax.Size = new System.Drawing.Size(46, 13);
            this.labelMax.TabIndex = 20;
            this.labelMax.Text = "Máximo:";
            // 
            // labelColchon
            // 
            this.labelColchon.AutoSize = true;
            this.labelColchon.Location = new System.Drawing.Point(14, 31);
            this.labelColchon.Name = "labelColchon";
            this.labelColchon.Size = new System.Drawing.Size(49, 13);
            this.labelColchon.TabIndex = 19;
            this.labelColchon.Text = "Colchón:";
            // 
            // FormAgregarMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(794, 678);
            this.Controls.Add(this.groupBoxStock);
            this.Controls.Add(this.panelViandas);
            this.Controls.Add(this.textNombre);
            this.Controls.Add(this.labelNombre);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btnAgregarMenu);
            this.Name = "FormAgregarMenu";
            this.Text = "FormAgregarMenu";
            this.Load += new System.EventHandler(this.FormAgregarMenu_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panelViandas.ResumeLayout(false);
            this.groupBoxStock.ResumeLayout(false);
            this.groupBoxStock.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.RadioButton radioSemanal;
        private System.Windows.Forms.RadioButton radioQuincenal;
        private System.Windows.Forms.RadioButton radioMensual;
        private System.Windows.Forms.Button btnAgregarMenu;
        private System.Windows.Forms.CheckedListBox checkedListDietas;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox textTiempoCoccionHoras;
        private System.Windows.Forms.TextBox textTiempoCoccionMinutos;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label labelNombre;
        private System.Windows.Forms.TextBox textNombre;
        private System.Windows.Forms.Panel panelViandas;
        private ItemVianda itemVianda1;
        private System.Windows.Forms.GroupBox groupBoxStock;
        private System.Windows.Forms.TextBox textStockMax;
        private System.Windows.Forms.TextBox textStockColchon;
        private System.Windows.Forms.Label labelMax;
        private System.Windows.Forms.Label labelColchon;
    }
}