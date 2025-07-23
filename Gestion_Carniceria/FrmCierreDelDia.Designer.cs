namespace Gestion_Carniceria
{
    partial class FrmCierreDelDia
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
            dtpFechaCierre = new DateTimePicker();
            btnGenerar = new Button();
            label1 = new Label();
            dgvVentasDelDia = new DataGridView();
            label2 = new Label();
            lblTotalRecaudado = new Label();
            groupBox1 = new GroupBox();
            btnExportar = new Button();
            label5 = new Label();
            groupBox2 = new GroupBox();
            label3 = new Label();
            btnVolver = new Button();
            ((System.ComponentModel.ISupportInitialize)dgvVentasDelDia).BeginInit();
            groupBox1.SuspendLayout();
            groupBox2.SuspendLayout();
            SuspendLayout();
            // 
            // dtpFechaCierre
            // 
            dtpFechaCierre.Location = new Point(6, 33);
            dtpFechaCierre.Name = "dtpFechaCierre";
            dtpFechaCierre.Size = new Size(236, 23);
            dtpFechaCierre.TabIndex = 0;
            // 
            // btnGenerar
            // 
            btnGenerar.Location = new Point(248, 33);
            btnGenerar.Name = "btnGenerar";
            btnGenerar.Size = new Size(75, 23);
            btnGenerar.TabIndex = 1;
            btnGenerar.Text = "Generar";
            btnGenerar.UseVisualStyleBackColor = true;
            btnGenerar.Click += btnGenerar_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(6, 15);
            label1.Name = "label1";
            label1.Size = new Size(121, 15);
            label1.TabIndex = 2;
            label1.Text = "Selecciona una fecha:";
            // 
            // dgvVentasDelDia
            // 
            dgvVentasDelDia.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvVentasDelDia.Location = new Point(6, 77);
            dgvVentasDelDia.Name = "dgvVentasDelDia";
            dgvVentasDelDia.Size = new Size(499, 331);
            dgvVentasDelDia.TabIndex = 3;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(6, 59);
            label2.Name = "label2";
            label2.Size = new Size(82, 15);
            label2.TabIndex = 4;
            label2.Text = "Ventas del día:";
            // 
            // lblTotalRecaudado
            // 
            lblTotalRecaudado.AutoSize = true;
            lblTotalRecaudado.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            lblTotalRecaudado.Location = new Point(6, 19);
            lblTotalRecaudado.Name = "lblTotalRecaudado";
            lblTotalRecaudado.Size = new Size(50, 21);
            lblTotalRecaudado.TabIndex = 6;
            lblTotalRecaudado.Text = "$0,00";
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(btnExportar);
            groupBox1.Controls.Add(label5);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(dgvVentasDelDia);
            groupBox1.Controls.Add(label1);
            groupBox1.Controls.Add(btnGenerar);
            groupBox1.Controls.Add(dtpFechaCierre);
            groupBox1.Location = new Point(6, 15);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(514, 415);
            groupBox1.TabIndex = 8;
            groupBox1.TabStop = false;
            // 
            // btnExportar
            // 
            btnExportar.Location = new Point(329, 33);
            btnExportar.Name = "btnExportar";
            btnExportar.Size = new Size(75, 23);
            btnExportar.TabIndex = 9;
            btnExportar.Text = "Exportar";
            btnExportar.UseVisualStyleBackColor = true;
            btnExportar.Click += btnExportar_Click;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            label5.Location = new Point(6, -6);
            label5.Name = "label5";
            label5.Size = new Size(109, 21);
            label5.TabIndex = 8;
            label5.Text = "Cierre del Día";
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(label3);
            groupBox2.Controls.Add(lblTotalRecaudado);
            groupBox2.Location = new Point(6, 436);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(187, 50);
            groupBox2.TabIndex = 9;
            groupBox2.TabStop = false;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            label3.Location = new Point(0, -2);
            label3.Name = "label3";
            label3.Size = new Size(135, 21);
            label3.TabIndex = 7;
            label3.Text = "Total Recaudado:";
            // 
            // btnVolver
            // 
            btnVolver.Location = new Point(445, 463);
            btnVolver.Name = "btnVolver";
            btnVolver.Size = new Size(75, 23);
            btnVolver.TabIndex = 10;
            btnVolver.Text = "Volver";
            btnVolver.UseVisualStyleBackColor = true;
            btnVolver.Click += btnVolver_Click;
            // 
            // FrmCierreDelDia
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(530, 493);
            Controls.Add(btnVolver);
            Controls.Add(groupBox2);
            Controls.Add(groupBox1);
            Name = "FrmCierreDelDia";
            Text = "Cierre del Día";
            ((System.ComponentModel.ISupportInitialize)dgvVentasDelDia).EndInit();
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private DateTimePicker dtpFechaCierre;
        private Button btnGenerar;
        private Label label1;
        private DataGridView dgvVentasDelDia;
        private Label label2;
        private Label lblTotalRecaudado;
        private GroupBox groupBox1;
        private Label label5;
        private GroupBox groupBox2;
        private Label label3;
        private Button btnVolver;
        private Button btnExportar;
    }
}