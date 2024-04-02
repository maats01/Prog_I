// See https://aka.ms/new-console-template for more information
using _240401_01.Models;

Console.WriteLine("Hello, World!");

// Construtor de Instanciação
Customer c1 = new Customer();
c1.CustomerId = 1;
c1.Name = "Mattyiah";
c1.EmailAddress = "mattyiah@mail.com";

Customer c2 = new Customer(2);
c1.Name = "Plato";
c1.EmailAddress = "plato@think.com";

// Construtor por atribuição
Customer c3 = new Customer{
    CustomerId = 3,
    Name = "Junior",
    EmailAddress = "junior@dotmail.com"
};