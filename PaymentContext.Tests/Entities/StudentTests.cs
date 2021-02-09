using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using PaymentContext.Domain.Entities;
using PaymentContext.Domain.Enums;
using PaymentContext.Domain.ValueObjects;

namespace PaymentContext.Tests
{
    [TestClass]
    public class StudentTests
    {

        private readonly Document _document;
        private readonly Address _address;
        private readonly Student _student;
        private readonly Email _email;
        private readonly Subscription _subscription;

        public StudentTests()
        {
            var name = new Name("Joao", "Silva");
            this._document = new Document("11122233345", EDocumentType.CPF);
            this._email = new Email("email@email.com");
            this._address = new Address("Av. Aclimacao", "102", "Brasil", "SP", "São José dos Campos", "Jd Alvorada", "12240570");
            this._student = new Student(name, _document, _email);
            this._subscription = new Subscription(null);
        }

        [TestMethod]
        public void ShouldREturnErrorWhenHadActiveSubscription()
        {
            var payment = new PayPalPayment("12345678", DateTime.Now, DateTime.Now, 100.15M, 0, "Jose da Silva", this._document, this._address, this._email);
            this._subscription.AddPayment(payment);
            this._student.AddSubscription(this._subscription);
            this._student.AddSubscription(this._subscription);

            Assert.IsTrue(_student.Invalid);
        }

        [TestMethod]
        public void ShouldREturnErrorWhenHadNoPayment()
        {
            //var payment = new PayPalPayment("12345678", DateTime.Now, DateTime.Now, 100.15M, 0, "Jose da Silva", this._document, this._address, this._email);
            //this._subscription.AddPayment(payment);
            this._student.AddSubscription(this._subscription);
            Assert.IsTrue(_student.Invalid);
        }
    }
}
