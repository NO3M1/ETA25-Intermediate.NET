using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium;

namespace ETA25_Intermediate_C_.Session5.HelperMethods;

public class JavascriptHelper
{
    private readonly IWebDriver _driver;
    private readonly IJavaScriptExecutor _javascriptExecutor;



    //instantiem chromedriver - constructor
    public JavascriptHelper(IWebDriver driver)
    {
        // _driver = private
        _driver = driver;
        _javascriptExecutor = (IJavaScriptExecutor)_driver;

    }

    /// <summary>
    /// Executes a javascript scroll to the x, y coordinates 
    /// </summary>
    public void Scroll(int x, int y)
    {
        _javascriptExecutor.ExecuteScript($"window.scrollTo({x}, {y});");
    }

    public void ScrollHorizontally(int x)
    {
        _javascriptExecutor.ExecuteScript($"window.scrollTo({x}, 0)");
    }

    public void ScrollVertically(int y)
    {
        _javascriptExecutor.ExecuteScript($"window.scrollTo(0, {y})");
    }

    public void ForceClick(IWebElement element)
    {
        _javascriptExecutor.ExecuteScript("arguments[0].click();", element);
        //prin argument 0 spunem ca elementul nostru de tip web element este $0
    }



}


