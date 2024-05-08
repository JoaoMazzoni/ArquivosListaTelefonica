using AgendaTelefone;
using System;
using System.Collections.Generic;
using System.Net;
using System.Runtime.CompilerServices;

public class Program
{
    internal static void Main(string[] args)
    {
        List<Contact> contactList = new List<Contact>();    
        int opc;

        do
        {
            Console.Clear();
            Console.WriteLine("   ---- MENU ----\n");
            Console.WriteLine("|1| - Adicionar Contato");
            Console.WriteLine("|2| - Remover Contato");
            Console.WriteLine("|3| - Editar Contato");
            Console.WriteLine("|4| - Mostrar Contatos");
            Console.WriteLine("|5| - Sair");
            Console.Write("\nDigite a opção desejada: ");
            opc = int.Parse(Console.ReadLine());

            switch (opc)
            {
                case 1:
                    Console.Clear();
                    Console.WriteLine("---- Registrar Contato ----");
                    contactList.Add(RegisterContact());
                    contactList.Sort();

                    break;

                case 2:
                    Console.WriteLine("\nInforme o nome do contato: ");
                    string nameRemove = Console.ReadLine();
                    contactList.RemoveAll(contact => contact.name == nameRemove);
                    Console.WriteLine($"\nO contato: {nameRemove} foi removido da lista!");
                    Console.ReadLine();
                    Console.Clear();
                    break;

                case 3:
                    // Adicionar a lógica para editar contato, se necessário
                    break;

                case 4:
                    Console.Clear();
                    int option;
                    Console.WriteLine("|1| - Imprimir Lista Completa");
                    Console.WriteLine("|2| - Imprimir Contato");
                    option = int.Parse(Console.ReadLine());
                    switch (option)
                    {
                        case 1:
                            Console.Clear();
                            foreach (Contact contact in contactList) //Para cada Item do tipo Contact em lista
                            {
                                Console.WriteLine(contact.ToString());
                            }
                            Console.ReadLine();
                            break;

                        case 2:
                            //Imprimir contato especifico.
                            break;

                        default:
                            Console.Clear();
                            Console.WriteLine("\nOpção Inválida");
                            break;
                    }
                    break;

                case 5:
                    Environment.Exit(0); //Sair do programa
                    break;

                default:
                    Console.WriteLine("\nOpção Inválida");
                    break;
            }
        } while (opc != 5);
    }

    static Contact RegisterContact()
    {
        string name;
        string email;

        Console.Write("\nInforme o nome: ");
        name = Console.ReadLine();

        Console.Write("\nInforme o email: ");
        email = Console.ReadLine();

        Address address = RegisterAddress();

        List<Phone> aux = RegisterPhone();

        return new Contact(name, email, address, aux);
    }

    static Address RegisterAddress()
    {
        string city;
        string street;
        string number;
        string neighborhood;
        string postcode;

        Console.Write("\nInforme a cidade: ");
        city = Console.ReadLine();

        Console.Write("\nInforme o nome da rua/avenida: ");
        street = Console.ReadLine();

        Console.Write("\nInforme o número do endereço: ");
        number = Console.ReadLine();

        Console.Write("\nInforme o bairro: ");
        neighborhood = Console.ReadLine();

        Console.Write("\nInforme o CEP: ");
        postcode = Console.ReadLine();

        return new Address(city, street, number, neighborhood, postcode);
    }

    static List<Phone> RegisterPhone()
    {
        List<Phone> phones = new();
        bool addAnother = true;

        do
        {
            string number;
            Console.Write("\nInforme o número de telefone: ");
            number = Console.ReadLine();
            Phone newPhone = new Phone(number);
            phones.Add(newPhone);

            Console.WriteLine("Números de telefone registrados:");
            foreach (Phone phone in phones)
            {
                Console.WriteLine(phone.phone);
            }

            Console.WriteLine("\nDeseja cadastrar outro número de telefone?");
            Console.WriteLine("|1| - SIM");
            Console.WriteLine("|2| - NÃO");
            Console.Write("\nDigite sua resposta: ");
            int option = int.Parse(Console.ReadLine());

            if (option != 1)
            {
                addAnother = false;
            }

        } while (addAnother == true);

        return phones;
    }


}
