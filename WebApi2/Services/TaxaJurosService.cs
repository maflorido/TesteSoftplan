using System;
using System.Net.Http;
using System.Threading.Tasks;

namespace WebApi2.Services
{
    public class TaxaJurosService: ITaxaJurosService
    {        
        private const string _apiUrl = "https://localhost:44379/taxaJuros";
        public async Task<double> GetTaxaJuros(double? valorinicial, double? tempo)
        {
            if (!valorinicial.HasValue || !tempo.HasValue)
                return 0;

            double taxaJuros = await ObterTaxaJuros();
            return Math.Pow(valorinicial.Value * (1 + taxaJuros), tempo.Value);
        }

        private async Task<double> ObterTaxaJuros()
        {
            using (HttpClient client = new HttpClient())
            {
                HttpResponseMessage response = await client.GetAsync(_apiUrl);
                if (response.IsSuccessStatusCode)
                {
                    return double.Parse(response.Content.ReadAsStringAsync().Result);                    
                }
                else
                    throw new Exception(response.Content.ReadAsStringAsync().Result);
            }
        }
    }
}