using Oracle.ManagedDataAccess.Client;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exemplo_04_Banco_de_Dados {
     public class Database {
          private string ConnectionString = "Data Source=(DESCRIPTION = (ADDRESS = (PROTOCOL = TCP)(HOST = 192.168.15.18)(PORT = 1521)) (CONNECT_DATA = (SERVER = DEDICATED) (SERVICE_NAME = treinamento)))); User Id = aluno14; Password = aluno14;";
         
          public List<Person> PessoasCadastradas { get; set; } = new List<Person>();

          public void CadastrarPessoa(string nome, int idade) {
               try {
                    // Cria uma conexão SQL
                    OracleConnection connection = new OracleConnection(ConnectionString);

                    // Abre a conexão
                    connection.Open();


                    OracleCommand sql = new OracleCommand("INSERT INTO person VALUES (:nome, :idade)", connection);

                    sql.Parameters.Add(new OracleParameter("nome", nome));
                    sql.Parameters.Add(new OracleParameter("idade", idade));

                    if (sql.ExecuteNonQuery() > 0) {
                         MessageBox.Show("Sucesso!");
                    } else {
                         MessageBox.Show("Falha");
                    }
               } catch(Exception ex) {
                    MessageBox.Show(ex.Message);
               }
          }

          public void ListarPessoas() {
               try {
                    OracleConnection connection = new OracleConnection(ConnectionString);
     
                    connection.Open();
     
                    OracleCommand sql = new OracleCommand("SELECT * FROM person", connection);
     
                    OracleDataReader registros = sql.ExecuteReader();

                    PessoasCadastradas.Clear();

                    while (registros.Read()) {
                         Person p = new Person();
                         p.Nome = registros.GetString(0);
                         p.Idade = registros.GetInt32(1);
     
                         PessoasCadastradas.Add(p);
                    }
               } catch (Exception ex) { }
          }
     }
}
