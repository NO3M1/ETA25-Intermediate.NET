using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ETA25_Intermediate_C_.Session10.Enums;
using ETA25_Intermediate_C_.Session10.HelperMethods;
using ETA25_Intermediate_C_.Session10.Pages;
using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Support.UI;

namespace ETA25_Intermediate_C_.Session10;

[TestFixture(DriverType.Chrome)]
[TestFixture(DriverType.Firefox)]
[TestFixture(DriverType.Edge)]

public class AlertsFramesWindowsTests : BaseTest
{
    public AlertsFramesWindowsTests(DriverType driverType) : base(driverType)
    {
    }

    [SetUp]
    public override void ExtraSetup()
    {

        AlertsPage = new AlertsPage(Driver);

        HomePage.AccesPageByName(Enums.CardName.AlertsFramesWindows);

        AlertsPage.AccessSideMenuOption(Enums.AlertsFramesWindowsMenuOption.Alerts);

        JavascriptHelper.ScrollVertically(200);
    }

    [TearDown]
    public override void ExtraCleanup()
    {
        //add implementation here
    }

    protected AlertsPage AlertsPage { get; private set; } = null!;

    [Test]
    public void OpenBasicAlertTest()
    {

        AlertsPage.OpenBasicAlert();

        var alertText = AlertHelper.GetAlertText();
        Assert.That(alertText == "You clicked a button");
    }

    [TestCase("This alert appeared after 5 seconds")]
    public void OpenTimerAlertTest(string alertExpectedText)
    {

        AlertsPage.OpenTimerAlert();

        var alertText = AlertHelper.GetAlertTextWithDelay();
        Assert.That(alertText == alertExpectedText);

    }

    [Test]
    public void OpenConfirmationAlertTest()
    {

        AlertsPage.OpenConfirmationAlert();

        var alertText = AlertHelper.GetAlertText();
        Assert.That(alertText == "Do you confirm action?");

        AlertHelper.AlertCancel();
        var alertResultText = AlertsPage.GetConfirmationAlertResult();

        Assert.That(alertResultText == "You selected Cancel");

    }

    //extra :)
    [TestCase("Ok")]
    public void OpenOKorCancelAlertTest(string userInput)
    {

        AlertsPage.OpenConfirmationAlert();

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

        var alertResultText = AlertsPage.GetConfirmationAlertResult();

        Assert.That(alertResultText == $"You selected {userInput}");

    }

    //scenariu negativ
    [Test]
    public void CheckConfirmationAlertResultWithoutOpeningALertTest()
    {

        ////AlertsPage.OpenConfirmationAlert();
        //var alertText = AlertHelper.GetAlertText();
        //Assert.That(alertText == "Do you confirm action?");
        //AlertHelper.AlertCancel();

        var alertResultText = AlertsPage.GetConfirmationAlertResult();

        //Assert.That(alertResultText == "");
        Assert.That(alertResultText == string.Empty);

    }

    [TestCase("Noemi Sz")]
    public void OpenComplexAlertTest(string alertInputText)
    {
        AlertsPage.OpenComplexAlert();

        var alertText = AlertHelper.GetAlertText();
        Assert.That(alertText == "Please enter your name");

        AlertHelper.AlertSendtext(alertInputText);
        var alertResultText = AlertsPage.GetComplexAlertResult();

        //Assert.That(alertResultText == $"You entered {alertInputText}");

    }

    /*    [Test]
        public void SwitchingAndGettingTextFromTheFrames()
        {
            HomePage.AccesPageByName(Enums.CardName.AlertsFramesWindows);

            IWebElement framesOption = Driver.FindElement(By.XPath("//span[text()=\"Frames\"]"));
            framesOption.Click();

            //FramesPage.GetTextFromBigFrame();

            //FramesPage.GetTextFromSmallFrame();

            //FramesPage.ScrollOnSmallFrame();


            Thread.Sleep(1000);
        }*/

    /*    [Test]
        public void GetTextFromNewTabTest()
        {
            HomePage.AccesPageByName(Enums.CardName.AlertsFramesWindows);

            IWebElement browserWindowOption = Driver.FindElement(By.XPath("//span[text()=\"Browser Windows\"]"));
            browserWindowOption.Click();

            //BrowserWindowsPage.GetTextFromNewTabButton();


            Thread.Sleep(1000);
        }*/

    /*    [Test]
        public void GetTextFromNewWindowButtonTest()
        {
            HomePage.AccesPageByName(Enums.CardName.AlertsFramesWindows);

            IWebElement browserWindowOption = Driver.FindElement(By.XPath("//span[text()=\"Browser Windows\"]"));
            browserWindowOption.Click();

            // BrowserWindowsPage.GetTextFromNewWindowButton();


            Thread.Sleep(1000);
        }*/

    /*    [Test]
        public void NestedFramesSwithcBackTest()
        {

            HomePage.AccesPageByName(Enums.CardName.AlertsFramesWindows);

            IWebElement nestedFramesOption = Driver.FindElement(By.XPath("//span[text()=\"Nested Frames\"]"));
            nestedFramesOption.Click();

            //NestedFramesPage.GetTextFromParent();
            // NestedFramesPage.GetTextFromChildFrame();

            //Console.WriteLine("Text returned from ParentFrame is:" + NestedFramesPage.GetTextFromParent());
            //  Console.WriteLine("Text returned from ChildFrame is:" + NestedFramesPage.GetTextFromChildFrame());
        }
    }*/

     [TestCase(DriverType.Firefox)]
    //[Test]
    public void OpenNewWindowMessageTest(DriverType driverType)
    {
        AlertsPage.AccessSideMenuOption(Enums.AlertsFramesWindowsMenuOption.BrowserWindows);

        IWebElement newWindowMessageButton = Driver.FindElement(By.Id("messageWindowButton"));
        newWindowMessageButton.Click();

        List<string> windows = Driver.WindowHandles.ToList();
        var currentWindowName = Driver.CurrentWindowHandle;
        Driver.SwitchTo().Window(windows[1]);


        string pageText = Driver.FindElement(By.TagName("body")).Text;
        string validationText = "Knowledge increases by sharing but not by saving. Please share this website with your friends and in your organization.";

        Assert.That(pageText, Is.EqualTo(validationText));
    }

}
