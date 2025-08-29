using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ETA25_Intermediate_C_.Session10.Interfaces;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;

namespace ETA25_Intermediate_C_.Session10.Drivers;
public class ChromeBrowser : IBrowser
{
    public IWebDriver CreateDriver()
    {
        //scopul: setarea driverului + intoarcem

        //options- ii dam optini cu care sa fie initializat driverul de chrome 
        var options = new ChromeOptions();
        options.AddArgument("--start-maximized");

        return new ChromeDriver(options);
    }
}
