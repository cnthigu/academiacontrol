namespace Aula_99
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
            lb_acesso = new Label();
            lb_usuario = new Label();
            lb_nomeusuario = new Label();
            label1 = new Label();
            menuStrip1 = new MenuStrip();
            alunosToolStripMenuItem = new ToolStripMenuItem();
            novoAlunoToolStripMenuItem = new ToolStripMenuItem();
            usuáriosToolStripMenuItem = new ToolStripMenuItem();
            gestãoDeUsuáriosToolStripMenuItem = new ToolStripMenuItem();
            novoUsuárioToolStripMenuItem = new ToolStripMenuItem();
            manutençãoToolStripMenuItem = new ToolStripMenuItem();
            bancoDeDadosToolStripMenuItem = new ToolStripMenuItem();
            loginToolStripMenuItem = new ToolStripMenuItem();
            loggonToolStripMenuItem = new ToolStripMenuItem();
            logoffToolStripMenuItem = new ToolStripMenuItem();
            menuStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // lb_acesso
            // 
            lb_acesso.AutoSize = true;
            lb_acesso.Location = new Point(56, 303);
            lb_acesso.Name = "lb_acesso";
            lb_acesso.Size = new Size(13, 15);
            lb_acesso.TabIndex = 0;
            lb_acesso.Text = "0";
            lb_acesso.Click += label1_Click;
            // 
            // lb_usuario
            // 
            lb_usuario.AutoSize = true;
            lb_usuario.Location = new Point(84, 303);
            lb_usuario.Name = "lb_usuario";
            lb_usuario.Size = new Size(50, 15);
            lb_usuario.TabIndex = 1;
            lb_usuario.Text = "Usuário:";
            lb_usuario.Click += lb_usuario_Click;
            // 
            // lb_nomeusuario
            // 
            lb_nomeusuario.AutoSize = true;
            lb_nomeusuario.Location = new Point(140, 303);
            lb_nomeusuario.Name = "lb_nomeusuario";
            lb_nomeusuario.Size = new Size(22, 15);
            lb_nomeusuario.TabIndex = 2;
            lb_nomeusuario.Text = "---";
            lb_nomeusuario.TextAlign = ContentAlignment.TopCenter;
            lb_nomeusuario.Click += lb_nomeusuario_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(12, 303);
            label1.Name = "label1";
            label1.Size = new Size(47, 15);
            label1.TabIndex = 3;
            label1.Text = "Acesso:";
            // 
            // menuStrip1
            // 
            menuStrip1.Items.AddRange(new ToolStripItem[] { alunosToolStripMenuItem, usuáriosToolStripMenuItem, manutençãoToolStripMenuItem, loginToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(510, 24);
            menuStrip1.TabIndex = 4;
            menuStrip1.Text = "menuStrip1";
            // 
            // alunosToolStripMenuItem
            // 
            alunosToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { novoAlunoToolStripMenuItem });
            alunosToolStripMenuItem.Name = "alunosToolStripMenuItem";
            alunosToolStripMenuItem.Size = new Size(56, 20);
            alunosToolStripMenuItem.Text = "Alunos";
            alunosToolStripMenuItem.Click += alunosToolStripMenuItem_Click;
            // 
            // novoAlunoToolStripMenuItem
            // 
            novoAlunoToolStripMenuItem.Name = "novoAlunoToolStripMenuItem";
            novoAlunoToolStripMenuItem.Size = new Size(180, 22);
            novoAlunoToolStripMenuItem.Text = "Novo Aluno";
            novoAlunoToolStripMenuItem.Click += novoAlunoToolStripMenuItem_Click;
            // 
            // usuáriosToolStripMenuItem
            // 
            usuáriosToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { gestãoDeUsuáriosToolStripMenuItem, novoUsuárioToolStripMenuItem });
            usuáriosToolStripMenuItem.Name = "usuáriosToolStripMenuItem";
            usuáriosToolStripMenuItem.Size = new Size(64, 20);
            usuáriosToolStripMenuItem.Text = "Usuários";
            usuáriosToolStripMenuItem.Click += usuáriosToolStripMenuItem_Click;
            // 
            // gestãoDeUsuáriosToolStripMenuItem
            // 
            gestãoDeUsuáriosToolStripMenuItem.Name = "gestãoDeUsuáriosToolStripMenuItem";
            gestãoDeUsuáriosToolStripMenuItem.Size = new Size(180, 22);
            gestãoDeUsuáriosToolStripMenuItem.Text = "Gestão de Usuários";
            gestãoDeUsuáriosToolStripMenuItem.Click += gestãoDeUsuáriosToolStripMenuItem_Click;
            // 
            // novoUsuárioToolStripMenuItem
            // 
            novoUsuárioToolStripMenuItem.Name = "novoUsuárioToolStripMenuItem";
            novoUsuárioToolStripMenuItem.Size = new Size(180, 22);
            novoUsuárioToolStripMenuItem.Text = "Novo Usuário";
            novoUsuárioToolStripMenuItem.Click += novoUsuárioToolStripMenuItem_Click;
            // 
            // manutençãoToolStripMenuItem
            // 
            manutençãoToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { bancoDeDadosToolStripMenuItem });
            manutençãoToolStripMenuItem.Name = "manutençãoToolStripMenuItem";
            manutençãoToolStripMenuItem.Size = new Size(86, 20);
            manutençãoToolStripMenuItem.Text = "Manutenção";
            // 
            // bancoDeDadosToolStripMenuItem
            // 
            bancoDeDadosToolStripMenuItem.Name = "bancoDeDadosToolStripMenuItem";
            bancoDeDadosToolStripMenuItem.Size = new Size(159, 22);
            bancoDeDadosToolStripMenuItem.Text = "Banco de Dados";
            bancoDeDadosToolStripMenuItem.Click += bancoDeDadosToolStripMenuItem_Click;
            // 
            // loginToolStripMenuItem
            // 
            loginToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { loggonToolStripMenuItem, logoffToolStripMenuItem });
            loginToolStripMenuItem.Name = "loginToolStripMenuItem";
            loginToolStripMenuItem.Size = new Size(49, 20);
            loginToolStripMenuItem.Text = "Login";
            // 
            // loggonToolStripMenuItem
            // 
            loggonToolStripMenuItem.Name = "loggonToolStripMenuItem";
            loggonToolStripMenuItem.Size = new Size(109, 22);
            loggonToolStripMenuItem.Text = "Logon";
            loggonToolStripMenuItem.Click += loggonToolStripMenuItem_Click;
            // 
            // logoffToolStripMenuItem
            // 
            logoffToolStripMenuItem.Name = "logoffToolStripMenuItem";
            logoffToolStripMenuItem.Size = new Size(109, 22);
            logoffToolStripMenuItem.Text = "Logoff";
            logoffToolStripMenuItem.Click += logoffToolStripMenuItem_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(510, 327);
            Controls.Add(label1);
            Controls.Add(lb_nomeusuario);
            Controls.Add(lb_usuario);
            Controls.Add(lb_acesso);
            Controls.Add(menuStrip1);
            MainMenuStrip = menuStrip1;
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Academia - Versão v1.0";
            Load += Form1_Load;
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        public Label lb_acesso;
        public Label lb_usuario;
        private Label label1;
        public Label lb_nomeusuario;
        private MenuStrip menuStrip1;
        private ToolStripMenuItem loginToolStripMenuItem;
        private ToolStripMenuItem loggonToolStripMenuItem;
        private ToolStripMenuItem logoffToolStripMenuItem;
        private ToolStripMenuItem manutençãoToolStripMenuItem;
        private ToolStripMenuItem usuáriosToolStripMenuItem;
        private ToolStripMenuItem gestãoDeUsuáriosToolStripMenuItem;
        private ToolStripMenuItem alunosToolStripMenuItem;
        private ToolStripMenuItem novoAlunoToolStripMenuItem;
        private ToolStripMenuItem bancoDeDadosToolStripMenuItem;
        private ToolStripMenuItem novoUsuárioToolStripMenuItem;
    }
}
