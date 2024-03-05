namespace Forms
{
    partial class FrmRegistrate
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmRegistrate));
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label1 = new Label();
            LblErrorContraseña = new Label();
            ErrorNombre = new Label();
            ErrorImpresora = new Label();
            TxtNombre = new TextBox();
            TxtContraseña = new TextBox();
            TxtRepetir = new TextBox();
            BtnRegistrar = new Button();
            pictureBox1 = new PictureBox();
            CbCaptcha = new CheckBox();
            LblErrorCaptcha = new Label();
            txtRespuestaCaptcha = new TextBox();
            LblCaptcha = new Label();
            BtnGenerarCodigo = new Button();
            BtnCancelar = new Button();
            CbImpresora = new ComboBox();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.ForeColor = SystemColors.ButtonFace;
            label2.Location = new Point(55, 134);
            label2.Name = "label2";
            label2.Size = new Size(86, 40);
            label2.TabIndex = 1;
            label2.Text = "Repetir \r\ncontraseña";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.ForeColor = SystemColors.ButtonFace;
            label3.Location = new Point(55, 85);
            label3.Name = "label3";
            label3.Size = new Size(86, 20);
            label3.TabIndex = 2;
            label3.Text = "contraseña";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.ForeColor = SystemColors.ButtonFace;
            label4.Location = new Point(55, 191);
            label4.Name = "label4";
            label4.Size = new Size(81, 20);
            label4.TabIndex = 3;
            label4.Text = "Impresora";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = SystemColors.ButtonFace;
            label1.Location = new Point(55, 36);
            label1.Name = "label1";
            label1.Size = new Size(64, 20);
            label1.TabIndex = 4;
            label1.Text = "nombre";
            // 
            // LblErrorContraseña
            // 
            LblErrorContraseña.AutoSize = true;
            LblErrorContraseña.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            LblErrorContraseña.ForeColor = Color.Red;
            LblErrorContraseña.Location = new Point(184, 112);
            LblErrorContraseña.Name = "LblErrorContraseña";
            LblErrorContraseña.Size = new Size(233, 17);
            LblErrorContraseña.TabIndex = 5;
            LblErrorContraseña.Text = "error. las contraseñas no son iguales";
            LblErrorContraseña.Visible = false;
            // 
            // ErrorNombre
            // 
            ErrorNombre.AutoSize = true;
            ErrorNombre.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            ErrorNombre.ForeColor = Color.Red;
            ErrorNombre.Location = new Point(184, 14);
            ErrorNombre.Name = "ErrorNombre";
            ErrorNombre.Size = new Size(209, 17);
            ErrorNombre.TabIndex = 6;
            ErrorNombre.Text = "Error. ese nombre ya esta en uso";
            ErrorNombre.Visible = false;
            // 
            // ErrorImpresora
            // 
            ErrorImpresora.AutoSize = true;
            ErrorImpresora.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            ErrorImpresora.ForeColor = Color.Red;
            ErrorImpresora.Location = new Point(184, 169);
            ErrorImpresora.Name = "ErrorImpresora";
            ErrorImpresora.Size = new Size(163, 17);
            ErrorImpresora.TabIndex = 7;
            ErrorImpresora.Text = "impresora no encontrada";
            ErrorImpresora.Visible = false;
            // 
            // TxtNombre
            // 
            TxtNombre.Location = new Point(184, 37);
            TxtNombre.Name = "TxtNombre";
            TxtNombre.Size = new Size(236, 23);
            TxtNombre.TabIndex = 8;
            // 
            // TxtContraseña
            // 
            TxtContraseña.Location = new Point(184, 82);
            TxtContraseña.Name = "TxtContraseña";
            TxtContraseña.PasswordChar = '*';
            TxtContraseña.Size = new Size(236, 23);
            TxtContraseña.TabIndex = 9;
            // 
            // TxtRepetir
            // 
            TxtRepetir.Location = new Point(184, 135);
            TxtRepetir.Name = "TxtRepetir";
            TxtRepetir.PasswordChar = '*';
            TxtRepetir.Size = new Size(236, 23);
            TxtRepetir.TabIndex = 10;
            // 
            // BtnRegistrar
            // 
            BtnRegistrar.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            BtnRegistrar.Location = new Point(55, 421);
            BtnRegistrar.Name = "BtnRegistrar";
            BtnRegistrar.Size = new Size(202, 36);
            BtnRegistrar.TabIndex = 16;
            BtnRegistrar.Text = "crear perfil";
            BtnRegistrar.UseVisualStyleBackColor = true;
            BtnRegistrar.Click += BtnRegistrar_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.BackgroundImage = (Image)resources.GetObject("pictureBox1.BackgroundImage");
            pictureBox1.Location = new Point(184, 247);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(46, 46);
            pictureBox1.TabIndex = 17;
            pictureBox1.TabStop = false;
            // 
            // CbCaptcha
            // 
            CbCaptcha.AutoSize = true;
            CbCaptcha.Cursor = Cursors.AppStarting;
            CbCaptcha.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            CbCaptcha.ForeColor = Color.White;
            CbCaptcha.Location = new Point(254, 269);
            CbCaptcha.Name = "CbCaptcha";
            CbCaptcha.Size = new Size(139, 24);
            CbCaptcha.TabIndex = 18;
            CbCaptcha.Text = "no soy un robot";
            CbCaptcha.UseVisualStyleBackColor = true;
            // 
            // LblErrorCaptcha
            // 
            LblErrorCaptcha.AutoSize = true;
            LblErrorCaptcha.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            LblErrorCaptcha.ForeColor = Color.Red;
            LblErrorCaptcha.Location = new Point(254, 249);
            LblErrorCaptcha.Name = "LblErrorCaptcha";
            LblErrorCaptcha.Size = new Size(131, 17);
            LblErrorCaptcha.TabIndex = 20;
            LblErrorCaptcha.Text = "Captcha no resuelto";
            LblErrorCaptcha.Visible = false;
            // 
            // txtRespuestaCaptcha
            // 
            txtRespuestaCaptcha.Location = new Point(184, 359);
            txtRespuestaCaptcha.Name = "txtRespuestaCaptcha";
            txtRespuestaCaptcha.Size = new Size(236, 23);
            txtRespuestaCaptcha.TabIndex = 21;
            // 
            // LblCaptcha
            // 
            LblCaptcha.AutoSize = true;
            LblCaptcha.Font = new Font("Anurati", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            LblCaptcha.ForeColor = SystemColors.ButtonFace;
            LblCaptcha.Location = new Point(184, 318);
            LblCaptcha.Name = "LblCaptcha";
            LblCaptcha.Size = new Size(0, 18);
            LblCaptcha.TabIndex = 22;
            // 
            // BtnGenerarCodigo
            // 
            BtnGenerarCodigo.Location = new Point(55, 304);
            BtnGenerarCodigo.Name = "BtnGenerarCodigo";
            BtnGenerarCodigo.Size = new Size(86, 48);
            BtnGenerarCodigo.TabIndex = 23;
            BtnGenerarCodigo.Text = "Generar otro codigo";
            BtnGenerarCodigo.UseVisualStyleBackColor = true;
            BtnGenerarCodigo.Click += BtnGenerarCodigo_Click;
            // 
            // BtnCancelar
            // 
            BtnCancelar.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            BtnCancelar.Location = new Point(276, 421);
            BtnCancelar.Name = "BtnCancelar";
            BtnCancelar.Size = new Size(202, 36);
            BtnCancelar.TabIndex = 24;
            BtnCancelar.Text = "cancelar";
            BtnCancelar.UseVisualStyleBackColor = true;
            BtnCancelar.Click += BtnCancelar_Click;
            // 
            // CbImpresora
            // 
            CbImpresora.FormattingEnabled = true;
            CbImpresora.Items.AddRange(new object[] { "Artillery hornet", "Artillery Sidewinder X2", "Artillery Genius PRO", "Creality CR-10 Smart", "Creality Ender 3 S1", "Creality Ender 3 V2", "Hellbot Magna SE" });
            CbImpresora.Location = new Point(184, 189);
            CbImpresora.Name = "CbImpresora";
            CbImpresora.Size = new Size(236, 23);
            CbImpresora.TabIndex = 25;
            // 
            // FrmRegistrate
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(0, 0, 64);
            ClientSize = new Size(499, 469);
            Controls.Add(CbImpresora);
            Controls.Add(BtnCancelar);
            Controls.Add(BtnGenerarCodigo);
            Controls.Add(LblCaptcha);
            Controls.Add(txtRespuestaCaptcha);
            Controls.Add(LblErrorCaptcha);
            Controls.Add(CbCaptcha);
            Controls.Add(pictureBox1);
            Controls.Add(BtnRegistrar);
            Controls.Add(TxtRepetir);
            Controls.Add(TxtContraseña);
            Controls.Add(TxtNombre);
            Controls.Add(ErrorImpresora);
            Controls.Add(ErrorNombre);
            Controls.Add(LblErrorContraseña);
            Controls.Add(label1);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Name = "FrmRegistrate";
            Text = "Registrate";
            Load += FrmRegistrate_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label2;
        private Label label3;
        private Label label4;
        private Label label1;
        private Label LblErrorContraseña;
        private Label ErrorNombre;
        private Label ErrorImpresora;
        private TextBox TxtNombre;
        private TextBox TxtContraseña;
        private TextBox TxtRepetir;
        private Button BtnRegistrar;
        private PictureBox pictureBox1;
        private CheckBox CbCaptcha;
        private Label LblErrorCaptcha;
        private TextBox txtRespuestaCaptcha;
        private Label LblCaptcha;
        private Button BtnGenerarCodigo;
        private Button BtnCancelar;
        private ComboBox CbImpresora;
    }
}