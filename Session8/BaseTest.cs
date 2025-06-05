using ETA25_Intermediate_C_.Session8.HelperMethods;
using ETA25_Intermediate_C_.Session8.Pages;
using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;

namespace ETA25_Intermediate_C_.Session8;
public abstract class BaseTest
{
    protected IWebDriver Driver { get; private set; } = null!;
    public const string BaseUrl = "https://demoqa.com/";
    protected AlertHelper AlertHelper { get; private set; } = null!;
    protected JavascriptHelper JavascriptHelper { get; private set; } = null!;
    protected Homepage HomePage { get; private set; } = null!;
    protected AlertsPage AlertsPage { get; private set; } = null!;
    protected  PracticeFormPage PracticeFormPage { get; private set; } = null!;



    [SetUp]
    public void Setup()
    {

        Driver = new ChromeDriver();
        AlertHelper= new AlertHelper(Driver);
        JavascriptHelper = new JavascriptHelper(Driver);
        HomePage = new Homepage(Driver);
        AlertsPage = new AlertsPage(Driver);
        PracticeFormPage = new PracticeFormPage(Driver);    


        Driver.Navigate().GoToUrl(BaseUrl);
        Driver.Manage().Window.Maximize();

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
}
