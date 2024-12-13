namespace ProjetoLogin.Apresentacao
{
    partial class Cadastre__se
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
            label2 = new Label();
            label3 = new Label();
            txtLogin = new TextBox();
            txtSenha = new TextBox();
            txtConfirmarSenha = new TextBox();
            btnCadastrar = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Calisto MT", 12F);
            label1.Location = new Point(67, 58);
            label1.Margin = new Padding(4, 0, 4, 0);
            label1.Name = "label1";
            label1.Size = new Size(51, 19);
            label1.TabIndex = 0;
            label1.Text = "Login";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Calisto MT", 12F);
            label2.Location = new Point(70, 149);
            label2.Margin = new Padding(4, 0, 4, 0);
            label2.Name = "label2";
            label2.Size = new Size(51, 19);
            label2.TabIndex = 1;
            label2.Text = "Senha";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Calisto MT", 12F);
            label3.Location = new Point(70, 244);
            label3.Margin = new Padding(4, 0, 4, 0);
            label3.Name = "label3";
            label3.Size = new Size(129, 19);
            label3.TabIndex = 2;
            label3.Text = "Confirmar Senha";
            // 
            // txtLogin
            // 
            txtLogin.Font = new Font("Microsoft Sans Serif", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtLogin.Location = new Point(67, 94);
            txtLogin.Margin = new Padding(4, 4, 4, 4);
            txtLogin.Name = "txtLogin";
            txtLogin.Size = new Size(294, 22);
            txtLogin.TabIndex = 3;
            // 
            // txtSenha
            // 
            txtSenha.Font = new Font("Microsoft Sans Serif", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtSenha.Location = new Point(70, 186);
            txtSenha.Margin = new Padding(4, 4, 4, 4);
            txtSenha.Name = "txtSenha";
            txtSenha.PasswordChar = '*';
            txtSenha.Size = new Size(207, 22);
            txtSenha.TabIndex = 4;
            // 
            // txtConfirmarSenha
            // 
            txtConfirmarSenha.Font = new Font("Microsoft Sans Serif", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtConfirmarSenha.Location = new Point(70, 286);
            txtConfirmarSenha.Margin = new Padding(4, 4, 4, 4);
            txtConfirmarSenha.Name = "txtConfirmarSenha";
            txtConfirmarSenha.PasswordChar = '*';
            txtConfirmarSenha.Size = new Size(207, 22);
            txtConfirmarSenha.TabIndex = 5;
            // 
            // btnCadastrar
            // 
            btnCadastrar.Location = new Point(107, 339);
            btnCadastrar.Margin = new Padding(4, 4, 4, 4);
            btnCadastrar.Name = "btnCadastrar";
            btnCadastrar.Size = new Size(140, 56);
            btnCadastrar.TabIndex = 6;
            btnCadastrar.Text = "Cadastrar";
            btnCadastrar.UseVisualStyleBackColor = true;
            // 
            // Cadastre__se
            // 
            AutoScaleDimensions = new SizeF(10F, 19F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(393, 443);
            Controls.Add(btnCadastrar);
            Controls.Add(txtConfirmarSenha);
            Controls.Add(txtSenha);
            Controls.Add(txtLogin);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Font = new Font("Calisto MT", 12F);
            FormBorderStyle = FormBorderStyle.FixedToolWindow;
            Margin = new Padding(4, 4, 4, 4);
            Name = "Cadastre__se";
            Text = "Cadastre__se";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private TextBox txtLogin;
        private TextBox txtSenha;
        private TextBox txtConfirmarSenha;
        private Button btnCadastrar;
    }
}