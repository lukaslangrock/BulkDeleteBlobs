# BulkDeleteBlobs
This application will delete all blobs in a given container.

# Environment Variables
To access your storage account and container, you need to pass your storage account name, key and container name to the application. You can do this by settings three environmental variables.

| Variable      | Value                 |
| ------------- |-----------------------|
| ACCOUNT_STR   | Storage account name  |
| KEY_STR       | Storage account key   |
| CONTAINER_STR | Container name        |

The storage account name and container name are the names you specified when you created the storage account and container. You can find your storage account key by opening your storage account in the [Azure portal](https://portal.azure.com/) and clicking on the `Access keys` tab under settings.

# Run
To run this application you need to have the [.NET Core 3 Runtime](https://dotnet.microsoft.com/download/dotnet-core/3.0/runtime) installed.

1. Clone or download the code
2. Open the folder in your terminal
3. Execute the command `dotnet run`.
