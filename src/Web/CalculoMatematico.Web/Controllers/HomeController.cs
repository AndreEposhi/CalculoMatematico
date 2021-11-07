using CalculoMatematico.Web.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;

namespace CalculoMatematico.Web.Controllers
{
    public class HomeController : Controller
    {
        public HomeController()
        {
        }

        public IActionResult Index(DivisorViewModel divisor)
        {
            return View(divisor);
        }

        [HttpPost]
        public IActionResult ObterDivisoresDeUmNumeroNatural(DivisorViewModel divisor)
        {
            var divisores = Core.DivisoresNumero.ObterDivisoresDeUmNumeroNatural(divisor.Numero);
            divisor.Divisores = divisores;
            divisor.NumerosPrimos = Core.NumeroPrimo.ObterNumerosPrimosDeUmNumeroNatural(divisor.Numero, divisores);
            return RedirectToAction("Index", divisor);
        }
    }
}
