public interface IPlataformService
    {
        string GetPlataformAsync(int id);
        string GetPlataformsAsync(string orderBy = "id");
        string CreatePlataformAsync(string newPlataform);
        string UpdatePlataformAsync(int id, string plataform);
        string DeletePlataformAsync(int id);
    }