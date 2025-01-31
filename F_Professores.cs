﻿using System;
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
    public partial class F_Professores : Form
    {
        public F_Professores()
        {
            InitializeComponent();
        }

        private void tb_idprofessor_TextChanged(object sender, EventArgs e)
        {

        }

        private void F_Professores_Load(object sender, EventArgs e)
        {
            string vquery = @" 
                    SELECT
                N_IDPROFESSOR as 'ID',
                T_NOMEPROFESSOR as 'Nome do Professor',
                T_TELEFONE as 'Telefone'
                    FROM
                tb_professores";
            dgv_professores.DataSource = Banco.dql(vquery);
            dgv_professores.Columns[0].Width = 60;
            dgv_professores.Columns[0].Width = 150;
        }

        private void btn_novo_Click(object sender, EventArgs e)
        {
            tb_idprofessor.Clear();
            tb_nomeprofessor.Clear();
            mtb_telefone.Clear();
            tb_nomeprofessor.Focus();
        }

        private void btn_salvar_Click(object sender, EventArgs e)
        {
            string vquery;

            if (tb_idprofessor.Text == "")
            {
                vquery = "INSERT INTO tb_professores (T_NOMEPROFESSOR, T_TELEFONE) VALUES('" + tb_nomeprofessor.Text + "', '" + mtb_telefone.Text + "')";
            }
            else
            {
                vquery = "UPDATE tb_professores SET T_NOMEPROFESSOR='" + tb_nomeprofessor.Text + "', T_TELEFONE='" + mtb_telefone.Text + "' WHERE N_IDPROFESSOR=" + tb_idprofessor.Text;
            }
            Banco.dml(vquery);
            vquery = @" 
            SELECT
                N_IDPROFESSOR as 'ID',
                T_NOMEPROFESSOR as 'Nome do Professor',
                T_TELEFONE as 'Telefone'
            FROM
                tb_professores";
            dgv_professores.DataSource = Banco.dql(vquery);
        }

        private void btn_excluir_Click(object sender, EventArgs e)
        {
            DialogResult res = MessageBox.Show("Confirma Exclusão?", "Excluir?", MessageBoxButtons.YesNo);
            if (res == DialogResult.Yes)
            {
                string vquery = "DELETE FROM tb_professores WHERE N_IDPROFESSOR=" + tb_idprofessor.Text;
                Banco.dml(vquery);
                dgv_professores.Rows.Remove(dgv_professores.CurrentRow);
            }
        }

        private void btn_fechar_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void dgv_professores_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dgv_professores_SelectionChanged(object sender, EventArgs e)
        {
            DataGridView dgv = (DataGridView)sender;
            int contlinhas = dgv.SelectedRows.Count;
            if (contlinhas > 0)
            {
                DataTable dt = new DataTable();
                string vid = dgv.SelectedRows[0].Cells[0].Value.ToString();
                string vquery = @"
                    SELECT
                        *
                    FROM
                    tb_professores 
                    WHERE
                    N_IDPROFESSOR=" + vid;
                dt = Banco.dql(vquery);
                tb_idprofessor.Text = dt.Rows[0].Field<Int64>("N_IDPROFESSOR").ToString();
                tb_nomeprofessor.Text = dt.Rows[0].Field<string>("T_NOMEPROFESSOR");
                mtb_telefone.Text = dt.Rows[0].Field<string>("T_TELEFONE");
            }
        }
    }
}
