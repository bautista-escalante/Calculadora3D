namespace Forms
{
    partial class FrmCaptcha
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
            BtnVerificar = new Button();
            btnCancelar = new Button();
            TxtCaptcha = new TextBox();
            LblCaptcha = new Label();
            lblErrorCapcha = new Label();
            label4 = new Label();
            SuspendLayout();
            // 
            // BtnVerificar
            // 
            BtnVerificar.Location = new Point(63, 286);
            BtnVerificar.Name = "BtnVerificar";
            BtnVerificar.Size = new Size(120, 38);
            BtnVerificar.TabIndex = 0;
            BtnVerificar.Text = "verificar";
            BtnVerificar.UseVisualStyleBackColor = true;
            BtnVerificar.Click += BtnVerificar_Click;
            // 
            // btnCancelar
            // 
            btnCancelar.Location = new Point(293, 286);
            btnCancelar.Name = "btnCancelar";
            btnCancelar.Size = new Size(120, 38);
            btnCancelar.TabIndex = 1;
            btnCancelar.Text = "cancelar";
            btnCancelar.UseVisualStyleBackColor = true;
            btnCancelar.Click += btnCancelar_Click;
            // 
            // TxtCaptcha
            // 
            TxtCaptcha.Location = new Point(109, 182);
            TxtCaptcha.Name = "TxtCaptcha";
            TxtCaptcha.Size = new Size(234, 23);
            TxtCaptcha.TabIndex = 2;
            // 
            // LblCaptcha
            // 
            LblCaptcha.AutoSize = true;
            LblCaptcha.Font = new Font("Anurati", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            LblCaptcha.ForeColor = Color.FromArgb(224, 224, 224);
            LblCaptcha.Location = new Point(186, 120);
            LblCaptcha.Name = "LblCaptcha";
            LblCaptcha.Size = new Size(0, 18);
            LblCaptcha.TabIndex = 3;
            // 
            // lblErrorCapcha
            // 
            lblErrorCapcha.AutoSize = true;
            lblErrorCapcha.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblErrorCapcha.ForeColor = Color.Red;
            lblErrorCapcha.Location = new Point(109, 159);
            lblErrorCapcha.Name = "lblErrorCapcha";
            lblErrorCapcha.Size = new Size(0, 20);
            lblErrorCapcha.TabIndex = 4;
            lblErrorCapcha.Visible = false;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.ForeColor = Color.White;
            label4.Location = new Point(186, 46);
            label4.Name = "label4";
            label4.Size = new Size(81, 20);
            label4.TabIndex = 6;
            label4.Text = "CAPTCHA ";
            // 
            // FrmCaptcha
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(0, 0, 64);
            ClientSize = new Size(452, 357);
            Controls.Add(label4);
            Controls.Add(lblErrorCapcha);
            Controls.Add(LblCaptcha);
            Controls.Add(TxtCaptcha);
            Controls.Add(btnCancelar);
            Controls.Add(BtnVerificar);
            Name = "FrmCaptcha";
            Text = "FrmCaptcha";
            Load += FrmCaptcha_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button BtnVerificar;
        private Button btnCancelar;
        private TextBox TxtCaptcha;
        private Label LblCaptcha;
        private Label lblErrorCapcha;
        private Label label4;
    }
}