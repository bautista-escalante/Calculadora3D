namespace Forms
{
    partial class FrmPrincipal
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
            btnCalcularCosto = new Button();
            TxtTiempo = new TextBox();
            TxtFilamento = new TextBox();
            LblErrorTiempo = new Label();
            LblErrorGramos = new Label();
            label3 = new Label();
            label4 = new Label();
            LblErrorInprevisto = new Label();
            TxtResultado = new TextBox();
            label6 = new Label();
            label7 = new Label();
            label8 = new Label();
            btnSalir = new Button();
            CbTipoFilamento = new ComboBox();
            label9 = new Label();
            LblErrorTipo = new Label();
            label1 = new Label();
            label2 = new Label();
            SuspendLayout();
            // 
            // btnCalcularCosto
            // 
            btnCalcularCosto.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnCalcularCosto.Location = new Point(49, 371);
            btnCalcularCosto.Name = "btnCalcularCosto";
            btnCalcularCosto.Size = new Size(164, 35);
            btnCalcularCosto.TabIndex = 0;
            btnCalcularCosto.Text = "calcular costo";
            btnCalcularCosto.UseVisualStyleBackColor = true;
            btnCalcularCosto.Click += btnCalcularCosto_Click;
            // 
            // TxtTiempo
            // 
            TxtTiempo.Location = new Point(181, 129);
            TxtTiempo.Name = "TxtTiempo";
            TxtTiempo.Size = new Size(169, 23);
            TxtTiempo.TabIndex = 3;
            // 
            // TxtFilamento
            // 
            TxtFilamento.Location = new Point(181, 51);
            TxtFilamento.Name = "TxtFilamento";
            TxtFilamento.Size = new Size(169, 23);
            TxtFilamento.TabIndex = 4;
            // 
            // LblErrorTiempo
            // 
            LblErrorTiempo.AutoSize = true;
            LblErrorTiempo.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            LblErrorTiempo.ForeColor = Color.Red;
            LblErrorTiempo.Location = new Point(181, 106);
            LblErrorTiempo.Name = "LblErrorTiempo";
            LblErrorTiempo.Size = new Size(51, 20);
            LblErrorTiempo.TabIndex = 5;
            LblErrorTiempo.Text = "label1";
            LblErrorTiempo.Visible = false;
            // 
            // LblErrorGramos
            // 
            LblErrorGramos.AutoSize = true;
            LblErrorGramos.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            LblErrorGramos.ForeColor = Color.Red;
            LblErrorGramos.Location = new Point(181, 28);
            LblErrorGramos.Name = "LblErrorGramos";
            LblErrorGramos.Size = new Size(51, 20);
            LblErrorGramos.TabIndex = 6;
            LblErrorGramos.Text = "label2";
            LblErrorGramos.Visible = false;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.ForeColor = Color.White;
            label3.Location = new Point(49, 128);
            label3.Name = "label3";
            label3.Size = new Size(84, 40);
            label3.TabIndex = 7;
            label3.Text = "tiempo de \r\nimpresion";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.ForeColor = Color.White;
            label4.Location = new Point(49, 51);
            label4.Name = "label4";
            label4.Size = new Size(77, 40);
            label4.TabIndex = 8;
            label4.Text = "filamento\r\nutilizado";
            // 
            // LblErrorInprevisto
            // 
            LblErrorInprevisto.AutoSize = true;
            LblErrorInprevisto.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            LblErrorInprevisto.ForeColor = Color.Red;
            LblErrorInprevisto.Location = new Point(49, 348);
            LblErrorInprevisto.Name = "LblErrorInprevisto";
            LblErrorInprevisto.Size = new Size(51, 20);
            LblErrorInprevisto.TabIndex = 9;
            LblErrorInprevisto.Text = "label5";
            LblErrorInprevisto.Visible = false;
            // 
            // TxtResultado
            // 
            TxtResultado.Enabled = false;
            TxtResultado.Location = new Point(181, 306);
            TxtResultado.Name = "TxtResultado";
            TxtResultado.Size = new Size(169, 23);
            TxtResultado.TabIndex = 11;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label6.ForeColor = Color.White;
            label6.Location = new Point(49, 305);
            label6.Name = "label6";
            label6.Size = new Size(79, 40);
            label6.TabIndex = 12;
            label6.Text = "costo de\r\nimpresion";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label7.ForeColor = Color.Lime;
            label7.Location = new Point(181, 243);
            label7.Name = "label7";
            label7.Size = new Size(197, 60);
            label7.TabIndex = 13;
            label7.Text = "este costo de impresion no\r\ntoma en cuenta los fallos \r\nque puedan suceder";
            label7.Visible = false;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label8.ForeColor = Color.Red;
            label8.Location = new Point(49, 266);
            label8.Name = "label8";
            label8.Size = new Size(97, 20);
            label8.TabIndex = 14;
            label8.Text = "Advertencia:";
            label8.Visible = false;
            // 
            // btnSalir
            // 
            btnSalir.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnSalir.Location = new Point(240, 371);
            btnSalir.Name = "btnSalir";
            btnSalir.Size = new Size(159, 35);
            btnSalir.TabIndex = 15;
            btnSalir.Text = "Salir";
            btnSalir.UseVisualStyleBackColor = true;
            btnSalir.Click += btnSalir_Click;
            // 
            // CbTipoFilamento
            // 
            CbTipoFilamento.FormattingEnabled = true;
            CbTipoFilamento.Items.AddRange(new object[] { "PLA", "TPU", "ABS", "ASA", "NYLONG" });
            CbTipoFilamento.Location = new Point(181, 200);
            CbTipoFilamento.Name = "CbTipoFilamento";
            CbTipoFilamento.Size = new Size(169, 23);
            CbTipoFilamento.TabIndex = 16;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label9.ForeColor = Color.White;
            label9.Location = new Point(49, 199);
            label9.Name = "label9";
            label9.Size = new Size(77, 40);
            label9.TabIndex = 17;
            label9.Text = "tipo de \r\nfilamento";
            // 
            // LblErrorTipo
            // 
            LblErrorTipo.AutoSize = true;
            LblErrorTipo.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            LblErrorTipo.ForeColor = Color.Red;
            LblErrorTipo.Location = new Point(181, 177);
            LblErrorTipo.Name = "LblErrorTipo";
            LblErrorTipo.Size = new Size(60, 20);
            LblErrorTipo.TabIndex = 18;
            LblErrorTipo.Text = "label10";
            LblErrorTipo.Visible = false;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.White;
            label1.Location = new Point(356, 129);
            label1.Name = "label1";
            label1.Size = new Size(25, 20);
            label1.TabIndex = 19;
            label1.Text = "hs";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.ForeColor = Color.White;
            label2.Location = new Point(356, 50);
            label2.Name = "label2";
            label2.Size = new Size(24, 20);
            label2.TabIndex = 20;
            label2.Text = "gr";
            // 
            // FrmPrincipal
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(0, 0, 64);
            ClientSize = new Size(429, 450);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(LblErrorTipo);
            Controls.Add(label9);
            Controls.Add(CbTipoFilamento);
            Controls.Add(btnSalir);
            Controls.Add(label8);
            Controls.Add(label7);
            Controls.Add(label6);
            Controls.Add(TxtResultado);
            Controls.Add(LblErrorInprevisto);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(LblErrorGramos);
            Controls.Add(LblErrorTiempo);
            Controls.Add(TxtFilamento);
            Controls.Add(TxtTiempo);
            Controls.Add(btnCalcularCosto);
            Name = "FrmPrincipal";
            Text = "Principal";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnCalcularCosto;
        private TextBox TxtTiempo;
        private TextBox TxtFilamento;
        private Label LblErrorTiempo;
        private Label LblErrorGramos;
        private Label label3;
        private Label label4;
        private Label LblErrorInprevisto;
        private TextBox TxtResultado;
        private Label label6;
        private Label label7;
        private Label label8;
        private Button btnSalir;
        private ComboBox CbTipoFilamento;
        private Label label9;
        private Label LblErrorTipo;
        private Label label1;
        private Label label2;
    }
}