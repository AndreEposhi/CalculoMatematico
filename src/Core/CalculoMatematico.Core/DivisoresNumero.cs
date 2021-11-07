using System.Collections.Generic;

namespace CalculoMatematico.Core
{
    public static class DivisoresNumero
    {
        public static IList<int> ObterDivisoresDeUmNumeroNatural(int numero)
        {
            var divisoresNumeros = new List<int>();

            if (numero <= 1)
                return divisoresNumeros;

            for (int num = 1; num <= numero; num++)
                if (numero % num == 0)
                    divisoresNumeros.Add(num);

            return divisoresNumeros;
        }
    }
}