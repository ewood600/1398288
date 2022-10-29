using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using System.Data.SqlClient;
using static System.Reflection.Metadata.BlobBuilder;

namespace WebApplication2.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class BooksController : ControllerBase
    {
        public IActionResult Get(Book Books_2)
        {
            var connectionString = "server=DESCKTOP-G529-18\\SQLEXPRESS; database=Books;Integrated Security=true;";

            using (var connection = new SqlConnection(connectionString))
            {
                var books = new List<Book>();
                connection.Open();

                using (var sqlCommand = new SqlCommand("SELECT id, Name FROM Books", connection))
                {
                    var reader = sqlCommand.ExecuteReader();
                    while (reader.Read())
                    {
                        books.Add(new Book
                        {
                            ID = int.Parse(reader["Id"].ToString()),
                            Name = reader["Name"].ToString(),
                        });
                    }
                }

                connection.Close();

                return Ok(books);
            }
        }
        public IActionResult Post(Book Books_2)
        {
            if (Books_2 == null || Books_2.Name == null || Books_2.Name == string.Empty)
                return BadRequest("неправильный формат данных о книге!");

            var connectionString = "server=DESCKTOP-G529-18\\SQLEXPRESS; database=Books;Integrated Security=true;";

            using (var connection = new SqlConnection(connectionString))
            {
                connection.Open();
                var commandText =
                    $"INSERT INTO Books_2(Name, Author_ID) VALUES ('{Books_2.Name}', {Books_2.Author_ID}";
                using (var sqlCommand = new SqlCommand(commandText, connection))
                {
                    var reader = sqlCommand.ExecuteNonQuery();
                }

                connection.Close();

                return Ok();

            }
        }


        public IActionResult Put(Book Books_2)
        {
            if (Books_2 == null || Books_2.Name == null || Books_2.Name == string.Empty)
                return BadRequest("неправильныйформат данных о книге!");

            var connectionString = "server=DESCKTOP-G529-18\\SQLEXPRESS; database=Books;Integrated Security=true;";

            using (var connection = new SqlConnection(connectionString))
            {
                connection.Open();
                var commandText =
                    $"INSERT INTO Books_2(Name, Author_ID) VALUES ('{Books_2.Name}', {Books_2.Author_ID}";
                using (var sqlCommand = new SqlCommand(commandText, connection))
                {
                    var reader = sqlCommand.ExecuteNonQuery();
                }

                connection.Close();

                return Ok();

            }
        }
        public IActionResult Delete(Book Books_2)
        {
            if (Books_2 == null || Books_2.Name == null || Books_2.Name == string.Empty)
                return BadRequest("неправильныйформат данных о книге!");

            var connectionString = "server=DESCKTOP-G529-18\\SQLEXPRESS; database=Books;Integrated Security=true;";

            using (var connection = new SqlConnection(connectionString))
            {
                connection.Open();
                var commandText =
                    $"INSERT INTO Books_2(Name, Author_ID) VALUES ('{Books_2.Name}', {Books_2.Author_ID}";
                using (var sqlCommand = new SqlCommand(commandText, connection))
                {
                    var reader = sqlCommand.ExecuteNonQuery();
                }

                connection.Close();

                return Ok();

            }
        }
    }
}
