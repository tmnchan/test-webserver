using System.Runtime.Serialization;

namespace WebService.DTO
{
    [DataContract]
    public class Setting
    {
        string _key;
        string _value;

        [DataMember]
        public string Key
        {
            get { return _key; }
            set { _key = value; }
        }

        [DataMember]
        public string Value
        {
            get { return _value; }
            set { _value = value; }
        }
    }
}