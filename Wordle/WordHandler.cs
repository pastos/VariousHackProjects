using Wordle.Helper;

namespace Wordle
{
    public class WordHandler
    {
        public async Task<WordleModel> GetTodaysWord()
        {
            HttpRequestHelper<WordleModel> httpHelper = new HttpRequestHelper<WordleModel>();
            string url = "https://www.nytimes.com/svc/wordle/v2/";
            string query = DateTime.Now.ToString("yyyy-MM-dd") + ".json";
            WordleModel result = await httpHelper.GetTodaysWord(url, query);
            return result;
        }
    }
    //user id232954499
    public class WordleModel
    {
        public int id { get; set; }
        public string solution { get; set; }
        public string print_date { get; set; }
        public int days_since_launch { get; set; }
        public string editor { get; set; }
    }
}