using System;

namespace HyperVAutomation
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to Hyper-V Automation Tool!");

            // Initialize services
            var hyperVService = new Services.HyperVService();
            var configurationService = new Services.ConfigurationService();

            // Load configuration
            configurationService.LoadConfiguration();

            // Handle user input for managing virtual machines
            while (true)
            {
                Console.WriteLine("Choose an option:");
                Console.WriteLine("1. Create VM");
                Console.WriteLine("2. Start VM");
                Console.WriteLine("3. Stop VM");
                Console.WriteLine("4. Delete VM");
                Console.WriteLine("5. Exit");

                var choice = Console.ReadLine();

                switch (choice)
                {
                    case "1":
                        hyperVService.CreateVM();
                        break;
                    case "2":
                        hyperVService.StartVM();
                        break;
                    case "3":
                        hyperVService.StopVM();
                        break;
                    case "4":
                        hyperVService.DeleteVM();
                        break;
                    case "5":
                        return;
                    default:
                        Console.WriteLine("Invalid option. Please try again.");
                        break;
                }
            }
        }
    }
}