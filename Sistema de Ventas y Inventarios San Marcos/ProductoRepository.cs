// DataAccess/ProductoRepository.cs
using MySql.Data.MySqlClient;
using Sistema_de_Ventas_y_Inventarios_San_Marcos.Models;
using System;
using System.Collections.Generic;

namespace Sistema_de_Ventas_y_Inventarios_San_Marcos.DataAccess
{
    public class ProductoRepository
    {
        private readonly string connectionString = "Server=localhost;Database=FerreteriaSanMarco;Uid=root;Pwd=1991242507;";

        public List<Producto> GetAll()
        {
            List<Producto> productos = new List<Producto>();
            using (MySqlConnection connection = new MySqlConnection(connectionString))
            {
                connection.Open();
                string query = "SELECT * FROM Producto";
                MySqlCommand cmd = new MySqlCommand(query, connection);
                MySqlDataReader reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    productos.Add(new Producto
                    {
                        ID_Producto = reader.GetInt32("ID_Producto"),
                        ID_Subcategoria = reader.GetInt32("ID_Subcategoria"),
                        Nombre = reader.GetString("Nombre"),
                        Descripcion = reader.GetString("Descripcion"),
                        Precio_Unitario = reader.GetDecimal("Precio_Unitario"),
                        Stock = reader.GetInt32("Stock"),
                        ID_Ubicacion = reader.GetInt32("ID_Ubicacion")
                    });
                }
            }
            return productos;
        }

        public Producto GetById(int id)
        {
            using (MySqlConnection connection = new MySqlConnection(connectionString))
            {
                connection.Open();
                string query = "SELECT * FROM Producto WHERE ID_Producto = @ID_Producto";
                MySqlCommand cmd = new MySqlCommand(query, connection);
                cmd.Parameters.AddWithValue("@ID_Producto", id);
                MySqlDataReader reader = cmd.ExecuteReader();
                if (reader.Read())
                {
                    return new Producto
                    {
                        ID_Producto = reader.GetInt32("ID_Producto"),
                        ID_Subcategoria = reader.GetInt32("ID_Subcategoria"),
                        Nombre = reader.GetString("Nombre"),
                        Descripcion = reader.GetString("Descripcion"),
                        Precio_Unitario = reader.GetDecimal("Precio_Unitario"),
                        Stock = reader.GetInt32("Stock"),
                        ID_Ubicacion = reader.GetInt32("ID_Ubicacion")
                    };
                }
                return null;
            }
        }

        public void Insert(Producto producto)
        {
            using (MySqlConnection connection = new MySqlConnection(connectionString))
            {
                connection.Open();
                string query = "INSERT INTO Producto (ID_Subcategoria, Nombre, Descripcion, Precio_Unitario, Stock, ID_Ubicacion) " +
                               "VALUES (@ID_Subcategoria, @Nombre, @Descripcion, @Precio_Unitario, @Stock, @ID_Ubicacion)";
                MySqlCommand cmd = new MySqlCommand(query, connection);
                cmd.Parameters.AddWithValue("@ID_Subcategoria", producto.ID_Subcategoria);
                cmd.Parameters.AddWithValue("@Nombre", producto.Nombre);
                cmd.Parameters.AddWithValue("@Descripcion", producto.Descripcion);
                cmd.Parameters.AddWithValue("@Precio_Unitario", producto.Precio_Unitario);
                cmd.Parameters.AddWithValue("@Stock", producto.Stock);
                cmd.Parameters.AddWithValue("@ID_Ubicacion", producto.ID_Ubicacion);
                cmd.ExecuteNonQuery();
            }
        }

        public List<Producto> GetBySubcategoria(int idSubcategoria)
        {
            List<Producto> productos = new List<Producto>();
            using (MySqlConnection connection = new MySqlConnection(connectionString))
            {
                connection.Open();
                string query = "SELECT * FROM Producto WHERE ID_Subcategoria = @ID_Subcategoria";
                MySqlCommand cmd = new MySqlCommand(query, connection);
                cmd.Parameters.AddWithValue("@ID_Subcategoria", idSubcategoria);
                MySqlDataReader reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    productos.Add(new Producto
                    {
                        ID_Producto = reader.GetInt32("ID_Producto"),
                        ID_Subcategoria = reader.GetInt32("ID_Subcategoria"),
                        Nombre = reader.GetString("Nombre"),
                        Descripcion = reader.GetString("Descripcion"),
                        Precio_Unitario = reader.GetDecimal("Precio_Unitario"),
                        Stock = reader.GetInt32("Stock"),
                        ID_Ubicacion = reader.GetInt32("ID_Ubicacion")
                    });
                }
            }
            return productos;
        }

        public List<Producto> Search(string nombre, int? idCategoria, int? idSubcategoria)
        {
            List<Producto> productos = new List<Producto>();
            using (MySqlConnection connection = new MySqlConnection(connectionString))
            {
                connection.Open();
                string query = "SELECT p.* FROM Producto p " +
                               "JOIN Subcategoria s ON p.ID_Subcategoria = s.ID_Subcategoria " +
                               "WHERE 1=1";
                if (!string.IsNullOrEmpty(nombre))
                {
                    query += " AND (LOWER(p.Nombre) LIKE LOWER(@Nombre) OR LOWER(p.Descripcion) LIKE LOWER(@Nombre))";
                }
                if (idCategoria.HasValue)
                {
                    query += " AND s.ID_Categoria = @ID_Categoria";
                }
                if (idSubcategoria.HasValue)
                {
                    query += " AND p.ID_Subcategoria = @ID_Subcategoria";
                }

                MySqlCommand cmd = new MySqlCommand(query, connection);
                if (!string.IsNullOrEmpty(nombre))
                {
                    cmd.Parameters.AddWithValue("@Nombre", "%" + nombre + "%");
                }
                if (idCategoria.HasValue)
                {
                    cmd.Parameters.AddWithValue("@ID_Categoria", idCategoria.Value);
                }
                if (idSubcategoria.HasValue)
                {
                    cmd.Parameters.AddWithValue("@ID_Subcategoria", idSubcategoria.Value);
                }

                MySqlDataReader reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    productos.Add(new Producto
                    {
                        ID_Producto = reader.GetInt32("ID_Producto"),
                        ID_Subcategoria = reader.GetInt32("ID_Subcategoria"),
                        Nombre = reader.GetString("Nombre"),
                        Descripcion = reader.GetString("Descripcion"),
                        Precio_Unitario = reader.GetDecimal("Precio_Unitario"),
                        Stock = reader.GetInt32("Stock"),
                        ID_Ubicacion = reader.GetInt32("ID_Ubicacion")
                    });
                }
            }
            return productos;
        }
    }
}