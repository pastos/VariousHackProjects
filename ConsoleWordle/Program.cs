using Wordle;

namespace ConsoleWordle
{
    internal class Program
    {
        static async Task Main(string[] args)
        {
            WordHandler handler = new WordHandler();
            WordleModel result = await handler.GetTodaysWord();

            CodleHandler codleHandler = new CodleHandler();
            CodleModel codleResult = await codleHandler.GetTodaysWord();

            Console.WriteLine("Wordle: " + result.solution);
            Console.WriteLine("Codle: " + codleResult.solution);

            Thread.Sleep(5000);
            await codleHandler.SolveTodaysWord(codleResult);
            Console.ReadLine();
        }
    }
}