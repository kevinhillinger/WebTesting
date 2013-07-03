using System.Configuration;

namespace WebTesting.Selenium.Configuration
{
    public class WebDriverSection : ConfigurationSection
    {
        [ConfigurationProperty("type", IsKey = true)]
        public string Type
        {
            get { return ((string)base["type"]); }
        }

        [ConfigurationProperty("desiredCapabilities")]
        public DesiredCapabilityElementCollection DesiredCapabilities
        {
            get { return ((DesiredCapabilityElementCollection) base["desiredCapabilities"]); }
        }
    }
}
