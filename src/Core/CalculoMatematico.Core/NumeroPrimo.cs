using System.Collections.Generic;
using System.Linq;

namespace CalculoMatematico.Core
{
    public static class NumeroPrimo
    {
        public static IList<int> ObterNumerosPrimosDeUmNumeroNatural(int numero, IList<int> divisoresNumeros)
        {
            var numerosPrimos = new List<int>();

            if (numero <= 1 || !divisoresNumeros.Any())
                return numerosPrimos;

            for (int num = 1; num <= numero; num++)
            {
                int contador = 0;

                for (int cont = 1; cont <= num; cont++)
                    if (num % cont == 0)
                        contador++;

                if (contador == 2)
                    numerosPrimos.Add(num);
            }

            numerosPrimos = numerosPrimos.Intersect(divisoresNumeros).ToList();

            return numerosPrimos;
        }
    }
}