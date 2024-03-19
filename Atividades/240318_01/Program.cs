using _240318_01.Models;

Customer c1 = new Customer();
c1.CustomerId = 1;
c1.FirstName = "Matheus";
c1.LastName = "Sampaio";
c1.BirthDate = new DateTime();
c1.EmailAddress = "matheus.sampaio@gmail.com";

Address address1 = new Address();
address1.AddressId = 1;
address1.Street = "Rua XV";
address1.District = "Santo Antônio";
address1.City = "Campos Novos";
address1.Number = 78;
address1.FederalState = "SC";
address1.Country = "Brasil";
address1.ZipCode = "89620-000";

c1.Addresses.Add(address1);

Console.WriteLine("ENDEREÇOS:");
foreach(var ad in c1.Addresses)
{
    Console.WriteLine("-------------------------");
    Console.WriteLine($"Rua: {ad.Street}");
    Console.WriteLine($"Bairro: {ad.District}");
    Console.WriteLine($"Número: {ad.Number}");
    Console.WriteLine($"Estado: {ad.FederalState}");
    Console.WriteLine($"Cidade: {ad.City}");
    Console.WriteLine($"País: {ad.Country}");
    Console.WriteLine("-------------------------");
}

Console.WriteLine($"Nome: {c1.FirstName} {c1.LastName}");
Console.WriteLine($"Email: {c1.EmailAddress}");