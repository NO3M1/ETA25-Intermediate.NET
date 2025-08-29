using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ETA25_Intermediate_C_.Session10.Enums;
using ETA25_Intermediate_C_.Session10.Interfaces;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Firefox;

namespace ETA25_Intermediate_C_.Session10.Drivers;
public static class BrowserFactory
{
    public static IBrowser GetBrowser(DriverType driverType)
    {
        switch (driverType)
        {
            case DriverType.Chrome:
                return new ChromeBrowser();

            case DriverType.Edge:
                return new EdgeBrowser();

            case DriverType.Firefox:
                return new FirefoxBrowser();

            default:
                throw new ArgumentException("Invalid type of browser", nameof(driverType));

        }
    }
}
