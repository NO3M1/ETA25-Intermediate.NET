using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ETA25_Intermediate_C_.Session4.Enums;
using ETA25_Intermediate_C_.Session4.HelperMethods;
using ETA25_Intermediate_C_.Session4.Pages;
using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;

namespace ETA25_Intermediate_C_.Session4;

public class WebTabelTests
{

    public IWebDriver Driver;
    public const string BaseUrl = "https://demoqa.com/";
    public JavascriptHelper JavascriptHelper;
    private readonly WebTablePage _webTablePage;
    private readonly Homepage _homePage;

    public WebTabelTests()
    {
        Driver = new ChromeDriver();
        JavascriptHelper = new JavascriptHelper(Driver);
        _webTablePage = new WebTablePage(Driver);
        _homePage = new Homepage(Driver);
    }

    [SetUp]
    public void Setup()
    {
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

    [Test]
    public void WebTableTest1()
    {
        JavascriptHelper.ScrollVertically(300);
        _homePage.AccesPageByName(CardName.Elements);
        IWebElement webTableOption = Driver.FindElement(By.XPath("//span[text()=\"Web Tables\"]"));
        webTableOption.Click();
        _webTablePage.AddButton.Click();
        _webTablePage.RegistrationFormCompletion("Noemi", "Sz", "test@test.com", "99", "99999", "IT");
        _webTablePage.RegistationSubmitButton.Click();

        //assert
        _webTablePage.ValidateRegistrationFormEntry("Noemi", "Sz", "test@test.com", "99", "99999", "IT");

    }


    [TestCase("Noemi", "Sz", "test@test.com", "99", "9999", "IT")]
    public void WebTableTestCase(string firstName, string lastName, string email, string age, string salary, string department)
    {
        JavascriptHelper.ScrollVertically(300);
        _homePage.AccesPageByName(CardName.Elements);
        IWebElement webTableOption = Driver.FindElement(By.XPath("//span[text()=\"Web Tables\"]"));
        webTableOption.Click();
        _webTablePage.AddButton.Click();
        _webTablePage.RegistrationFormCompletion(firstName, lastName, email, age, salary, department);
        _webTablePage.RegistationSubmitButton.Click();

        //assert
        _webTablePage.ValidateRegistrationFormEntry(firstName, lastName, email, age, salary, department);
        

    }
}

