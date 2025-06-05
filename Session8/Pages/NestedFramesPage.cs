using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ETA25_Intermediate_C_.Session8.HelperMethods;
using OpenQA.Selenium;

namespace ETA25_Intermediate_C_.Session8.Pages;

class NestedFramesPage
{
    private readonly IWebDriver _driver;
    private readonly FramesHelper _framesHelper;

    public NestedFramesPage(IWebDriver driver)
    {
        _driver = driver;
        _framesHelper = new FramesHelper(driver);
    }

    IWebElement iFrameParent => _driver.FindElement(By.Id("frame1"));
    //IWebElement bodyText => _driver.FindElement(By.TagName("body"));
    string bodyTextParent => _driver.FindElement(By.TagName("body")).Text;
    IWebElement iFrameChild => _driver.FindElement(By.TagName("iframe"));
    IWebElement bodyTextChild => _driver.FindElement(By.TagName("p"));

    public string GetTextFromParent()
    {
        //iFrameParent.Click();
        _framesHelper.SwithToFrame(iFrameParent);
        return bodyTextParent; 
    }

    public string GetTextFromChildFrame()
    {
        _driver.SwitchTo().Frame(iFrameChild);
        return bodyTextChild.Text;
    }
}
