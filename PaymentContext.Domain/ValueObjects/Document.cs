using Flunt.Validations;
using PaymentContext.Domain.Enums;
using PaymentContext.Shared.ValueObjects;

namespace PaymentContext.Domain.ValueObjects
{
    public class Document : ValueObject
    {
        public Document(string number, EDocumentType type)
        {
            this.Number = number;
            this.Type = type;

            AddNotifications(new Contract()
                .Requires()
                .IsTrue(this.Validate(), "Document.Number", "Documento inválido"));
        }
        public string Number { get; private set; }
        public EDocumentType Type { get; private set; }

        private bool Validate()
        {
            if (this.Type == EDocumentType.CNPJ && Number.Length == 14)
                return true;
            if (this.Type == EDocumentType.CPF && Number.Length == 11)
                return true;

            return false;
        }
    }
}
