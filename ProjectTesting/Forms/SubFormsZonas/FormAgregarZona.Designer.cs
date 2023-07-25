
namespace ProjectTesting.Forms.SubFormsZonas
{
    partial class FormAgregarZona
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
            this.btnIngresarCliente = new System.Windows.Forms.Button();
            this.departamentosCombo = new System.Windows.Forms.ComboBox();
            this.Departamento = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.textNombreZona = new System.Windows.Forms.TextBox();
            this.panelZonas = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnIngresarCliente
            // 
            this.btnIngresarCliente.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(51)))), ((int)(((byte)(145)))));
            this.btnIngresarCliente.FlatAppearance.BorderSize = 0;
            this.btnIngresarCliente.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnIngresarCliente.Font = new System.Drawing.Font("Calibri", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnIngresarCliente.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnIngresarCliente.Location = new System.Drawing.Point(48, 288);
            this.btnIngresarCliente.Name = "btnIngresarCliente";
            this.btnIngresarCliente.Size = new System.Drawing.Size(111, 31);
            this.btnIngresarCliente.TabIndex = 12;
            this.btnIngresarCliente.Text = "Agregar";
            this.btnIngresarCliente.UseVisualStyleBackColor = false;
            this.btnIngresarCliente.Click += new System.EventHandler(this.btnIngresarCliente_Click);
            // 
            // departamentosCombo
            // 
            this.departamentosCombo.FormattingEnabled = true;
            this.departamentosCombo.Location = new System.Drawing.Point(157, 56);
            this.departamentosCombo.Name = "departamentosCombo";
            this.departamentosCombo.Size = new System.Drawing.Size(169, 21);
            this.departamentosCombo.TabIndex = 14;
            this.departamentosCombo.SelectedIndexChanged += new System.EventHandler(this.departamentosCombo_SelectedIndexChanged);
            // 
            // Departamento
            // 
            this.Departamento.AutoSize = true;
            this.Departamento.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Departamento.Location = new System.Drawing.Point(45, 59);
            this.Departamento.Name = "Departamento";
            this.Departamento.Size = new System.Drawing.Size(98, 18);
            this.Departamento.TabIndex = 13;
            this.Departamento.Text = "Departamento";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(84, 106);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(59, 18);
            this.label1.TabIndex = 15;
            this.label1.Text = "Nombre";
            // 
            // textNombreZona
            // 
            this.textNombreZona.Location = new System.Drawing.Point(157, 106);
            this.textNombreZona.Name = "textNombreZona";
            this.textNombreZona.Size = new System.Drawing.Size(169, 20);
            this.textNombreZona.TabIndex = 16;
            // 
            // panelZonas
            // 
            this.panelZonas.Location = new System.Drawing.Point(445, 59);
            this.panelZonas.Name = "panelZonas";
            this.panelZonas.Size = new System.Drawing.Size(253, 260);
            this.panelZonas.TabIndex = 18;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(375, 56);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(44, 18);
            this.label2.TabIndex = 17;
            this.label2.Text = "Zonas";
            // 
            // FormAgregarZona
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(863, 357);
            this.Controls.Add(this.panelZonas);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.textNombreZona);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.departamentosCombo);
            this.Controls.Add(this.Departamento);
            this.Controls.Add(this.btnIngresarCliente);
            this.Name = "FormAgregarZona";
            this.Text = "FormAgregarZona";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnIngresarCliente;
        private System.Windows.Forms.ComboBox departamentosCombo;
        private System.Windows.Forms.Label Departamento;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textNombreZona;
        private System.Windows.Forms.Panel panelZonas;
        private System.Windows.Forms.Label label2;
    }
}