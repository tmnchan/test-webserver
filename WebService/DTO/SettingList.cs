using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Web;

namespace WebService.DTO
{
    [DataContract]
    public class SettingList
    {
        private List<Setting> arrayOfSetting;

        [DataMember]
        public List<Setting> ArrayOfSetting
        {
            get { return arrayOfSetting; }
            set { arrayOfSetting = value; }
        }
    }
}