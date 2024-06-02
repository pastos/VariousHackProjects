using Wordle.Helper;

namespace Wordle
{
    public class CodleHandler
    {
        public async Task<CodleModel> GetTodaysWord()
        {
            HttpRequestHelper< string> httpHelper = new Helper.HttpRequestHelper<string>();
            string url = "https://codle.me/";
            string query = "fav";
            string codleSolution = await httpHelper.GetTodaysWord(url, query);
            CodleModel result = new CodleModel()
            {
                solution = codleSolution
            };
            return result;
        }

        public async Task<string> SolveTodaysWord(CodleModel codleModel)
        {
        
            HttpRequestHelper<string> httpHelper = new Helper.HttpRequestHelper<string>();
            string url = "https://codle.me/check/?word=";
            string response = await httpHelper.GetTodaysWord(url, codleModel.solution);
            return response;
        }
    }


    public class CodleModel
    {        
        public string solution { get; set; }
        
    }



}