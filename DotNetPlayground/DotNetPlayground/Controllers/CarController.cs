﻿using DotNetPlayground.Data;
using DotNetPlayground.Dto;
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
    //public async Task<ActionResult<Car>> Get()
    //{
    //    var cars = await _baza.Cars.ToListAsync();
    //    return Ok(cars);
    //}
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
    public async Task<IActionResult> CarUpdateAction([FromBody]CarDtoUpdate dtoUpdate, [FromServices] ICarRepository carRepository)
    {
        var car = await carRepository.GetById(dtoUpdate.Id); //repozitoriju saljem Id koji sam dobila

        if (car is null)
            return NotFound($"Auto s Id: {dtoUpdate.Id} nije pronađeno");

        /*Sve što je u dtopUpdate sada treba biti prebačeno na Car: */
        var date = DateTime.Now;
        Car newCar = new Car()
        {
            Marka = dtoUpdate.Marka,
            Tip = dtoUpdate.Tip,
            DatumKreiranja = date.ToShortDateString()
        };

        int dodijeliBaziNoveVrijednosti = await carRepository.KreiranjeAutauBazi(newCar);

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
