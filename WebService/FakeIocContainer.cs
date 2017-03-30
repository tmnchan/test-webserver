using GalaSoft.MvvmLight.Ioc;
using WebService.DA.Impl;
using WebService.DA.Interfaces;

namespace WebService
{
    public static class FakeIocContainer
    {
        private static bool IsRegistered = false;
        public static void Register()
        {
            if (!IsRegistered)
            {
                SimpleIoc.Default.Register<ISettingProvider, MockSettingProvider>();
                IsRegistered = true;
            }
        }

        public static T GetInstance<T>() where T: class
        {
            return SimpleIoc.Default.GetInstance<T>();
        }
    }
}