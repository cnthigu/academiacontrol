namespace Aula_99
{
    partial class F_login
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
            tb_username = new TextBox();
            tb_senha = new TextBox();
            bt_logar = new Button();
            tb_cancelar = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(116, 66);
            label1.Name = "label1";
            label1.Size = new Size(60, 15);
            label1.TabIndex = 0;
            label1.Text = "Username";
            label1.Click += label1_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(116, 110);
            label2.Name = "label2";
            label2.Size = new Size(39, 15);
            label2.TabIndex = 1;
            label2.Text = "Senha";
            // 
            // tb_username
            // 
            tb_username.Location = new Point(116, 84);
            tb_username.Name = "tb_username";
            tb_username.Size = new Size(100, 23);
            tb_username.TabIndex = 2;
            tb_username.TextChanged += tb_username_TextChanged;
            // 
            // tb_senha
            // 
            tb_senha.Location = new Point(116, 128);
            tb_senha.Name = "tb_senha";
            tb_senha.Size = new Size(100, 23);
            tb_senha.TabIndex = 3;
            tb_senha.UseSystemPasswordChar = true;
            tb_senha.TextChanged += tb_senha_TextChanged;
            // 
            // bt_logar
            // 
            bt_logar.Location = new Point(116, 157);
            bt_logar.Name = "bt_logar";
            bt_logar.Size = new Size(100, 23);
            bt_logar.TabIndex = 4;
            bt_logar.Text = "Logar";
            bt_logar.UseVisualStyleBackColor = true;
            bt_logar.Click += bt_logar_Click;
            // 
            // tb_cancelar
            // 
            tb_cancelar.Location = new Point(130, 186);
            tb_cancelar.Name = "tb_cancelar";
            tb_cancelar.Size = new Size(72, 23);
            tb_cancelar.TabIndex = 5;
            tb_cancelar.Text = "Cancelar";
            tb_cancelar.UseVisualStyleBackColor = true;
            tb_cancelar.Click += tb_cancelar_Click;
            // 
            // F_login
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(345, 284);
            Controls.Add(tb_cancelar);
            Controls.Add(bt_logar);
            Controls.Add(tb_senha);
            Controls.Add(tb_username);
            Controls.Add(label2);
            Controls.Add(label1);
            FormBorderStyle = FormBorderStyle.FixedDialog;
            MinimizeBox = false;
            Name = "F_login";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Login - AcademiaSystem";
            Load += F_login_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private TextBox tb_username;
        private TextBox tb_senha;
        private Button bt_logar;
        private Button tb_cancelar;
    }
}