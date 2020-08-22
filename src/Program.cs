using System;
using System.Threading.Tasks;
using Microsoft.Azure.Storage;
using Microsoft.Azure.Storage.Auth;
using Microsoft.Azure.Storage.Blob;

namespace BulkDeleteBlobs
{
    class Program
    {
        // This application requires three environment variables:
        // ACCOUNT_STR:     Storage account name
        // KEY_STR:         Storage account key
        // CONTAINER_STR:   Container name

        static void Main(string[] args)
        {
            Console.WriteLine("Connecting to storage account");

            // Retrieves the connection string an environment variable on the machine for use with the application.
            StorageCredentials storageCredentials = new StorageCredentials(Environment.GetEnvironmentVariable("ACCOUNT_STR"), Environment.GetEnvironmentVariable("KEY_STR"));
            CloudStorageAccount storageAccount = new CloudStorageAccount(storageCredentials, true);

            CloudBlobClient cloudBlobClient = storageAccount.CreateCloudBlobClient();

            Console.WriteLine("Deleting blobs");

            // Credit: https://stackoverflow.com/questions/10426213/how-to-clean-an-azure-storage-blob-container
            Parallel.ForEach(cloudBlobClient.GetContainerReference(Environment.GetEnvironmentVariable("CONTAINER_STR")).ListBlobs(useFlatBlobListing: true), x => ((CloudBlob)x).Delete());

            Console.WriteLine("Done");
        }
    }
}
