using System.Threading.Tasks;

namespace WebApi2.Services
{
    public interface ITaxaJurosService
    {
        Task<double> GetTaxaJuros(double? valorinicial, double? tempo);
    }
}
