# Check if the Hyper-V module is installed
if (-not (Get-Module -ListAvailable -Name Hyper-V)) {
    Write-Output "Hyper-V module not found. Installing..."
    Install-WindowsFeature -Name Hyper-V -IncludeManagementTools -Restart
} else {
    Write-Output "Hyper-V module is already installed."
}