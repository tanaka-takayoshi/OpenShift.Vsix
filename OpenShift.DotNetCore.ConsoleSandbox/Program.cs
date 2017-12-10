using Microsoft.Rest;
using OpenShift.DotNet.Service;
using System;
using System.Net.Http;

namespace OpenShift.DotNetCore.ConsoleSandbox
{
    class Program
    {
        static void Main(string[] args)
        {
            var handler = new HttpClientHandler
            {
                ServerCertificateCustomValidationCallback = HttpClientHandler.DangerousAcceptAnyServerCertificateValidator
            };
            var client = new OpenShiftAPIwithKubernetes(new Uri("https://ose3-single-vm.westus2.cloudapp.azure.com:8443"), new TokenCredentials("zXg4eone96E9tLrZCDdATlTJhcITXxcSAxV83TdUhPU"), handler);
            var pods = client.ListCoreV1NamespacedPodAsync("fukuokanetconf").GetAwaiter().GetResult();
            foreach (var pod in pods.Items)
            {
                Console.WriteLine(pod.Metadata.Name + "=" + pod.Status.Phase);
            }
            Console.ReadLine();
        }
    }
}
