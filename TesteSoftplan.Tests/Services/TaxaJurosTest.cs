using Moq;
using NUnit.Framework;
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
            Mock<TaxaJurosService> mock = new Mock<TaxaJurosService>();
            mock.Setup(x => x.ObterTaxaJuros()).ReturnsAsync(0.01);
            
            var retorno = mock.Object.ObterValorFinal(100, 2).Result;
            Assert.AreEqual(102.01, retorno);
        }

        [Test]
        public void TaxaJuros_Get2()
        {
            Mock<TaxaJurosService> mock = new Mock<TaxaJurosService>();
            mock.Setup(x => x.ObterTaxaJuros()).ReturnsAsync(0.01);

            var retorno = mock.Object.ObterValorFinal(1000, 3).Result;
            Assert.AreEqual(1030.30, retorno);
        }

        [Test]
        public void TaxaJuros_Get3()
        {
            Mock<TaxaJurosService> mock = new Mock<TaxaJurosService>();
            mock.Setup(x => x.ObterTaxaJuros()).ReturnsAsync(0.01);

            var retorno = mock.Object.ObterValorFinal(100, 5).Result;
            Assert.AreEqual(105.10, retorno);
        }
    }
}