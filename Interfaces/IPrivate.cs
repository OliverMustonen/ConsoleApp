
namespace ConsoleApp.Interfaces;

public interface IPrivate : ICustomer
{
    string FirstName { get; set; }
    string LastName { get; set; }
}