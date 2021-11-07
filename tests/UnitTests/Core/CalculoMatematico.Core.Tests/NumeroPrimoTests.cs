using System.Collections.Generic;
using System.Linq;
using Xunit;

namespace CalculoMatematico.Core.Tests
{
    public class NumeroPrimoTests
    {
        public static IEnumerable<object[]> SourceSucess()
        {
            yield return new object[] { 15, new List<int> { 1, 3, 5, 15 } };
            yield return new object[] { 45, new List<int> { 1, 3, 5, 9, 15, 45 } };
            yield return new object[] { 60, new List<int> { 1, 2, 3, 4, 5, 6, 10, 12, 15, 20, 30, 60 } };
            yield return new object[] { 70, new List<int> { 1, 2, 5, 7, 10, 14, 35, 70 } };
            yield return new object[] { 84, new List<int> { 1, 2, 3, 4, 6, 7, 12, 14, 21, 28, 42, 84 } };
        }
        public static IEnumerable<object[]> SourceFail()
        {
            yield return new object[] { -15, new List<int> { 1, 3, 5, 15 } };
            yield return new object[] { -45, new List<int> { 1, 3, 5, 9, 15, 45 } };
            yield return new object[] { -60, new List<int> { 1, 2, 3, 4, 5, 6, 10, 12, 15, 20, 30, 60 } };
            yield return new object[] { -70, new List<int> { 1, 2, 5, 7, 10, 14, 35, 70 } };
            yield return new object[] { -84, new List<int> { 1, 2, 3, 4, 6, 7, 12, 14, 21, 28, 42, 84 } };
        }
        [Theory]
        [MemberData(nameof(SourceSucess))]
        public void Deve_Obter_Numeros_Primos_De_Um_Numero_Natural(int numero, IList<int> divisoresNumeros)
        {
            // Act
            var numerosPrimos = NumeroPrimo.ObterNumerosPrimosDeUmNumeroNatural(numero, divisoresNumeros);

            // Assert
            Assert.True(numerosPrimos.Any());
        }

        [Theory]
        [MemberData(nameof(SourceFail))]
        public void Nao_Deve_Obter_Numeros_Primos_De_Um_Numero_Natural(int numero, IList<int> divisoresNumeros)
        {
            // Act
            var numerosPrimos = NumeroPrimo.ObterNumerosPrimosDeUmNumeroNatural(numero, divisoresNumeros);

            // Assert
            Assert.True(!numerosPrimos.Any());
        }
    }
}