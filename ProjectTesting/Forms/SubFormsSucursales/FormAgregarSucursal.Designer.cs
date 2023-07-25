
namespace ProjectTesting.Forms.SubFormsSucursales
{
    partial class FormAgregarSucursal
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
            this.Departamento = new System.Windows.Forms.Label();
            this.labelCantVehiculos = new System.Windows.Forms.Label();
            this.radio1 = new System.Windows.Forms.RadioButton();
            this.radio2 = new System.Windows.Forms.RadioButton();
            this.radio3 = new System.Windows.Forms.RadioButton();
            this.labelCantCocinas = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.panelZonas = new System.Windows.Forms.Panel();
            this.departamentosCombo = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // Departamento
            // 
            this.Departamento.AutoSize = true;
            this.Departamento.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Departamento.Location = new System.Drawing.Point(51, 92);
            this.Departamento.Name = "Departamento";
            this.Departamento.Size = new System.Drawing.Size(98, 18);
            this.Departamento.TabIndex = 0;
            this.Departamento.Text = "Departamento";
            this.Departamento.Click += new System.EventHandler(this.Departamento_Click);
            // 
            // labelCantVehiculos
            // 
            this.labelCantVehiculos.AutoSize = true;
            this.labelCantVehiculos.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelCantVehiculos.Location = new System.Drawing.Point(51, 135);
            this.labelCantVehiculos.Name = "labelCantVehiculos";
            this.labelCantVehiculos.Size = new System.Drawing.Size(144, 18);
            this.labelCantVehiculos.TabIndex = 1;
            this.labelCantVehiculos.Text = "Cantidad de vehiculos";
            // 
            // radio1
            // 
            this.radio1.AutoSize = true;
            this.radio1.Location = new System.Drawing.Point(201, 136);
            this.radio1.Name = "radio1";
            this.radio1.Size = new System.Drawing.Size(31, 17);
            this.radio1.TabIndex = 2;
            this.radio1.TabStop = true;
            this.radio1.Text = "1";
            this.radio1.UseVisualStyleBackColor = true;
            // 
            // radio2
            // 
            this.radio2.AutoSize = true;
            this.radio2.Location = new System.Drawing.Point(238, 136);
            this.radio2.Name = "radio2";
            this.radio2.Size = new System.Drawing.Size(31, 17);
            this.radio2.TabIndex = 3;
            this.radio2.TabStop = true;
            this.radio2.Text = "2";
            this.radio2.UseVisualStyleBackColor = true;
            // 
            // radio3
            // 
            this.radio3.AutoSize = true;
            this.radio3.Location = new System.Drawing.Point(275, 136);
            this.radio3.Name = "radio3";
            this.radio3.Size = new System.Drawing.Size(31, 17);
            this.radio3.TabIndex = 4;
            this.radio3.TabStop = true;
            this.radio3.Text = "3";
            this.radio3.UseVisualStyleBackColor = true;
            // 
            // labelCantCocinas
            // 
            this.labelCantCocinas.AutoSize = true;
            this.labelCantCocinas.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelCantCocinas.Location = new System.Drawing.Point(51, 178);
            this.labelCantCocinas.Name = "labelCantCocinas";
            this.labelCantCocinas.Size = new System.Drawing.Size(130, 18);
            this.labelCantCocinas.TabIndex = 5;
            this.labelCantCocinas.Text = "Cantidad de cocinas";
            // 
            // textBox1
            // 
            this.textBox1.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox1.Location = new System.Drawing.Point(201, 170);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(43, 26);
            this.textBox1.TabIndex = 6;
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(51, 229);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(44, 18);
            this.label1.TabIndex = 7;
            this.label1.Text = "Zonas";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // panelZonas
            // 
            this.panelZonas.Location = new System.Drawing.Point(163, 229);
            this.panelZonas.Name = "panelZonas";
            this.panelZonas.Size = new System.Drawing.Size(253, 260);
            this.panelZonas.TabIndex = 8;
            this.panelZonas.Paint += new System.Windows.Forms.PaintEventHandler(this.panelZonas_Paint);
            // 
            // departamentosCombo
            // 
            this.departamentosCombo.FormattingEnabled = true;
            this.departamentosCombo.Location = new System.Drawing.Point(163, 89);
            this.departamentosCombo.Name = "departamentosCombo";
            this.departamentosCombo.Size = new System.Drawing.Size(169, 21);
            this.departamentosCombo.TabIndex = 9;
            this.departamentosCombo.SelectedIndexChanged += new System.EventHandler(this.departamentosCombo_SelectedIndexChanged);
            // 
            // FormAgregarSucursal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 518);
            this.Controls.Add(this.departamentosCombo);
            this.Controls.Add(this.panelZonas);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.labelCantCocinas);
            this.Controls.Add(this.radio3);
            this.Controls.Add(this.radio2);
            this.Controls.Add(this.radio1);
            this.Controls.Add(this.labelCantVehiculos);
            this.Controls.Add(this.Departamento);
            this.Name = "FormAgregarSucursal";
            this.Text = "FormAgregarSucursal";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label Departamento;
        private System.Windows.Forms.Label labelCantVehiculos;
        private System.Windows.Forms.RadioButton radio1;
        private System.Windows.Forms.RadioButton radio2;
        private System.Windows.Forms.RadioButton radio3;
        private System.Windows.Forms.Label labelCantCocinas;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panelZonas;
        private System.Windows.Forms.ComboBox departamentosCombo;
    }
}