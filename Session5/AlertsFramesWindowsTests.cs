using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ETA25_Intermediate_C_.Session5.Enums;
using ETA25_Intermediate_C_.Session5.HelperMethods;
using ETA25_Intermediate_C_.Session5.Pages;
using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;

namespace ETA25_Intermediate_C_.Session5;
public class AlertsFramesWindowsTests
{
    public IWebDriver Driver { get; private set; }
    public const string BaseUrl = "https://demoqa.com/";
    public AlertHelper AlertHelper;
    public JavascriptHelper JavascriptHelper;
    private readonly Homepage _homePage;
    private readonly AlertsPage _alertsPage;

    //contructor
    public AlertsFramesWindowsTests()
    {
        //initializare driverului & others
        Driver = new ChromeDriver();
        AlertHelper = new AlertHelper(Driver);
        JavascriptHelper = new JavascriptHelper(Driver);
        _homePage = new Homepage(Driver);
        _alertsPage = new AlertsPage(Driver);
        
    }

    [SetUp]
    public void Setup()
    {
        Driver.Navigate().GoToUrl(BaseUrl);
        Driver.Manage().Window.Maximize();

        JavascriptHelper.ScrollVertically(400);

        _homePage.AccesPageByName(CardName.AlertsFramesWindows);

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
    public void OpenBasicAlertTest()
    {

        IWebElement practiceFormOption = Driver.FindElement(By.XPath("//span[text()=\"Alerts\"]"));
        practiceFormOption.Click();

        _alertsPage.OpenBasicAlert();

        var alertText = AlertHelper.GetAlertText();
        Assert.That(alertText == "You clicked a button");

    }

    [TestCase("This alert appeared after 5 seconds")]
    public void OpenTimerAlertTest(string alertExpectedText)
    {

        IWebElement practiceFormOption = Driver.FindElement(By.XPath("//span[text()=\"Alerts\"]"));
        practiceFormOption.Click();

        _alertsPage.OpenTimerAlert();

        var alertText = AlertHelper.GetAlertTextWithDelay();
        Assert.That(alertText == alertExpectedText);

    }

    [Test]
    public void OpenConfirmationAlertTest()
    {

        IWebElement practiceFormOption = Driver.FindElement(By.XPath("//span[text()=\"Alerts\"]"));
        practiceFormOption.Click();

        _alertsPage.OpenConfirmationAlert();

        var alertText = AlertHelper.GetAlertText();
        Assert.That(alertText == "Do you confirm action?");

        AlertHelper.AlertCancel();
        var alertResultText = _alertsPage.GetConfirmationAlertResult();

        Assert.That(alertResultText == "You selected Cancel");

    }

    //extra :)
    [TestCase("Ok")]
    public void OpenOKorCancelAlertTest(string userInput)
    {

        IWebElement practiceFormOption = Driver.FindElement(By.XPath("//span[text()=\"Alerts\"]"));
        practiceFormOption.Click();

        _alertsPage.OpenConfirmationAlert();

        var alertText = AlertHelper.GetAlertText();
        Assert.That(alertText == "Do you confirm action?");

        if (userInput == "Cancel")
        {
            AlertHelper.AlertCancel();
        }
        else 
        {
            AlertHelper.AlertOk();
        }

        var alertResultText = _alertsPage.GetConfirmationAlertResult();

        Assert.That(alertResultText == $"You selected {userInput}");

    }

    //scenariu negativ
    [Test]
    public void CheckConfirmationAlertResultWithoutOpeningALertTest()
    {

        IWebElement practiceFormOption = Driver.FindElement(By.XPath("//span[text()=\"Alerts\"]"));
        practiceFormOption.Click();

        ////_alertsPage.OpenConfirmationAlert();
        //var alertText = AlertHelper.GetAlertText();
        //Assert.That(alertText == "Do you confirm action?");
        //AlertHelper.AlertCancel();

        var alertResultText = _alertsPage.GetConfirmationAlertResult();

        //Assert.That(alertResultText == "");
        Assert.That(alertResultText == string.Empty);

    }

    [TestCase("Noemi Sz")]
    public void OpenComplexAlertTest(string alertInputText)
    {

        IWebElement practiceFormOption = Driver.FindElement(By.XPath("//span[text()=\"Alerts\"]"));
        practiceFormOption.Click();

        _alertsPage.OpenComplexAlert();

        var alertText = AlertHelper.GetAlertText();
        Assert.That(alertText == "Please enter your name");

        AlertHelper.AlertSendtext(alertInputText);

        var alertResultText = _alertsPage.GetComplexAlertResult();

        Console.WriteLine($"alertResultText: {alertResultText}"); // nu se ia textul din ceva motiv

        Assert.That(alertResultText == $"You entered {alertInputText}", Is.True);

    }


}

