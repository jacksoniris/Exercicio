using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Questao2;

public class Program
{
    static async Task Main()
    {
        var builder = new HostBuilder()
            .ConfigureServices((hostContext, services) =>
            {
                services.AddHttpClient("service", client =>
                {
                    client.BaseAddress = new Uri("https://jsonmock.hackerrank.com/api/football_matches");
                });
                services.AddScoped<IHttpService, HttpService>();
            }).UseConsoleLifetime();

        var host = builder.Build();

        using (var serviceScope = host.Services.CreateScope())
        {
            var services = serviceScope.ServiceProvider;

            try
            {

                var myService = services.GetRequiredService<IHttpService>();

                string teamName = "Paris Saint-Germain";
                int year = 2013;
                int totalGoals = await myService.getTotalScoredGoals(teamName, year);

                Console.WriteLine("Team " + teamName + " scored " + totalGoals.ToString() + " goals in " + year);

                teamName = "Chelsea";
                year = 2014;
                totalGoals = await myService.getTotalScoredGoals(teamName, year);

                Console.WriteLine("Team " + teamName + " scored " + totalGoals.ToString() + " goals in " + year);

            }
            catch (Exception ex)
            {
                Console.WriteLine("Error Occured");
            }
        }

        // Output expected:
        // Team Paris Saint - Germain scored 109 goals in 2013
        // Team Chelsea scored 92 goals in 2014
    }

}


