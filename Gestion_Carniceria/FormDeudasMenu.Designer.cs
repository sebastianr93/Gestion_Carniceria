namespace Gestion_Carniceria
{
    partial class FormDeudasMenu
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
            label1 = new Label();
            buttonClientesD = new Button();
            buttonProveedoresD = new Button();
            buttonVolverD = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 20F);
            label1.Location = new Point(102, 32);
            label1.Name = "label1";
            label1.Size = new Size(332, 37);
            label1.TabIndex = 0;
            label1.Text = "Deudas - Cuenta Corriente";
            // 
            // buttonClientesD
            // 
            buttonClientesD.Location = new Point(74, 115);
            buttonClientesD.Name = "buttonClientesD";
            buttonClientesD.Size = new Size(139, 46);
            buttonClientesD.TabIndex = 1;
            buttonClientesD.Text = "Clientes";
            buttonClientesD.UseVisualStyleBackColor = true;
            buttonClientesD.Click += buttonClientesD_Click;
            // 
            // buttonProveedoresD
            // 
            buttonProveedoresD.Location = new Point(315, 115);
            buttonProveedoresD.Name = "buttonProveedoresD";
            buttonProveedoresD.Size = new Size(143, 46);
            buttonProveedoresD.TabIndex = 2;
            buttonProveedoresD.Text = "Proveedores";
            buttonProveedoresD.UseVisualStyleBackColor = true;
            buttonProveedoresD.Click += buttonProveedoresD_Click;
            // 
            // buttonVolverD
            // 
            buttonVolverD.Location = new Point(191, 208);
            buttonVolverD.Name = "buttonVolverD";
            buttonVolverD.Size = new Size(142, 52);
            buttonVolverD.TabIndex = 3;
            buttonVolverD.Text = "Volver";
            buttonVolverD.UseVisualStyleBackColor = true;
            buttonVolverD.Click += buttonVolverD_Click;
            // 
            // FormDeudasMenu
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(561, 331);
            Controls.Add(buttonVolverD);
            Controls.Add(buttonProveedoresD);
            Controls.Add(buttonClientesD);
            Controls.Add(label1);
            Name = "FormDeudasMenu";
            Text = "FormDeudasMenu";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Button buttonClientesD;
        private Button buttonProveedoresD;
        private Button buttonVolverD;
    }
}