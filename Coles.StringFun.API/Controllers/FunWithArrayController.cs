using Coles.StringFun.Application;
using Microsoft.AspNetCore.Mvc;

namespace Coles.StringFun.API.Controllers
{
	[ApiController]
	[Route("coles/arrays/v1")]
	public class FunWithArrayController : Controller
	{
		private readonly IArrayRequestHandler<string> _arrayRequestHandler;

		public FunWithArrayController(IArrayRequestHandler<string> arrayRequestHandler)
		{
			_arrayRequestHandler = arrayRequestHandler;
		}

		[HttpPost, HttpOptions]
		[Route("distinct")]
		public async Task<ActionResult> GetDistinctList([FromBody] string[] elements)
		{
			try
			{

				return Ok(_arrayRequestHandler.GetDistinct(elements));
			}
			catch (Exception e)
			{
				return new ObjectResult($"An error occured: {e.Message}") { StatusCode = 500 };
			}
		}
	}
}
