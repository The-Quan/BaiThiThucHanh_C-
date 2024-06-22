using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BaiThiThucHanh
{
   public class ContactManager
{
    private Hashtable contacts;

    public ContactManager()
    {
        contacts = new Hashtable();
    }

    // Method to add a new contact
    public void AddContact(string name, string phone)
    {
        Contact newContact = new Contact(name, phone);
        contacts.Add(name, newContact);
    }

    // Method to find a contact by name and display phone number
    public void FindContact(string name)
    {
        if (contacts.ContainsKey(name))
        {
            Contact contact = (Contact)contacts[name];
            Console.WriteLine($"Phone number for {name}: {contact.Phone}");
        }
        else
        {
            Console.WriteLine($"{name} not found.");
        }
    }

    // Method to display all contacts
    public void DisplayContacts()
    {
        Console.WriteLine("Address Book:");
        Console.WriteLine("--------------");
        foreach (string key in contacts.Keys)
        {
            Contact contact = (Contact)contacts[key];
            Console.WriteLine($"Name: {contact.Name}, Phone: {contact.Phone}");
        }
        Console.WriteLine("--------------");
    }

    // Main method to run the program
    public void Run ()
    {
        ContactManager contactManager = new ContactManager();
        int choice;

        do
        {
            Console.WriteLine("Contact Manager Menu:");
            Console.WriteLine("1. Add new contact");
            Console.WriteLine("2. Find a contact by name");
            Console.WriteLine("3. Display all contacts");
            Console.WriteLine("4. Exit");
            Console.Write("Enter your choice: ");
            if (!int.TryParse(Console.ReadLine(), out choice))
            {
                Console.WriteLine("Invalid input. Please enter a number between 1 and 4.");
                continue;
            }

            switch (choice)
            {
                case 1:
                    Console.Write("Enter name: ");
                    string name = Console.ReadLine();
                    Console.Write("Enter phone number: ");
                    string phone = Console.ReadLine();
                    contactManager.AddContact(name, phone);
                    Console.WriteLine("Contact added successfully.");
                    break;
                case 2:
                    Console.Write("Enter name to find: ");
                    name = Console.ReadLine();
                    contactManager.FindContact(name);
                    break;
                case 3:
                    contactManager.DisplayContacts();
                    break;
                case 4:
                    Console.WriteLine("Exiting program.");
                    break;
                default:
                    Console.WriteLine("Invalid choice. Please enter a number between 1 and 4.");
                    break;
            }

        } while (choice != 4);
    }
}
}