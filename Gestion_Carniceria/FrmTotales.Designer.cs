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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmTotales));
            totalesventastext = new Label();
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
            label3 = new Label();
            label4 = new Label();
            groupBox1 = new GroupBox();
            label5 = new Label();
            groupBox2 = new GroupBox();
            button1 = new Button();
            groupBox1.SuspendLayout();
            groupBox2.SuspendLayout();
            SuspendLayout();
            // 
            // totalesventastext
            // 
            resources.ApplyResources(totalesventastext, "totalesventastext");
            totalesventastext.Name = "totalesventastext";
            // 
            // costoproductostext
            // 
            resources.ApplyResources(costoproductostext, "costoproductostext");
            costoproductostext.Name = "costoproductostext";
            // 
            // labelTotalVentasValor
            // 
            resources.ApplyResources(labelTotalVentasValor, "labelTotalVentasValor");
            labelTotalVentasValor.Name = "labelTotalVentasValor";
            // 
            // labelTotalCobradoValor
            // 
            resources.ApplyResources(labelTotalCobradoValor, "labelTotalCobradoValor");
            labelTotalCobradoValor.Name = "labelTotalCobradoValor";
            // 
            // labelTotalACobrarValor
            // 
            resources.ApplyResources(labelTotalACobrarValor, "labelTotalACobrarValor");
            labelTotalACobrarValor.ForeColor = Color.Red;
            labelTotalACobrarValor.Name = "labelTotalACobrarValor";
            // 
            // label1
            // 
            resources.ApplyResources(label1, "label1");
            label1.Name = "label1";
            // 
            // labelDeudaProveedoresValor
            // 
            resources.ApplyResources(labelDeudaProveedoresValor, "labelDeudaProveedoresValor");
            labelDeudaProveedoresValor.ForeColor = Color.Red;
            labelDeudaProveedoresValor.Name = "labelDeudaProveedoresValor";
            // 
            // label2
            // 
            resources.ApplyResources(label2, "label2");
            label2.Name = "label2";
            // 
            // dateTimePicker1Inicio
            // 
            resources.ApplyResources(dateTimePicker1Inicio, "dateTimePicker1Inicio");
            dateTimePicker1Inicio.Name = "dateTimePicker1Inicio";
            dateTimePicker1Inicio.ValueChanged += dateTimePicker1Inicio_ValueChanged;
            // 
            // dateTimePicker2Final
            // 
            resources.ApplyResources(dateTimePicker2Final, "dateTimePicker2Final");
            dateTimePicker2Final.Name = "dateTimePicker2Final";
            dateTimePicker2Final.ValueChanged += dateTimePicker2Final_ValueChanged;
            // 
            // ButtonBuscarEntreFechas
            // 
            resources.ApplyResources(ButtonBuscarEntreFechas, "ButtonBuscarEntreFechas");
            ButtonBuscarEntreFechas.Name = "ButtonBuscarEntreFechas";
            ButtonBuscarEntreFechas.UseVisualStyleBackColor = true;
            ButtonBuscarEntreFechas.Click += ButtonBuscarEntreFechas_Click;
            // 
            // label3
            // 
            resources.ApplyResources(label3, "label3");
            label3.Name = "label3";
            // 
            // label4
            // 
            resources.ApplyResources(label4, "label4");
            label4.Name = "label4";
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(label4);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(ButtonBuscarEntreFechas);
            groupBox1.Controls.Add(dateTimePicker2Final);
            groupBox1.Controls.Add(dateTimePicker1Inicio);
            resources.ApplyResources(groupBox1, "groupBox1");
            groupBox1.Name = "groupBox1";
            groupBox1.TabStop = false;
            // 
            // label5
            // 
            resources.ApplyResources(label5, "label5");
            label5.Name = "label5";
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(label2);
            groupBox2.Controls.Add(label1);
            groupBox2.Controls.Add(costoproductostext);
            groupBox2.Controls.Add(totalesventastext);
            groupBox2.Controls.Add(labelDeudaProveedoresValor);
            groupBox2.Controls.Add(labelTotalVentasValor);
            groupBox2.Controls.Add(labelTotalACobrarValor);
            groupBox2.Controls.Add(labelTotalCobradoValor);
            resources.ApplyResources(groupBox2, "groupBox2");
            groupBox2.Name = "groupBox2";
            groupBox2.TabStop = false;
            // 
            // button1
            // 
            resources.ApplyResources(button1, "button1");
            button1.Name = "button1";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // FrmTotales
            // 
            resources.ApplyResources(this, "$this");
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(button1);
            Controls.Add(groupBox2);
            Controls.Add(label5);
            Controls.Add(groupBox1);
            Name = "FrmTotales";
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label totalesventastext;
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
        private Label label3;
        private Label label4;
        private GroupBox groupBox1;
        private Label label5;
        private GroupBox groupBox2;
        private Button button1;
    }
}