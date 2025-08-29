using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ETA25_Intermediate_C_.Session10.Interfaces;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Firefox;

namespace ETA25_Intermediate_C_.Session10.Drivers;
public class FirefoxBrowser : IBrowser
{
    public IWebDriver CreateDriver()
    {
     
        //var options = new FirefoxOptions();
        var driver = new FirefoxDriver();
        driver.Manage().Window.Maximize();


        return driver;
    }
}
