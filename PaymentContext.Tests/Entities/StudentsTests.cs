using Microsoft.VisualStudio.TestTools.UnitTesting;
using PaymentContext.Domain.ValueObjects;

namespace PaymentContext.Tests
{
    [TestClass]
    public class StudentTests
    {
        [TestMethod]
        public void AdcionarAssinatura()
        {
            //var subscription = new Subscription(null);
            //var student = new Student("Joao", "Romeiro", "326915400", "j.romeiro@live.com");
            //student.AddSubscription(subscription);

            var name = new Name("Joao", "Romeiro");

            foreach (var notification in name.Notifications)
            {

            }
        }
    }
}
