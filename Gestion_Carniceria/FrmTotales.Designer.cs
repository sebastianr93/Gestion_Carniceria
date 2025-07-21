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
            labelTotalCobradoValor = new Label();
            labelTotalACobrarValor = new Label();
            label1 = new Label();
            labelDeudaProveedoresValor = new Label();
            label2 = new Label();
            dateTimePicker1Inicio = new DateTimePicker();
            dateTimePicker2Final = new DateTimePicker();
            ButtonBuscarEntreFechas = new Button();
            button1 = new Button();
            SuspendLayout();
            // 
            // totalesventastext
            // 
            totalesventastext.AutoSize = true;
            totalesventastext.Location = new Point(195, 183);
            totalesventastext.Name = "totalesventastext";
            totalesventastext.Size = new Size(96, 15);
            totalesventastext.TabIndex = 0;
            totalesventastext.Text = "Totales de Ventas";
            // 
            // titulo
            // 
            titulo.AutoSize = true;
            titulo.Font = new Font("Segoe UI", 20F);
            titulo.Location = new Point(367, 21);
            titulo.Name = "titulo";
            titulo.Size = new Size(119, 37);
            titulo.TabIndex = 1;
            titulo.Text = "TOTALES";
            // 
            // costoproductostext
            // 
            costoproductostext.AutoSize = true;
            costoproductostext.Location = new Point(195, 214);
            costoproductostext.Name = "costoproductostext";
            costoproductostext.Size = new Size(81, 15);
            costoproductostext.TabIndex = 2;
            costoproductostext.Text = "Total Cobrado";
            // 
            // labelTotalVentasValor
            // 
            labelTotalVentasValor.AutoSize = true;
            labelTotalVentasValor.Location = new Point(588, 183);
            labelTotalVentasValor.Name = "labelTotalVentasValor";
            labelTotalVentasValor.Size = new Size(38, 15);
            labelTotalVentasValor.TabIndex = 3;
            labelTotalVentasValor.Text = "label1";
            // 
            // labelTotalCobradoValor
            // 
            labelTotalCobradoValor.AutoSize = true;
            labelTotalCobradoValor.Location = new Point(590, 215);
            labelTotalCobradoValor.Name = "labelTotalCobradoValor";
            labelTotalCobradoValor.Size = new Size(38, 15);
            labelTotalCobradoValor.TabIndex = 4;
            labelTotalCobradoValor.Text = "label1";
            // 
            // labelTotalACobrarValor
            // 
            labelTotalACobrarValor.AutoSize = true;
            labelTotalACobrarValor.ForeColor = Color.Red;
            labelTotalACobrarValor.Location = new Point(590, 244);
            labelTotalACobrarValor.Name = "labelTotalACobrarValor";
            labelTotalACobrarValor.Size = new Size(38, 15);
            labelTotalACobrarValor.TabIndex = 5;
            labelTotalACobrarValor.Text = "label1";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(195, 244);
            label1.Name = "label1";
            label1.Size = new Size(114, 15);
            label1.TabIndex = 6;
            label1.Text = "Deuda Total Clientes";
            // 
            // labelDeudaProveedoresValor
            // 
            labelDeudaProveedoresValor.AutoSize = true;
            labelDeudaProveedoresValor.ForeColor = Color.Red;
            labelDeudaProveedoresValor.Location = new Point(590, 272);
            labelDeudaProveedoresValor.Name = "labelDeudaProveedoresValor";
            labelDeudaProveedoresValor.Size = new Size(38, 15);
            labelDeudaProveedoresValor.TabIndex = 7;
            labelDeudaProveedoresValor.Text = "label2";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(195, 272);
            label2.Name = "label2";
            label2.Size = new Size(197, 15);
            label2.TabIndex = 8;
            label2.Text = "Cuenta Corttiente Total Proveedores";
            // 
            // dateTimePicker1Inicio
            // 
            dateTimePicker1Inicio.Location = new Point(195, 102);
            dateTimePicker1Inicio.Name = "dateTimePicker1Inicio";
            dateTimePicker1Inicio.Size = new Size(231, 23);
            dateTimePicker1Inicio.TabIndex = 9;
            dateTimePicker1Inicio.ValueChanged += dateTimePicker1Inicio_ValueChanged;
            // 
            // dateTimePicker2Final
            // 
            dateTimePicker2Final.Location = new Point(446, 102);
            dateTimePicker2Final.Name = "dateTimePicker2Final";
            dateTimePicker2Final.Size = new Size(227, 23);
            dateTimePicker2Final.TabIndex = 10;
            dateTimePicker2Final.ValueChanged += dateTimePicker2Final_ValueChanged;
            // 
            // ButtonBuscarEntreFechas
            // 
            ButtonBuscarEntreFechas.Location = new Point(703, 102);
            ButtonBuscarEntreFechas.Name = "ButtonBuscarEntreFechas";
            ButtonBuscarEntreFechas.Size = new Size(75, 23);
            ButtonBuscarEntreFechas.TabIndex = 11;
            ButtonBuscarEntreFechas.Text = "Buscar";
            ButtonBuscarEntreFechas.UseVisualStyleBackColor = true;
            ButtonBuscarEntreFechas.Click += ButtonBuscarEntreFechas_Click;
            // 
            // button1
            // 
            button1.Location = new Point(808, 312);
            button1.Name = "button1";
            button1.Size = new Size(8, 8);
            button1.TabIndex = 12;
            button1.Text = "button1";
            button1.UseVisualStyleBackColor = true;
            // 
            // FrmTotales
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(967, 585);
            Controls.Add(button1);
            Controls.Add(ButtonBuscarEntreFechas);
            Controls.Add(dateTimePicker2Final);
            Controls.Add(dateTimePicker1Inicio);
            Controls.Add(label2);
            Controls.Add(labelDeudaProveedoresValor);
            Controls.Add(label1);
            Controls.Add(labelTotalACobrarValor);
            Controls.Add(labelTotalCobradoValor);
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
        private Label labelTotalCobradoValor;
        private Label labelTotalACobrarValor;
        private Label label1;
        private Label labelDeudaProveedoresValor;
        private Label label2;
        private DateTimePicker dateTimePicker1Inicio;
        private DateTimePicker dateTimePicker2Final;
        private Button ButtonBuscarEntreFechas;
        private Button button1;
    }
}