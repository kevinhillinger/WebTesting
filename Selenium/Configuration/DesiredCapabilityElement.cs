using System;
using System.Configuration;

namespace WebTesting.Selenium.Configuration
{
    public class DesiredCapabilityElement : ConfigurationElement
    {
        [ConfigurationProperty("name", DefaultValue = "", IsKey = true, IsRequired = true)]
        public string Name
        {
            get { return ((string)(base["name"])); }
            set { base["name"] = value; }
        }

        [ConfigurationProperty("value", DefaultValue = "", IsKey = false, IsRequired = false)]
        public string Value
        {
            get { return ((string)(base["value"])); }
            set { base["value"] = value; }
        }

        [ConfigurationProperty("type", DefaultValue = "", IsKey = false, IsRequired = false)]
        public Type Type
        {
            get { return ((Type)(base["type"])); }
            set { base["type"] = value; }
        }
    }

}
