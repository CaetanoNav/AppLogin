
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
            string email = txtEmailLogin.Text; 
            string senha = txtSenhaLogin.Text;

            string stringconexao = ConfigurationManager.ConnectionStrings["Minhaconexao"].ConnectionString;

            //Criando Conexao
            using (SqlConnection conexao = new SqlConnection(stringconexao))
            {
                conexao.Open();

                string comandoSelect = "SELECT COUNT(*) FROM Cadastros WHERE email = @email and senha = @senha";
                SqlCommand comando = new SqlCommand(comandoSelect, conexao);
                //Parametros
                comando.Parameters.AddWithValue("@email", email);
                comando.Parameters.AddWithValue("@senha", senha);

                object resultado = comando.ExecuteScalar();
                int compara = 0;

                if (resultado != null)
                    compara = Convert.ToInt32(resultado);
                if (compara > 0)
                {
                    MessageBox.Show("Registro efetuado com sucesso", "Sucesso em login", MessageBoxButtons.OK);
                    return;
                }
                else
                {
                    MessageBox.Show("Nenhum registro foi encontrado, e-mail ou senha incorretos", "Falha de login", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }


            }
        }
    }
}
