using System.IO;
using Newtonsoft.Json;

namespace HyperVAutomation.Services
{
    public class ConfigurationService
    {
        private readonly string configFilePath;

        public ConfigurationService(string configFilePath)
        {
            this.configFilePath = configFilePath;
        }

        public void LoadConfiguration(out VirtualMachine vmConfig)
        {
            if (File.Exists(configFilePath))
            {
                var json = File.ReadAllText(configFilePath);
                vmConfig = JsonConvert.DeserializeObject<VirtualMachine>(json);
            }
            else
            {
                vmConfig = new VirtualMachine();
            }
        }

        public void SaveConfiguration(VirtualMachine vmConfig)
        {
            var json = JsonConvert.SerializeObject(vmConfig, Formatting.Indented);
            File.WriteAllText(configFilePath, json);
        }
    }
}