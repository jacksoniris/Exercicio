namespace Questao2
{
    public interface IHttpService
    {
        Task<int> getTotalScoredGoals(string team, int year);

    }
}