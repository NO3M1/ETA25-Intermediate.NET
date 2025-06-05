using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ETA25_Intermediate_C_.Session8.HelperMethods;
using OpenQA.Selenium;

namespace ETA25_Intermediate_C_.Session8.Pages;

class FramesPage
{
    private readonly IWebDriver _driver;
    private readonly JavascriptHelper _javascriptHelper;
    private readonly FramesHelper _framesHelper;

    public FramesPage(IWebDriver driver)
    {
        _driver = driver;
        _javascriptHelper = new JavascriptHelper(driver);
        _framesHelper = new FramesHelper(driver);
      
    }

    IWebElement frame1 => _driver.FindElement(By.Id("frame1"));
    IWebElement frame2 => _driver.FindElement(By.Id("frame2"));
    IWebElement frame1Text => _driver.FindElement(By.Id("sampleHeading"));
    IWebElement frame2Text => _driver.FindElement(By.Id("sampleHeading"));

    public void GetTextFromBigFrame()
    {
        _framesHelper.SwithToFrame(frame1);

        //or
        //_driver.SwitchTo().Frame(frame1);

        Console.WriteLine(frame1Text.Text);

        //revenim la main content
        _driver.SwitchTo().DefaultContent();
        //or folosim helperul
        _framesHelper.SwithToDeafultContent();

    }

    public void ScrollOnSmallFrame()
    {
        _javascriptHelper.ScrollVertically(1000);
        _framesHelper.SwithToFrame(frame2);
        _javascriptHelper.Scroll(1000,1000);

    }

    public void GetTextFromSmallFrame()
    {
        _framesHelper.SwithToFrame(frame2);
        Console.WriteLine(frame2Text.Text);
        _framesHelper.SwithToDeafultContent();
    }

}
