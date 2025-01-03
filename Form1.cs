namespace Aula_99
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            F_login f_login = new F_login(this);
            f_login.ShowDialog();

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void lb_usuario_Click(object sender, EventArgs e)
        {

        }

        public void lb_nomeusuario_Click(object sender, EventArgs e)
        {

        }

        private void loggonToolStripMenuItem_Click(object sender, EventArgs e)
        {
            F_login f_Login = new F_login(this);
            f_Login.ShowDialog();
        }

        private void logoffToolStripMenuItem_Click(object sender, EventArgs e)
        {
            lb_acesso.Text = "0";
            lb_nomeusuario.Text = "...";
            Globais.nivel = 0;
            Globais.logado = false;
        }

        private void usuáriosToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void alunosToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void bancoDeDadosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (Globais.logado)
            {
                if (Globais.nivel >= 3)
                {

                }
                else
                {
                    MessageBox.Show("Nível de acesso não permitido!");
                }
            }
            else
            {
                MessageBox.Show("É Necessário estar logado!");
            }
        }

        private void novoUsuárioToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (Globais.logado)
            {
                if (Globais.nivel >= 2)
                {
                    F_NovoUsuario f_NovoUsuario = new F_NovoUsuario();
                    f_NovoUsuario.ShowDialog();
                }
                else
                {
                    MessageBox.Show("Nível de acesso não permitido!");
                }
            }
            else
            {
                MessageBox.Show("É Necessário estar logado!");
            }
        }

        private void gestãoDeUsuáriosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (Globais.logado)
            {
                if (Globais.nivel >= 2)
                {
                    F_GestaoUsuarios f_GestaoUsuarios = new F_GestaoUsuarios();
                    f_GestaoUsuarios.ShowDialog();
                }
                else
                {
                    MessageBox.Show("Nível de acesso não permitido!");
                }
            }
            else
            {
                MessageBox.Show("É Necessário estar logado!");
            }
        }

        private void novoAlunoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (Globais.logado)
            {
                //
            }
            else
            {
                MessageBox.Show("É Necessário estar logado!");
            }
        }
    }
}
