using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Aula_99
{
    public partial class F_GestaoTurma : Form
    {
        string idSelecionado;
        int modo = 1;

        public F_GestaoTurma()
        {
            InitializeComponent();
        }

        private void F_GestaoTurma_Load(object sender, EventArgs e)
        {
            //ou INNER JOIN
            string vqueryDVG = @"
                SELECT
                    tbt.N_IDTURMA as 'ID',
                    tbt.T_DSCTURMA as 'Turma',
                    tbh.T_DSCHORARIO as 'Horário'

                FROM
                    tb_turmas as tbt
                LEFT JOIN 
                    tb_horarios as tbh on tbh.N_IDHORARIO = tbt.N_IDHORARIO";
            dgv_turmas.DataSource = Banco.dql(vqueryDVG);
            dgv_turmas.Columns[0].Width = 30;
            dgv_turmas.Columns[1].Width = 120;
            dgv_turmas.Columns[2].Width = 120;

            //pouluar combobox professor


            string vqueryProfessores = @"
                SELECT  
                    N_IDPROFESSOR,
                    T_NOMEPROFESSOR
                FROM
                    tb_professores
                ORDER BY
                    N_IDPROFESSOR

             ";
            cb_professor.Items.Clear();
            cb_professor.DataSource = Banco.dql(vqueryProfessores);
            cb_professor.DisplayMember = "T_NOMEPROFESSOR";
            cb_professor.ValueMember = "N_IDPROFESSOR";


            //pouluar combobox status (ativa = a, paralisada = b, cancelada = c)
            Dictionary<string, string> st = new Dictionary<string, string>();
            st.Add("A", "Ativa");
            st.Add("B", "Paralisada");
            st.Add("C", "Cancelada");

            cb_status.DataSource = new BindingSource(st, null);
            cb_status.DisplayMember = "Value";
            cb_status.ValueMember = "Key";

            //pouluar horarios

            string vqueryHorarios = @"
                SELECT  
                   *
                FROM
                    tb_horarios
                ORDER BY
                    T_DSCHORARIO

             ";
            cb_horarios.Items.Clear();
            cb_horarios.DataSource = Banco.dql(vqueryHorarios);
            cb_horarios.DisplayMember = "T_DSCHORARIO";
            cb_horarios.ValueMember = "N_IDHORARIO";
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void dgv_turmas_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private class BindingSourc
        {
            private Dictionary<string, string> st;
            private object value;

            public BindingSourc(Dictionary<string, string> st, object value)
            {
                this.st = st;
                this.value = value;
            }
        }

        private void dgv_turmas_SelectionChanged(object sender, EventArgs e)
        {
            DataGridView dgv = (DataGridView)sender;
            int contlinhas = dgv.SelectedRows.Count;
            if (contlinhas > 0)
            {
                modo = 0;
                idSelecionado = dgv_turmas.SelectedRows[0].Cells[0].Value.ToString();
                string vqueryCampos = @"
                    SELECT
                        T_DSCTURMA,
                        N_IDPROFESSOR,
                        N_IDHORARIO,
                        N_MAXALUNOS,
                        T_STATUS
                    FROM
                        tb_turmas
                    WHERE
                        N_IDTURMA=" + idSelecionado;

                DataTable dt = Banco.dql(vqueryCampos);
                tb_dscturma.Text = dt.Rows[0].Field<string>("T_STATUS");
                cb_professor.SelectedValue = dt.Rows[0].Field<Int64>("N_IDPROFESSOR").ToString();
                cb_maxAlunos.ValueMember = dt.Rows[0].Field<Int64>("N_MAXALUNOS").ToString();
                cb_status.SelectedValue = dt.Rows[0].Field<string>("T_STATUS");
                cb_horarios.SelectedValue = dt.Rows[0].Field<Int64>("N_IDHORARIO").ToString();

            }
        }

        private void tb_dscturma_TextChanged(object sender, EventArgs e)
        {

        }

        private void btn_novaTurma_Click(object sender, EventArgs e)
        {
            tb_dscturma.Clear();
            cb_horarios.SelectedIndex = -1;
            cb_maxAlunos.SelectedIndex = -1;
            cb_professor.SelectedIndex = -1;
            cb_status.SelectedIndex = -1;
            tb_dscturma.Focus();
            modo = 2;
        }

        private void btn_salvarEdicao_Click(object sender, EventArgs e)
        {
            if (modo != 0) {
                string queryTurma = "";
                if (modo == 1)
                {
                    queryTurma = String.Format(@" 
                        UPDATE
                            tb_turmas
                        SET
                            T_DSCTURMA='{0}',
                            N_IDPROFESSOR={1},
                            N_IDHORARIO={2},
                            N_MAXALUNOS={3},
                            T_STATUS='{4}'
                        WHERE
                            N_IDTURMA={5}",
                            tb_dscturma.Text,
                            cb_professor.SelectedValue,
                            cb_horarios.SelectedValue,
                            cb_maxAlunos.SelectedValue,
                            dgv_turmas.SelectedRows[0].Cells["N_IDTURMA"].Value);
                }
                else
                {
                    queryTurma = String.Format(@"
                        INSERT INTO tb_turmas
                        (T_DSCTURMA,N_IDPROFESSOR,N_IDHORARIO,T_STATUS)
                            VALUES({0},{1},{2},{3})", tb_dscturma.Text, cb_professor.SelectedValue,cb_horarios.SelectedValue,cb_maxAlunos,cb_status.SelectedValue);
                }
                int linha = dgv_turmas.SelectedRows[0].Index;
                queryTurma = String.Format(@"
                        UPDATE
                            tb_turmas
                        SET
                            T_DSCTURMA='{0}',
                            N_IDPROFESSOR={1},
                            N_IDHORARIO={2},
                            N_MAXALUNOS={3},
                            T_STATUS='{4}'
                        WHERE
                            N_IDTURMA={5}",
                            tb_dscturma.Text,
                            cb_professor.SelectedValue,
                            cb_horarios.SelectedValue,
                            cb_maxAlunos.SelectedValue,
                            dgv_turmas.SelectedRows[0].Cells[6].Value);

                Banco.dml(queryTurma);
                dgv_turmas[1, linha].Value = tb_dscturma.Text;
                dgv_turmas[2, linha].Value = cb_horarios.Text;
                MessageBox.Show("Dados Salvados!");
            }
        }

        private void btn_excluir_Click(object sender, EventArgs e)
        {
            DialogResult res = MessageBox.Show("Confirmar Exclusão", "Excluir?", MessageBoxButtons.YesNo);
            if (res == DialogResult.Yes)
            {
                string queryExcluirTurma = String.Format(@"
                    DELETE
                    FROM
                        tb_turmas
                    WHERE
                        N_IDTURMA={0}", idSelecionado);
                Banco.dml(queryExcluirTurma);
                dgv_turmas.Rows.Remove(dgv_turmas.CurrentRow);
            }
        }

        private void btn_fechar_Click(object sender, EventArgs e)
        {
            Close();    
        }
    }
}   
