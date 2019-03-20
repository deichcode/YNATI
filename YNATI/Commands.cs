using System;
using Microsoft.Extensions.CommandLineUtils;

namespace YNATI
{
    public static class Commands
    {
        public static Action<CommandLineApplication> Import()
        {
            return command =>
            {
                command.Description = "Import transactions from MoneyMoney to YNAB";
                command.HelpOption(Constants.DefaultHelpOptionTemplate);
                command.OnExecute(() =>
                {
                    Console.WriteLine("Import started");
                    return 0;
                });
            };
        }

        public static Action<CommandLineApplication> Configure()
        {
            return command => { };
        }
    }
}