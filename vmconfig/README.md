# VM Configuration Files

This folder contains JSON configuration files for setting up and managing Hyper-V virtual machines. Each JSON file defines the properties and settings for one or more virtual machines.

## Example Configuration

An example configuration file (`myvms.json`) might look like this:
``` json
[
  {
    "Name": "VM1",
    "Memory": 4096,
    "ProcessorCount": 2,
    "DiskSizeGB": 50,
    "NetworkAdapter": "Default Switch",
    "ISOPath": "C:\\Path\\To\\Your\\ISO\\file1.iso",
    "VHDPath": "C:\\Path\\To\\Your\\VHD\\file1.vhdx"
  },
  {
    "Name": "VM2",
    "Memory": 2048,
    "ProcessorCount": 1,
    "DiskSizeGB": 30,
    "NetworkAdapter": "Default Switch",
    "ISOPath": "C:\\Path\\To\\Your\\ISO\\file2.iso",
    "VHDPath": "C:\\Path\\To\\Your\\VHD\\file2.vhdx"
  }
]
```

## Adding New Configurations

To add a new VM configuration, create a new JSON file in this folder and define the necessary properties for your virtual machines. Ensure that the JSON structure follows the example provided above.

## Usage

The application will read the configuration files from this folder to set up and manage the virtual machines. Make sure to place your configuration files here before running the application.

## Notes

- Ensure that the paths specified in the configuration files are correct and accessible.
- The `NetworkAdapter` should match the name of an existing network switch in Hyper-V.

For more details on how to use these configuration files, refer to the main [README.md](../README.md) file in the project root.
