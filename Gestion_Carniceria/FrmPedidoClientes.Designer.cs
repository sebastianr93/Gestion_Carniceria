namespace Gestion_Carniceria
{
    partial class FrmPedidoClientes
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
            comboBox1 = new ComboBox();
            label2 = new Label();
            label3 = new Label();
            comboBox2 = new ComboBox();
            label4 = new Label();
            textBox1 = new TextBox();
            dataGridView1 = new DataGridView();
            button1 = new Button();
            button2 = new Button();
            dataGridView2 = new DataGridView();
            button3 = new Button();
            button4 = new Button();
            label5 = new Label();
            label6 = new Label();
            groupBox1 = new GroupBox();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView2).BeginInit();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            label1.Location = new Point(12, 9);
            label1.Name = "label1";
            label1.Size = new Size(110, 21);
            label1.TabIndex = 0;
            label1.Text = "Nuevo Pedido";
            // 
            // comboBox1
            // 
            comboBox1.FormattingEnabled = true;
            comboBox1.Location = new Point(12, 51);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(131, 23);
            comboBox1.TabIndex = 1;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(12, 33);
            label2.Name = "label2";
            label2.Size = new Size(47, 15);
            label2.TabIndex = 2;
            label2.Text = "Cliente:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(149, 33);
            label3.Name = "label3";
            label3.Size = new Size(90, 15);
            label3.TabIndex = 3;
            label3.Text = "Medio de Pago:";
            // 
            // comboBox2
            // 
            comboBox2.FormattingEnabled = true;
            comboBox2.Location = new Point(149, 51);
            comboBox2.Name = "comboBox2";
            comboBox2.Size = new Size(131, 23);
            comboBox2.TabIndex = 4;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            label4.Location = new Point(481, 9);
            label4.Name = "label4";
            label4.Size = new Size(142, 21);
            label4.TabIndex = 5;
            label4.Text = "Lista de Productos";
            // 
            // textBox1
            // 
            textBox1.Location = new Point(481, 50);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(117, 23);
            textBox1.TabIndex = 6;
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(481, 80);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.Size = new Size(307, 359);
            dataGridView1.TabIndex = 7;
            // 
            // button1
            // 
            button1.Location = new Point(604, 49);
            button1.Name = "button1";
            button1.Size = new Size(62, 23);
            button1.TabIndex = 8;
            button1.Text = "Buscar";
            button1.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            button2.Location = new Point(672, 49);
            button2.Name = "button2";
            button2.Size = new Size(116, 23);
            button2.TabIndex = 9;
            button2.Text = "Agregar a Pedido";
            button2.UseVisualStyleBackColor = true;
            // 
            // dataGridView2
            // 
            dataGridView2.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView2.Location = new Point(12, 80);
            dataGridView2.Name = "dataGridView2";
            dataGridView2.Size = new Size(463, 359);
            dataGridView2.TabIndex = 10;
            // 
            // button3
            // 
            button3.Location = new Point(356, 445);
            button3.Name = "button3";
            button3.Size = new Size(119, 23);
            button3.TabIndex = 11;
            button3.Text = "Confirmar Venta";
            button3.UseVisualStyleBackColor = true;
            // 
            // button4
            // 
            button4.Location = new Point(674, 445);
            button4.Name = "button4";
            button4.Size = new Size(114, 23);
            button4.TabIndex = 12;
            button4.Text = "Volver al Menú";
            button4.UseVisualStyleBackColor = true;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(481, 33);
            label5.Name = "label5";
            label5.Size = new Size(54, 15);
            label5.TabIndex = 13;
            label5.Text = "Nombre:";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            label6.Location = new Point(70, 19);
            label6.Name = "label6";
            label6.Size = new Size(50, 21);
            label6.TabIndex = 14;
            label6.Text = "$0.00";
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(label6);
            groupBox1.Location = new Point(286, 18);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(189, 54);
            groupBox1.TabIndex = 15;
            groupBox1.TabStop = false;
            groupBox1.Text = "Monto Total:";
            // 
            // FrmPedidoClientes
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 480);
            Controls.Add(groupBox1);
            Controls.Add(label5);
            Controls.Add(button4);
            Controls.Add(button3);
            Controls.Add(dataGridView2);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(dataGridView1);
            Controls.Add(textBox1);
            Controls.Add(label4);
            Controls.Add(comboBox2);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(comboBox1);
            Controls.Add(label1);
            Name = "FrmPedidoClientes";
            Text = "Nuevo Pedido";
            Load += FrmPedidoClientes_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView2).EndInit();
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private ComboBox comboBox1;
        private Label label2;
        private Label label3;
        private ComboBox comboBox2;
        private Label label4;
        private TextBox textBox1;
        private DataGridView dataGridView1;
        private Button button1;
        private Button button2;
        private DataGridView dataGridView2;
        private Button button3;
        private Button button4;
        private Label label5;
        private Label label6;
        private GroupBox groupBox1;
    }
}