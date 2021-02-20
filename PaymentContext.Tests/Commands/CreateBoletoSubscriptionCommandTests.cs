using Microsoft.VisualStudio.TestTools.UnitTesting;
using PaymentContext.Domain.Commands;
namespace PaymentContext.Tests
{
    [TestClass]
    public class CreateBoletoSubscriptionCommandTests
    {
        // Red, Green, Refactor
        [TestMethod]
        public void SouldReturnErrorWhenNameIsInvalid()
        {
            var command = new CreateBoletoSubscriptionCommand();
            command.FirstName = "Joao";

            command.Validate();
            Assert.AreEqual(false, command.Valid);
        }
    }
}
