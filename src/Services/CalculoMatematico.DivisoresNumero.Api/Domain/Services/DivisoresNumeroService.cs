using CalculoMatematico.DivisoresNumero.Api.Domain.Exceptions;
using CalculoMatematico.DivisoresNumero.Api.ViewModels;
using System.Linq;

namespace CalculoMatematico.DivisoresNumero.Api.Domain.Services
{
    public class DivisoresNumeroService : IDivisoresNumeroService
    {
        public DivisoresNumeroViewModel ObterDivisoresDeUmNumeroNatural(int numero)
        {
            if (numero <= 1)
                throw new DomainException($"O número informado {numero} é inválido");

            var divisoresNumero = new Models.DivisoresNumero(numero);
            divisoresNumero.ObterDivisoresDeUmNumeroNatural(numero);

            return new DivisoresNumeroViewModel
            {
                Numero = divisoresNumero.Numero,
                DivisoresNumeros = divisoresNumero.DivisoresNumeros.ToList(),
                NumerosPrimos = divisoresNumero.NumerosPrimos.ToList()
            };
        }
    }
}