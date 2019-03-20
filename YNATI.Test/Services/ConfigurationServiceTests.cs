using Moq;
using Xunit;
using YNATI.Services;

namespace YNATI.Test
{
    public class ConfigurationServiceTests
    {
        private IConfigurationService _sut;
        private Mock<IMoneyMoneyService> moneyMoneyService;
        private Mock<IYnabService> ynabService;

        public ConfigurationServiceTests()
        {
            moneyMoneyService = new Mock<IMoneyMoneyService>();
            ynabService = new Mock<IYnabService>();
            
            _sut = new ConfigurationService(moneyMoneyService.Object, ynabService.Object);
        }

        public class Configure : ConfigurationServiceTests
        {
            [Fact]
            public void ShouldGetMoneyMoneyAccounts()
            {
                _sut.Configure();

                moneyMoneyService.Verify(s => s.GetAccounts());
            }
            
            [Fact]
            public void ShouldGetYnabAccounts()
            {
                _sut.Configure();

                ynabService.Verify(s => s.GetAccounts());
            }
        }
    }
}