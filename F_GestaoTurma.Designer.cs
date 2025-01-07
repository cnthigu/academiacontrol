namespace Aula_99
{
    partial class F_GestaoTurma
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
            dgv_turmas = new DataGridView();
            btn_novaTurma = new Button();
            btn_salvarEdicao = new Button();
            btn_excluir = new Button();
            btn_imprimir = new Button();
            btn_fechar = new Button();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            cb_professor = new ComboBox();
            cb_horarios = new ComboBox();
            cb_maxAlunos = new ComboBox();
            cb_status = new ComboBox();
            label5 = new Label();
            tb_dscturma = new TextBox();
            ((System.ComponentModel.ISupportInitialize)dgv_turmas).BeginInit();
            SuspendLayout();
            // 
            // dgv_turmas
            // 
            dgv_turmas.AllowUserToAddRows = false;
            dgv_turmas.AllowUserToDeleteRows = false;
            dgv_turmas.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgv_turmas.EnableHeadersVisualStyles = false;
            dgv_turmas.Location = new Point(12, 12);
            dgv_turmas.MultiSelect = false;
            dgv_turmas.Name = "dgv_turmas";
            dgv_turmas.ReadOnly = true;
            dgv_turmas.RowHeadersVisible = false;
            dgv_turmas.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgv_turmas.Size = new Size(381, 413);
            dgv_turmas.TabIndex = 7;
            dgv_turmas.CellContentClick += dgv_turmas_CellContentClick;
            dgv_turmas.SelectionChanged += dgv_turmas_SelectionChanged;
            // 
            // btn_novaTurma
            // 
            btn_novaTurma.Location = new Point(12, 431);
            btn_novaTurma.Name = "btn_novaTurma";
            btn_novaTurma.Size = new Size(104, 23);
            btn_novaTurma.TabIndex = 8;
            btn_novaTurma.Text = "Nova Turma";
            btn_novaTurma.UseVisualStyleBackColor = true;
            btn_novaTurma.Click += btn_novaTurma_Click;
            // 
            // btn_salvarEdicao
            // 
            btn_salvarEdicao.Location = new Point(122, 431);
            btn_salvarEdicao.Name = "btn_salvarEdicao";
            btn_salvarEdicao.Size = new Size(104, 23);
            btn_salvarEdicao.TabIndex = 9;
            btn_salvarEdicao.Text = "Salvar Edição";
            btn_salvarEdicao.UseVisualStyleBackColor = true;
            btn_salvarEdicao.Click += btn_salvarEdicao_Click;
            // 
            // btn_excluir
            // 
            btn_excluir.Location = new Point(232, 431);
            btn_excluir.Name = "btn_excluir";
            btn_excluir.Size = new Size(104, 23);
            btn_excluir.TabIndex = 10;
            btn_excluir.Text = "Excluir";
            btn_excluir.UseVisualStyleBackColor = true;
            btn_excluir.Click += btn_excluir_Click;
            // 
            // btn_imprimir
            // 
            btn_imprimir.Location = new Point(342, 431);
            btn_imprimir.Name = "btn_imprimir";
            btn_imprimir.Size = new Size(104, 23);
            btn_imprimir.TabIndex = 11;
            btn_imprimir.Text = "Imprimir Turma";
            btn_imprimir.UseVisualStyleBackColor = true;
            btn_imprimir.Click += btn_imprimir_Click;
            // 
            // btn_fechar
            // 
            btn_fechar.Location = new Point(636, 431);
            btn_fechar.Name = "btn_fechar";
            btn_fechar.Size = new Size(54, 23);
            btn_fechar.TabIndex = 12;
            btn_fechar.Text = "Fechar";
            btn_fechar.UseVisualStyleBackColor = true;
            btn_fechar.Click += btn_fechar_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(399, 67);
            label1.Name = "label1";
            label1.Size = new Size(56, 15);
            label1.TabIndex = 17;
            label1.Text = "Professor";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(399, 121);
            label2.Name = "label2";
            label2.Size = new Size(73, 15);
            label2.TabIndex = 18;
            label2.Text = "Max. Alunos";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(544, 121);
            label3.Name = "label3";
            label3.Size = new Size(39, 15);
            label3.TabIndex = 19;
            label3.Text = "Status";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(399, 178);
            label4.Name = "label4";
            label4.Size = new Size(52, 15);
            label4.TabIndex = 20;
            label4.Text = "Horários";
            // 
            // cb_professor
            // 
            cb_professor.FormattingEnabled = true;
            cb_professor.Location = new Point(399, 85);
            cb_professor.Name = "cb_professor";
            cb_professor.Size = new Size(291, 23);
            cb_professor.TabIndex = 21;
            // 
            // cb_horarios
            // 
            cb_horarios.FormattingEnabled = true;
            cb_horarios.Location = new Point(399, 196);
            cb_horarios.Name = "cb_horarios";
            cb_horarios.Size = new Size(291, 23);
            cb_horarios.TabIndex = 22;
            // 
            // cb_maxAlunos
            // 
            cb_maxAlunos.FormattingEnabled = true;
            cb_maxAlunos.Location = new Point(399, 139);
            cb_maxAlunos.Name = "cb_maxAlunos";
            cb_maxAlunos.Size = new Size(140, 23);
            cb_maxAlunos.TabIndex = 23;
            // 
            // cb_status
            // 
            cb_status.FormattingEnabled = true;
            cb_status.Location = new Point(545, 139);
            cb_status.Name = "cb_status";
            cb_status.Size = new Size(145, 23);
            cb_status.TabIndex = 24;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(399, 22);
            label5.Name = "label5";
            label5.Size = new Size(77, 15);
            label5.TabIndex = 25;
            label5.Text = "Nome Turma";
            // 
            // tb_dscturma
            // 
            tb_dscturma.Location = new Point(399, 41);
            tb_dscturma.Name = "tb_dscturma";
            tb_dscturma.Size = new Size(291, 23);
            tb_dscturma.TabIndex = 26;
            tb_dscturma.TextChanged += tb_dscturma_TextChanged;
            // 
            // F_GestaoTurma
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(695, 458);
            Controls.Add(tb_dscturma);
            Controls.Add(label5);
            Controls.Add(cb_status);
            Controls.Add(cb_maxAlunos);
            Controls.Add(cb_horarios);
            Controls.Add(cb_professor);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(btn_fechar);
            Controls.Add(btn_imprimir);
            Controls.Add(btn_excluir);
            Controls.Add(btn_salvarEdicao);
            Controls.Add(btn_novaTurma);
            Controls.Add(dgv_turmas);
            Name = "F_GestaoTurma";
            Text = "F_GestaoTurma";
            Load += F_GestaoTurma_Load;
            ((System.ComponentModel.ISupportInitialize)dgv_turmas).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dgv_turmas;
        private Button btn_novaTurma;
        private Button btn_salvarEdicao;
        private Button btn_excluir;
        private Button btn_imprimir;
        private Button btn_fechar;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private ComboBox cb_professor;
        private ComboBox cb_horarios;
        private ComboBox cb_maxAlunos;
        private ComboBox cb_status;
        private Label label5;
        private TextBox tb_dscturma;
    }
}