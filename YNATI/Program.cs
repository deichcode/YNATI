using System;
using Microsoft.Extensions.CommandLineUtils;
using Microsoft.Extensions.DependencyInjection;

namespace YNATI
{
    internal static class Program
    {
        private static void Main(string[] args)
        {
            var serviceProvider = new ServiceCollection()
                .AddLogging()
                .BuildServiceProvider();

            var app = new CommandLineApplication {Name = "ynati"};
            app.HelpOption(Constants.DefaultHelpOptionTemplate);

            app.Command("import", Commands.Import());
            app.Command("configure", Commands.Configure());

            app.Execute(args);
        }
    }
}
