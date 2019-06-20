This Tests project is not a regular test project. 

Debugging an API is a lot easier using a unit test framework. 

To protect my employer, I have kept any identifying names outside this project and use a JSON file that lives outside this solution at 'c:\temp\transip-api-config.json'
While there is a change that these test do not suit you're TransIP setup, at least it shows how to use the API. I have to admin, that isn't rocket science if you are familier with 'Controle Panel' (web admin interface)

Vps names have the following format '[username]-vps[counter]'. Don't confuse name with description (often the servername)!
Note that the path to the private key file needs to be encoded according the JSON specs (similar to C# string escaping - e.g. c:\\temp\\transip-key.pem)

{
	"Username": "YourName",
	"PrivateKeyFile": "Path/to/private-key-pem-file",

	"Servers": [
		"BaseInstallVps": "VPS name of vps used as a base for creating new VPSes",
		"TestVps": "Name of VPS which can be used for testing"
	]
}
