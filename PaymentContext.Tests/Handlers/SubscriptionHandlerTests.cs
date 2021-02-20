using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using PaymentContext.Domain.Commands;
using PaymentContext.Domain.Enums;
using PaymentContext.Domain.Handlers;
using PaymentContext.Tests.Mocks;

namespace PaymentContext.Tests
{
    [TestClass]
    public class SubscriptionHandlerTests
    {
        // Red, Green, Refactor
        [TestMethod]
        public void SouldReturnErrorWhenDocumentExists()
        {
            var handler = new SubscriptionHandler(new FakeStudentRepository(), new FakeEmailService());
            var command = new CreateBoletoSubscriptionCommand();
            command.FirstName = "João";
            command.LastName = "Romeiro";
            command.Document = "11111111111";
            command.Email = "email@email.comc";
            command.BarCode = "123";
            command.BoletoNumber = "456";
            command.PaymentNumber = "789";
            command.PaidDate = DateTime.Now;
            command.ExpireDate = DateTime.Now.AddMonths(1);
            command.Total = 100;
            command.TotalPaid = 100;
            command.Payer = "João Romeiro";
            command.PayerDocument = "11111111111";
            command.PayerDocumentType = EDocumentType.CPF;
            command.PayerEmail = "email@email.comc";
            command.Street = "Av. Aclimação";
            command.Number = "102";
            command.Neighborhood = "Jd. Alvorada";
            command.City = "São José dos Campos";
            command.State = "SP";
            command.Country = "Brasil";
            command.ZipCode = "1224050";

            handler.Handle(command);
            Assert.AreEqual(false, command.Valid);
        }
    }
}
