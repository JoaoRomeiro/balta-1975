using Microsoft.VisualStudio.TestTools.UnitTesting;
using PaymentContext.Domain.ValueObjects;

namespace PaymentContext.Tests
{
    [TestClass]
    public class DocumentTests
    {
        // Red, Green, Refactor
        [TestMethod]
        [DataTestMethod]
        [DataRow("3511159407")]
        [DataRow("623346950")]
        [DataRow("88611108")]
        [DataRow("4552911")]
        [DataRow("798644")]
        public void SouldReturnErrorWhenCNPJIsInvalid(string cnpj)
        {
            var doc = new Document(cnpj, Domain.Enums.EDocumentType.CNPJ);
            Assert.IsTrue(doc.Invalid);
        }

        [TestMethod]
        [DataTestMethod]
        [DataRow("44202935000126")]
        [DataRow("03460387000157")]
        [DataRow("02471582000110")]
        [DataRow("93518752000120")]
        [DataRow("00226461000187")]
        public void SouldReturnSuccessWhenCNPJIsValid(string cnpj)
        {
            var doc = new Document(cnpj, Domain.Enums.EDocumentType.CNPJ);
            Assert.IsTrue(doc.Valid);
        }

        [TestMethod]
        [DataTestMethod]
        [DataRow("3511159407")]
        [DataRow("623346950")]
        [DataRow("88611108")]
        [DataRow("4552911")]
        [DataRow("798644")]
        public void SouldReturnErrorWhenCPFIsInvalid(string cpf)
        {
            var doc = new Document(cpf, Domain.Enums.EDocumentType.CPF);
            Assert.IsTrue(doc.Invalid);
        }

        [TestMethod]
        [DataTestMethod]
        [DataRow("35111594078")]
        [DataRow("62334695033")]
        [DataRow("88611108000")]
        [DataRow("45529110070")]
        [DataRow("79864459040")]
        public void SouldReturnSuccessWhenCPFIsValid(string cpf)
        {
            var doc = new Document(cpf, Domain.Enums.EDocumentType.CPF);
            Assert.IsTrue(doc.Valid);
        }
    }
}
