namespace Database;

public interface IConnector
{
	Task<List<T>> QueryAsync<T, TU>(string query, TU parameters, string connectionString);
	Task ExecuteAsync<T>(string command, T parameters, string connectionString);
}