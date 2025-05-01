using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium;

namespace ETA25_Intermediate_C_.Session5.Pages;

public class BasePage
{
    public BasePage(IWebDriver driver)
    {
        Driver = driver;
    }

    // va fi initializat o singura data
    protected IWebDriver Driver { get; }

    //WebElements

    public IWebElement ElementsMenu => GetMenuSection(1);
    public IWebElement FormsMenu => GetMenuSection(2);
    public IWebElement AlertFrameWindowsMenu => GetMenuSection(3);
    public IWebElement WidgetsMenu => GetMenuSection(4);
    public IWebElement InteractionsMenu => GetMenuSection(5);
    public IWebElement BookStoreApplicationMenu => GetMenuSection(6);


    private IWebElement GetMenuSection(int elementNo)
    {
        if (elementNo < 1 || elementNo > 6)
        {
            throw new ArgumentException("Element number out of valid range [1-6]");
        }
        return Driver.FindElement(By.XPath($"//div[@class=\"element-group\"][{elementNo}]"));
    }


}

