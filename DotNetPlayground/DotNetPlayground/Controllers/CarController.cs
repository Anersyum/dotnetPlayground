using DotNetPlayground.Data;
using DotNetPlayground.Dto.Car;
using DotNetPlayground.Interfaces;
using DotNetPlayground.Migrations;
using DotNetPlayground.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System.Security.Cryptography;
using System.Text;

namespace DotNetPlayground.Controllers;

[Route("api/[controller]")]
[ApiController]
public class CarController : ControllerBase
{
    /*
Napraviti API endpoint-e (rute) unutar ovog controller-a koji će omogućit da se prikažu
sva vozila koja su snimljena u bazu podataka, da se mogu kreirati nova vozila, da se mogu obrisati
i da se mogu editovati vozila.

Model vozila je isti kao što je na Angular strani. Prikaz informacija o kreiranom vozilu treba da bude isti kao
i kod tabelarnog prikaza u Angular-u. 
Npr.
Tip: Karavan,
Marka: MojaMarka
DatumKreiranja: 09.01.2023.

Dozvoljeno je sve resurse koristiti. :D
Za sva pitanja, obratite se najbližem lijenom... instruktoru... ili mentoru... ili kako god xD.

Have fun coding ^_^
*/
    private readonly Baza _baza;
    public CarController(Baza baza)
    {
        //moguće je unutar konstruktora pozvati i ICarRepositry, te onda ne moram unutar metoda pisati [FromServices]
        _baza = baza;
    }

    //[HttpGet] - 2 primjera "OK" funkcija
    [HttpGet("/cars")]
    /*public async Task<ActionResult<Car>> Get()
    {
        var cars = await _baza.Cars.ToListAsync();
        return Ok(cars);
    }*/
    public async Task<IActionResult> GetAllCarsAction([FromServices] ICarRepository carRepository)
    {
        var cars = await carRepository.GetAllCars();
        return Ok(cars);
    }

    [HttpPost("/car/create")]
    public async Task<IActionResult> CarCreateAction(CarDto carDto, [FromServices] ICarRepository carRepository)
    {
        var date = DateTime.Now;
        Car newCar = new Car()
        {
            Marka = carDto.Marka,
            Tip = carDto.Tip,
            DatumKreiranja = date.ToShortDateString()
        };

        int carId = await carRepository.KreiranjeAutauBazi(newCar);
        return CreatedAtAction(nameof(CarCreateAction), carId);
    }

    [HttpPut("/car/update")]
    public async Task<IActionResult> CarUpdateAction([FromBody] CarDtoUpdate dtoUpdate, [FromServices] ICarRepository carRepository)
    {
        var car = await carRepository.GetById(dtoUpdate.Id); //repozitoriju saljem Id koji sam dobila

        if (car is null)
            return NotFound($"Auto s Id: {dtoUpdate.Id} nije pronađeno");

        /*Sve što je u dtopUpdate sada treba biti prebačeno na Car: */
        var date = DateTime.Now;
        // Amor: ovaj dio bi išao nekako ovako
        /*
         Car newCar = new Car()
        {
            Marka = dtoUpdate.Marka,
            Tip = dtoUpdate.Tip,
            DatumKreiranja = date.ToShortDateString()
        };
        */
        car.Marka = dtoUpdate.Marka;
        car.Tip = dtoUpdate.Tip;
        car.DatumKreiranja = date.ToShortDateString();
        /*
          kad uradiš ovo, newCar ti više ne treba i onda možeš normalno uraditi update
          ako zamjeniš property-e dohvaćenog auta, onda nema potrebe da vršiš update jer se ništa nije promijenilo
         */

        /* Amor: što se tiče PUT i Swagger, Swagger prikazuje sve što ti je unutar DTO i to je ok
            Ok je imati ID za update jer kažeš "ok, automobil čiji je ID 14, njegova nova Marka je novaMarka 
            i njegov novi tip je noviTip. Tako da je ok imati ID i u Swagger-u jer ćeš ti svakako i sa PostMan-a ili
            sa Angulara slati ID na PUT rutu. Drugačije nećeš znati koji entity update-aš pa bi tu imala problem
            sa update-om. Tako da si dobro razumjela da je ok to polje imati unutar Swagger-a :D
         */

        /* 
         Amor: ovo ne treba u update jer ponovo kreiraš auto, a želiš ga samo da update-aš
         int dodijeliBaziNoveVrijednosti = await carRepository.KreiranjeAutauBazi(newCar);
        */
                await carRepository.Update(car);
        return Ok(dtoUpdate);
    }

    [HttpDelete("/car/delete/{carId}")]
    public async Task<IActionResult> CarDeleteAction(int carId, [FromServices] ICarRepository carRepository)
    {
        var carBaseId = await carRepository.DeleteById(carId);
        return Ok();
    }
}
