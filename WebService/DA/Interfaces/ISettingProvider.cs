using System.Collections.Generic;
using WebService.DTO;

namespace WebService.DA.Interfaces
{
    interface ISettingProvider
    {
        SettingList GetSettings(string searchField = null);
    }
}
