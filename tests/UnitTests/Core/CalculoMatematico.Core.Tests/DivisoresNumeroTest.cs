using System.Linq;
using Xunit;

namespace CalculoMatematico.Core.Tests
{
    public class DivisoresNumeroTest
    {
        [Theory]
        [InlineData(45)]
        [InlineData(60)]
        [InlineData(70)]
        [InlineData(100)]
        [InlineData(120)]
        public void Deve_Obter_Divisores_De_Um_Numero_Natural(int numero)
        {
            // Act
            var divisoresNumeros = DivisoresNumero.ObterDivisoresDeUmNumeroNatural(numero);

            // Assert
            Assert.True(divisoresNumeros.Any());
        }

        [Theory]
        [InlineData(0)]
        [InlineData(-1)]
        [InlineData(-5)]
        [InlineData(-10)]
        [InlineData(-20)]
        public void Nao_Deve_Obter_Divisores_De_Um_Numero_Natural(int numero)
        {
            // Act
            var divisoresNumeros = DivisoresNumero.ObterDivisoresDeUmNumeroNatural(numero);

            // Assert
            Assert.True(!divisoresNumeros.Any());
        }
    }
}