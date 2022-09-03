using Ecohacks.Shared;
using Microsoft.AspNetCore.Mvc;

namespace Ecohacks.Server.Controllers;

[ApiController]
[Route("Demo")]
public class DemoController : ControllerBase
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
}