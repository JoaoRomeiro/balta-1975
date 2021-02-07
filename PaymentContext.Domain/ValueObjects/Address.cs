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
