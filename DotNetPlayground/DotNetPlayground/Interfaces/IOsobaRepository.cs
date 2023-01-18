using DotNetPlayground.Models;

namespace DotNetPlayground.Interfaces
{
    public interface IOsobaRepository
    {
        public Task<List<Osoba>> GetAllOsobe();
        public Task<bool> UpdateOsobu(Osoba osoba);
        public Task<bool> DeleteOsobu(int id);
        public Task<int> CreateNovuOsobuInBase(Osoba osoba);
        public Task<Osoba> GetByIdOsobu(int id);
    }
}
