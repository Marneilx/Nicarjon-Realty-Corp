using System;

class Program
{
    static void Main(string[] args)
    {
        TenantManager manager = new TenantManager();
        while (true)
        {
            Console.WriteLine("Welcome to the NICARJON Tenant Management System\n");
            Console.WriteLine("1. Register");
            Console.WriteLine("2. Login");
            Console.WriteLine("3. Exit");
            Console.Write("Please select an option: ");

            string option = Console.ReadLine();
            switch (option)
            {
                case "1":
                    manager.RegisterTenant();
                    break;
                case "2":
                    manager.Login();
                    break;
                case "3":
                    Console.WriteLine("\nExiting program.");
                    return;
                default:
                    Console.WriteLine("Invalid option, please try again.");
                    break;
            }
        }
    }
}
