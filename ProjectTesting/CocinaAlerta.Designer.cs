
namespace ProjectTesting
{
    partial class CocinaAlerta
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
            this.labelNombre = new System.Windows.Forms.Label();
            this.labelStockActual = new System.Windows.Forms.Label();
            this.labelStockMax = new System.Windows.Forms.Label();
            this.btnConfirmar = new System.Windows.Forms.Button();
            this.labelCantidadProducir = new System.Windows.Forms.Label();
            this.btnVerDetalles = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // labelNombre
            // 
            this.labelNombre.AutoSize = true;
            this.labelNombre.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelNombre.Location = new System.Drawing.Point(3, 9);
            this.labelNombre.Name = "labelNombre";
            this.labelNombre.Size = new System.Drawing.Size(104, 16);
            this.labelNombre.TabIndex = 6;
            this.labelNombre.Text = "Nombre Menú";
            // 
            // labelStockActual
            // 
            this.labelStockActual.AutoSize = true;
            this.labelStockActual.Font = new System.Drawing.Font("Calibri", 6.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelStockActual.Location = new System.Drawing.Point(4, 34);
            this.labelStockActual.Name = "labelStockActual";
            this.labelStockActual.Size = new System.Drawing.Size(52, 11);
            this.labelStockActual.TabIndex = 7;
            this.labelStockActual.Text = "Stock Actual:";
            // 
            // labelStockMax
            // 
            this.labelStockMax.AutoSize = true;
            this.labelStockMax.Font = new System.Drawing.Font("Calibri", 6.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelStockMax.Location = new System.Drawing.Point(116, 34);
            this.labelStockMax.Name = "labelStockMax";
            this.labelStockMax.Size = new System.Drawing.Size(59, 11);
            this.labelStockMax.TabIndex = 8;
            this.labelStockMax.Text = "Stock Máximo:";
            // 
            // btnConfirmar
            // 
            this.btnConfirmar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(177)))), ((int)(((byte)(212)))));
            this.btnConfirmar.FlatAppearance.BorderSize = 0;
            this.btnConfirmar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnConfirmar.Font = new System.Drawing.Font("Calibri", 6.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnConfirmar.Location = new System.Drawing.Point(266, 57);
            this.btnConfirmar.Name = "btnConfirmar";
            this.btnConfirmar.Size = new System.Drawing.Size(109, 27);
            this.btnConfirmar.TabIndex = 9;
            this.btnConfirmar.Text = "Confirmar Produccion";
            this.btnConfirmar.UseVisualStyleBackColor = false;
            // 
            // labelCantidadProducir
            // 
            this.labelCantidadProducir.AutoSize = true;
            this.labelCantidadProducir.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelCantidadProducir.Location = new System.Drawing.Point(3, 57);
            this.labelCantidadProducir.Name = "labelCantidadProducir";
            this.labelCantidadProducir.Size = new System.Drawing.Size(117, 15);
            this.labelCantidadProducir.TabIndex = 10;
            this.labelCantidadProducir.Text = "Cantidad a producir:";
            // 
            // btnVerDetalles
            // 
            this.btnVerDetalles.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(177)))), ((int)(((byte)(212)))));
            this.btnVerDetalles.FlatAppearance.BorderSize = 0;
            this.btnVerDetalles.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnVerDetalles.Font = new System.Drawing.Font("Calibri", 6.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnVerDetalles.Location = new System.Drawing.Point(266, 9);
            this.btnVerDetalles.Name = "btnVerDetalles";
            this.btnVerDetalles.Size = new System.Drawing.Size(99, 27);
            this.btnVerDetalles.TabIndex = 11;
            this.btnVerDetalles.Text = "Ver detalles de menú";
            this.btnVerDetalles.UseVisualStyleBackColor = false;
            this.btnVerDetalles.Click += new System.EventHandler(this.btnVerDetalles_Click);
            // 
            // CocinaAlerta
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(67)))), ((int)(((byte)(145)))), ((int)(((byte)(181)))));
            this.Controls.Add(this.btnVerDetalles);
            this.Controls.Add(this.labelCantidadProducir);
            this.Controls.Add(this.btnConfirmar);
            this.Controls.Add(this.labelStockMax);
            this.Controls.Add(this.labelStockActual);
            this.Controls.Add(this.labelNombre);
            this.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.Name = "CocinaAlerta";
            this.Size = new System.Drawing.Size(397, 90);
            this.Load += new System.EventHandler(this.CocinaAlerta_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label labelNombre;
        private System.Windows.Forms.Label labelStockActual;
        private System.Windows.Forms.Label labelStockMax;
        private System.Windows.Forms.Button btnConfirmar;
        private System.Windows.Forms.Label labelCantidadProducir;
        private System.Windows.Forms.Button btnVerDetalles;
    }
}
