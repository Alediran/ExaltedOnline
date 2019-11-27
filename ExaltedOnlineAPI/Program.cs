using Microsoft.AspNetCore;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Azure.KeyVault;
using Microsoft.Azure.Services.AppAuthentication;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Configuration.AzureKeyVault;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using System.Threading.Tasks;

namespace ExaltedOnlineAPI
{
    /// <summary>
    /// 
    /// </summary>
    public static class Program
    {
        private static string GetKeyVaultEndpoint() => "https://ExaltedOnline.vault.azure.net/";

        /// <summary>
        /// 
        /// </summary>
        /// <param name="args"></param>
        public static void Main(string[] args)
        {            
            CreateHostBuilder(args).Build().Run();
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="args"></param>
        /// <returns></returns>
        public static IHostBuilder CreateHostBuilder(string[] args) =>
           Host.CreateDefaultBuilder(args)
            .ConfigureAppConfiguration((context, config) =>
            {
                var builtConfig = config.Build();

              /*  config.AddAzureKeyVault(
                    $"https://{builtConfig["KeyVault:Vault"]}.vault.azure.net/",
                    builtConfig["KeyVault:ClientId"],
                    builtConfig["KeyVault:ClientSecret"],
                    new DefaultKeyVaultSecretManager());*/
            })
            .ConfigureWebHostDefaults(webBuilder => 
            { 
                webBuilder.UseStartup<Startup>(); 
            });
    }
}
