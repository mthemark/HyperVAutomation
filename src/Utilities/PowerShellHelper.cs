using System.Management.Automation;

namespace HyperVAutomation.Utilities
{
    public class PowerShellHelper
    {
        public string ExecuteCommand(string command)
        {
            using (PowerShell powerShell = PowerShell.Create())
            {
                powerShell.AddScript(command);
                var results = powerShell.Invoke();
                return string.Join("\n", results);
            }
        }

        public string RunScript(string scriptPath)
        {
            using (PowerShell powerShell = PowerShell.Create())
            {
                powerShell.AddScript(System.IO.File.ReadAllText(scriptPath));
                var results = powerShell.Invoke();
                return string.Join("\n", results);
            }
        }
    }
}