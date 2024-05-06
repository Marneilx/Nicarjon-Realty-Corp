using System;
using System.Collections.Generic;

public class TenantManager
{
    private List<Tenant> tenants = new List<Tenant>();

    public void RegisterTenant()
    {
        Console.WriteLine("Enter username:");
        string username = Console.ReadLine();
        Console.WriteLine("Enter password:");
        string password = Console.ReadLine();
        Console.WriteLine("Choose an apartment from the list: [101, 102, 103]");
        string apartment = Console.ReadLine();
        Console.WriteLine("Choose a plan duration (1, 3, 6, 9 months or custom):");
        int duration;
        while (!int.TryParse(Console.ReadLine(), out duration) || duration <= 0)
        {
            Console.WriteLine("Invalid input. Please enter a valid number of months:");
        }

        Tenant newTenant = new Tenant(username, password, apartment, duration);
        tenants.Add(newTenant);
        Console.WriteLine("Registration successful!");
    }

    public void Login()
    {
        
        Console.WriteLine("Welcome to NICARJON Realty Corp.\n");
        Console.WriteLine("Enter username:");
        string username = Console.ReadLine();
        Console.WriteLine("Enter password:");
        string password = Console.ReadLine();

        Tenant tenant = tenants.Find(t => t.Username == username && t.Password == password);
        if (tenant != null)
        {
            Console.WriteLine("\n\nLogin successful!");
            Console.WriteLine($"\nYou are logged in as {tenant.Username} living in apartment {tenant.Apartment} with a {tenant.Duration}-month lease.");

            double totalBill = Billing.CalculateTotalBill(tenant);
            Console.WriteLine($"\nYour total bill for the duration of the lease is: P{totalBill}\n");
        }
        else
        {
            Console.WriteLine("\n\nLogin failed. Incorrect username or password.\n");
        }
    }
}
