using System.IO;
using Newtonsoft.Json;

namespace HyperVAutomation.Services
{
    public class ConfigurationService
    {
        private string configFilePath;

        // set configFilePath
        public void SetConfigFilePath(string configFilePath)
        {
            this.configFilePath = configFilePath;
        }

        // load configuration for multiple VirtualMachine from file
        public void LoadConfiguration(out VirtualMachine[] vmConfigs)
        {
            if (File.Exists(configFilePath))
            {
                var json = File.ReadAllText(configFilePath);
                vmConfigs = JsonConvert.DeserializeObject<VirtualMachine[]>(json);
            }
            else
            {
                vmConfigs = new VirtualMachine[0];
            }
        }

        // save confirguration for multiple VirtualMachine to file
        public void SaveConfiguration(VirtualMachine[] vmConfigs)
        {
            var json = JsonConvert.SerializeObject(vmConfigs, Formatting.Indented);
            File.WriteAllText(configFilePath, json);
        }
    }
}