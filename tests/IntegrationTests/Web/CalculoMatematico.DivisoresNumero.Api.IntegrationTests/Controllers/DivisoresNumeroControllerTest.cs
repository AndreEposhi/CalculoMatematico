using CalculoMatematico.DivisoresNumero.Api.IntegrationTests.Configuration;
using System.Net.Http;
using Xunit;

namespace CalculoMatematico.DivisoresNumero.Api.IntegrationTests.Controllers
{
    public class DivisoresNumeroControllerTest
    {
        private BaseTestFixture _baseTestFixture;

        public DivisoresNumeroControllerTest()
        {
            _baseTestFixture = new BaseTestFixture();
        }

        [Theory]
        [InlineData(45, 200)]
        public void Deve_Obter_Divisores_De_Um_Numero_Natural_Com_Sucesso(int numero, int status)
        {
            // Act
            var responseResult = _baseTestFixture.Client.GetAsync($"/api/divisoresnumero/ObterDivisoresDeUmNumeroNatural?numero={numero}").Result;

            // Assert
            Assert.Equal(status, (int)responseResult.StatusCode);
        }
    }
}