namespace Forms
{
    partial class FrmLogin
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
            btningresar = new Button();
            label2 = new Label();
            TxtContraseña = new TextBox();
            txtNombre = new TextBox();
            label1 = new Label();
            label3 = new Label();
            LlblRegistar = new LinkLabel();
            label4 = new Label();
            lblErrorCuenta = new Label();
            LblErrorNombre = new Label();
            LblErrorContraseña = new Label();
            SuspendLayout();
            // 
            // btningresar
            // 
            btningresar.Location = new Point(80, 236);
            btningresar.Name = "btningresar";
            btningresar.Size = new Size(292, 43);
            btningresar.TabIndex = 1;
            btningresar.Text = "ingresar";
            btningresar.UseVisualStyleBackColor = true;
            btningresar.Click += btningresar_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.FromArgb(0, 0, 64);
            label2.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.ForeColor = SystemColors.Control;
            label2.Location = new Point(80, 84);
            label2.Name = "label2";
            label2.Size = new Size(64, 20);
            label2.TabIndex = 3;
            label2.Text = "nombre";
            // 
            // TxtContraseña
            // 
            TxtContraseña.Location = new Point(185, 155);
            TxtContraseña.Name = "TxtContraseña";
            TxtContraseña.PasswordChar = '*';
            TxtContraseña.Size = new Size(187, 23);
            TxtContraseña.TabIndex = 4;
            // 
            // txtNombre
            // 
            txtNombre.Location = new Point(185, 81);
            txtNombre.Name = "txtNombre";
            txtNombre.Size = new Size(187, 23);
            txtNombre.TabIndex = 5;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.FromArgb(0, 0, 64);
            label1.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = SystemColors.Control;
            label1.Location = new Point(80, 158);
            label1.Name = "label1";
            label1.Size = new Size(88, 20);
            label1.TabIndex = 6;
            label1.Text = "Contraseña";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(0, 0);
            label3.Name = "label3";
            label3.Size = new Size(38, 15);
            label3.TabIndex = 7;
            label3.Text = "label3";
            // 
            // LlblRegistar
            // 
            LlblRegistar.ActiveLinkColor = Color.FromArgb(64, 0, 64);
            LlblRegistar.AutoSize = true;
            LlblRegistar.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            LlblRegistar.Location = new Point(237, 314);
            LlblRegistar.Name = "LlblRegistar";
            LlblRegistar.Size = new Size(101, 20);
            LlblRegistar.TabIndex = 8;
            LlblRegistar.TabStop = true;
            LlblRegistar.Text = "haz click aqui";
            LlblRegistar.LinkClicked += LlblRegistar_LinkClicked;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.BackColor = Color.FromArgb(0, 0, 64);
            label4.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.ForeColor = SystemColors.Control;
            label4.Location = new Point(80, 314);
            label4.Name = "label4";
            label4.Size = new Size(157, 20);
            label4.TabIndex = 9;
            label4.Text = "no tenes una cuenta?";
            // 
            // lblErrorCuenta
            // 
            lblErrorCuenta.AutoSize = true;
            lblErrorCuenta.BackColor = Color.FromArgb(0, 0, 64);
            lblErrorCuenta.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblErrorCuenta.ForeColor = Color.Red;
            lblErrorCuenta.Location = new Point(80, 294);
            lblErrorCuenta.Name = "lblErrorCuenta";
            lblErrorCuenta.Size = new Size(0, 20);
            lblErrorCuenta.TabIndex = 10;
            // 
            // LblErrorNombre
            // 
            LblErrorNombre.AutoSize = true;
            LblErrorNombre.BackColor = Color.FromArgb(0, 0, 64);
            LblErrorNombre.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            LblErrorNombre.ForeColor = Color.Red;
            LblErrorNombre.Location = new Point(185, 58);
            LblErrorNombre.Name = "LblErrorNombre";
            LblErrorNombre.Size = new Size(0, 20);
            LblErrorNombre.TabIndex = 11;
            // 
            // LblErrorContraseña
            // 
            LblErrorContraseña.AutoSize = true;
            LblErrorContraseña.BackColor = Color.FromArgb(0, 0, 64);
            LblErrorContraseña.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            LblErrorContraseña.ForeColor = Color.Red;
            LblErrorContraseña.Location = new Point(185, 132);
            LblErrorContraseña.Name = "LblErrorContraseña";
            LblErrorContraseña.Size = new Size(0, 20);
            LblErrorContraseña.TabIndex = 12;
            // 
            // FrmLogin
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(0, 0, 64);
            ClientSize = new Size(470, 371);
            Controls.Add(LblErrorContraseña);
            Controls.Add(LblErrorNombre);
            Controls.Add(lblErrorCuenta);
            Controls.Add(label4);
            Controls.Add(LlblRegistar);
            Controls.Add(label3);
            Controls.Add(label1);
            Controls.Add(txtNombre);
            Controls.Add(TxtContraseña);
            Controls.Add(label2);
            Controls.Add(btningresar);
            Name = "FrmLogin";
            Text = "ingresa";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Button btningresar;
        private Label label2;
        private TextBox TxtContraseña;
        private TextBox txtNombre;
        private Label label1;
        private Label label3;
        private LinkLabel LlblRegistar;
        private Label label4;
        private Label lblErrorCuenta;
        private Label LblErrorNombre;
        private Label LblErrorContraseña;
    }
}