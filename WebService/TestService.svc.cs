using WebService.DA.Interfaces;
using WebService.DTO;

namespace WebService
{
    public class TestService : ITestService
    {
        private ISettingProvider _iSettingProvider;
        public TestService()
        {
            FakeIocContainer.Register();
            _iSettingProvider = FakeIocContainer.GetInstance<ISettingProvider>();
        }

        public SettingList GetItems(string searchField = null)
        {
            return _iSettingProvider.GetSettings(searchField);
        }

    }
}
