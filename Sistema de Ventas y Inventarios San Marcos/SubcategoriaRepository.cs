// DataAccess/SubcategoriaRepository.cs
using FerreteriaSanMarco.Models;
using MySql.Data.MySqlClient;
using Sistema_de_Ventas_y_Inventarios_San_Marcos.Models;
using System.Collections.Generic;

namespace Sistema_de_Ventas_y_Inventarios_San_Marcos.DataAccess
{
    public class SubcategoriaRepository
    {
        private readonly string connectionString = "Server=localhost;Database=FerreteriaSanMarco;Uid=root;Pwd=1991242507;";

        public List<Subcategoria> GetByCategoria(int idCategoria)
        {
            List<Subcategoria> subcategorias = new List<Subcategoria>();
            using (MySqlConnection connection = new MySqlConnection(connectionString))
            {
                connection.Open();
                string query = "SELECT * FROM Subcategoria WHERE ID_Categoria = @ID_Categoria";
                MySqlCommand cmd = new MySqlCommand(query, connection);
                cmd.Parameters.AddWithValue("@ID_Categoria", idCategoria);
                MySqlDataReader reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    subcategorias.Add(new Subcategoria
                    {
                        ID_Subcategoria = reader.GetInt32("ID_Subcategoria"),
                        ID_Categoria = reader.GetInt32("ID_Categoria"),
                        Nombre = reader.GetString("Nombre")
                    });
                }
            }
            return subcategorias;
        }
    }
}