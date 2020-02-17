using System;
using dotenv.net;
using Microsoft.Azure.Management.Fluent;
using Microsoft.Azure.Management.ResourceManager.Fluent;
using Microsoft.Azure.Management.ResourceManager.Fluent.Core;

namespace AzureVMWithCSharp
{
    class Program
    {
        static string CLIENT_ID=Environment.GetEnvironmentVariable("CLIENT_ID");
        static string CLIENT_SECRET=Environment.GetEnvironmentVariable("CLIENT_SECRET");
        static string TENANT_ID=Environment.GetEnvironmentVariable("TENANT_ID");
        static IAzure azure = null;
        static void Main(string[] args)
        {
            DotEnv.Config();


            var credentials = SdkContext.AzureCredentialsFactory
            .FromServicePrincipal(clientId:CLIENT_ID, clientSecret:CLIENT_SECRET,tenantId:TENANT_ID,AzureEnvironment.AzureGlobalCloud);

            azure = Azure
                .Configure()
                .WithLogLevel(HttpLoggingDelegatingHandler.Level.Basic)
                .Authenticate(credentials)
                .WithDefaultSubscription();
            
            createResourceGroup("rg-from-csharp");
        }

        static void createResourceGroup(string resourceGroupName)
        {
            azure.ResourceGroups.Define(resourceGroupName)
            .WithRegion(Region.USEast2)
            .Create();
        }
    }
}
