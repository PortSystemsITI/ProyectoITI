
namespace ProjectTesting
{
    partial class AlertaCocina
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
            this.panelAlerta = new System.Windows.Forms.Panel();
            this.btnAlertaMenu = new System.Windows.Forms.Button();
            this.panelStockActual = new System.Windows.Forms.Panel();
            this.panelCantidadProducir = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.btnConfirmar = new System.Windows.Forms.Button();
            this.labelStockActual = new System.Windows.Forms.Label();
            this.labelCantidadProducir = new System.Windows.Forms.Label();
            this.panelAlerta.SuspendLayout();
            this.panelStockActual.SuspendLayout();
            this.panelCantidadProducir.SuspendLayout();
            this.panel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelAlerta
            // 
            this.panelAlerta.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.panelAlerta.Controls.Add(this.panel3);
            this.panelAlerta.Controls.Add(this.panelCantidadProducir);
            this.panelAlerta.Controls.Add(this.panelStockActual);
            this.panelAlerta.Controls.Add(this.btnAlertaMenu);
            this.panelAlerta.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelAlerta.Location = new System.Drawing.Point(0, 0);
            this.panelAlerta.Name = "panelAlerta";
            this.panelAlerta.Size = new System.Drawing.Size(420, 34);
            this.panelAlerta.TabIndex = 1;
            // 
            // btnAlertaMenu
            // 
            this.btnAlertaMenu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(51)))), ((int)(((byte)(145)))));
            this.btnAlertaMenu.Dock = System.Windows.Forms.DockStyle.Left;
            this.btnAlertaMenu.FlatAppearance.BorderSize = 0;
            this.btnAlertaMenu.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAlertaMenu.Font = new System.Drawing.Font("Calibri", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAlertaMenu.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnAlertaMenu.Location = new System.Drawing.Point(0, 0);
            this.btnAlertaMenu.Name = "btnAlertaMenu";
            this.btnAlertaMenu.Size = new System.Drawing.Size(117, 34);
            this.btnAlertaMenu.TabIndex = 4;
            this.btnAlertaMenu.Text = "ID : NOMBRE";
            this.btnAlertaMenu.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAlertaMenu.UseVisualStyleBackColor = false;
            // 
            // panelStockActual
            // 
            this.panelStockActual.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.panelStockActual.Controls.Add(this.labelStockActual);
            this.panelStockActual.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelStockActual.Location = new System.Drawing.Point(117, 0);
            this.panelStockActual.Name = "panelStockActual";
            this.panelStockActual.Size = new System.Drawing.Size(66, 34);
            this.panelStockActual.TabIndex = 8;
            // 
            // panelCantidadProducir
            // 
            this.panelCantidadProducir.BackColor = System.Drawing.SystemColors.Info;
            this.panelCantidadProducir.Controls.Add(this.labelCantidadProducir);
            this.panelCantidadProducir.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelCantidadProducir.Location = new System.Drawing.Point(183, 0);
            this.panelCantidadProducir.Name = "panelCantidadProducir";
            this.panelCantidadProducir.Size = new System.Drawing.Size(70, 34);
            this.panelCantidadProducir.TabIndex = 9;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.panel3.Controls.Add(this.btnConfirmar);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel3.Location = new System.Drawing.Point(253, 0);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(169, 34);
            this.panel3.TabIndex = 10;
            // 
            // btnConfirmar
            // 
            this.btnConfirmar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(51)))), ((int)(((byte)(145)))));
            this.btnConfirmar.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnConfirmar.FlatAppearance.BorderSize = 0;
            this.btnConfirmar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnConfirmar.Font = new System.Drawing.Font("Calibri", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnConfirmar.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnConfirmar.Location = new System.Drawing.Point(0, 0);
            this.btnConfirmar.Name = "btnConfirmar";
            this.btnConfirmar.Size = new System.Drawing.Size(169, 34);
            this.btnConfirmar.TabIndex = 8;
            this.btnConfirmar.Text = "En Produccion";
            this.btnConfirmar.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnConfirmar.UseVisualStyleBackColor = false;
            // 
            // labelStockActual
            // 
            this.labelStockActual.AutoSize = true;
            this.labelStockActual.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelStockActual.Location = new System.Drawing.Point(16, 9);
            this.labelStockActual.Name = "labelStockActual";
            this.labelStockActual.Size = new System.Drawing.Size(22, 18);
            this.labelStockActual.TabIndex = 0;
            this.labelStockActual.Text = "12";
            // 
            // labelCantidadProducir
            // 
            this.labelCantidadProducir.AutoSize = true;
            this.labelCantidadProducir.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelCantidadProducir.Location = new System.Drawing.Point(22, 9);
            this.labelCantidadProducir.Name = "labelCantidadProducir";
            this.labelCantidadProducir.Size = new System.Drawing.Size(22, 18);
            this.labelCantidadProducir.TabIndex = 1;
            this.labelCantidadProducir.Text = "12";
            // 
            // AlertaCocina
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(420, 34);
            this.Controls.Add(this.panelAlerta);
            this.Name = "AlertaCocina";
            this.Text = "AlertaCocina";
            this.panelAlerta.ResumeLayout(false);
            this.panelStockActual.ResumeLayout(false);
            this.panelStockActual.PerformLayout();
            this.panelCantidadProducir.ResumeLayout(false);
            this.panelCantidadProducir.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelAlerta;
        private System.Windows.Forms.Button btnAlertaMenu;
        private System.Windows.Forms.Panel panelCantidadProducir;
        private System.Windows.Forms.Panel panelStockActual;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Button btnConfirmar;
        private System.Windows.Forms.Label labelCantidadProducir;
        private System.Windows.Forms.Label labelStockActual;
    }
}