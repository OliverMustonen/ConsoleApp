
using ConsoleApp.Interfaces;

namespace ConsoleApp.Models;

public class Private : IPrivate
{
    public string FirstName { get; set; } = null!;
    public string LastName { get; set; } = null!;
    public Guid CustomerNumber { get; set; }
    public bool IsVerified { get; set; }
}
