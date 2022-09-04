
using Microsoft.AspNetCore.Mvc;

namespace Ecohacks.server.Controllers;

[ApiController]
[Route("to be decided")]
public class SmthController : ControllerBase
{
    [HttpPost]
    [Route("StoreToDb")]
    public async Task<ActionResult> Store([FromBody] DbObjectKv keyValuePair)
    {
        await Task.Delay(69);
        return Ok();
    }
	
    [HttpGet]
    [Route("GetFromDb")]
    public async Task<ActionResult> Get()
    {
        await Task.Delay(69);
        return Ok();
    }
    // GET all action

    // GET by Id action

    // POST action

    // PUT action

    // DELETE action
}




/*
string query = "SELECT * FROM residential_freezers WHERE ModelNumber = @Query";
IConnector conn = new Connector();
List<Model> results = await conn.QueryAsync<Model, dynamic>(query, new
{
    Query = userInputModelNumber
});*/