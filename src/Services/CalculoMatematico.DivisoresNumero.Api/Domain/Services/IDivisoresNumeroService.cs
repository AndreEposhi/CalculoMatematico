using CalculoMatematico.DivisoresNumero.Api.ViewModels;

namespace CalculoMatematico.DivisoresNumero.Api.Domain.Services
{
    public interface IDivisoresNumeroService
    {
        /// <summary>
        /// Obtem os divisores e os números primos de um número natural
        /// </summary>
        /// <param name="numero">Número natural</param>
        /// <returns></returns>
        DivisoresNumeroViewModel ObterDivisoresDeUmNumeroNatural(int numero);
    }
}