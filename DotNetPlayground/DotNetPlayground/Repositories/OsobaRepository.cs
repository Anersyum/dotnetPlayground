using DotNetPlayground.Data;
using DotNetPlayground.Interfaces;
using DotNetPlayground.Models;
using Microsoft.EntityFrameworkCore;

namespace DotNetPlayground.Repositories
{
    public class OsobaRepository : IOsobaRepository
    {
        protected readonly Baza _baza;

        public OsobaRepository(Baza baza)
        {
            this._baza = baza;
        }

        public async Task<int> CreateNovuOsobuInBase(Osoba osoba)
        {
            int id = 0;
            var kreiranaOsoba=await _baza.Osobe.AddAsync(osoba);
            await _baza.SaveChangesAsync();
            id = kreiranaOsoba.Entity.Id;
            return id;
        }

        public async Task<bool> DeleteOsobu(int id)
        {
            var osobaId = await GetByIdOsobu(id);

            if (osobaId == null)
                return false;

            _baza.Osobe.Remove(osobaId);
            await _baza.SaveChangesAsync();
            return true;
        }

        public async Task<List<Osoba>> GetAllOsobe()
        {
            var osobe = await _baza.Osobe.ToListAsync();
            return osobe;
        }

        public async Task<Osoba> GetByIdOsobu(int id)
        {
            return await _baza.Osobe.FirstOrDefaultAsync(o => o.Id == id);
        }

        public async Task<bool> UpdateOsobu(Osoba osoba)
        {
            if (osoba.Id == null)
                return false;

            _baza.Osobe.Update(osoba);
            await _baza.SaveChangesAsync();
            return true;
        }
    }
}
