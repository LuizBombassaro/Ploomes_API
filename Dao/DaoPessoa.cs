using System.Data.SqlClient;
using TestePloomesAPI.Model;
using System.Data;


namespace TestePloomesAPI.Dao
{
    public class DaoPessoa
    {
        string conexao = "Data Source=LUIZO\\SQLEXPRESS01;Initial Catalog=PloomesAPI;Integrated Security=True"; // como a tarefa era simples não senti necessidade de esconder a conexão do BD

        public List<Pessoa> GetPessoas()
        {
            List<Pessoa> pessoas = new List<Pessoa>();

            using (SqlConnection conexaoSQL = new SqlConnection(conexao))
            {
                conexaoSQL.Open();
                String SelectQuery = "GetPessoas";
                using (SqlCommand cmd = new SqlCommand(SelectQuery, conexaoSQL))
                {
                    cmd.CommandType = CommandType.StoredProcedure;
                    using (SqlDataReader reader = cmd.ExecuteReader())
                    {
                        if (reader != null)
                        {
                            while (reader.Read())
                            {
                                var pessoa = new Pessoa();
                                pessoa.Nome = reader["Nome"].ToString();
                                pessoa.Email = reader["Email"].ToString();
                                pessoas.Add(pessoa);
                            }
                        }
                    }
                }
            }
                return pessoas;
        }

        public void InsertPessoa(Pessoa pessoa)
        {
            List<Pessoa> pessoas = new List<Pessoa>();

            using (SqlConnection conexaoSQL = new SqlConnection(conexao))
            {
                conexaoSQL.Open();
                String InsertQuery = "PostPessoas";
                using (SqlCommand cmd = new SqlCommand(InsertQuery, conexaoSQL))
                {
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@NOME", pessoa.Nome);
                    cmd.Parameters.AddWithValue("@EMAIL", pessoa.Email);
                    cmd.ExecuteNonQuery();
                }
            }
        }
    }
}
