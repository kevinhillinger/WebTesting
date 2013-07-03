using System.Configuration;

namespace WebTesting.Selenium.Configuration
{
    [ConfigurationCollection(typeof(DesiredCapabilityElement))]
    public class DesiredCapabilityElementCollection : ConfigurationElementCollection
    {
        protected override ConfigurationElement CreateNewElement()
        {
            return new DesiredCapabilityElement();
        }

        protected override object GetElementKey(ConfigurationElement element)
        {
            return ((DesiredCapabilityElement) element).Name;
        }
    }
}
