using PaymentContext.Domain.Entities;
using PaymentContext.Domain.Repositories;

namespace PaymentContext.Tests.Mocks
{
    public class FakeStudentRepository : IStudentRepository
    {
        void IStudentRepository.CreateSubscription(Student student)
        {

        }

        bool IStudentRepository.DocumentExists(string document)
        {
            if (document.Equals("11111111111"))
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        bool IStudentRepository.EmailExists(string email)
        {
            if (email.Equals("email@email.com"))
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
