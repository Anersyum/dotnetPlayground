using DotNetPlayground.Classes;
using DotNetPlayground.Interfaces;
using DotNetPlayground.Servisi;
using IdentityModel;
using IdentityModel.Client;
// using IdentityServer4.Models;
// using IdentityServer4.Services;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace DotNetPlayground.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class Controller_Z1 : ControllerBase
    {
        //private SaberiDvaBrojaServis_Z1 KontrolerServis { get; set; }
        //private OduzmiPaSaberi_Z1 ServisPrviDrugi { get; set; }
        //public Controller_Z1(SaberiDvaBrojaServis_Z1 saberi, OduzmiPaSaberi_Z1 drugiServis)
        //{
        //    KontrolerServis = saberi;
        //    ServisPrviDrugi = drugiServis;
        //}

        [HttpGet("IdentityLogin")]
        public async Task<IActionResult> Login()
        {
            HttpClient client = new();

            var dico = await client.GetDiscoveryDocumentAsync("https://localhost:7095");

            if (dico.IsError) 
            {
                return BadRequest("dico");
            }
            
            //client.

            var tokenResponse = await client.RequestClientCredentialsTokenAsync(new ClientCredentialsTokenRequest
            {
                Address = dico.TokenEndpoint,
                ClientId = "client",
                ClientSecret = "secret",
                Scope = "api1",
                Parameters =
                {
                    { "test", "54545" },
                    { "UserName", "lskdjfklsdjfl" }
                },
                Resource = { "api1" },
            });

            if (tokenResponse.IsError)
            {
                return BadRequest("Tokne");
            }

            return Ok(tokenResponse.Json);
        }

        [HttpGet("IdentityLoginNoAuthorize")]
        public async Task<IActionResult> LoginNoAuthorize()
        {
            HttpClient client = new();

            var dico = await client.GetDiscoveryDocumentAsync("https://localhost:7095");

            if (dico.IsError)
            {
                return BadRequest("dico");
            }

            //client.

            var tokenResponse = await client.RequestClientCredentialsTokenAsync(new ClientCredentialsTokenRequest
            {
                Address = dico.TokenEndpoint,
                ClientId = "client",
                ClientSecret = "secret",
                Scope = "api1",
            });

            if (tokenResponse.IsError)
            {
                return BadRequest("Tokne");
            }

            return Ok(tokenResponse.Json);
        }


        [HttpGet("/HelloWorldGet")]
        public string HelloWorldGet()
        {
            return "HelloWorldGet";
        }

        [HttpGet("/HelloWorldBr")]
        public string HelloWorldBr(int broj)
        {
            return $"HelloWorld{broj}";
        }
        [HttpGet("/Saberi")]
        public int SaberiDrugoIme(int br1, int br2)
        {
            return br1 + br2;
        }
        [HttpPost("/HelloWorldPost")]
        public string HelloWorldPost()
        {
            return "HelloWorldPost";
        }
        [HttpPost("/HelloWorldPoruka")]
        public string HelloWorldPoruka(string poruka)
        {
            return $"HelloWorld {poruka}";
        }
        [HttpPost("/Sabiranje")]
        public int Sabiranje(int br1, int br2)
        {
            return br1 + br2;
        }
        [HttpPost("/SaberiMe")]
        public int SabiranjeKlasa(Saberi_Z1 brojevi)
        {
            return brojevi.broj1 + brojevi.broj2;
        }

        [HttpPost("/ServisSaberi")]
        public int ServisSaberi(Saberi_Z1 broj, [FromServices]IKalkulator_Z1 servisSaberi)
        {
            return servisSaberi.kalkulisi(broj);
        }

        //[HttpGet("/ServisSaberiKonstruktor")]
        //public int ServisSaberiKonstruktor(Saberi_Z1 broj)
        //{
        //    return KontrolerServis.Saberi(broj);
        //}

        //[HttpPost("/Servisi")]
        //public int DvaServisa(Saberi_Z1 broj)
        //{
        //    return ServisPrviDrugi.izracunj(broj);
        //}

    }
}
