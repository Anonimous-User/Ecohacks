using DatabaseAccess;
using ecohacksthing.Shared;
using Microsoft.AspNetCore.Mvc;

namespace EcoHacksThing.server.Controllers;

[ApiController]
[Route("Api/Appliances")]
public class SmthController : ControllerBase
{
    [HttpPost]
    [Route("StoreToDb")]
    public async Task<ActionResult> Store([FromBody] Appliance keyValuePair)
    {
        //insert into database
    }
	
    [HttpPut]
    [Route("GetFromDb")]
    public async Task<ActionResult> Put([FromBody] string search, [FromBody] int compactOrNot)
    {
        if (search != null)
        {
            string query = "SELECT * FROM appliances WHERE ModelNumber LIKE @ModelNumber LIMIT 1";
            IConnector conn = new Connector();
            List<Appliance> results = await conn.QueryAsync<Appliance, dynamic>(query, new
            {
                ModelNumber = $"%{search}%"
            });
            return results.Count is 0 ? NotFound() : Ok(results[0]);
        } else if (compactOrNot == 1)
        {
            string query = "SELECT * FROM appliances WHERE Compactt LIKE @Compactt LIMIT 1";
            IConnector conn = new Connector();
            List<Appliance> results = await conn.QueryAsync<Appliance, dynamic>(query, new
            {
                Compactt = $"%yes%"
            });
            return results.Count is 0 ? NotFound() : Ok(results[0]);//I think this only returns one product when we probably want it to return a list
        }
        
    }

    [HttpGet]
    [Route("GetFromDb")]
    public async Task<ActionResult> Get()
    {
        //get from database and do smth like comparison ig
    }
}




/*
string query = "SELECT * FROM residential_freezers WHERE ModelNumber = @Query";
IConnector conn = new Connector();
List<Model> results = await conn.QueryAsync<Model, dynamic>(query, new
{
    Query = userInputModelNumber
});*/