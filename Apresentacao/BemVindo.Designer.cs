﻿namespace ProjetoLogin.Apresentacao
{
    partial class BemVindo
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
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Mistral", 48F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(151, 115);
            label1.Name = "label1";
            label1.Size = new Size(305, 76);
            label1.TabIndex = 0;
            label1.Text = "Bem Vindo!!";
            // 
            // BemVindo
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.Control;
            ClientSize = new Size(609, 347);
            Controls.Add(label1);
            FormBorderStyle = FormBorderStyle.FixedToolWindow;
            Name = "BemVindo";
            Text = "BemVindo";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
    }
}