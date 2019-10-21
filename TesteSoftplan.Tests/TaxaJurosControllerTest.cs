using NUnit.Framework;
using Web.Controllers;

namespace TesteSoftplan.Tests
{
     [TestFixture]
    public class TaxaJurosControllerTest
    {
        
        [Test]
        public void TaxaJuros_Get()
        {
            TaxaJurosController controller = new TaxaJurosController();
            var retorno = controller.Get();
            Assert.AreEqual(0.01M, retorno);
        }
    }
}