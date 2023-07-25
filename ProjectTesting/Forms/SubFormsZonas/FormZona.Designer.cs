
namespace ProjectTesting.Forms.SubFormsZonas
{
    partial class FormZona
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
            this.labelID = new System.Windows.Forms.Label();
            this.labelNombre = new System.Windows.Forms.Label();
            this.checkAgregarSucursal = new System.Windows.Forms.CheckBox();
            this.SuspendLayout();
            // 
            // labelID
            // 
            this.labelID.AutoSize = true;
            this.labelID.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelID.Location = new System.Drawing.Point(12, 9);
            this.labelID.Name = "labelID";
            this.labelID.Size = new System.Drawing.Size(46, 18);
            this.labelID.TabIndex = 0;
            this.labelID.Text = "label1";
            this.labelID.Click += new System.EventHandler(this.labelID_Click);
            // 
            // labelNombre
            // 
            this.labelNombre.AutoSize = true;
            this.labelNombre.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelNombre.Location = new System.Drawing.Point(79, 9);
            this.labelNombre.Name = "labelNombre";
            this.labelNombre.Size = new System.Drawing.Size(46, 18);
            this.labelNombre.TabIndex = 1;
            this.labelNombre.Text = "label1";
            // 
            // checkAgregarSucursal
            // 
            this.checkAgregarSucursal.AutoSize = true;
            this.checkAgregarSucursal.Location = new System.Drawing.Point(167, 9);
            this.checkAgregarSucursal.Name = "checkAgregarSucursal";
            this.checkAgregarSucursal.Size = new System.Drawing.Size(15, 14);
            this.checkAgregarSucursal.TabIndex = 2;
            this.checkAgregarSucursal.UseVisualStyleBackColor = true;
            // 
            // FormZona
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(195, 27);
            this.Controls.Add(this.checkAgregarSucursal);
            this.Controls.Add(this.labelNombre);
            this.Controls.Add(this.labelID);
            this.Name = "FormZona";
            this.Text = "FormZona";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public System.Windows.Forms.Label labelID;
        public System.Windows.Forms.Label labelNombre;
        public System.Windows.Forms.CheckBox checkAgregarSucursal;
    }
}