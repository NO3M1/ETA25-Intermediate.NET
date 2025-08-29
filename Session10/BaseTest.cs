using ETA25_Intermediate_C_.Session10.Drivers;
using ETA25_Intermediate_C_.Session10.Enums;
using ETA25_Intermediate_C_.Session10.HelperMethods;
using ETA25_Intermediate_C_.Session10.Interfaces;
using ETA25_Intermediate_C_.Session10.Pages;
using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Firefox;

namespace ETA25_Intermediate_C_.Session10;
public abstract class BaseTest
{
  

    protected IWebDriver Driver { get; private set; } = null!;
    public const string BaseUrl = "https://demoqa.com/";
    protected AlertHelper AlertHelper { get; private set; } = null!;
    protected JavascriptHelper JavascriptHelper { get; private set; } = null!;
    protected Homepage HomePage { get; private set; } = null!;
    protected DriverType DriverType { get; }


    //toate clasele care nu au testfixure - o sa functioneze cu default chrome
    protected BaseTest() : this(DriverType.Chrome)
    {

    }

    protected BaseTest(DriverType driverType)
    {
        DriverType = driverType;

    }


    [SetUp]
    public void Setup()
    {

        //citirea contextului?
    
        var arg = TestContext.CurrentContext.Test.Arguments.FirstOrDefault()?.ToString();
        var result = Enum.TryParse(arg, out DriverType driverTypeArg);


        //identify the type of browser class needed 
        IBrowser browser = result is not false ? BrowserFactory.GetBrowser(driverTypeArg): BrowserFactory.GetBrowser(DriverType);

        //initialize the actual Iwebdriver
        Driver = browser.CreateDriver();

        Driver.Navigate().GoToUrl(BaseUrl);


        AlertHelper = new AlertHelper(Driver);
        JavascriptHelper = new JavascriptHelper(Driver);
        HomePage = new Homepage(Driver);


    }


    [TearDown]
    public void CleanUp()
    {
        if (Driver != null)
        {
            Driver.Quit();
            Driver.Dispose();

        }

    }
    /// <summary>
    /// Please decorate this method with [SetUp] attribute
    /// and use it for extra setup before running tests 
    /// </summary>
    public abstract void ExtraSetup();


    /// <summary>
    /// Please decorate this method with [CleanUp] attribute
    /// and use it for extra clean up after running tests 
    /// </summary>
    public abstract void ExtraCleanup();




}
