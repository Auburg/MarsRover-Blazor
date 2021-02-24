using Microsoft.AspNetCore.Components.WebAssembly.Hosting;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Net.Http;
using System.Threading.Tasks;
using MarsRover.Configuration;
using MarsRover.Services;

namespace MarsRover
{
    public class Program
    {
        public static async Task Main(string[] args)
        {     
            var builder = WebAssemblyHostBuilder.CreateDefault(args);
            builder.RootComponents.Add<App>("#app");

            builder.Services.AddScoped(sp => new HttpClient { BaseAddress = new Uri(builder.HostEnvironment.BaseAddress) });
            Configuration.IConfiguration settings = builder.Configuration.Get<Rootobject>().Configuration;
            builder.Services.AddSingleton(settings);         
            builder.Services.AddSingleton<IMarsRoverApi, MarsRoverApi>();           
            builder.Services.AddSingleton<IRoverEventService, RoverEventService>();           
            await builder.Build().RunAsync();
        }
    }
}
