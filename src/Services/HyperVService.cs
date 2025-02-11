using System;
using System.Management.Automation;
using System.IO;

namespace HyperVAutomation.Services
{
    public class HyperVService
    {
        public void EnsureHyperVModuleInstalled()
        {
            string scriptPath = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "scripts", "InstallHyperVModule.ps1");

            using (PowerShell ps = PowerShell.Create())
            {
                ps.AddScript(File.ReadAllText(scriptPath));
                ps.Invoke();

                if (ps.HadErrors)
                {
                    foreach (var error in ps.Streams.Error)
                    {
                        Console.WriteLine(error.ToString());
                    }
                }
            }
        }

        public void CreateVM(string name, int memory, int cpuCount, int diskSize)
        {
            Console.WriteLine($"CreateVM called with parameters: Name={name}, Memory={memory}, CPUCount={cpuCount}, DiskSize={diskSize}");
            /*
            using (PowerShell ps = PowerShell.Create())
            {
                ps.AddCommand("New-VM")
                  .AddParameter("Name", name)
                  .AddParameter("MemoryStartupBytes", memory * 1024 * 1024)
                  .AddParameter("Generation", 2);

                ps.AddCommand("Set-VMProcessor")
                  .AddParameter("VMName", name)
                  .AddParameter("Count", cpuCount);

                ps.AddCommand("New-VHD")
                  .AddParameter("Path", $"C:\\HyperV\\{name}.vhdx")
                  .AddParameter("SizeBytes", diskSize * 1024 * 1024 * 1024);

                ps.AddCommand("Add-VMHardDiskDrive")
                  .AddParameter("VMName", name)
                  .AddParameter("Path", $"C:\\HyperV\\{name}.vhdx");

                ps.Invoke();

                if (ps.HadErrors)
                {
                    foreach (var error in ps.Streams.Error)
                    {
                        Console.WriteLine(error.ToString());
                    }
                }
            }
            */
        }

        public void StartVM(string name)
        {
            Console.WriteLine($"StartVM called with parameter: Name={name}");
            /*
            using (PowerShell ps = PowerShell.Create())
            {
                ps.AddCommand("Start-VM")
                  .AddParameter("Name", name);

                ps.Invoke();

                if (ps.HadErrors)
                {
                    foreach (var error in ps.Streams.Error)
                    {
                        Console.WriteLine(error.ToString());
                    }
                }
            }
            */
        }

        public void StopVM(string name)
        {
            Console.WriteLine($"StopVM called with parameter: Name={name}");
            /*
            using (PowerShell ps = PowerShell.Create())
            {
                ps.AddCommand("Stop-VM")
                  .AddParameter("Name", name);

                ps.Invoke();

                if (ps.HadErrors)
                {
                    foreach (var error in ps.Streams.Error)
                    {
                        Console.WriteLine(error.ToString());
                    }
                }
            }
            */
        }

        public void DeleteVM(string name)
        {
            Console.WriteLine($"DeleteVM called with parameter: Name={name}");
            /*
            using (PowerShell ps = PowerShell.Create())
            {
                ps.AddCommand("Remove-VM")
                  .AddParameter("Name", name)
                  .AddParameter("Force", true);

                ps.Invoke();

                if (ps.HadErrors)
                {
                    foreach (var error in ps.Streams.Error)
                    {
                        Console.WriteLine(error.ToString());
                    }
                }
            }
            */
        }
    }
}