using Flunt.Validations;
using PaymentContext.Shared.ValueObjects;

namespace PaymentContext.Domain.ValueObjects
{
    public class Address : ValueObject
    {
        public Address(string street, string number, string country, string state, string city, string neighborhood, string zipCode)
        {
            this.Street = street;
            this.Number = number;
            this.Country = country;
            this.State = state;
            this.City = city;
            this.Neighborhood = neighborhood;
            this.ZipCode = zipCode;

            AddNotifications(new Contract()
                .Requires()
                .HasMinLen(this.Street, 3, "Address.Street", "Logradouro deve conter pelo menos 3 caracteres")
                .HasMaxLen(this.Street, 60, "Address.Street", "Logradouro deve conter até 60 caracteres"));
        }

        public string Street { get; private set; }
        public string Number { get; private set; }
        public string Country { get; private set; }
        public string State { get; private set; }
        public string City { get; private set; }
        public string Neighborhood { get; private set; }
        public string ZipCode { get; private set; }
    }
}
