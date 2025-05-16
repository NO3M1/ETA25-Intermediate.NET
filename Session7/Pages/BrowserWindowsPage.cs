using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ETA25_Intermediate_C_.Session7.HelperMethods;
using NUnit.Framework;
using OpenQA.Selenium;

namespace ETA25_Intermediate_C_.Session7.Pages;

class BrowserWindowsPage
{
    private readonly IWebDriver _driver;
    private readonly FramesHelper _framesHelper;

    public BrowserWindowsPage(IWebDriver driver)
    {
        _driver = driver;
        _framesHelper = new FramesHelper(driver);
    }

    IWebElement newTabButton => _driver.FindElement(By.Id("tabButton"));
    IWebElement newWindowButton => _driver.FindElement(By.Id("windowButton"));
    IWebElement newWindowMessage => _driver.FindElement(By.Id("messageWindowButton"));
    IWebElement newTabText => _driver.FindElement(By.Id("sampleHeading"));
    IWebElement newTabHeading => _driver.FindElement(By.TagName("h1"));
    IWebElement newWindowHeading => _driver.FindElement(By.TagName("h1"));




    public void GetTextFromNewTabButton()
    {
        newTabButton.Click();
        List<string> tabsList = new List<string>(_driver.WindowHandles);
        _driver.SwitchTo().Window(tabsList[1]);
        _framesHelper.SwithToDeafultContent();

    }

    public void GetTextFromNewWindowButton()
    {
        newWindowButton.Click();
        List<string> tabsList = new List<string>(_driver.WindowHandles);
        _driver.SwitchTo().Window(tabsList[1]);
        Assert.That(newWindowHeading.Text, Is.EqualTo("This is a sample page"));
    }

    //new window text ?
}
