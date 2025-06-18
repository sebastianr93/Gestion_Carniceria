namespace Gestion_Carniceria
{
    partial class FrmPedidoProveedores
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
            label5 = new Label();
            button4 = new Button();
            dataGridView2 = new DataGridView();
            button1 = new Button();
            dataGridView1 = new DataGridView();
            textBox1 = new TextBox();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            comboBox1 = new ComboBox();
            label1 = new Label();
            textBox2 = new TextBox();
            label6 = new Label();
            textBox3 = new TextBox();
            button2 = new Button();
            button3 = new Button();
            button5 = new Button();
            ((System.ComponentModel.ISupportInitialize)dataGridView2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(481, 33);
            label5.Name = "label5";
            label5.Size = new Size(54, 15);
            label5.TabIndex = 27;
            label5.Text = "Nombre:";
            // 
            // button4
            // 
            button4.Location = new Point(674, 445);
            button4.Name = "button4";
            button4.Size = new Size(114, 23);
            button4.TabIndex = 26;
            button4.Text = "Volver al Menú";
            button4.UseVisualStyleBackColor = true;
            // 
            // dataGridView2
            // 
            dataGridView2.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView2.Location = new Point(12, 80);
            dataGridView2.Name = "dataGridView2";
            dataGridView2.Size = new Size(463, 359);
            dataGridView2.TabIndex = 24;
            // 
            // button1
            // 
            button1.Location = new Point(604, 49);
            button1.Name = "button1";
            button1.Size = new Size(62, 23);
            button1.TabIndex = 22;
            button1.Text = "Buscar";
            button1.UseVisualStyleBackColor = true;
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(481, 80);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.Size = new Size(307, 359);
            dataGridView1.TabIndex = 21;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(481, 50);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(117, 23);
            textBox1.TabIndex = 20;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            label4.Location = new Point(481, 9);
            label4.Name = "label4";
            label4.Size = new Size(142, 21);
            label4.TabIndex = 19;
            label4.Text = "Lista de Productos";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(149, 33);
            label3.Name = "label3";
            label3.Size = new Size(46, 15);
            label3.TabIndex = 17;
            label3.Text = "Detalle:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(12, 33);
            label2.Name = "label2";
            label2.Size = new Size(64, 15);
            label2.TabIndex = 16;
            label2.Text = "Proveedor:";
            label2.Click += label2_Click;
            // 
            // comboBox1
            // 
            comboBox1.FormattingEnabled = true;
            comboBox1.Location = new Point(12, 51);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(131, 23);
            comboBox1.TabIndex = 15;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            label1.Location = new Point(12, 9);
            label1.Name = "label1";
            label1.Size = new Size(110, 21);
            label1.TabIndex = 14;
            label1.Text = "Nuevo Pedido";
            // 
            // textBox2
            // 
            textBox2.Location = new Point(149, 51);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(117, 23);
            textBox2.TabIndex = 28;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(272, 33);
            label6.Name = "label6";
            label6.Size = new Size(74, 15);
            label6.TabIndex = 29;
            label6.Text = "Monto Total:";
            // 
            // textBox3
            // 
            textBox3.Location = new Point(272, 51);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(117, 23);
            textBox3.TabIndex = 30;
            // 
            // button2
            // 
            button2.Location = new Point(395, 49);
            button2.Name = "button2";
            button2.Size = new Size(62, 23);
            button2.TabIndex = 31;
            button2.Text = "Crear";
            button2.UseVisualStyleBackColor = true;
            // 
            // button3
            // 
            button3.Location = new Point(704, 49);
            button3.Name = "button3";
            button3.Size = new Size(84, 23);
            button3.TabIndex = 32;
            button3.Text = "Editar Stock";
            button3.UseVisualStyleBackColor = true;
            // 
            // button5
            // 
            button5.Location = new Point(12, 445);
            button5.Name = "button5";
            button5.Size = new Size(110, 23);
            button5.TabIndex = 33;
            button5.Text = "Crear Informe";
            button5.UseVisualStyleBackColor = true;
            // 
            // FrmPedidoProveedores
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 475);
            Controls.Add(button5);
            Controls.Add(button3);
            Controls.Add(button2);
            Controls.Add(textBox3);
            Controls.Add(label6);
            Controls.Add(textBox2);
            Controls.Add(label5);
            Controls.Add(button4);
            Controls.Add(dataGridView2);
            Controls.Add(button1);
            Controls.Add(dataGridView1);
            Controls.Add(textBox1);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(comboBox1);
            Controls.Add(label1);
            Name = "FrmPedidoProveedores";
            Text = "Pedidos de Proveedores";
            Load += FrmPedidoProveedores_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridView2).EndInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label5;
        private Button button4;
        private DataGridView dataGridView2;
        private Button button1;
        private DataGridView dataGridView1;
        private TextBox textBox1;
        private Label label4;
        private Label label3;
        private Label label2;
        private ComboBox comboBox1;
        private Label label1;
        private TextBox textBox2;
        private Label label6;
        private TextBox textBox3;
        private Button button2;
        private Button button3;
        private Button button5;
    }
}