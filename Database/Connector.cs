using System.Data;
using Dapper;
using MySql.Data.MySqlClient;

namespace Database;

public class Connector : IConnector
{
	public async Task<List<T>> QueryAsync<T, TU>(string query, TU parameters, string connectionString)
	{
		using IDbConnection connection = new MySqlConnection(connectionString);
		// ReSharper disable once HeapView.PossibleBoxingAllocation
		IEnumerable<T> rows = await connection.QueryAsync<T>(query, parameters);
		return rows.ToList();
	}
    
	public Task ExecuteAsync<T>(string command, T parameters, string connectionString)
	{
		using IDbConnection connection = new MySqlConnection(connectionString);
		// ReSharper disable once HeapView.PossibleBoxingAllocation
		return connection.ExecuteAsync(command, parameters);
	}
}