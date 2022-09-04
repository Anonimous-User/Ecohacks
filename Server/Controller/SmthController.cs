string query = "SELECT * FROM residential_freezers WHERE ModelNumber = @Query";
IConnector conn = new Connector();
List<Model> results = await conn.QueryAsync<Model, dynamic>(query, new
{
    Query = userInputModelNumber
});