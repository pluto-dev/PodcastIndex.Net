using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using PodcastIndex.Net;

namespace SampleConsoleProject 
{
    static class Program
    {
        static void Main(string[] args)
        {
            var host = Host.CreateDefaultBuilder()
                .ConfigureServices(
                    (context, services) =>
                    {
                        services.AddPodcastIndexNet(context.Configuration);
                    }
                )
                .Build();

            ActivatorUtilities.CreateInstance<Test>(host.Services);
        }
    }

    class Test
    {
        public Test(IPodcastIndex podcastIndex)
        {
            var search = podcastIndex.Search().GetByTermAsync("Batman").Result;
        }
    }
}
