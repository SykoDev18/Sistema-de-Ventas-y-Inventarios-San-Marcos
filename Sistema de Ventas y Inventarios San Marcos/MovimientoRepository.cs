// DataAccess/MovimientoRepository.cs
using MySql.Data.MySqlClient;
using Sistema_de_Ventas_y_Inventarios_San_Marcos.Models;
using System;
using System.Collections.Generic;

namespace Sistema_de_Ventas_y_Inventarios_San_Marcos.DataAccess
{
    public class MovimientoRepository
    {
        private readonly string connectionString = "Server=localhost;Database=FerreteriaSanMarco;Uid=root;Pwd=1991242507;";

        public List<Movimiento> GetAll()
        {
            List<Movimiento> movimientos = new List<Movimiento>();
            using (MySqlConnection connection = new MySqlConnection(connectionString))
            {
                connection.Open();
                string query = "SELECT * FROM Movimiento";
                MySqlCommand cmd = new MySqlCommand(query, connection);
                MySqlDataReader reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    movimientos.Add(new Movimiento
                    {
                        ID_Movimiento = reader.GetInt32("ID_Movimiento"),
                        ID_Producto = reader.GetInt32("ID_Producto"),
                        Tipo_Movimiento = reader.GetString("Tipo_Movimiento"),
                        Cantidad = reader.GetInt32("Cantidad"),
                        Fecha = reader.GetDateTime("Fecha")
                    });
                }
            }
            return movimientos;
        }

        public void Insert(Movimiento movimiento)
        {
            using (MySqlConnection connection = new MySqlConnection(connectionString))
            {
                connection.Open();
                string query = "INSERT INTO Movimiento (ID_Producto, Tipo_Movimiento, Cantidad, Fecha) " +
                               "VALUES (@ID_Producto, @Tipo_Movimiento, @Cantidad, @Fecha)";
                MySqlCommand cmd = new MySqlCommand(query, connection);
                cmd.Parameters.AddWithValue("@ID_Producto", movimiento.ID_Producto);
                cmd.Parameters.AddWithValue("@Tipo_Movimiento", movimiento.Tipo_Movimiento);
                cmd.Parameters.AddWithValue("@Cantidad", movimiento.Cantidad);
                cmd.Parameters.AddWithValue("@Fecha", movimiento.Fecha);
                cmd.ExecuteNonQuery();
            }
        }
    }
}