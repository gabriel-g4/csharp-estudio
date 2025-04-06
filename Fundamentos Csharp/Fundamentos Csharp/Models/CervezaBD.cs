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

        //public void Create(Cerveza cerveza)
        //{
        //    string query = "INSERT INTO cervezas"
        //}
    }
}
