using CalculoMatematico.DivisoresNumero.Api.Domain.Services;
using Microsoft.AspNetCore.Mvc;

namespace CalculoMatematico.DivisoresNumero.Api.Controllers
{
    [ApiController]
    [Route("api/divisoresnumero")]
    public class DivisoresNumeroController : ControllerBase
    {
        private readonly IDivisoresNumeroService _divisoresNumeroService;

        public DivisoresNumeroController(IDivisoresNumeroService divisoresNumeroService)
        {
            _divisoresNumeroService = divisoresNumeroService;
        }

        [HttpGet("ObterDivisoresDeUmNumeroNatural")]
        public IActionResult ObterDivisoresDeUmNumeroNatural(int numero)
        {
            return Ok(_divisoresNumeroService.ObterDivisoresDeUmNumeroNatural(numero));
        }
    }
}