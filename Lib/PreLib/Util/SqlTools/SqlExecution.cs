using Microsoft.Data.SqlClient;

namespace MyUtilities.SqlTools
{
    public static class SqlExecution
    {
        public static async Task<int> ExecuteNonQuery(string query, string connectionString)
        {
            using var connection = new SqlConnection(connectionString);
            using var command = new SqlCommand(query, connection);
            await connection.OpenAsync();
            return await command.ExecuteNonQueryAsync();
        }

        public static async Task<T?> ExecuteScalar<T>(string query, string connectionString)
        {
            using var connection = new SqlConnection(connectionString);
            using var command = new SqlCommand(query, connection);
            await connection.OpenAsync();
            return (T?)await command.ExecuteScalarAsync();
        }

        public static async Task<T?> ExecuteQuery<T>(string query, string connectionString, Func<SqlDataReader, T> map)
        {
            using var connection = new SqlConnection(connectionString);
            using var command = new SqlCommand(query, connection);
            await connection.OpenAsync();
            using var reader = await command.ExecuteReaderAsync();
            return reader.Read() ? map(reader) : default;
        }
    }
}