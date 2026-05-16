using System.Configuration;
using System.Data;
using System.Diagnostics;
using Microsoft.Data.SqlClient;

namespace CustomersManagement;

public class DbHelper
{
    private readonly string _connectionString;

    public DbHelper()
    {
        _connectionString = ConfigurationManager.ConnectionStrings["DBConnection"].ConnectionString;
    }

    // Read
    public async Task<List<Movie>> GetMoviesAsync()
    {
        try
        {
            var movies = new List<Movie>();

            await using var connection = new SqlConnection(_connectionString);
            await connection.OpenAsync();

            const string sql = "SELECT Id, Title, Genre, Year, Rating, CreatedAt FROM Movies";
            await using var command = new SqlCommand(sql, connection);
            await using var dataReader = await command.ExecuteReaderAsync();

            if (!dataReader.HasRows)
                return movies;

            int ordId = dataReader.GetOrdinal("Id");
            int ordTitle = dataReader.GetOrdinal("Title");
            int ordGenre = dataReader.GetOrdinal("Genre");
            int ordYear = dataReader.GetOrdinal("Year");
            int ordRating = dataReader.GetOrdinal("Rating");
            int ordCreatedAt = dataReader.GetOrdinal("CreatedAt");

            while (await dataReader.ReadAsync())
            {
                movies.Add(new Movie
                {
                    Id = dataReader.GetInt32(ordId),
                    Title = dataReader.GetString(ordTitle),
                    Genre = dataReader.GetString(ordGenre),
                    Year = dataReader.GetInt32(ordYear),
                    Rating = dataReader.GetDouble(ordRating),
                    CreatedAt = dataReader.GetDateTime(ordCreatedAt)
                });
            }

            return movies;
        }
        catch (Exception ex)
        {
            Trace.TraceError("GetMoviesAsync failed: {0}", ex.Message);
            throw;
        }
    }

    // Create
    public async Task CreateMovieAsync(Movie movie)
    {
        try
        {
            await using var connection = new SqlConnection(_connectionString);
            await connection.OpenAsync();

            const string sql = @"
INSERT INTO Movies (Title, Genre, Year, Rating) 
VALUES (@Title, @Genre, @Year, @Rating)";

            await using var command = new SqlCommand(sql, connection);

            command.Parameters.Add("@Title", SqlDbType.NVarChar, 100).Value = movie.Title;
            command.Parameters.Add("@Genre", SqlDbType.NVarChar, 50).Value = movie.Genre;
            command.Parameters.Add("@Year", SqlDbType.Int).Value = movie.Year;
            command.Parameters.Add("@Rating", SqlDbType.Float).Value = movie.Rating;

            await command.ExecuteNonQueryAsync();
        }
        catch (Exception ex)
        {
            Trace.TraceError("CreateMovieAsync failed: {0}", ex.Message);
            throw;
        }
    }

    // Update
    public async Task UpdateMovieAsync(Movie movie)
    {
        try
        {
            await using var connection = new SqlConnection(_connectionString);
            await connection.OpenAsync();

            const string sql = @"
UPDATE Movies 
SET Title=@Title, Genre=@Genre, Year=@Year, Rating=@Rating
WHERE Id=@Id";

            await using var command = new SqlCommand(sql, connection);

            command.Parameters.Add("@Title", SqlDbType.NVarChar, 100).Value = movie.Title;
            command.Parameters.Add("@Genre", SqlDbType.NVarChar, 50).Value = movie.Genre;
            command.Parameters.Add("@Year", SqlDbType.Int).Value = movie.Year;
            command.Parameters.Add("@Rating", SqlDbType.Float).Value = movie.Rating;
            command.Parameters.Add("@Id", SqlDbType.Int).Value = movie.Id;

            await command.ExecuteNonQueryAsync();
        }
        catch (Exception ex)
        {
            Trace.TraceError("UpdateMovieAsync failed: {0}", ex.Message);
            throw;
        }
    }

    // Delete
    public async Task DeleteMovieAsync(int id)
    {
        try
        {
            await using var connection = new SqlConnection(_connectionString);
            await connection.OpenAsync();

            const string sql = "DELETE FROM Movies WHERE Id=@Id";
            await using var command = new SqlCommand(sql, connection);
            command.Parameters.Add("@Id", SqlDbType.Int).Value = id;

            await command.ExecuteNonQueryAsync();
        }
        catch (Exception ex)
        {
            Trace.TraceError("DeleteMovieAsync failed: {0}", ex.Message);
            throw;
        }
    }
}