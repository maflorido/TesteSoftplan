using System.Net.Http;
namespace WebApi2.Services
{
    public class TaxaJurosService
    {
        private const string _apiUrl = string.Concat("http://localhost:5001/taxaJuros");
        public async Task<decimal> GetTaxaJuros()
        {
            using(HttpClient client = new HttpClient())
            {
                HttpResponseMessage response = await client.GetAsync(_apiUrl);
                

                
            }
        }
    }
}