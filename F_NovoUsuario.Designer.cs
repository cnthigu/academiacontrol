namespace Aula_99
{
    partial class F_NovoUsuario
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
            tb_nome = new TextBox();
            tb_username = new TextBox();
            label2 = new Label();
            tb_senha = new TextBox();
            label3 = new Label();
            label4 = new Label();
            cb_status = new ComboBox();
            n_nivel = new NumericUpDown();
            label5 = new Label();
            label7 = new Label();
            label6 = new Label();
            label8 = new Label();
            label9 = new Label();
            panel1 = new Panel();
            btn_fechar = new Button();
            btn_cancelar = new Button();
            btn_salvar = new Button();
            btn_novo = new Button();
            ((System.ComponentModel.ISupportInitialize)n_nivel).BeginInit();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(87, -102);
            label1.Name = "label1";
            label1.Size = new Size(38, 15);
            label1.TabIndex = 0;
            label1.Text = "label1";
            // 
            // tb_nome
            // 
            tb_nome.Location = new Point(3, 31);
            tb_nome.Name = "tb_nome";
            tb_nome.Size = new Size(204, 23);
            tb_nome.TabIndex = 1;
            tb_nome.TextChanged += textBox1_TextChanged;
            // 
            // tb_username
            // 
            tb_username.Location = new Point(213, 31);
            tb_username.Name = "tb_username";
            tb_username.Size = new Size(94, 23);
            tb_username.TabIndex = 3;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(213, 13);
            label2.Name = "label2";
            label2.Size = new Size(60, 15);
            label2.TabIndex = 2;
            label2.Text = "Username";
            label2.Click += label2_Click;
            // 
            // tb_senha
            // 
            tb_senha.Location = new Point(313, 31);
            tb_senha.Name = "tb_senha";
            tb_senha.PasswordChar = '-';
            tb_senha.Size = new Size(104, 23);
            tb_senha.TabIndex = 5;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(313, 13);
            label3.Name = "label3";
            label3.Size = new Size(39, 15);
            label3.TabIndex = 4;
            label3.Text = "Senha";
            label3.Click += label3_Click;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(3, 13);
            label4.Name = "label4";
            label4.Size = new Size(40, 15);
            label4.TabIndex = 6;
            label4.Text = "Nome";
            // 
            // cb_status
            // 
            cb_status.FormattingEnabled = true;
            cb_status.Items.AddRange(new object[] { "A", "B", "D" });
            cb_status.Location = new Point(3, 76);
            cb_status.Name = "cb_status";
            cb_status.Size = new Size(94, 23);
            cb_status.TabIndex = 7;
            // 
            // n_nivel
            // 
            n_nivel.Location = new Point(103, 77);
            n_nivel.Maximum = new decimal(new int[] { 3, 0, 0, 0 });
            n_nivel.Name = "n_nivel";
            n_nivel.Size = new Size(104, 23);
            n_nivel.TabIndex = 8;
            n_nivel.ValueChanged += n_nivel_ValueChanged;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(3, 58);
            label5.Name = "label5";
            label5.Size = new Size(39, 15);
            label5.TabIndex = 9;
            label5.Text = "Status";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(103, 59);
            label7.Name = "label7";
            label7.Size = new Size(34, 15);
            label7.TabIndex = 11;
            label7.Text = "Nivel";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(3, 102);
            label6.Name = "label6";
            label6.Size = new Size(60, 15);
            label6.TabIndex = 12;
            label6.Text = "A = Ativo!";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(69, 103);
            label8.Name = "label8";
            label8.Size = new Size(82, 15);
            label8.TabIndex = 13;
            label8.Text = "B = Bloquedo!";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(157, 103);
            label9.Name = "label9";
            label9.Size = new Size(84, 15);
            label9.TabIndex = 14;
            label9.Text = "D = Desligado!";
            // 
            // panel1
            // 
            panel1.Controls.Add(btn_fechar);
            panel1.Controls.Add(btn_cancelar);
            panel1.Controls.Add(btn_salvar);
            panel1.Controls.Add(btn_novo);
            panel1.Dock = DockStyle.Bottom;
            panel1.Location = new Point(0, 180);
            panel1.Name = "panel1";
            panel1.Size = new Size(433, 29);
            panel1.TabIndex = 15;
            // 
            // btn_fechar
            // 
            btn_fechar.Location = new Point(355, 3);
            btn_fechar.Name = "btn_fechar";
            btn_fechar.Size = new Size(75, 23);
            btn_fechar.TabIndex = 16;
            btn_fechar.Text = "Fechar";
            btn_fechar.UseVisualStyleBackColor = true;
            btn_fechar.Click += btn_fechar_Click;
            // 
            // btn_cancelar
            // 
            btn_cancelar.Location = new Point(165, 3);
            btn_cancelar.Name = "btn_cancelar";
            btn_cancelar.Size = new Size(75, 23);
            btn_cancelar.TabIndex = 2;
            btn_cancelar.Text = "Cancelar";
            btn_cancelar.UseVisualStyleBackColor = true;
            btn_cancelar.Click += btn_cancelar_Click;
            // 
            // btn_salvar
            // 
            btn_salvar.Location = new Point(84, 3);
            btn_salvar.Name = "btn_salvar";
            btn_salvar.Size = new Size(75, 23);
            btn_salvar.TabIndex = 1;
            btn_salvar.Text = "Salvar";
            btn_salvar.UseVisualStyleBackColor = true;
            btn_salvar.Click += button2_Click;
            // 
            // btn_novo
            // 
            btn_novo.Location = new Point(3, 3);
            btn_novo.Name = "btn_novo";
            btn_novo.Size = new Size(75, 23);
            btn_novo.TabIndex = 0;
            btn_novo.Text = "Novo";
            btn_novo.UseVisualStyleBackColor = true;
            btn_novo.Click += btn_novo_Click;
            // 
            // F_NovoUsuario
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(433, 209);
            Controls.Add(panel1);
            Controls.Add(label9);
            Controls.Add(label8);
            Controls.Add(label6);
            Controls.Add(label7);
            Controls.Add(label5);
            Controls.Add(n_nivel);
            Controls.Add(cb_status);
            Controls.Add(label4);
            Controls.Add(tb_senha);
            Controls.Add(label3);
            Controls.Add(tb_username);
            Controls.Add(label2);
            Controls.Add(tb_nome);
            Controls.Add(label1);
            FormBorderStyle = FormBorderStyle.FixedDialog;
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "F_NovoUsuario";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Novo Usuário";
            Load += F_NovoUsuario_Load;
            ((System.ComponentModel.ISupportInitialize)n_nivel).EndInit();
            panel1.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox tb_nome;
        private TextBox tb_username;
        private Label label2;
        private TextBox tb_senha;
        private Label label3;
        private Label label4;
        private ComboBox cb_status;
        private NumericUpDown n_nivel;
        private Label label5;
        private Label label7;
        private Label label6;
        private Label label8;
        private Label label9;
        private Panel panel1;
        private Button btn_fechar;
        private Button btn_cancelar;
        private Button btn_salvar;
        private Button btn_novo;
    }
}