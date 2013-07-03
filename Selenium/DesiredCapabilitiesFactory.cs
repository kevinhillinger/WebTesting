using System;
using OpenQA.Selenium;
using OpenQA.Selenium.Remote;
using WebTesting.Selenium.Configuration;

namespace WebTesting.Selenium
{
    public class DesiredCapabilitiesFactory
    {
        public ICapabilities Create(WebDriverSection config)
        {
            var capabilities = (DesiredCapabilities)typeof (DesiredCapabilities).GetMethod(config.Type).Invoke(null, null);

            foreach (DesiredCapabilityElement element in config.DesiredCapabilities)
            {
                var typedValue = Convert.ChangeType(element.Value, element.Type);
                capabilities.SetCapability(element.Name, typedValue);
            }

            return capabilities;
        }
    }
}
