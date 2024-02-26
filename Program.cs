
using ConsoleApp.Interfaces;
using ConsoleApp.Models;
using Newtonsoft.Json;

var customers = new List<ICustomer>()
{
    new Private { CustomerNumber = Guid.NewGuid(), FirstName = "Oliver", LastName = "Mustonen"},
    new Company { CustomerNumber = Guid.NewGuid(), CompanyName = "EPN Sverige AB" }
                
};

string json = JsonConvert.SerializeObject(customers, new JsonSerializerSettings
{
    Formatting = Formatting.Indented,
    TypeNameHandling = TypeNameHandling.Auto
});




Console.WriteLine(json);
Console.ReadKey();

var list = JsonConvert.DeserializeObject<List<ICustomer>>(json, new JsonSerializerSettings
{
    TypeNameHandling = TypeNameHandling.Auto
});

if(list != null)
{
    foreach (var customer in list)
    {
        switch (customer)
        {
            case Private privatePerson:
                Console.WriteLine($"PRIVAT: {privatePerson.FirstName} {privatePerson.LastName}");
                break;
            case Company company:
                Console.WriteLine($"FÖRETAG: {company.CompanyName}");
                break;
        }
    }
}

Console.ReadKey();