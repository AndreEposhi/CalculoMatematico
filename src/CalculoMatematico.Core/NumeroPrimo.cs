using System.Collections.Generic;

namespace CalculoMatematico.Core
{
    public static class NumeroPrimo
    {
        public static IList<int> ObterNumerosPrimosDeUmNumeroNatural(int numero)
        {
            var numerosPrimos = new List<int>();

            if (numero <= 1)
                return numerosPrimos;

            for (int i = 2; i < numero; i++)
                if (numero % i == 0)
                    numerosPrimos.Add(numero);

            return numerosPrimos;
        }
    }
}