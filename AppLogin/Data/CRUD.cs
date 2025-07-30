using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppLogin.Data
{
    internal class CRUD
    {
        private readonly string stringConexao;
        //Método construtor
        public CRUD()
        {
            stringConexao = ConfigurationManager.ConnectionStrings["Minhaconexao"].ConnectionString;
        }
        //Procura do Usuário
        public bool ProcuraUsuario(string id)
        {
            using (SqlConnection conexao = new SqlConnection(stringConexao))
            {
                string query = @"SELECT COUNT(*) FROM Cadastros WHERE email = @id OR cpf = @id OR telefone = @id";

                SqlCommand sqlCommand = new SqlCommand(query, conexao);
                sqlCommand.Parameters.AddWithValue("@id", id);

                conexao.Open();
                int contador = (int)sqlCommand.ExecuteScalar(); //0 = Não existe, 1 = Existe

                
                if (contador > 0)
                    return true;
                else
                    return false;
            }
        }
        //Efetua Login
        public bool Logar(string id, string senha)
        {
            using (SqlConnection conexao = new SqlConnection(stringConexao))
            {
                string query = @"SELECT COUNT(*) FROM Cadastros WHERE email = @id AND senha = @senha OR cpf = @id AND senha = @senha OR telefone = @id AND senha = @senha";

                SqlCommand sqlCommand = new SqlCommand(query, conexao);
                sqlCommand.Parameters.AddWithValue("@id", id);
                sqlCommand.Parameters.AddWithValue("@senha", senha);

                conexao.Open();
                int contador = (int)sqlCommand.ExecuteScalar();

                if(contador > 0)
                    return true;
                else
                    return false;
            }
        }
        //Cadastra Usuário
        public int CriaUusario(string nome, string sobrenome, string email, string cpf, string telefone, string senha)
        {
            using (SqlConnection conexao = new SqlConnection(stringConexao))
            {
                string query = @"INSERT INTO Cadastros (nome, sobrenome, email, telefone, cpf, senha) VALUES (@nome, @sobrenome, @email, @telefone, @cpf, @senha)";
                SqlCommand sqlCommand = new SqlCommand(query,conexao);
                sqlCommand.Parameters.AddWithValue("@nome", nome);
                sqlCommand.Parameters.AddWithValue("@sobrenome", sobrenome);
                sqlCommand.Parameters.AddWithValue("@email", email);
                sqlCommand.Parameters.AddWithValue("@cpf", cpf);
                sqlCommand.Parameters.AddWithValue("@telefone", telefone);
                sqlCommand.Parameters.AddWithValue("@senha", senha);

                conexao.Open();
                int linhasCriadas= (int)sqlCommand.ExecuteNonQuery();


                return linhasCriadas; //0 = Falha, 1 = Sucesso
            }
        }
    }

    internal class TratamentoId
    {
        private string idTratada;
        public string Tratamento(string id)
        {
            if (id.Contains('@'))
                idTratada = id;
            else
            {
                List<char> listaNumeros = new  List<char>();
                for (int i = 0; i < id.Length; i++)
                {
                    if (char.IsDigit(id[i]))
                    {
                        listaNumeros.Add(id[i]);
                    }
                }
                idTratada = new string(listaNumeros.ToArray());
            }
            return idTratada;
        }
    }
}
