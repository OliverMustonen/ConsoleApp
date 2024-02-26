namespace ConsoleApp.Interfaces;

public interface ICustomer
{
    Guid CustomerNumber { get; set; }
    bool IsVerified { get; set; }
}



