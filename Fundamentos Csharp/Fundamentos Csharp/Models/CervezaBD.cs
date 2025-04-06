using System;
using System.Collections.Generic;
using Microsoft.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fundamentos_Csharp.Models
{
    internal class CervezaBD
    {
        string connectionString = "Data Source=localhost;" +
            "Initial Catalog=pruebaCsharp;" +
            "Integrated Security=true;TrustServerCertificate=true";

        public List<Cerveza> Get()
        {
            List<Cerveza> cervezas = new List<Cerveza>();

            string query = "SELECT nombre, marca, alcohol, cantidad " +
                "from cervezas";

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                SqlCommand command = new SqlCommand(query, connection);

                connection.Open();

                SqlDataReader sqlDataReader = command.ExecuteReader();

                while (sqlDataReader.Read())
                {
                    string Nombre = sqlDataReader.GetString(0);
                    int Cantidad = sqlDataReader.GetInt32(3);

                    Cerveza cerveza = new Cerveza(Nombre, Cantidad);

                    cerveza.Marca = sqlDataReader.GetString(1);
                    cerveza.Alcohol = sqlDataReader.GetInt32(2);

                    // Añadir a la lista

                    cervezas.Add(cerveza);
                }

                sqlDataReader.Close();
                connection.Close();
            }

            return cervezas;
        }

        public void Create(Cerveza cerveza)
        {
            string query = "INSERT INTO cervezas (nombre, marca, alcohol, cantidad) " +
                "VALUES (@nombre, @marca, @alcohol, @cantidad)";

            using (var connection = new SqlConnection(connectionString))
            {
                SqlCommand command = new SqlCommand(query, connection);

                command.Parameters.AddWithValue("@nombre", cerveza.Nombre);
                command.Parameters.AddWithValue("@marca", cerveza.Marca);
                command.Parameters.AddWithValue("@alcohol", cerveza.Alcohol);
                command.Parameters.AddWithValue("@cantidad", cerveza.Cantidad);

                connection.Open();

                command.ExecuteNonQuery();

                connection.Close();
            }
        }

        public void Update(Cerveza cerveza, int id)
        {
            string query = "UPDATE cervezas " +
                "SET nombre=@nombre, marca=@marca, alcohol=@alcohol, cantidad=@cantidad " +
                "WHERE id=@id";

            using (var connection = new SqlConnection(connectionString))
            {
                SqlCommand command = new SqlCommand(query, connection);

                command.Parameters.AddWithValue("@nombre", cerveza.Nombre);
                command.Parameters.AddWithValue("@marca", cerveza.Marca);
                command.Parameters.AddWithValue("@alcohol", cerveza.Alcohol);
                command.Parameters.AddWithValue("@cantidad", cerveza.Cantidad);
                command.Parameters.AddWithValue("@id", id);

                connection.Open();

                command.ExecuteNonQuery();

                connection.Close();
            }
        }

        public void Delete(int id)
        {
            string query = "DELETE FROM cervezas " +
                "WHERE id=@id";

            using (var connection = new SqlConnection(connectionString))
            {
                SqlCommand command = new SqlCommand(query, connection);

                command.Parameters.AddWithValue("@id", id);

                connection.Open();

                command.ExecuteNonQuery();

                connection.Close();
            }
        }
    }
}
