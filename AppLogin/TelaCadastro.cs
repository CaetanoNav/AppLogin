using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.Data.SqlClient;
using Microsoft.SqlServer;

namespace AppLogin
{
    public partial class TelaCadastro : Form
    {
        //Variaveis
        bool senhaCensurada = true;
        bool confirmSenhaCens = true;
        bool verificaSenha = false;
        bool verificaConfirmaSenha = false;
        bool verificaEmail = false;
        bool verificaNome = false;
        bool verificaSobrenome = false;
        bool verificaTelefone = false;
        bool verificaCPF = false;
        public TelaCadastro()
        {
            InitializeComponent();
            botCadastrar.Enabled = false;
        }
        //Voltando para a página de login
        private void linkVoltar_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.Close();
        }

        //Validação da Caixa de email
        private void txtEmaiCadastro_Validated(object sender, EventArgs e)
        {
            bool verificaArroba = false;
            bool verificaPontoCom = false;
            string email = txtEmaiCadastro.Text;
            char[] arrayEmail = email.ToCharArray();

            for (int i = 0; i < arrayEmail.Length; i++)
            {
                if (arrayEmail[i] == '@')
                    verificaArroba = true;
            }

            if (email.Length >= 4 && email.Substring(email.Length - 4, 4) == ".com")
                verificaPontoCom = true;

            if (verificaPontoCom == false || verificaArroba == false)
            {
                txtEmaiCadastro.BackColor = Color.FromArgb(255, 200, 200);
                verificaEmail = false;
            }
            else
            {
                txtEmaiCadastro.BackColor = Color.White;
                verificaEmail = true;
            }
            AtualizarStatusCadastro();
        }

        //Caixa Senha
        private void txtSenhaCastro_TextChanged(object sender, EventArgs e)
        {
            short contadorCharMaius = 0;
            short contadorCharEsp = 0;
            short contadorNum = 0;
            short contadorCharMinus = 0;

            //Lendo a caixa de texto
            string senha = txtSenhaCastro.Text;
            //Transformando em uma lista
            char[] letras = senha.ToCharArray();
            // Percorrer a lista
            for (int i = 0; i < letras.Length; i++)
            {
                char letra = letras[i];

                switch (letra)
                {
                    case char c when char.IsUpper(c): contadorCharMaius += 1; break;
                    case char c when char.IsLower(c): contadorCharMinus += 1; break;
                    case char c when char.IsDigit(c): contadorNum += 1; break;
                    default: contadorCharEsp += 1; break;
                }
            }

            //Alterando cor do campo
            if (senha.Length >= 8 && senha.Length < 12 && contadorCharEsp > 0 && contadorCharMaius > 0 && contadorNum > 0 && contadorCharMinus > 0)
            {
                txtSenhaCastro.BackColor = Color.FromArgb(255, 255, 200);
                verificaSenha = true;
            }

            else if (senha.Length >= 12 && contadorCharEsp > 0 && contadorCharMaius > 0 && contadorNum > 0 && contadorCharMinus > 0)
            {
                txtSenhaCastro.BackColor = Color.FromArgb(200, 255, 200);
                verificaSenha = true;
            }
            else
            {
                txtSenhaCastro.BackColor = Color.FromArgb(255, 200, 200);
                verificaSenha = false;
            }
            AtualizarStatusCadastro();
        }

        //Caixa Confirma Senha
        private void txtConfirmaSenha_TextChanged(object sender, EventArgs e)
        {
            if (txtConfirmaSenha.Text.Equals(txtSenhaCastro.Text))
            {
                verificaConfirmaSenha = true;
                txtConfirmaSenha.BackColor = Color.White;
            }
            else
            {
                txtConfirmaSenha.BackColor = Color.FromArgb(255, 200, 200);
                verificaConfirmaSenha = false;
            }
            AtualizarStatusCadastro();
        }

        //Botão Gerar Senha
        private void botGerarSenha_Click(object sender, EventArgs e)
        {
            short contMaiusc = 0;
            short contMinusc = 0;
            short contDigit = 0;
            short contEspc = 0;
            const string CARACTERESPERMITIDOS = "ABCDEFGHIJKLMNOPQRSTUVWXYZabcdefghijklmnopqrstuvwxyz0123456789+=-!@#$%^&*()-+=[]{}|;:',.<>?/";
            char[] arraySenha = new char[12];
            Random random = new Random();

            do
            {
                contMaiusc = 0;
                contMinusc = 0;
                contDigit = 0;
                contEspc = 0;
                for (int i = 0; i < 12; i++)
                {
                    arraySenha[i] = CARACTERESPERMITIDOS[random.Next(CARACTERESPERMITIDOS.Length)];

                    switch (arraySenha[i])
                    {
                        case char c when char.IsUpper(c): contMaiusc += 1; break;
                        case char c when char.IsLower(c): contMinusc += 1; break;
                        case char c when char.IsDigit(c): contDigit += 1; break;
                        default: contEspc += 1; break;
                    }
                }
            } while (contMaiusc < 1 || contMinusc < 1 || contDigit < 1 || contEspc < 1);
            string senhaGerada = new string(arraySenha);
            txtSenhaCastro.Text = senhaGerada;
            verificaSenha = true;
        }

        //Botão Censura
        private void botSenhaCensura_Click(object sender, EventArgs e)
        {
            senhaCensurada = !senhaCensurada;

            if (senhaCensurada == false)
            {
                txtSenhaCastro.UseSystemPasswordChar = false;
                botSenhaCensura.Text = "Ocultar";
            }
            else
            {
                txtSenhaCastro.UseSystemPasswordChar = true;
                botSenhaCensura.Text = "Mostrar";
            }
        }

        //Botão Censurada Confirma Senha
        private void botConfSenhaCensura_Click(object sender, EventArgs e)
        {
            confirmSenhaCens = !confirmSenhaCens;

            if (confirmSenhaCens == false)
            {
                txtConfirmaSenha.UseSystemPasswordChar = false;
                botConfSenhaCensura.Text = "Ocultar";
            }
            else
            {
                txtConfirmaSenha.UseSystemPasswordChar = true;
                botConfSenhaCensura.Text = "Mostrar";
            }
        }

        //Atualização do status do cadastro
        private void AtualizarStatusCadastro()
        {
            if (verificaEmail && verificaSenha && verificaConfirmaSenha) //&& verificaSobrenome && verificaTelefone && verificaCPF && verificaNome
            {
                botCadastrar.Enabled = true;
            }
            else
            {
                botCadastrar.Enabled = false;
            }
        }

        //Botão Cadastrar + Conexão com o Banco
        private void botCadastrar_Click(object sender, EventArgs e)
        {
            //Variaveis
            string email = txtEmaiCadastro.Text;
            string senha = txtSenhaCastro.Text;
            string telefone = txtTelefone.Text;
            string cpf = txtCPF.Text;
            string nome = txtNome.Text;
            string stringConexao = "Data Source=CAETANO;Initial Catalog=AppLogin;Integrated Security=True;Encrypt=False";

            //Criando Conexao - Utilizando o Using para não precisar lembrar de fechar a conexao, um modo seguro
            using (SqlConnection conexao = new SqlConnection(stringConexao))
            {
                conexao.Open();

                //Select para verificação, utilizando para metros ao inves de concatenação
                string sqlComando = "SELECT COUNT(*) FROM Cadastros WHERE email = @email OR telefone = @telefone OR cpf = @cpf";

                SqlCommand comando = new SqlCommand(sqlComando, conexao);
                //Declarando os parametros, AddWithValue = atribui o valor
                comando.Parameters.AddWithValue("@email", email);
                comando.Parameters.AddWithValue("@telefone", telefone);
                comando.Parameters.AddWithValue("@cpf", cpf);
                
                //O comando ExecuteScalar(), retorna apenas a primeira célula, ele retorna 0 pra nd ou 1 caso tenha acha
                object resultado = comando.ExecuteScalar();
                int jaEmUso = 0;

                if (resultado != null)
                {
                    jaEmUso = Convert.ToInt32(resultado);
                }

                if (jaEmUso > 0)
                {
                    MessageBox.Show("Já existe um cadastro com esses dados", "Erro ao cadastrar", MessageBoxButtons.OK);
                    return;
                }
                else
                {
                    string insertSql = @"INSERT INTO Cadastros (nome, email, telefone, cpf, senha) VALUES (@nome, @email, @telefone, @cpf, @senha)";

                    SqlCommand insertcomando = new SqlCommand(insertSql, conexao);
                    insertcomando.Parameters.AddWithValue("@nome", nome);
                    insertcomando.Parameters.AddWithValue("@email", email);
                    insertcomando.Parameters.AddWithValue("@telefone", telefone);
                    insertcomando.Parameters.AddWithValue("@cpf", cpf);
                    insertcomando.Parameters.AddWithValue("@senha", senha);

                    int linhasCriadas = (int)insertcomando.ExecuteNonQuery();
                    if (linhasCriadas > 0)
                    {
                        MessageBox.Show("Cadastro realizado com sucesso!", "Novo Cadastro");
                        this.Close(); // Fecha a tela de cadastro, se quiser
                    }
                    else
                    {
                        MessageBox.Show("Erro ao cadastrar. Tente novamente.");
                    }
                }
            }
        }
    }
}
