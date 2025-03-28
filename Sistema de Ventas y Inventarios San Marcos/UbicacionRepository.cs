// DataAccess/UbicacionRepository.cs
using FerreteriaSanMarco.Models;
using MySql.Data.MySqlClient;
using Sistema_de_Ventas_y_Inventarios_San_Marcos.Models;
using System.Collections.Generic;

namespace Sistema_de_Ventas_y_Inventarios_San_Marcos.DataAccess
{
    public class UbicacionRepository
    {
        private readonly string connectionString = "Server=localhost;Database=FerreteriaSanMarco;Uid=root;Pwd=1991242507;";

        public List<Ubicacion> GetAll()
        {
            List<Ubicacion> ubicaciones = new List<Ubicacion>();
            using (MySqlConnection connection = new MySqlConnection(connectionString))
            {
                connection.Open();
                string query = "SELECT * FROM Ubicacion";
                MySqlCommand cmd = new MySqlCommand(query, connection);
                MySqlDataReader reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    ubicaciones.Add(new Ubicacion
                    {
                        ID_Ubicacion = reader.GetInt32("ID_Ubicacion"),
                        Descripcion = reader.GetString("Descripcion")
                    });
                }
            }
            return ubicaciones;
        }
    }
}