using System;
using System.IO;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Web.Hosting;
using WebService.DA.Interfaces;
using WebService.DTO;

namespace WebService.DA.Impl
{
    public class MockSettingProvider : ISettingProvider
    {
        public SettingList GetSettings(string searchField = null)
        {
            return GetFilteredSettings(searchField);
        }

        private SettingList GetFilteredSettings(string filter = null)
        {
            string settingFileStubs = Path.Combine(HostingEnvironment.ApplicationPhysicalPath, "App_Data", "SettingStubs.xml");
            var allSettings = Deserialize(settingFileStubs);

            if (!string.IsNullOrEmpty(filter) && allSettings != null && allSettings.ArrayOfSetting.Any())
            {
                var filterArray = filter.Trim().Split(' ');
                allSettings.ArrayOfSetting = allSettings.ArrayOfSetting
                    .Where(s => IsArrayContainsString(filterArray, s.Key)).ToList();
            }

            return allSettings;
        }

        private bool IsArrayContainsString(string[] array, string s)
        {
            return array.Any(f => s != null
                           && s.IndexOf(f, 0, StringComparison.InvariantCultureIgnoreCase) != -1);
        }

        private SettingList Deserialize(string fileName)
        {
            try
            {
                using (var file = new FileStream(fileName, FileMode.Open))
                {
                    file.Position = 0;
                    DataContractSerializer dcs = new DataContractSerializer(typeof(SettingList));
                    var settingsList = (SettingList)dcs.ReadObject(file);
                    file.Close();
                    return settingsList;
                }
            }
            catch (Exception e)
            {
                throw new FaultException("There was a problem reading settings.");
            }
        }
    }
}