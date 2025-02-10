using System;
using System.Management.Automation;

namespace HyperVAutomation.Services
{
    public class HyperVService
    {
        public void CreateVM(string name, int memory, int cpuCount, int diskSize)
        {
            // Implementation for creating a Hyper-V virtual machine
            // Example PowerShell command: New-VM
        }

        public void StartVM(string name)
        {
            // Implementation for starting a Hyper-V virtual machine
            // Example PowerShell command: Start-VM
        }

        public void StopVM(string name)
        {
            // Implementation for stopping a Hyper-V virtual machine
            // Example PowerShell command: Stop-VM
        }

        public void DeleteVM(string name)
        {
            // Implementation for deleting a Hyper-V virtual machine
            // Example PowerShell command: Remove-VM
        }
    }
}