using System;
using System.Collections.Generic;

public class Class1
{
    public Class1()
        public List<books>{get all}
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
                return books;
            }
        }
    }
}
