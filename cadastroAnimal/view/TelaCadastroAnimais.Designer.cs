﻿namespace cadastroAnimal.view
{
    partial class TelaCadastroAnimais
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
            label4 = new Label();
            tbx_ = new TextBox();
            ttx = new TextBox();
            cbx = new ComboBox();
            btn_Cadastrer = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(82, 121);
            label1.Name = "label1";
            label1.Size = new Size(44, 15);
            label1.TabIndex = 0;
            label1.Text = "Nome:";
            label1.Click += label1_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(82, 169);
            label2.Name = "label2";
            label2.Size = new Size(36, 15);
            label2.TabIndex = 1;
            label2.Text = "Raça:";
            label2.Click += label2_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 21.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.Location = new Point(260, 48);
            label3.Name = "label3";
            label3.Size = new Size(299, 40);
            label3.TabIndex = 2;
            label3.Text = "Cadastro de Animais";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.Location = new Point(82, 222);
            label4.Name = "label4";
            label4.Size = new Size(41, 15);
            label4.TabIndex = 3;
            label4.Text = "Porte:";
            label4.Click += label4_Click;
            // 
            // tbx_
            // 
            tbx_.Location = new Point(135, 118);
            tbx_.Name = "tbx_";
            tbx_.Size = new Size(100, 23);
            tbx_.TabIndex = 4;
            tbx_.TextChanged += textBox1_TextChanged;
            // 
            // ttx
            // 
            ttx.Location = new Point(135, 166);
            ttx.Name = "ttx";
            ttx.Size = new Size(100, 23);
            ttx.TabIndex = 5;
            // 
            // cbx
            // 
            cbx.FormattingEnabled = true;
            cbx.Items.AddRange(new object[] { "Pequeno", "Medio", "Grande" });
            cbx.Location = new Point(135, 219);
            cbx.Name = "cbx";
            cbx.Size = new Size(121, 23);
            cbx.TabIndex = 6;
            // 
            // btn_Cadastrer
            // 
            btn_Cadastrer.Location = new Point(135, 346);
            btn_Cadastrer.Name = "btn_Cadastrer";
            btn_Cadastrer.Size = new Size(611, 30);
            btn_Cadastrer.TabIndex = 7;
            btn_Cadastrer.Text = "Cadastrar";
            btn_Cadastrer.UseVisualStyleBackColor = true;
            btn_Cadastrer.Click += btn_Cadastrer_Click;
            // 
            // TelaCadastroAnimais
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btn_Cadastrer);
            Controls.Add(cbx);
            Controls.Add(ttx);
            Controls.Add(tbx_);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            MaximizeBox = false;
            Name = "TelaCadastroAnimais";
            ShowIcon = false;
            Text = "Sistema De Cadastro De Animais";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private TextBox tbx_;
        private TextBox ttx;
        private ComboBox cbx;
        private Button btn_Cadastrer;
    }
}