namespace Gestion_Carniceria
{
    partial class FrmPrePedidoCliente
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
            cbClientes = new ComboBox();
            label2 = new Label();
            cbMediosDePago = new ComboBox();
            label3 = new Label();
            BtnContinuar = new Button();
            SuspendLayout();
            // 
            // cbClientes
            // 
            cbClientes.FormattingEnabled = true;
            cbClientes.Location = new Point(246, 126);
            cbClientes.Name = "cbClientes";
            cbClientes.Size = new Size(262, 23);
            cbClientes.TabIndex = 2;
            cbClientes.SelectedIndexChanged += cbClientes_SelectedIndexChanged;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(347, 98);
            label2.Name = "label2";
            label2.Size = new Size(47, 15);
            label2.TabIndex = 3;
            label2.Text = "Cliente:";
            // 
            // cbMediosDePago
            // 
            cbMediosDePago.FormattingEnabled = true;
            cbMediosDePago.Location = new Point(246, 243);
            cbMediosDePago.Name = "cbMediosDePago";
            cbMediosDePago.Size = new Size(262, 23);
            cbMediosDePago.TabIndex = 5;
            cbMediosDePago.SelectedIndexChanged += cbMediosDePago_SelectedIndexChanged;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(326, 215);
            label3.Name = "label3";
            label3.Size = new Size(90, 15);
            label3.TabIndex = 6;
            label3.Text = "Medio de Pago:";
            // 
            // BtnContinuar
            // 
            BtnContinuar.Location = new Point(304, 345);
            BtnContinuar.Name = "BtnContinuar";
            BtnContinuar.Size = new Size(134, 40);
            BtnContinuar.TabIndex = 7;
            BtnContinuar.Text = "Continuar";
            BtnContinuar.UseVisualStyleBackColor = true;
            // 
            // FrmPrePedidoCliente
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(BtnContinuar);
            Controls.Add(label3);
            Controls.Add(cbMediosDePago);
            Controls.Add(label2);
            Controls.Add(cbClientes);
            Name = "FrmPrePedidoCliente";
            Text = "FrmPrePedidoCliente";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ComboBox cbClientes;
        private Label label2;
        private ComboBox cbMediosDePago;
        private Label label3;
        private Button BtnContinuar;
    }
}