namespace Gestion_Carniceria
{
    partial class FrmTotales
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
            totalesventastext = new Label();
            titulo = new Label();
            costoproductostext = new Label();
            labelTotalVentasValor = new Label();
            SuspendLayout();
            // 
            // totalesventastext
            // 
            totalesventastext.AutoSize = true;
            totalesventastext.Location = new Point(145, 87);
            totalesventastext.Name = "totalesventastext";
            totalesventastext.Size = new Size(96, 15);
            totalesventastext.TabIndex = 0;
            totalesventastext.Text = "Totales de Ventas";
            // 
            // titulo
            // 
            titulo.AutoSize = true;
            titulo.Font = new Font("Segoe UI", 20F);
            titulo.Location = new Point(359, 18);
            titulo.Name = "titulo";
            titulo.Size = new Size(119, 37);
            titulo.TabIndex = 1;
            titulo.Text = "TOTALES";
            // 
            // costoproductostext
            // 
            costoproductostext.AutoSize = true;
            costoproductostext.Location = new Point(145, 118);
            costoproductostext.Name = "costoproductostext";
            costoproductostext.Size = new Size(146, 15);
            costoproductostext.TabIndex = 2;
            costoproductostext.Text = "Costo Productos Vendidos";
            // 
            // labelTotalVentasValor
            // 
            labelTotalVentasValor.AutoSize = true;
            labelTotalVentasValor.Location = new Point(538, 87);
            labelTotalVentasValor.Name = "labelTotalVentasValor";
            labelTotalVentasValor.Size = new Size(38, 15);
            labelTotalVentasValor.TabIndex = 3;
            labelTotalVentasValor.Text = "label1";
            // 
            // FrmTotales
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(967, 585);
            Controls.Add(labelTotalVentasValor);
            Controls.Add(costoproductostext);
            Controls.Add(titulo);
            Controls.Add(totalesventastext);
            Name = "FrmTotales";
            Text = "FrmTotales";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label totalesventastext;
        private Label titulo;
        private Label costoproductostext;
        private Label labelTotalVentasValor;
    }
}