using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium;
using OpenQA.Selenium.Android;
using OpenQA.Selenium.Remote;
using WebTesting.Selenium.Configuration;

namespace WebTesting.Selenium
{
    public class WebDriver
    {
        private static IWebDriver _current;

        public static IWebDriver Current
        {
            get
            {
                if (_current == null)
                {
                    var config = (WebDriverSection)System.Configuration.ConfigurationManager.GetSection("webDriver");

                    var type = Type.GetType(config.Type + "Driver");

                    if (type == null)
                    {
                        throw new InvalidCastException("Invalid web driver type in the configuration");
                    }

                    IWebDriver driver;
                    switch (config.Type)
                    {
                        case "RemoteWeb":
                            var capabilities = new DesiredCapabilitiesFactory().Create(config);
                            driver = (IWebDriver)Activator.CreateInstance(type, capabilities);
                            break;
                        default:
                             driver = (IWebDriver)Activator.CreateInstance(type);
                            break;
                    }
                    
                    _current = driver;
                }

                return _current;
            }
        }


    }
}
