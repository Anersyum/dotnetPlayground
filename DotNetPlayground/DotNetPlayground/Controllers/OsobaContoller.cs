using DotNetPlayground.Data;
using DotNetPlayground.Dto.Osoba;
using DotNetPlayground.Interfaces;
using DotNetPlayground.Models;
using DotNetPlayground.Repositories;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System.Security.Cryptography.Xml;

namespace DotNetPlayground.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class OsobaContoller : ControllerBase
    {
        private readonly IOsobaRepository osobaRepository;

        public OsobaContoller(IOsobaRepository osobaRepository)
        {
            this.osobaRepository = osobaRepository;
        }
        [HttpGet("/osobe")]
        public async Task<IActionResult> GetOsobeAction()
        {
            var osobe = await osobaRepository.GetAllOsobe();
            return Ok(osobe);
        }
        [HttpGet("/osoba")]
        public async Task<IActionResult> GetOsobaByIdAction([FromServices] IOsobaRepository osobaRepository,
            int id)
        {
            var osobe = await osobaRepository.GetByIdOsobu(id);

            if (osobe==null)
            {
                return NotFound($"Nema osobe s id: {id}");
            }

            return Ok(osobe);
        }
        [HttpPost("/osoba")]
        public async Task<IActionResult> CreateOsobaAction([FromServices] IOsobaRepository osobaRepository,
           OsobaCreateDto osobaCreateDto)
        {
            Osoba newOsoba = new Osoba()
            {
                Ime = osobaCreateDto.Ime,
                Prezime = osobaCreateDto.Prezime,
                Email = osobaCreateDto.Email,
                DatumRodjenja = osobaCreateDto.DatumRodjenja,
                DatumKreiranja = DateTime.Now, //Swgger: ne radi update ovog property
                NajdrazaHrana = osobaCreateDto.NajdrazaHrana
            };
            int osobaId = await osobaRepository.CreateNovuOsobuInBase(newOsoba);
            return CreatedAtAction(nameof(CreateOsobaAction), osobaId);
        }

        [HttpPut("/osoba")]
        public async Task<IActionResult> UpdateOsobaAction(OsobaUpdateDto osobaDto,
            [FromServices] IOsobaRepository osobaRepository)
        {
            var osoba = await osobaRepository.GetByIdOsobu(osobaDto.Id);
            if (osoba is null)
                return NotFound($"Nema osobe s id: {osobaDto.Id}");

            osoba.Ime = osobaDto.Ime;
            osoba.Prezime = osobaDto.Prezime;
            osoba.Email = osobaDto.Email;
            osoba.DatumRodjenja = osobaDto.DatumRodjenja;

            await osobaRepository.UpdateOsobu(osoba);
            return Ok(osobaDto);
        }

        [HttpPut("/osoba/{osobaId}")]
        public async Task<IActionResult> UpdateOsobaAction(OsobaUpdateDto osobaDto,
            [FromServices] IOsobaRepository osobaRepository, int osobaId)
        {
            var osoba = await osobaRepository.GetByIdOsobu(osobaId);
            if (osoba is null)
                return NotFound($"Nema osobe s id: {osobaId}");

            osoba.Ime = osobaDto.Ime;
            osoba.Prezime = osobaDto.Prezime;
            osoba.Email = osobaDto.Email;
            osoba.DatumRodjenja = osobaDto.DatumRodjenja;

            await osobaRepository.UpdateOsobu(osoba);
            return Ok(osobaDto);
        }
        [HttpDelete("/osoba/{osobaId}")]
        public async Task<IActionResult> DeleteOsobaAction(int osobaId,
            [FromServices] IOsobaRepository osobaRepository)
        {
            await osobaRepository.DeleteOsobu(osobaId);
            return Ok();
        }
    }
}
