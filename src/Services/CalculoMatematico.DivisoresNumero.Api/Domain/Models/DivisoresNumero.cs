using System.Collections.Generic;

namespace CalculoMatematico.DivisoresNumero.Api.Domain.Models
{
    public class DivisoresNumero
    {
        private readonly List<int> _divisoresNumeros;
        private readonly List<int> _numerosPrimos;

        public int Numero { get; private set; }
        public IReadOnlyCollection<int> DivisoresNumeros => _divisoresNumeros;
        public IReadOnlyCollection<int> NumerosPrimos => _numerosPrimos;
        public DivisoresNumero(int numero)
        {
            Numero = numero;
            _divisoresNumeros = new List<int>();
            _numerosPrimos = new List<int>();
        }

        /// <summary>
        /// Adiciona os divisores de um número natural na propriedade
        /// </summary>
        /// <param name="numero">Número natural</param>
        /// <returns></returns>
        private IList<int> AdicionarDivisoresDeUmNumeroNatural(int numero)
        {
            var divisoresNumeros = Core.DivisoresNumero.ObterDivisoresDeUmNumeroNatural(numero);

            foreach (var divisor in divisoresNumeros)
                _divisoresNumeros.Add(divisor);

            return _divisoresNumeros;
        }
        /// <summary>
        /// Adicionar os números primos de um número natual na propriedade
        /// </summary>
        /// <param name="numero">Número natural</param>
        /// <param name="divisoresNumeros">Divisores do número natural</param>
        /// <returns></returns>
        private IList<int> AdicionarNumerosPrimosDeUmNumeroNatural(int numero, IList<int> divisoresNumeros)
        {
            var numerosPrimos = Core.NumeroPrimo.ObterNumerosPrimosDeUmNumeroNatural(numero, divisoresNumeros);

            foreach (var numeroPrimo in numerosPrimos)
                _numerosPrimos.Add(numeroPrimo);

            return _numerosPrimos;
        }
        public DivisoresNumero ObterDivisoresDeUmNumeroNatural(int numero)
        {
            var divisoresNumeros = AdicionarDivisoresDeUmNumeroNatural(numero);
            AdicionarNumerosPrimosDeUmNumeroNatural(numero, divisoresNumeros);

            return new DivisoresNumero(numero);
        }
    }
}