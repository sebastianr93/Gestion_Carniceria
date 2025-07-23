namespace Gestion_Carniceria
{
    partial class FrmMediosDePago
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
            nudAjuste = new NumericUpDown();
            dgvMediosPago = new DataGridView();
            txtNombre = new TextBox();
            btnCrear = new Button();
            btnEliminar = new Button();
            btnVolver = new Button();
            label1 = new Label();
            label2 = new Label();
            groupBox1 = new GroupBox();
            label3 = new Label();
            ((System.ComponentModel.ISupportInitialize)nudAjuste).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dgvMediosPago).BeginInit();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // nudAjuste
            // 
            nudAjuste.Location = new Point(133, 34);
            nudAjuste.Name = "nudAjuste";
            nudAjuste.Size = new Size(87, 23);
            nudAjuste.TabIndex = 1;
            // 
            // dgvMediosPago
            // 
            dgvMediosPago.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvMediosPago.Location = new Point(9, 64);
            dgvMediosPago.Name = "dgvMediosPago";
            dgvMediosPago.Size = new Size(351, 191);
            dgvMediosPago.TabIndex = 2;
            dgvMediosPago.CellEndEdit += dgvMediosPago_CellEndEdit;
            dgvMediosPago.CellValidating += dgvMediosPago_CellValidating;
            dgvMediosPago.UserDeletingRow += dgvMediosPago_UserDeletingRow;
            // 
            // txtNombre
            // 
            txtNombre.Location = new Point(9, 34);
            txtNombre.Name = "txtNombre";
            txtNombre.Size = new Size(118, 23);
            txtNombre.TabIndex = 3;
            // 
            // btnCrear
            // 
            btnCrear.Location = new Point(285, 35);
            btnCrear.Name = "btnCrear";
            btnCrear.Size = new Size(75, 23);
            btnCrear.TabIndex = 4;
            btnCrear.Text = "Crear";
            btnCrear.UseVisualStyleBackColor = true;
            btnCrear.Click += btnCrear_Click;
            // 
            // btnEliminar
            // 
            btnEliminar.Location = new Point(9, 261);
            btnEliminar.Name = "btnEliminar";
            btnEliminar.Size = new Size(75, 23);
            btnEliminar.TabIndex = 5;
            btnEliminar.Text = "Eliminar";
            btnEliminar.UseVisualStyleBackColor = true;
            btnEliminar.Click += btnEliminar_Click;
            // 
            // btnVolver
            // 
            btnVolver.Location = new Point(285, 261);
            btnVolver.Name = "btnVolver";
            btnVolver.Size = new Size(75, 23);
            btnVolver.TabIndex = 6;
            btnVolver.Text = "Volver";
            btnVolver.UseVisualStyleBackColor = true;
            btnVolver.Click += btnVolver_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(9, 16);
            label1.Name = "label1";
            label1.Size = new Size(54, 15);
            label1.TabIndex = 7;
            label1.Text = "Nombre:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(133, 16);
            label2.Name = "label2";
            label2.Size = new Size(64, 15);
            label2.TabIndex = 8;
            label2.Text = "Ajuste (%):";
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(label1);
            groupBox1.Controls.Add(btnVolver);
            groupBox1.Controls.Add(btnEliminar);
            groupBox1.Controls.Add(btnCrear);
            groupBox1.Controls.Add(txtNombre);
            groupBox1.Controls.Add(dgvMediosPago);
            groupBox1.Controls.Add(nudAjuste);
            groupBox1.Location = new Point(12, 12);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(366, 294);
            groupBox1.TabIndex = 9;
            groupBox1.TabStop = false;
            groupBox1.Text = "groupBox1";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            label3.Location = new Point(6, -5);
            label3.Name = "label3";
            label3.Size = new Size(208, 21);
            label3.TabIndex = 10;
            label3.Text = "Configurar Medios De Pago";
            // 
            // FrmMediosDePago
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(388, 318);
            Controls.Add(groupBox1);
            Name = "FrmMediosDePago";
            Text = "Medios De Pago";
            Load += FrmMediosDePago_Load;
            ((System.ComponentModel.ISupportInitialize)nudAjuste).EndInit();
            ((System.ComponentModel.ISupportInitialize)dgvMediosPago).EndInit();
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private NumericUpDown nudAjuste;
        private DataGridView dgvMediosPago;
        private TextBox txtNombre;
        private Button btnCrear;
        private Button btnEliminar;
        private Button btnVolver;
        private Label label1;
        private Label label2;
        private GroupBox groupBox1;
        private Label label3;
    }
}