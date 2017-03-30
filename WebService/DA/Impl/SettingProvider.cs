using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using WebService.DA.Interfaces;
using WebService.DTO;

namespace WebService.DA.Impl
{
    public class SettingProvider : ISettingProvider
    {
        public SettingList GetSettings(string searchField = null)
        {
            throw new NotImplementedException();
        }
    }
}