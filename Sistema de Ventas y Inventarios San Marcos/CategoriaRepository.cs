// DataAccess/CategoriaRepository.cs
using FerreteriaSanMarco.Models;
using MySql.Data.MySqlClient;
using Sistema_de_Ventas_y_Inventarios_San_Marcos.Models;
using System.Collections.Generic;

namespace Sistema_de_Ventas_y_Inventarios_San_Marcos.DataAccess
{
    public class CategoriaRepository
    {
        private readonly string connectionString = "Server=localhost;Database=FerreteriaSanMarco;Uid=root;Pwd=1991242507;";

        public List<Categoria> GetAll()
        {
            List<Categoria> categorias = new List<Categoria>();
            using (MySqlConnection connection = new MySqlConnection(connectionString))
            {
                connection.Open();
                string query = "SELECT * FROM Categoria";
                MySqlCommand cmd = new MySqlCommand(query, connection);
                MySqlDataReader reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    categorias.Add(new Categoria
                    {
                        ID_Categoria = reader.GetInt32("ID_Categoria"),
                        Nombre = reader.GetString("Nombre")
                    });
                }
            }
            return categorias;
        }
    }
}