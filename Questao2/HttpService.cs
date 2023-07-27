using Newtonsoft.Json;
namespace Questao2
{

    public class HttpService : IHttpService
    {
        private readonly IHttpClientFactory _httpClientFactory;

        const string TEAM_1 = "team1";
        const string TEAM_2 = "team2";
        const int INITIAL_PAGE = 1;

        public HttpService(IHttpClientFactory httpClientFactory)
        {
            _httpClientFactory = httpClientFactory;
        }

        public async Task<int> getTotalScoredGoals(string team, int year)
        {

            var total_team_1 = await Get(team, year, TEAM_1);

            var Total_Goals_Team_1 = total_team_1.Sum(x => x.data.Sum(x => x.team1goals)) ;

            var total_team_2 = await Get(team, year, TEAM_2);

            var Total_Goals_Team_2 = total_team_2.Sum(x => x.data.Sum(x => x.team2goals));

            return Total_Goals_Team_1 + Total_Goals_Team_2;
        }

        private async Task<List<ResultadoDto>> Get(string team, int year, string position)
        {
            List<ResultadoDto> resultados = new List<ResultadoDto>();

            var client = _httpClientFactory.CreateClient("service");
            var result = await client.GetAsync($"?year={year}&{position}={team}");
            var data_result = JsonConvert.DeserializeObject<ResultadoDto>(result.Content.ReadAsStringAsync().Result);
            
            resultados.Add(data_result);

            if (data_result.total_pages > 1)
            {
                for (int i = 2; i <= data_result.total_pages; i++)
                {
                    var data_result_paged = await GetByPage(team, year, position, i);
                    resultados.Add(data_result_paged);
                }
            }

            return resultados;

        }

        private async Task<ResultadoDto> GetByPage(string team, int year, string position, int page = INITIAL_PAGE)
        {
            var client = _httpClientFactory.CreateClient("service");
            var result = await client.GetAsync($"?year={year}&{position}={team}&page={page}");
            var resultado = JsonConvert.DeserializeObject<ResultadoDto>(result.Content.ReadAsStringAsync().Result);

            return resultado;
        }
    }
}
