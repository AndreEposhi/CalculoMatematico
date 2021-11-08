namespace CalculoMatematico.Web.Services
{
    public interface IDivisoresNumeroService
    {
        /// <summary>
        /// Obtem os divisores e números primos de um número natural
        /// </summary>
        /// <param name="numero">Número natural</param>
        /// <returns></returns>
        Models.DivisoresNumeroViewModel ObterDivisoresDeUmNumeroNatural(int numero);
    }
}