namespace ProjetoLogin
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            pictureBox1 = new PictureBox();
            lblLogin = new Label();
            lblSenha = new Label();
            txbLogin = new TextBox();
            txbSenha = new TextBox();
            btnEntrar = new Button();
            btnSair = new Button();
            btnCadastreSe = new Button();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(49, 59);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(258, 227);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // lblLogin
            // 
            lblLogin.AutoSize = true;
            lblLogin.Font = new Font("Calisto MT", 14.25F);
            lblLogin.Location = new Point(360, 93);
            lblLogin.Name = "lblLogin";
            lblLogin.Size = new Size(75, 22);
            lblLogin.TabIndex = 1;
            lblLogin.Text = "LOGIN";
            // 
            // lblSenha
            // 
            lblSenha.AutoSize = true;
            lblSenha.Font = new Font("Calisto MT", 14.25F);
            lblSenha.Location = new Point(360, 159);
            lblSenha.Name = "lblSenha";
            lblSenha.Size = new Size(78, 22);
            lblSenha.TabIndex = 2;
            lblSenha.Text = "SENHA";
            // 
            // txbLogin
            // 
            txbLogin.Location = new Point(441, 92);
            txbLogin.Name = "txbLogin";
            txbLogin.Size = new Size(184, 23);
            txbLogin.TabIndex = 3;
            // 
            // txbSenha
            // 
            txbSenha.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txbSenha.Location = new Point(446, 153);
            txbSenha.Name = "txbSenha";
            txbSenha.PasswordChar = '*';
            txbSenha.Size = new Size(179, 25);
            txbSenha.TabIndex = 4;
            // 
            // btnEntrar
            // 
            btnEntrar.Location = new Point(429, 224);
            btnEntrar.Name = "btnEntrar";
            btnEntrar.Size = new Size(75, 23);
            btnEntrar.TabIndex = 5;
            btnEntrar.Text = "Entrar";
            btnEntrar.UseVisualStyleBackColor = false;
            // 
            // btnSair
            // 
            btnSair.Location = new Point(550, 224);
            btnSair.Name = "btnSair";
            btnSair.Size = new Size(75, 23);
            btnSair.TabIndex = 6;
            btnSair.Text = "Sair";
            btnSair.UseVisualStyleBackColor = false;
            btnSair.Click += btnSair_Click;
            // 
            // btnCadastreSe
            // 
            btnCadastreSe.Font = new Font("Calisto MT", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnCadastreSe.Location = new Point(441, 283);
            btnCadastreSe.Name = "btnCadastreSe";
            btnCadastreSe.Size = new Size(179, 28);
            btnCadastreSe.TabIndex = 7;
            btnCadastreSe.Text = "CADASTRE - SE";
            btnCadastreSe.UseVisualStyleBackColor = false;
            btnCadastreSe.Click += btnCadastreSe_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ButtonFace;
            ClientSize = new Size(688, 370);
            Controls.Add(btnCadastreSe);
            Controls.Add(btnSair);
            Controls.Add(btnEntrar);
            Controls.Add(txbSenha);
            Controls.Add(txbLogin);
            Controls.Add(lblSenha);
            Controls.Add(lblLogin);
            Controls.Add(pictureBox1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "Form1";
            Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox pictureBox1;
        private Label lblLogin;
        private Label lblSenha;
        private TextBox txbLogin;
        private TextBox txbSenha;
        private Button btnEntrar;
        private Button btnSair;
        private Button btnCadastreSe;
    }
}
