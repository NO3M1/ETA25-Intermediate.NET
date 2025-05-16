using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium.Support.UI;
using OpenQA.Selenium;

namespace ETA25_Intermediate_C_.Session7.HelperMethods;

class FramesHelper
{
    private readonly IWebDriver _driver;
    private readonly WebDriverWait _wait;

    public FramesHelper(IWebDriver driver)
    {
        _driver = driver;
        _wait = new WebDriverWait(_driver, TimeSpan.FromSeconds(5));
    }

    public void SwithToFrame(IWebElement frame)
    {
        _driver.SwitchTo().Frame(frame);
    }

    public void SwithToDeafultContent()
    {
        _driver.SwitchTo().DefaultContent();
    }


}
