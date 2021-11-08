using CalculoMatematico.Web.Models;
using CalculoMatematico.Web.Services;
using Microsoft.AspNetCore.Mvc;

namespace CalculoMatematico.Web.Controllers
{
    public class HomeController : Controller
    {
        private readonly IDivisoresNumeroService _divisoresNumeroService;
        public HomeController(IDivisoresNumeroService divisoresNumeroService)
        {
            _divisoresNumeroService = divisoresNumeroService;
        }

        public IActionResult Index(DivisoresNumeroViewModel divisor)
        {
            return View(divisor);
        }

        [HttpPost]
        public IActionResult ObterDivisoresDeUmNumeroNatural(DivisoresNumeroViewModel divisor)
        {
            var divisoresNumeros = _divisoresNumeroService.ObterDivisoresDeUmNumeroNatural(divisor.Numero);

            return RedirectToAction("Index", divisoresNumeros);
        }
    }
}