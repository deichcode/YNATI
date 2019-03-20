namespace YNATI.Services
{
    public class ConfigurationService : IConfigurationService
    {
        private readonly IMoneyMoneyService _moneyMoneyService;
        private readonly IYnabService _ynabService;

        public ConfigurationService(IMoneyMoneyService moneyMoneyService, IYnabService ynabService)
        {
            _moneyMoneyService = moneyMoneyService;
            _ynabService = ynabService;
        }

        public void Configure()
        {
            _moneyMoneyService.GetAccounts();
            _ynabService.GetAccounts();
        }
    }
}