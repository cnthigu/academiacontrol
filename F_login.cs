﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Aula_99
{
    public partial class F_login : Form
    {
        Form1 form1;
        DataTable dt = new DataTable();
        public F_login(Form1 f)
        {
            InitializeComponent();
            form1 = f;
        }

        private void F_login_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void tb_senha_TextChanged(object sender, EventArgs e)
        {

        }

        private void tb_username_TextChanged(object sender, EventArgs e)
        {

        }

        private void bt_logar_Click(object sender, EventArgs e)
        {
            string serialHD = Utils.ObterSerialHD();
            string username = tb_username.Text;
            string senha = tb_senha.Text;

            if (username == "" || senha == "")
            {
                MessageBox.Show("Usuário e Senha Invádilos.");
                tb_username.Focus();
                return;
            }
            string sql1 = "SELECT * FROM tb_usuarios WHERE T_USERNAME='" + username + "' AND T_SENHAUSUARIO='" + senha + "'AND SERIAL_DISCO = '" + serialHD + "'";
            string sql = "SELECT * FROM tb_usuarios WHERE T_USERNAME='" + username + "' AND T_SENHAUSUARIO='" + senha + "'";
            dt = Banco.dql(sql);
            if (dt.Rows.Count == 1)
            {
                form1.lb_acesso.Text = dt.Rows[0].ItemArray[5].ToString();
                form1.lb_nomeusuario.Text = dt.Rows[0].Field<string>("T_NOMEUSUARIO");
                Globais.nivel = int.Parse(dt.Rows[0].Field<Int64>("N_NIVELUSUARIO").ToString());
                Globais.logado = true;
                this.Close();
            }
            else
            {
                MessageBox.Show("Usuário não encontrando!");
            }
            if (serialHD == "190638800812")
            {
                MessageBox.Show("Hwid Liberado");

            }
            else
            {
                MessageBox.Show("Você não tem permissão, contate um administrador.");
            }
            ;
        }

        private void tb_cancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }
    }
}
