#
# Script.ps1
#

param (
	[string]$version = "1.0",
	[switch]$help
)

if ($help -eq $true)
{
	Write-Host "Start the development web server for HvacTools."
	Write-Host "-version: the version of the reference data service to run. Default: 1.0"
	exit
}
c:\Python27\python.exe .\etc\Web\WebAPI_$version\reference_data_service.py