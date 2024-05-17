using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using _240401_01.Models;
using _240401_01.Controllers;
using System.Runtime.InteropServices;

namespace _240401_01.Views
{
    public class CustomerView
    {
        private CustomerController customerController;
        private AddressView addressView;
        public CustomerView()
        {
            addressView = new AddressView();
            customerController = new CustomerController();
            this.Init();
        }
    
        public void Init()
        {
            Console.WriteLine("*************");
            Console.WriteLine("MENU CUSTOMER");
            Console.WriteLine("*************");

            bool aux = true;
            do{
                Console.WriteLine("Escolha uma opção:");
                Console.WriteLine("1 - Inserir Consumidor");
                Console.WriteLine("2 - Pesquisar Consumidor");
                Console.WriteLine("3 - Listar Consumidores");
                Console.WriteLine("4 - Deletar/Atualizar dados");
                Console.WriteLine("0 - Sair");

                int menu = 0;
                try
                {
                    menu = Convert.ToInt16(Console.ReadLine());
                    switch(menu)
                    {
                        case 0:
                            aux = false;
                        break;

                        case 1:
                            InsertCustomer();
                        break;

                        case 2:
                            SearchCustomer();
                        break;

                        case 3:
                            ListCustomers();
                        break;

                        case 4:
                            DeleteOrUpdateCustomer();
                        break;
                        
                        default: 
                            Console.WriteLine("Opção inválida.");
                            aux = true;
                        break;
                    }
                }
                catch
                {
                    Console.WriteLine("Opção inválida.");
                    menu = -1;
                }                
            }while(aux);
        }

        private void InsertCustomer()
        {
            Console.WriteLine("***********************");
            Console.WriteLine("INSERIR NOVO CONSUMIDOR");
            Console.WriteLine("***********************");

            Customer customer = new Customer();
            Console.Write("Nome: ");
            customer.Name = Console.ReadLine();
            Console.WriteLine("");

            Console.Write("Email: ");
            customer.EmailAddress = Console.ReadLine();
            Console.WriteLine("");

            int aux = 0;
            do{
                Console.WriteLine("Deseja informar endereço?");
                Console.WriteLine("0 - Não");
                Console.WriteLine("1 - Sim");
                try
                {
                    aux = Convert.ToInt16(Console.ReadLine());
                    if (aux == 1)
                    {
                        customer.Addresses.Add(addressView.Insert());
                    }
                    else if (aux == 0)
                    {
                        break;
                    }
                    else
                    {
                        aux = 1;
                        Console.WriteLine("Opção inválida, tente novamente.");
                    }
                }
                catch
                {
                    aux = 1;
                    Console.WriteLine("Opção inválida, tente novamente.");
                }
            }while(aux != 0);

            try{
                customerController.Insert(customer);
                Console.WriteLine("Customer inserido com sucesso!");
            }
            catch{
                Console.WriteLine("Ops! Ocorreu um erro.");
            }
            
        }

        private void SearchCustomer()
        {
            int aux = -1;
            do
            {
                Console.WriteLine("PESQUISAR CONSUMIDOR");
                Console.WriteLine("********************");
                Console.WriteLine("1 - Buscar por ID");
                Console.WriteLine("2 - Buscar por nome");
                Console.WriteLine("0 - Sair");

                aux = Convert.ToInt16(Console.ReadLine());
                switch(aux)
                {
                    case 1:
                        Console.WriteLine("********************");
                        Console.WriteLine("Informe o ID: ");
                        int id = Convert.ToInt32(Console.ReadLine());
                        ShowCustomerById(id);
                    break;

                    case 2:
                        Console.WriteLine("********************");
                        Console.WriteLine("Informe o nome: ");
                        string name = Console.ReadLine();
                        ShowCustomersByName(name);
                    break;

                    case 0:
                    break;

                    default:
                        aux = -1;
                        Console.WriteLine("Opção inválida.");
                    break;
                }    
            }
            while(aux != 0);
        }

        private void DeleteOrUpdateCustomer()
        {
            int aux = -1;
            while(aux != 0)
            {
                Console.WriteLine("*******************");
                Console.WriteLine("1 - Deletar por Id");
                Console.WriteLine("2 - Deletar endereço por Id");
                Console.WriteLine("3 - Atualizar dados");
                Console.WriteLine("0 - Sair");
                aux = Convert.ToInt16((Console.ReadLine()));
                switch(aux)
                {
                    case 1:
                        DeleteCustomerById();
                    break;

                    case 2:
                        DeleteCustomerAddressById();
                    break;

                    case 3:     
                    break;

                    case 0:
                    break;

                    default:
                        Console.WriteLine("Opção inválida, tente novamente.");
                        aux = -1;
                    break;
                }
            }
        }

        private void DeleteCustomerById()
        {
            Console.WriteLine("***************************");
            Console.WriteLine("Deletando consumidor por Id");
            Console.WriteLine("***************************");
            Console.WriteLine("Insira o Id do consumidor: ");

            CustomerController c = new CustomerController();
            int customerId = Convert.ToInt32(Console.ReadLine());
            if (c.Get(customerId) != null )
            {
                Console.Write("Consumidor encontrado: ");
                ShowCustomerById(customerId);

                int aux = -1;
                while (aux != 0)
                {
                    Console.WriteLine("Deseja mesmo deletar o consumidor acima?");
                    Console.WriteLine("1 - Sim");
                    Console.WriteLine("0 - Voltar");

                    aux = Convert.ToInt16(Console.ReadLine());
                    switch (aux)
                    {
                        case 1:
                            try
                            {
                                c.Delete(customerId);
                            }
                            catch
                            {
                                Console.WriteLine("Algo inesperado aconteceu.");
                                break;
                            }
                            Console.WriteLine("Consumidor deletado com sucesso.");
                            aux = 0;
                        break;

                        case 0:
                        break;

                        default:
                            Console.WriteLine("Opção inválida, tente novamente.");
                        break;
                    }
                }
            }
            else
            {
                Console.WriteLine($"Consumidor de Id {customerId} não encontrado.");
            }
        }

        private void DeleteCustomerAddressById()
        {
            Console.WriteLine("***************************");
            Console.WriteLine("Deletando endereço por Id");
            Console.WriteLine("***************************");
            Console.WriteLine("Insira o Id do consumidor: ");

            CustomerController c = new CustomerController();
            AddressController a = new AddressController();
            
            int customerId = Convert.ToInt32(Console.ReadLine());
            Customer customer = c.Get(customerId);
            int addressesCount = customer.Addresses.Count;
            if ( customer != null && addressesCount > 0 )
            {
                Console.WriteLine(customer.ToString());
                ListCustomerAddresses(customer);
                Console.WriteLine("Digite o Id do endereço que você quer deletar: ");
                Address address = a.Get(Convert.ToInt16(Console.ReadLine()));

                int aux = -1;
                while ( aux != 0 )
                {
                    Console.WriteLine("Deseja realmente deletar esse endereço?");
                    Console.WriteLine("1 - Sim");
                    Console.WriteLine("0 - Voltar");

                    aux = Convert.ToInt16(Console.ReadLine());
                    switch (aux)
                    {
                        case 1:
                            try
                            {
                                a.Delete(customer, address);
                            }
                            catch
                            {
                                Console.WriteLine("Algo inesperado aconteceu.");
                                break;
                            }
                            Console.WriteLine("Endereço deletado com sucesso.");
                            aux = 0;
                        break;

                        case 0:
                        break;

                        default:
                            Console.WriteLine("Opção inválida, tente novamente.");
                        break;
                    }
                }
            }
            else
            {
                Console.WriteLine($"Consumidor com Id {customerId} inexistente ou sem endereços cadastrados.");
            }
        }

        private void ListCustomers()
        {
            
            List<Customer>? result = customerController.Get();
            if (result == null || result?.Count == 0)
            {
                Console.WriteLine("Não encontrado.");
                return;
            }

            Console.WriteLine("*********************");
            foreach (Customer customer in result)
            {
                Console.WriteLine(customer.ToString());
            }
        }

        public void ListCustomerAddresses(Customer customer)
        {
            foreach (var c in customer.Addresses) // revisar
                Console.WriteLine(c.ToString());
        }

        private void ShowCustomerById(int id)
        {
            Customer? c = customerController.Get(id);
            if (c != null)
                Console.WriteLine(c.ToString());
            else
                Console.WriteLine($"Consumidor de Id {id} não encontrado.");
        }

        private void ShowCustomersByName(string name)
        {
            
            List<Customer>? result = customerController.GetByName(name);
            if (result == null || result?.Count == 0)
            {
                Console.WriteLine("Não encontrado.");
                return;
            }

            foreach (Customer customer in result)
                Console.WriteLine(customer.ToString());
        }
    }
}