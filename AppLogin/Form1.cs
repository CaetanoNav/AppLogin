
using AppLogin.Data;
using Microsoft.Data.SqlClient;
using Microsoft.IdentityModel.Protocols;
using System.Configuration;

namespace AppLogin
{
    public partial class TelaLogin : Form
    {
        public TelaLogin()
        {
            InitializeComponent();
        }

        //Acesasndo a tela de cadastro
        private void botCriarConta_Click(object sender, EventArgs e)
        {
            this.Hide();
            using (var telaCadastro = new TelaCadastro())
            {
                telaCadastro.ShowDialog();
            }
            this.Show();
        }
        //Botão Entrar
        private void botEntrar_Click(object sender, EventArgs e)
        {
            string id = txtEmailLogin.Text;
            string senha = txtSenhaLogin.Text;

            CRUD login = new CRUD();

            TratamentoId idTratamento = new TratamentoId();
            string idTratada = idTratamento.Tratamento(id);

            bool usuarioExistente = login.ProcuraUsuario(idTratada);
            bool senhaCorreta = login.Logar(idTratada, senha);

            if (usuarioExistente)
            {
                if (senhaCorreta)
                {
                    MessageBox.Show("Registro efetuado com sucesso", "Sucesso no login", MessageBoxButtons.OK);
                }
                else
                {
                    MessageBox.Show("Por favor verifique sua senha","Senha incorreta",MessageBoxButtons.OK);
                }
            }
            else
            {
                MessageBox.Show("Id invalido ou inexistente", "Falha no login",MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }
    }
}
