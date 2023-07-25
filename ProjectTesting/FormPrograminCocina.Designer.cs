
namespace ProjectTesting
{
    partial class FormPrograminCocina
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
            this.panelAlertas = new System.Windows.Forms.Panel();
            this.cocinaAlerta1 = new ProjectTesting.CocinaAlerta();
            this.btnTestAgregarAlerta = new System.Windows.Forms.Button();
            this.panelAlertas.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelAlertas
            // 
            this.panelAlertas.AutoScroll = true;
            this.panelAlertas.Controls.Add(this.cocinaAlerta1);
            this.panelAlertas.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panelAlertas.Location = new System.Drawing.Point(12, 53);
            this.panelAlertas.Name = "panelAlertas";
            this.panelAlertas.Size = new System.Drawing.Size(533, 379);
            this.panelAlertas.TabIndex = 0;
            this.panelAlertas.Paint += new System.Windows.Forms.PaintEventHandler(this.panelAlertas_Paint);
            // 
            // cocinaAlerta1
            // 
            this.cocinaAlerta1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(67)))), ((int)(((byte)(145)))), ((int)(((byte)(181)))));
            this.cocinaAlerta1.Dock = System.Windows.Forms.DockStyle.Top;
            this.cocinaAlerta1.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.cocinaAlerta1.Location = new System.Drawing.Point(0, 0);
            this.cocinaAlerta1.Margin = new System.Windows.Forms.Padding(4);
            this.cocinaAlerta1.Name = "cocinaAlerta1";
            this.cocinaAlerta1.Size = new System.Drawing.Size(533, 125);
            this.cocinaAlerta1.TabIndex = 0;
            this.cocinaAlerta1.Load += new System.EventHandler(this.cocinaAlerta1_Load);
            // 
            // btnTestAgregarAlerta
            // 
            this.btnTestAgregarAlerta.Location = new System.Drawing.Point(22, 477);
            this.btnTestAgregarAlerta.Name = "btnTestAgregarAlerta";
            this.btnTestAgregarAlerta.Size = new System.Drawing.Size(143, 31);
            this.btnTestAgregarAlerta.TabIndex = 5;
            this.btnTestAgregarAlerta.Text = "Simular Alerta";
            this.btnTestAgregarAlerta.UseVisualStyleBackColor = true;
            this.btnTestAgregarAlerta.Click += new System.EventHandler(this.btnTestAgregarAlerta_Click);
            // 
            // FormPrograminCocina
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(637, 520);
            this.Controls.Add(this.btnTestAgregarAlerta);
            this.Controls.Add(this.panelAlertas);
            this.Name = "FormPrograminCocina";
            this.Text = "FormPrograminCocina";
            this.panelAlertas.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelAlertas;
        private System.Windows.Forms.Button btnTestAgregarAlerta;
        private CocinaAlerta cocinaAlerta1;
    }
}