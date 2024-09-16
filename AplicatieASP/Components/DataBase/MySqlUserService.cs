using MySql.Data.MySqlClient;
using System.Collections.Generic;
using System.Threading.Tasks;
using AplicatieASP.Components.DataBase.Models;

namespace AplicatieASP.Components.DataBase
{
    public class MySqlUserService
    {
        private readonly string _connectionString;

        public MySqlUserService(IConfiguration configuration)
        {
            _connectionString = configuration.GetConnectionString("DefaultConnection");
        }

        // Method to fetch all users from the Users table
        public async Task<List<User>> GetAllUsersAsync()
        {
            var users = new List<User>();

            using (var connection = new MySqlConnection(_connectionString))
            {
                await connection.OpenAsync();

                // Define your SQL query to fetch users
                var query = "SELECT id, name FROM users";

                using (var command = new MySqlCommand(query, connection))
                using (var reader = await command.ExecuteReaderAsync())
                {
                    while (await reader.ReadAsync())
                    {
                        users.Add(new User
                        {
                            Id = reader.GetInt32(0),
                            Name = reader.GetString(1),                            
                        });
                    }
                }
            }

            return users;
        }
    }
}
