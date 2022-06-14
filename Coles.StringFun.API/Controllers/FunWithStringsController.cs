using Coles.StringFun.Application;
using Microsoft.AspNetCore.Mvc;

namespace Coles.StringFun.API.Controllers
{
	[ApiController]
	[Route("coles/strings/v1")]
	public class FunWithStringsController : Controller
	{
		private readonly IStringRequestHandler _stringRequestHandler;

		public FunWithStringsController(IStringRequestHandler stringRequestHandler)
		{
			_stringRequestHandler = stringRequestHandler;
		}

		[HttpGet, HttpOptions]
		[Route("reverse")]
		public async Task<ActionResult> Reverse(string sentence)
		{
			try
			{

				return Ok(_stringRequestHandler.GetReverse(sentence));
			}
			catch (Exception e)
			{
				return new ObjectResult($"An error occured: {e.Message}") { StatusCode = 500 };
			}
		}

		[HttpPost, HttpOptions]
		[Route("areAnagrams")]
		public async Task<ActionResult> CheckForAnagrams([FromBody] string[] words)
		{
			try
			{

				return Ok(_stringRequestHandler.CheckIfAreAnagrams(words));
			}
			catch (Exception e)
			{
				return new ObjectResult($"An error occured: {e.Message}") { StatusCode = 500 };
			}
		}
	}
}
