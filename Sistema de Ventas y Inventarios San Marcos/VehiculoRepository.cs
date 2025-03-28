// DataAccess/VehiculoRepository.cs
using MySql.Data.MySqlClient;
using Sistema_de_Ventas_y_Inventarios_San_Marcos.Models;
using System;
using System.Collections.Generic;

namespace Sistema_de_Ventas_y_Inventarios_San_Marcos.DataAccess
{
    public class VehiculoRepository
    {
        private readonly string connectionString = "Server=localhost;Database=FerreteriaSanMarco;Uid=root;Pwd=1991242507;";

        public List<Vehiculo> GetAll()
        {
            List<Vehiculo> vehiculos = new List<Vehiculo>();
            using (MySqlConnection connection = new MySqlConnection(connectionString))
            {
                connection.Open();
                string query = "SELECT * FROM Vehiculo";
                MySqlCommand cmd = new MySqlCommand(query, connection);
                MySqlDataReader reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    vehiculos.Add(new Vehiculo
                    {
                        ID_Vehiculo = reader.GetInt32("ID_Vehiculo"),
                        Marca = reader.GetString("Marca"),
                        Modelo = reader.GetString("Modelo"),
                        Ano = reader.GetInt32("Ano"),
                        ID_Birlo = reader.IsDBNull(reader.GetOrdinal("ID_Birlo")) ? (int?)null : reader.GetInt32("ID_Birlo"),
                        ID_Tuerca = reader.IsDBNull(reader.GetOrdinal("ID_Tuerca")) ? (int?)null : reader.GetInt32("ID_Tuerca")
                    });
                }
            }
            return vehiculos;
        }

        public void Insert(Vehiculo vehiculo)
        {
            using (MySqlConnection connection = new MySqlConnection(connectionString))
            {
                connection.Open();
                string query = "INSERT INTO Vehiculo (Marca, Modelo, Ano, ID_Birlo, ID_Tuerca) " +
                               "VALUES (@Marca, @Modelo, @Ano, @ID_Birlo, @ID_Tuerca)";
                MySqlCommand cmd = new MySqlCommand(query, connection);
                cmd.Parameters.AddWithValue("@Marca", vehiculo.Marca);
                cmd.Parameters.AddWithValue("@Modelo", vehiculo.Modelo);
                cmd.Parameters.AddWithValue("@Ano", vehiculo.Ano);
                cmd.Parameters.AddWithValue("@ID_Birlo", (object)vehiculo.ID_Birlo ?? DBNull.Value);
                cmd.Parameters.AddWithValue("@ID_Tuerca", (object)vehiculo.ID_Tuerca ?? DBNull.Value);
                cmd.ExecuteNonQuery();
            }
        }

        public List<Vehiculo> GetByBirlo(int idBirlo)
        {
            List<Vehiculo> vehiculos = new List<Vehiculo>();
            using (MySqlConnection connection = new MySqlConnection(connectionString))
            {
                connection.Open();
                string query = "SELECT * FROM Vehiculo WHERE ID_Birlo = @ID_Birlo";
                MySqlCommand cmd = new MySqlCommand(query, connection);
                cmd.Parameters.AddWithValue("@ID_Birlo", idBirlo);
                MySqlDataReader reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    vehiculos.Add(new Vehiculo
                    {
                        ID_Vehiculo = reader.GetInt32("ID_Vehiculo"),
                        Marca = reader.GetString("Marca"),
                        Modelo = reader.GetString("Modelo"),
                        Ano = reader.GetInt32("Ano"),
                        ID_Birlo = reader.IsDBNull(reader.GetOrdinal("ID_Birlo")) ? (int?)null : reader.GetInt32("ID_Birlo"),
                        ID_Tuerca = reader.IsDBNull(reader.GetOrdinal("ID_Tuerca")) ? (int?)null : reader.GetInt32("ID_Tuerca")
                    });
                }
            }
            return vehiculos;
        }

        public List<Vehiculo> GetByTuerca(int idTuerca)
        {
            List<Vehiculo> vehiculos = new List<Vehiculo>();
            using (MySqlConnection connection = new MySqlConnection(connectionString))
            {
                connection.Open();
                string query = "SELECT * FROM Vehiculo WHERE ID_Tuerca = @ID_Tuerca";
                MySqlCommand cmd = new MySqlCommand(query, connection);
                cmd.Parameters.AddWithValue("@ID_Tuerca", idTuerca);
                MySqlDataReader reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    vehiculos.Add(new Vehiculo
                    {
                        ID_Vehiculo = reader.GetInt32("ID_Vehiculo"),
                        Marca = reader.GetString("Marca"),
                        Modelo = reader.GetString("Modelo"),
                        Ano = reader.GetInt32("Ano"),
                        ID_Birlo = reader.IsDBNull(reader.GetOrdinal("ID_Birlo")) ? (int?)null : reader.GetInt32("ID_Birlo"),
                        ID_Tuerca = reader.IsDBNull(reader.GetOrdinal("ID_Tuerca")) ? (int?)null : reader.GetInt32("ID_Tuerca")
                    });
                }
            }
            return vehiculos;
        }
    }
}