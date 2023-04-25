
using System.Data.SqlClient;


namespace Projeto.Controller
{
    public class Conexao
    {
        public string connectionString { get; private set; }
        private SqlConnection connection;

        public Conexao()
        {
            this.connectionString = "Data Source=DESKTOP-CAS1E6J;Initial Catalog=CONTROLE_ESTOQUE;User ID=sa;Password=pass";
            this.connection = new SqlConnection(connectionString);
        }

        public void AbrirConexao()
        {
            this.connection.Open();
        }

        public void FecharConexao()
        {
            this.connection.Close();
        }

        public void ExecutarComando(string comando)
        {
            SqlCommand sqlCommand = new SqlCommand(comando, this.connection);
            sqlCommand.ExecuteNonQuery();
        }
    }
}