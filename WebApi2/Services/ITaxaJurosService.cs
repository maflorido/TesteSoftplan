using System.Threading.Tasks;

namespace WebApi2.Services
{
    public interface ITaxaJurosService
    {
        Task<double> ObterValorFinal(double? valorinicial, double? tempo);
    }
}
