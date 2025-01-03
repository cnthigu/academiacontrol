using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SQLite;
using System.Drawing;

namespace Aula_99
{
    internal class Banco
    {
        private static SQLiteConnection conexao;

        private static SQLiteConnection ConexaoBanco()
        {
            conexao = new SQLiteConnection("Data Source=C:\\Users\\higu\\source\\repos\\Aula 99\\banco\\banco_academia.db");
            conexao.Open();
            return conexao;
        }
        public static DataTable ObterTodosUsuarios()
        {
            SQLiteDataAdapter da = null;
            DataTable dt = new DataTable();
            try
            {
                var vcon = ConexaoBanco();
                var cmd = vcon.CreateCommand();
                cmd.CommandText = "SELECT * FROM tb_usuarios";
                da = new SQLiteDataAdapter(cmd.CommandText, vcon);
                da.Fill(dt);
                vcon.Close();
                return dt;
                
            }
            catch (Exception ex)
            {
                throw ex;
            }

        }

        public static DataTable consulta(string sql)
        {
            SQLiteDataAdapter da = null;
            DataTable dt = new DataTable();
            try
            {
                var vcon = ConexaoBanco();
                var cmd = vcon.CreateCommand();
                cmd.CommandText = sql;
                da = new SQLiteDataAdapter(cmd.CommandText, vcon);
                da.Fill(dt);
                vcon.Close();
                return dt;

            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        //// Funções do Form GestãodeUusuario

        public static DataTable ObterUsuariosIdNome()
        {
            SQLiteDataAdapter da = null;
            DataTable dt = new DataTable(); 
            try
            {
                var vcon = ConexaoBanco();
                var cmd = vcon.CreateCommand();
                cmd.CommandText = "SELECT N_IDUSUARIO as 'ID Usuário', T_NOMEUSUARIO as 'Nome Usuário' FROM tb_usuarios";
                da = new SQLiteDataAdapter(cmd.CommandText, vcon);
                da.Fill(dt);
                vcon.Close();
                return dt;

            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public static DataTable ObterDadosUsuario(string id)
        {
            SQLiteDataAdapter da = null;
            DataTable dt = new DataTable();
            try
            {
                var vcon = ConexaoBanco();
                var cmd = vcon.CreateCommand();
                cmd.CommandText = "SELECT * FROM tb_usuarios WHERE N_IDUSUARIO="+id;
                da = new SQLiteDataAdapter(cmd.CommandText, vcon);
                da.Fill(dt);
                vcon.Close();
                return dt;

            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public static void NovoUsuario(Usuario u)
        {
            if (existeusername(u))
            {
                MessageBox.Show("Username já existe!");
                return;
            }
            try
            {   var vcon = ConexaoBanco();
                using (var cmd = vcon.CreateCommand())
                {
                    cmd.CommandText = "INSERT INTO tb_usuarios (T_NOMEUSUARIO, T_USERNAME, T_SENHAUSUARIO, T_STATUSUSUARIO, N_NIVELUSUARIO) VALUES (@nome, @username, @senha, @status, @nivel)";
                    cmd.Parameters.AddWithValue("@nome", u.nome);
                    cmd.Parameters.AddWithValue("@username", u.username);
                    cmd.Parameters.AddWithValue("@senha", u.senha);
                    cmd.Parameters.AddWithValue("@status", u.status);
                    cmd.Parameters.AddWithValue("@nivel", u.nivel);

                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Usuário inserido com sucesso!");
                    vcon.Close();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao inserir usuário");
            }
        }

        /// 

        public static bool existeusername(Usuario u)
        {
            bool res = false;
            DataTable dt = new DataTable();
            try
            {
                var vcon = ConexaoBanco();
                var cmd = vcon.CreateCommand();
                {
                    cmd.CommandText = "SELECT 1 FROM tb_usuarios WHERE T_USERNAME = @username";
                    cmd.Parameters.AddWithValue("@username", u.username);
                    using (SQLiteDataAdapter da = new SQLiteDataAdapter(cmd))
                    {
                        da.Fill(dt);
                    }
                }
                res = dt.Rows.Count > 0;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao verificar username");
            }
            return res;
        }
    }

}
