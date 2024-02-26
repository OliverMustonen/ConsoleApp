

using ConsoleApp.Interfaces;

namespace ConsoleApp.Models;

public class Company : ICustomer, ICompany
{
    public string CompanyName { get; set; } = null!;
    public Guid CustomerNumber { get; set; }
    public bool IsVerified { get; set; }
}
