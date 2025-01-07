namespace Aula_99
{
    partial class F_Horarios
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
            tb_idHorario = new TextBox();
            dgv_horarios = new DataGridView();
            btn_novo = new Button();
            btn_salvar = new Button();
            btn_excluir = new Button();
            btn_fechar = new Button();
            label1 = new Label();
            label2 = new Label();
            mtb_dscHorario = new MaskedTextBox();
            ((System.ComponentModel.ISupportInitialize)dgv_horarios).BeginInit();
            SuspendLayout();
            // 
            // tb_idHorario
            // 
            tb_idHorario.Location = new Point(120, 27);
            tb_idHorario.Name = "tb_idHorario";
            tb_idHorario.ReadOnly = true;
            tb_idHorario.Size = new Size(50, 23);
            tb_idHorario.TabIndex = 0;
            tb_idHorario.TabStop = false;
            tb_idHorario.TextChanged += tb_idHorario_TextChanged;
            // 
            // dgv_horarios
            // 
            dgv_horarios.AllowUserToAddRows = false;
            dgv_horarios.AllowUserToDeleteRows = false;
            dgv_horarios.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgv_horarios.Location = new Point(26, 58);
            dgv_horarios.MultiSelect = false;
            dgv_horarios.Name = "dgv_horarios";
            dgv_horarios.ReadOnly = true;
            dgv_horarios.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgv_horarios.Size = new Size(462, 359);
            dgv_horarios.TabIndex = 2;
            dgv_horarios.CellContentClick += dgv_horarios_CellContentClick;
            dgv_horarios.SelectionChanged += dgv_horarios_SelectionChanged;
            // 
            // btn_novo
            // 
            btn_novo.Location = new Point(26, 423);
            btn_novo.Name = "btn_novo";
            btn_novo.Size = new Size(113, 23);
            btn_novo.TabIndex = 3;
            btn_novo.Text = " Novo Horario";
            btn_novo.UseVisualStyleBackColor = true;
            btn_novo.Click += btn_novo_Click;
            // 
            // btn_salvar
            // 
            btn_salvar.Location = new Point(145, 423);
            btn_salvar.Name = "btn_salvar";
            btn_salvar.Size = new Size(113, 23);
            btn_salvar.TabIndex = 4;
            btn_salvar.Text = "Salvar Horario";
            btn_salvar.UseVisualStyleBackColor = true;
            btn_salvar.Click += btn_salvar_Click;
            // 
            // btn_excluir
            // 
            btn_excluir.Location = new Point(264, 423);
            btn_excluir.Name = "btn_excluir";
            btn_excluir.Size = new Size(113, 23);
            btn_excluir.TabIndex = 5;
            btn_excluir.Text = "Excluir Horario";
            btn_excluir.UseVisualStyleBackColor = true;
            btn_excluir.Click += btn_excluir_Click;
            // 
            // btn_fechar
            // 
            btn_fechar.Location = new Point(383, 423);
            btn_fechar.Name = "btn_fechar";
            btn_fechar.Size = new Size(105, 23);
            btn_fechar.TabIndex = 6;
            btn_fechar.Text = "Fechar";
            btn_fechar.UseVisualStyleBackColor = true;
            btn_fechar.Click += btn_fechar_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(87, 30);
            label1.Name = "label1";
            label1.Size = new Size(18, 15);
            label1.TabIndex = 7;
            label1.Text = "ID";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(272, 30);
            label2.Name = "label2";
            label2.Size = new Size(52, 15);
            label2.TabIndex = 8;
            label2.Text = "Horários";
            // 
            // mtb_dscHorario
            // 
            mtb_dscHorario.Location = new Point(330, 30);
            mtb_dscHorario.Mask = "99:99\\até99:99";
            mtb_dscHorario.Name = "mtb_dscHorario";
            mtb_dscHorario.Size = new Size(116, 23);
            mtb_dscHorario.TabIndex = 9;
            mtb_dscHorario.MaskInputRejected += maskedTextBox1_MaskInputRejected;
            // 
            // F_Horarios
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(510, 460);
            Controls.Add(mtb_dscHorario);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(btn_fechar);
            Controls.Add(btn_excluir);
            Controls.Add(btn_salvar);
            Controls.Add(btn_novo);
            Controls.Add(dgv_horarios);
            Controls.Add(tb_idHorario);
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "F_Horarios";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "F_Horarios";
            Load += F_Horarios_Load;
            ((System.ComponentModel.ISupportInitialize)dgv_horarios).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox tb_idHorario;
        private DataGridView dgv_horarios;
        private Button btn_novo;
        private Button btn_salvar;
        private Button btn_excluir;
        private Button btn_fechar;
        private Label label1;
        private Label label2;
        private MaskedTextBox mtb_dscHorario;
    }
}