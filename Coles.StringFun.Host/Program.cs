
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Coles.StringFun.Host;
using Coles.StringFun.Domain;
using Coles.StringFun.Application;
using Coles.StringFun.Definitions;

using IHost host = Host.CreateDefaultBuilder(args)
	.ConfigureServices((_, services) =>
		services.AddSingleton<IArrayFunctions<string>, ArrayFunctions<string>>()
				.AddSingleton<IStringFunctions, StringFunctions>()
				.AddSingleton<IStringRequestHandler, StringRequestHandler>()
				.AddSingleton<IArrayRequestHandler<string>, ArrayRequestHandler<string>>()
				.AddTransient<LogWriter>())
				.Build();

Run(host.Services);
await host.RunAsync();


static void Run(IServiceProvider services)
{
	using IServiceScope serviceScope = services.CreateScope();
	IServiceProvider provider = serviceScope.ServiceProvider;

	LogWriter logger = provider.GetRequiredService<LogWriter>();
	IArrayRequestHandler<string> arrayRequestHandler = provider.GetRequiredService<IArrayRequestHandler<string>>();
	IStringRequestHandler stringRequestHandler = provider.GetRequiredService<IStringRequestHandler>();



	logger.Write("\n--------Welcome to Coles Fun With Strings---------");
	logger.Write("\n\n\nChoose your option from:");

	var userChoice = Helper.GetUserChoice(logger, Helper.GetUserOptions());

	switch (userChoice?.ToLower())
	{
		case "1":
			logger.Write($"\nEnter sentence to reverse:");
			var sentence = Console.ReadLine();
			if (sentence?.Length < 1)
			{
				logger.Write("\nInvalid sentence");
				break;
			}
			logger.Write($"\n Reveresed {stringRequestHandler.GetReverse(sentence)}");
			break;

		case "2":
			logger.Write($"\nEnter first word to test for anagrams:");
			var word1 = Console.ReadLine();
			logger.Write($"\nEnter second word to test for anagrams:");
			var word2 = Console.ReadLine();
			var areAnagrams = stringRequestHandler.CheckIfAreAnagrams(new string[] { word1, word2 }) == true ? "" : " not ";
			logger.Write($"\n The words {word1} and {word2} are{areAnagrams} anagrams");
			break;

		case "3":
			logger.Write($"\nEnter words to remove repeated elements (seperated by commas):");
			var words = Console.ReadLine();

			if (words?.Length < 1)
			{
				logger.Write("\nInvalid list");
				break;
			}

			var wordArray = words?.Split(',');
			var distinctList = arrayRequestHandler.GetDistinct(wordArray);
			logger.Write($"\nDistinct string list: {string.Join(",", distinctList)}");
			break;

		default:
			break;
	}

	logger.Write("\n\n\n\t THANK YOU FOR PLAYING");
	return;
}