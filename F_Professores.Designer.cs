namespace Aula_99
{
    partial class F_Professores
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
            tb_idprofessor = new TextBox();
            tb_nomeprofessor = new TextBox();
            label1 = new Label();
            label2 = new Label();
            mtb_telefone = new MaskedTextBox();
            label3 = new Label();
            dgv_professores = new DataGridView();
            btn_novo = new Button();
            btn_salvar = new Button();
            btn_excluir = new Button();
            btn_fechar = new Button();
            ((System.ComponentModel.ISupportInitialize)dgv_professores).BeginInit();
            SuspendLayout();
            // 
            // tb_idprofessor
            // 
            tb_idprofessor.Location = new Point(12, 28);
            tb_idprofessor.Name = "tb_idprofessor";
            tb_idprofessor.ReadOnly = true;
            tb_idprofessor.Size = new Size(100, 23);
            tb_idprofessor.TabIndex = 0;
            tb_idprofessor.TabStop = false;
            tb_idprofessor.TextChanged += tb_idprofessor_TextChanged;
            // 
            // tb_nomeprofessor
            // 
            tb_nomeprofessor.Location = new Point(115, 28);
            tb_nomeprofessor.Name = "tb_nomeprofessor";
            tb_nomeprofessor.Size = new Size(262, 23);
            tb_nomeprofessor.TabIndex = 1;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(12, 9);
            label1.Name = "label1";
            label1.Size = new Size(18, 15);
            label1.TabIndex = 2;
            label1.Text = "ID";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(118, 9);
            label2.Name = "label2";
            label2.Size = new Size(67, 15);
            label2.TabIndex = 3;
            label2.Text = "Professores";
            // 
            // mtb_telefone
            // 
            mtb_telefone.Location = new Point(383, 28);
            mtb_telefone.Mask = "(999) 000-0000";
            mtb_telefone.Name = "mtb_telefone";
            mtb_telefone.Size = new Size(138, 23);
            mtb_telefone.TabIndex = 4;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(386, 9);
            label3.Name = "label3";
            label3.Size = new Size(51, 15);
            label3.TabIndex = 5;
            label3.Text = "Telefone";
            // 
            // dgv_professores
            // 
            dgv_professores.AllowUserToAddRows = false;
            dgv_professores.AllowUserToDeleteRows = false;
            dgv_professores.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgv_professores.EnableHeadersVisualStyles = false;
            dgv_professores.Location = new Point(12, 57);
            dgv_professores.MultiSelect = false;
            dgv_professores.Name = "dgv_professores";
            dgv_professores.ReadOnly = true;
            dgv_professores.RowHeadersVisible = false;
            dgv_professores.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgv_professores.Size = new Size(509, 238);
            dgv_professores.TabIndex = 6;
            dgv_professores.CellContentClick += dgv_professores_CellContentClick;
            dgv_professores.SelectionChanged += dgv_professores_SelectionChanged;
            // 
            // btn_novo
            // 
            btn_novo.Location = new Point(12, 301);
            btn_novo.Name = "btn_novo";
            btn_novo.Size = new Size(100, 23);
            btn_novo.TabIndex = 7;
            btn_novo.Text = "Novo Professor";
            btn_novo.UseVisualStyleBackColor = true;
            btn_novo.Click += btn_novo_Click;
            // 
            // btn_salvar
            // 
            btn_salvar.Location = new Point(118, 301);
            btn_salvar.Name = "btn_salvar";
            btn_salvar.Size = new Size(100, 23);
            btn_salvar.TabIndex = 8;
            btn_salvar.Text = "Salvar";
            btn_salvar.UseVisualStyleBackColor = true;
            btn_salvar.Click += btn_salvar_Click;
            // 
            // btn_excluir
            // 
            btn_excluir.Location = new Point(224, 301);
            btn_excluir.Name = "btn_excluir";
            btn_excluir.Size = new Size(100, 23);
            btn_excluir.TabIndex = 9;
            btn_excluir.Text = "Excluir";
            btn_excluir.UseVisualStyleBackColor = true;
            btn_excluir.Click += btn_excluir_Click;
            // 
            // btn_fechar
            // 
            btn_fechar.Location = new Point(465, 301);
            btn_fechar.Name = "btn_fechar";
            btn_fechar.Size = new Size(56, 23);
            btn_fechar.TabIndex = 10;
            btn_fechar.Text = "fechar";
            btn_fechar.UseVisualStyleBackColor = true;
            btn_fechar.Click += btn_fechar_Click;
            // 
            // F_Professores
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(533, 340);
            Controls.Add(btn_fechar);
            Controls.Add(btn_excluir);
            Controls.Add(btn_salvar);
            Controls.Add(btn_novo);
            Controls.Add(dgv_professores);
            Controls.Add(label3);
            Controls.Add(mtb_telefone);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(tb_nomeprofessor);
            Controls.Add(tb_idprofessor);
            Name = "F_Professores";
            Text = "F_Professores";
            Load += F_Professores_Load;
            ((System.ComponentModel.ISupportInitialize)dgv_professores).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox tb_idprofessor;
        private TextBox tb_nomeprofessor;
        private Label label1;
        private Label label2;
        private MaskedTextBox mtb_telefone;
        private Label label3;
        private DataGridView dgv_professores;
        private Button btn_novo;
        private Button btn_salvar;
        private Button btn_excluir;
        private Button btn_fechar;
    }
}