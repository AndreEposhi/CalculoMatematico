using CalculoMatematico.Web.Configurations;
using CalculoMatematico.Web.Models;
using Newtonsoft.Json;
using System;
using System.Net.Http;

namespace CalculoMatematico.Web.Services
{
    public class DivisoresNumeroService : IDivisoresNumeroService
    {
        private readonly HttpClient _httpClient;
        private readonly IApiConfiguration _apiConfiguration;

        public DivisoresNumeroService(HttpClient httpClient, IApiConfiguration apiConfiguration)
        {
            _httpClient = httpClient;
            _httpClient.BaseAddress = new Uri(apiConfiguration.DivisoresNumeroUrl);
        }

        public DivisoresNumeroViewModel ObterDivisoresDeUmNumeroNatural(int numero)
        {
            var responseReult = _httpClient.GetAsync($"/api/divisoresnumero/ObterDivisoresDeUmNumeroNatural?numero={numero}").Result;

            if (responseReult.IsSuccessStatusCode)
            {
                var jsonResult = responseReult.Content.ReadAsStringAsync().Result;
                return JsonConvert.DeserializeObject<DivisoresNumeroViewModel>(jsonResult);
            }

            return null;
        }
    }
}