using System;
using System.Globalization;
using System.Net.Http;
using System.Threading.Tasks;
using WebApi2.Extensions;

namespace WebApi2.Services
{
    public class TaxaJurosService: ITaxaJurosService
    {        
        private const string _apiUrl = "https://localhost:44379/taxaJuros";
        public async Task<double> ObterValorFinal(double? valorinicial, double? tempo)
        {
            if (!valorinicial.HasValue || !tempo.HasValue)
                return 0;

            double taxaJuros = await ObterTaxaJuros();
            
            return (valorinicial.Value * Math.Pow(1 + taxaJuros, tempo.Value)).Truncate(2);
        }

        /// <summary>
        /// o método é virtual devido ao fato de precisar ser mocado no teste.
        /// poderia ser um método privado e usar o fake para mocar, mas preferi fazer assim.
        /// </summary>
        /// <returns></returns>
        public virtual async Task<double> ObterTaxaJuros()
        {
            using (HttpClient client = new HttpClient())
            {
                HttpResponseMessage response = await client.GetAsync(_apiUrl);
                if (response.IsSuccessStatusCode)
                {
                    return double.Parse(response.Content.ReadAsStringAsync().Result, CultureInfo.InvariantCulture);                    
                }
                else
                    throw new Exception(response.Content.ReadAsStringAsync().Result);
            }
        }
    }
}