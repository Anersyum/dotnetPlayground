using DotNetPlayground.Models;

namespace DotNetPlayground.Interfaces
{
    public interface ICarRepository
    {
        public Task<int> KreiranjeAutauBazi(Car car);
        public Task<Car> GetById(int id);
        public Task<List<Car>> GetAllCars(); //get
        public Task<bool> Update(Car car); //post
        public Task<bool> DeleteById(int id); //delete

        //Od Microsofta "jednostavniji" primjeri potrebnih funkcija
        //IEnumerable<Car> GetAllCars();
        //Car GetCar(int id);
        //Car Add(Car item);
        //void Remove(int id);
        //bool Update(Car item);
    }
}
