using DotNetPlayground.Data;
using DotNetPlayground.Interfaces;
using DotNetPlayground.Models;
using Microsoft.EntityFrameworkCore;
using System.Reflection.Metadata.Ecma335;

namespace DotNetPlayground.Repositories
{
    public class CarRepository : ICarRepository
    {
        private readonly Baza _baza;
        /*private List<Car> _cars = new List<Car>();
        private int _nextId = 4;*/

        public CarRepository(Baza baza)
        {
            _baza = baza;
            /*ne treba: _cars = _baza.Cars.ToList();*/
        }

        public async Task<int> KreiranjeAutauBazi(Car car)
        {
            int carId = 0;
            var kreiranoVozilo = await _baza.Cars.AddAsync(car);
            await _baza.SaveChangesAsync();
            carId = kreiranoVozilo.Entity.Id;
            return carId;
        }
        public async Task<Car> GetById(int id)
        {
            return await _baza.Cars.FirstOrDefaultAsync(x => x.Id == id);
        }
        public async Task<List<Car>> GetAllCars()
        {
            var cars = await _baza.Cars.ToListAsync();
            return cars;
        }
        public async Task<bool> DeleteById(int id)
        {
            var car = await GetById(id);

            //nema auta:
            if (car is null)
                return false;

            //pronađen auto
            _baza.Cars.Remove(car);
            await _baza.SaveChangesAsync();
            return true;
        }
        public async Task<bool> Update(Car car)
        {
            /*
             u ovoj metodi dobivam studenta kojeg sam izmijenila (u contolleru)
            update-ujem unos i spašavam:
             */
            _baza.Cars.Update(car);
            await _baza.SaveChangesAsync();

            return true;
        }

        //Od Microsofta "jednostavniji" primjeri potrebnih funkcija - implementacija:

        /*
        IEnumerable<Car> ICarRepository.GetAllCars()
        {
            return _baza.Cars.ToList();
        }
        */

        /*
        public Car GetCar(int id)
        {
            return _cars.Find(x => x.Id == id);
        }
        */

        /*
        public Car Add(Car item)
        {
            if (item == null)
            {
                throw new ArgumentNullException("item");
            }
            item.Id = _nextId++;
            _cars.Add(item);
            return item;
        }
        */

        /* 
         public void Remove(int id)
         {
             _cars.RemoveAll(x => x.Id == id);
         }
        */

        /* 
         public bool Update(Car item)
         {
             if (item == null)
             {
                 throw new ArgumentNullException("item");
             }
             int index = _cars.FindIndex(x => x.Id == item.Id);
             if (index == -1)
             {
                 return false;
             }
             _cars.RemoveAt(index);
             _cars.Add(item);
             return true;
         }
        */
    }

    /*
    //sealed - ova klasa se ne može dalje nasljeđivati
    public class Proba : CarRepository // ne može naslijediti klasu CarRepository jer je ona sealed
    {

    }
    */
}
