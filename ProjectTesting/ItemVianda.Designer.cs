
namespace ProjectTesting
{
    partial class ItemVianda
    {
        /// <summary> 
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de componentes

        /// <summary> 
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.checkBox = new System.Windows.Forms.CheckBox();
            this.textBoxNombre = new System.Windows.Forms.TextBox();
            this.labelDietas = new System.Windows.Forms.Label();
            this.labelCantidad = new System.Windows.Forms.Label();
            this.listBoxDietas = new System.Windows.Forms.ListBox();
            this.comboBoxCantidad = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // checkBox
            // 
            this.checkBox.AutoSize = true;
            this.checkBox.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkBox.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.checkBox.Location = new System.Drawing.Point(3, 0);
            this.checkBox.Name = "checkBox";
            this.checkBox.Size = new System.Drawing.Size(40, 22);
            this.checkBox.TabIndex = 0;
            this.checkBox.Text = "ID";
            this.checkBox.UseVisualStyleBackColor = true;
            // 
            // textBoxNombre
            // 
            this.textBoxNombre.Location = new System.Drawing.Point(3, 19);
            this.textBoxNombre.Multiline = true;
            this.textBoxNombre.Name = "textBoxNombre";
            this.textBoxNombre.ReadOnly = true;
            this.textBoxNombre.Size = new System.Drawing.Size(298, 57);
            this.textBoxNombre.TabIndex = 1;
            this.textBoxNombre.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // labelDietas
            // 
            this.labelDietas.AutoSize = true;
            this.labelDietas.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelDietas.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.labelDietas.Location = new System.Drawing.Point(304, -1);
            this.labelDietas.Name = "labelDietas";
            this.labelDietas.Size = new System.Drawing.Size(51, 18);
            this.labelDietas.TabIndex = 3;
            this.labelDietas.Text = "Dietas:";
            // 
            // labelCantidad
            // 
            this.labelCantidad.AutoSize = true;
            this.labelCantidad.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelCantidad.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.labelCantidad.Location = new System.Drawing.Point(306, 87);
            this.labelCantidad.Name = "labelCantidad";
            this.labelCantidad.Size = new System.Drawing.Size(66, 18);
            this.labelCantidad.TabIndex = 4;
            this.labelCantidad.Text = "Cantidad:";
            // 
            // listBoxDietas
            // 
            this.listBoxDietas.BackColor = System.Drawing.SystemColors.InactiveBorder;
            this.listBoxDietas.FormattingEnabled = true;
            this.listBoxDietas.Location = new System.Drawing.Point(307, 20);
            this.listBoxDietas.Name = "listBoxDietas";
            this.listBoxDietas.Size = new System.Drawing.Size(162, 56);
            this.listBoxDietas.TabIndex = 6;
            // 
            // comboBoxCantidad
            // 
            this.comboBoxCantidad.FormattingEnabled = true;
            this.comboBoxCantidad.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4",
            "5",
            "6",
            "7",
            "8",
            "9",
            "10",
            "11",
            "12",
            "13",
            "14",
            "15",
            "16",
            "17",
            "18",
            "19",
            "20"});
            this.comboBoxCantidad.Location = new System.Drawing.Point(378, 87);
            this.comboBoxCantidad.Name = "comboBoxCantidad";
            this.comboBoxCantidad.Size = new System.Drawing.Size(62, 21);
            this.comboBoxCantidad.TabIndex = 7;
            // 
            // ItemVianda
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(67)))), ((int)(((byte)(145)))), ((int)(((byte)(181)))));
            this.Controls.Add(this.comboBoxCantidad);
            this.Controls.Add(this.listBoxDietas);
            this.Controls.Add(this.labelCantidad);
            this.Controls.Add(this.labelDietas);
            this.Controls.Add(this.textBoxNombre);
            this.Controls.Add(this.checkBox);
            this.Name = "ItemVianda";
            this.Size = new System.Drawing.Size(472, 111);
            this.Load += new System.EventHandler(this.ItemVianda_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.CheckBox checkBox;
        private System.Windows.Forms.TextBox textBoxNombre;
        private System.Windows.Forms.Label labelDietas;
        private System.Windows.Forms.Label labelCantidad;
        private System.Windows.Forms.ListBox listBoxDietas;
        private System.Windows.Forms.ComboBox comboBoxCantidad;
    }
}
