using Moq;
using NUnit.Framework;
using System.Threading.Tasks;
using WebApi2.Services;

namespace TesteSoftplan.Tests
{
    [TestFixture]
    public class TaxaJurosTest
    {
        
        [Test]
        public void TaxaJuros_Get_NullValues()
        {
            TaxaJurosService svc = new TaxaJurosService();
            var retorno = svc.ObterValorFinal(null, null).Result;
            Assert.AreEqual(0, retorno);
        }

        [Test]
        public void TaxaJuros_Get()
        {
            TaxaJurosService svc = new TaxaJurosService();
            Mock<TaxaJurosService> mock = new Mock<TaxaJurosService>();
            mock.Setup(x => x.ObterTaxaJuros()).Returns(Task.FromResult(0.01));
            
            var retorno = svc.ObterValorFinal(null, null).Result;
            Assert.AreEqual(0, retorno);
        }
    }
}