using Flunt.Validations;
using PaymentContext.Shared.ValueObjects;

namespace PaymentContext.Domain.ValueObjects
{
    public class Name : ValueObject
    {
        public Name(string firstName, string lastName)
        {
            this.FirstName = firstName;
            this.LastName = lastName;

            AddNotifications(new Contract()
                .Requires()
                .HasMinLen(this.FirstName, 3, "Name.Firstname", "Nome deve conter pelo menos 3 caracteres")
                .HasMaxLen(this.FirstName, 60, "Name.Firstname", "Nome deve conter até 60 caracteres")
                .HasMinLen(this.LastName, 3, "Name.LastName", "Sobrenome deve conter pelo menos 3 caracteres")
                .HasMaxLen(this.LastName, 60, "Name.LastName", "Nome deve conter até 60 caracteres"));
        }

        public string FirstName { get; private set; }
        public string LastName { get; private set; }

        public override string ToString()
        {
            return $"{FirstName} {LastName}".Trim();
        }
    }
}
