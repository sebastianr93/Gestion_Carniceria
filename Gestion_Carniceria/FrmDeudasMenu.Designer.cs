namespace Gestion_Carniceria
{
    partial class FrmDeudasMenu
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
            buttonClientesD = new Button();
            buttonProveedoresD = new Button();
            buttonVolverD = new Button();
            groupBox1 = new GroupBox();
            label1 = new Label();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // buttonClientesD
            // 
            buttonClientesD.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            buttonClientesD.Location = new Point(16, 41);
            buttonClientesD.Name = "buttonClientesD";
            buttonClientesD.Size = new Size(139, 23);
            buttonClientesD.TabIndex = 1;
            buttonClientesD.Text = "Clientes";
            buttonClientesD.UseVisualStyleBackColor = true;
            buttonClientesD.Click += buttonClientesD_Click;
            // 
            // buttonProveedoresD
            // 
            buttonProveedoresD.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            buttonProveedoresD.Location = new Point(309, 41);
            buttonProveedoresD.Name = "buttonProveedoresD";
            buttonProveedoresD.Size = new Size(143, 23);
            buttonProveedoresD.TabIndex = 2;
            buttonProveedoresD.Text = "Proveedores";
            buttonProveedoresD.UseVisualStyleBackColor = true;
            buttonProveedoresD.Click += buttonProveedoresD_Click;
            // 
            // buttonVolverD
            // 
            buttonVolverD.Location = new Point(199, 103);
            buttonVolverD.Name = "buttonVolverD";
            buttonVolverD.Size = new Size(75, 23);
            buttonVolverD.TabIndex = 3;
            buttonVolverD.Text = "Volver";
            buttonVolverD.UseVisualStyleBackColor = true;
            buttonVolverD.Click += buttonVolverD_Click;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(label1);
            groupBox1.Controls.Add(buttonVolverD);
            groupBox1.Controls.Add(buttonProveedoresD);
            groupBox1.Controls.Add(buttonClientesD);
            groupBox1.Location = new Point(12, 12);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(475, 137);
            groupBox1.TabIndex = 4;
            groupBox1.TabStop = false;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI Semibold", 20.25F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            label1.Location = new Point(57, -10);
            label1.Name = "label1";
            label1.Size = new Size(365, 37);
            label1.TabIndex = 4;
            label1.Text = "Deudas y Cuentas Corrientes";
            // 
            // FormDeudasMenu
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(500, 157);
            Controls.Add(groupBox1);
            Name = "FormDeudasMenu";
            Text = "Registro de Deudas";
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion
        private Button buttonClientesD;
        private Button buttonProveedoresD;
        private Button buttonVolverD;
        private GroupBox groupBox1;
        private Label label1;
    }
}