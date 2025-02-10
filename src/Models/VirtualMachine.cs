public class VirtualMachine
{
    public string Name { get; set; }
    public int Memory { get; set; } // in MB
    public int CPUCount { get; set; }
    public int DiskSize { get; set; } // in GB

    public VirtualMachine(string name, int memory, int cpuCount, int diskSize)
    {
        Name = name;
        Memory = memory;
        CPUCount = cpuCount;
        DiskSize = diskSize;
    }

    public bool Validate()
    {
        return !string.IsNullOrWhiteSpace(Name) && 
               Memory > 0 && 
               CPUCount > 0 && 
               DiskSize > 0;
    }
}