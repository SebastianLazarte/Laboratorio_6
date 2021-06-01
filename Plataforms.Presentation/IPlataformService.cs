namespace Plataforms.Presentation
{
        public interface IPlataformService 
        {
        string GetPlataformAsync(int id);
        string CreatePlataformAsync(string newPlataform);
        string UpdatePlataformAsync(int id, string plataform);
        string DeletePlataformAsync(int id);
        }
}