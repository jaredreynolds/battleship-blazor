using Battleship.Services;
using Microsoft.AspNetCore.Blazor.Browser.Rendering;
using Microsoft.AspNetCore.Blazor.Browser.Services;
using Microsoft.Extensions.DependencyInjection;

namespace Battleship
{
    public class Program
    {
        static void Main(string[] args)
        {
            var serviceProvider = new BrowserServiceProvider(services =>
            {
                // Add any custom services here
                services.Add(ServiceDescriptor.Singleton<CurrentPlayerService, CurrentPlayerService>());
                services.Add(ServiceDescriptor.Singleton<Game, Game>());
                services.Add(ServiceDescriptor.Singleton<Pacman, Pacman>());
                services.Add(ServiceDescriptor.Singleton<PacmanBoard, PacmanBoard>());
            });

            new BrowserRenderer(serviceProvider).AddComponent<App>("app");
        }
    }
}
