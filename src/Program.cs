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

            // ensure Hyper-V module is installed
            hyperVService.EnsureHyperVModuleInstalled();

            // get files in the ./vmconfig folder ending with .json
            var configFiles = System.IO.Directory.GetFiles("./vmconfig", "*.json");

            // allow user to select one of the config files
            if (configFiles.Length > 0)
            {
                Console.WriteLine("Select a configuration file:");
                for (int i = 0; i < configFiles.Length; i++)
                {
                    Console.WriteLine($"{i + 1}. {configFiles[i]}");
                }
                var choice = Console.ReadLine();
                var configFilePath = configFiles[int.Parse(choice) - 1];
                // Set configuration file path
                configurationService.SetConfigFilePath(configFilePath);
            }
            else
            {
                Console.WriteLine("No configuration files found. Please create a configuration file in the vmconfig folder.");
                return;
            }

            // Load configuration
            configurationService.LoadConfiguration(out VirtualMachine[] vmConfigs);

            //Handle user input to select a single vm from vmconfigs
            while (true)
            {
                Console.WriteLine("Select a VM:");
                for (int i = 0; i < vmConfigs.Length; i++)
                {
                    Console.WriteLine($"{i + 1}. {vmConfigs[i].Name}");
                }
                var choice = Console.ReadLine();
                var selectedVM = vmConfigs[int.Parse(choice) - 1];
                // handle user input for managing virtual machines
                var _exit = 'n';
                while (_exit != 'y')
                {
                    Console.WriteLine("Choose an option:");
                    Console.WriteLine("1. Create VM");
                    Console.WriteLine("2. Start VM");
                    Console.WriteLine("3. Stop VM");
                    Console.WriteLine("4. Delete VM");
                    Console.WriteLine($"5. Exit management of {selectedVM.Name}");
                    var vmChoice = Console.ReadLine();
                    switch (vmChoice)
                    {
                        case "1":
                            hyperVService.CreateVM(selectedVM.Name, selectedVM.Memory, selectedVM.CPUCount, selectedVM.DiskSize);
                            break;
                        case "2":
                            hyperVService.StartVM(selectedVM.Name);
                            break;
                        case "3":
                            hyperVService.StopVM(selectedVM.Name);
                            break;
                        case "4":
                            hyperVService.DeleteVM(selectedVM.Name);
                            break;
                        case "5":
                            _exit = 'y';
                            continue;
                        default:
                            Console.WriteLine("Invalid option. Please try again.");
                            break;
                    }
                }
                // handle user input to continue vm management or exit
                Console.WriteLine("Do you want to manage another VM? (y/n)");
                var shouldContinue = Console.ReadLine();
                if (shouldContinue.ToLower() != "y")
                    break;
            }
            // thank you for using the tool
            Console.WriteLine("Thank you for using the Hyper-V Automation Tool!");
        }
    }
}