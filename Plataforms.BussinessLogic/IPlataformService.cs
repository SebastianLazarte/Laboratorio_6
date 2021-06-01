namespace Plataforms.BussinessLogic
{
public interface IPlataformService
    {
        string GetPlataformAsync(int id);
        string GetPlataformsAsync(string orderBy = "iid");
        string CreatePlataformAsync(string newPlataform);
        string UpdatePlataformAsync(int id, string plataform);
        string DeletePlataformAsync(int id);
    }
}