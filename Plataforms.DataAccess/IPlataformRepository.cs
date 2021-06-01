    public interface IPlataformRepository
    {
        string GetPlataformAsync(int id, bool showSeries = false);
        string  GetPlataformsAsync(string orderBy, bool showSeries = false);
        void CreatePlataform(string newPlataform);
        bool UpdatePlataform(string plataform);
        string DeletePlataform(int id);

        
    }