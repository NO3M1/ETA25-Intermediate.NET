using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ETA25_Intermediate_C_.Session8.Enums;
using ETA25_Intermediate_C_.Session8.HelperMethods;
using ETA25_Intermediate_C_.Session8.Pages;
using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;

namespace ETA25_Intermediate_C_.Session8;
public class AlertsFramesWindowsTests : BaseTest
{

    [Test]
    public void OpenBasicAlertTest()
    {
        HomePage.AccesPageByName(Enums.CardName.AlertsFramesWindows);

        IWebElement practiceFormOption = Driver.FindElement(By.XPath("//span[text()=\"Alerts\"]"));
        practiceFormOption.Click();

        AlertsPage.OpenBasicAlert();

        var alertText = AlertHelper.GetAlertText();
        Assert.That(alertText == "You clicked a button");

    }

    [TestCase("This alert appeared after 5 seconds")]
    public void OpenTimerAlertTest(string alertExpectedText)
    {
        HomePage.AccesPageByName(Enums.CardName.AlertsFramesWindows);

        IWebElement practiceFormOption = Driver.FindElement(By.XPath("//span[text()=\"Alerts\"]"));
        practiceFormOption.Click();

        AlertsPage.OpenTimerAlert();

        var alertText = AlertHelper.GetAlertTextWithDelay();
        Assert.That(alertText == alertExpectedText);

    }

    [Test]
    public void OpenConfirmationAlertTest()
    {
        HomePage.AccesPageByName(Enums.CardName.AlertsFramesWindows);

        IWebElement practiceFormOption = Driver.FindElement(By.XPath("//span[text()=\"Alerts\"]"));
        practiceFormOption.Click();

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

        HomePage.AccesPageByName(Enums.CardName.AlertsFramesWindows);

        IWebElement practiceFormOption = Driver.FindElement(By.XPath("//span[text()=\"Alerts\"]"));
        practiceFormOption.Click();

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
        HomePage.AccesPageByName(Enums.CardName.AlertsFramesWindows);

        IWebElement practiceFormOption = Driver.FindElement(By.XPath("//span[text()=\"Alerts\"]"));
        practiceFormOption.Click();

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
        HomePage.AccesPageByName(Enums.CardName.AlertsFramesWindows);

        IWebElement practiceFormOption = Driver.FindElement(By.XPath("//span[text()=\"Alerts\"]"));
        practiceFormOption.Click();

        AlertsPage.OpenComplexAlert();

        var alertText = AlertHelper.GetAlertText();
        Assert.That(alertText == "Please enter your name");

        AlertHelper.AlertSendtext(alertInputText);

        var alertResultText = AlertsPage.GetComplexAlertResult();

        Console.WriteLine($"alertResultText: {alertResultText}"); // nu se ia textul din ceva motiv

        Assert.That(alertResultText == $"You entered {alertInputText}", Is.True);

    }

    [Test]
    public void SwitchingAndGettingTextFromTheFrames()
    {
        HomePage.AccesPageByName(Enums.CardName.AlertsFramesWindows);

        IWebElement framesOption = Driver.FindElement(By.XPath("//span[text()=\"Frames\"]"));
        framesOption.Click();

        //FramesPage.GetTextFromBigFrame();

        //FramesPage.GetTextFromSmallFrame();

        //FramesPage.ScrollOnSmallFrame();


        Thread.Sleep(1000);
    }

    [Test]
    public void GetTextFromNewTabTest()
    {
        HomePage.AccesPageByName(Enums.CardName.AlertsFramesWindows);

        IWebElement browserWindowOption = Driver.FindElement(By.XPath("//span[text()=\"Browser Windows\"]"));
        browserWindowOption.Click();

        //BrowserWindowsPage.GetTextFromNewTabButton();


        Thread.Sleep(1000);
    }

    [Test]
    public void GetTextFromNewWindowButtonTest()
    {
        HomePage.AccesPageByName(Enums.CardName.AlertsFramesWindows);

        IWebElement browserWindowOption = Driver.FindElement(By.XPath("//span[text()=\"Browser Windows\"]"));
        browserWindowOption.Click();

        // BrowserWindowsPage.GetTextFromNewWindowButton();


        Thread.Sleep(1000);
    }

    [Test]
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
}

