using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ETA25_Intermediate_C_.Session9.Enums;
using ETA25_Intermediate_C_.Session9.HelperMethods;
using ETA25_Intermediate_C_.Session9.Pages;
using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.DevTools.V133.Storage;

namespace ETA25_Intermediate_C_.Session9;
public class TextBoxTests : BaseTest
{


    [TestCase(["Noemi Sz", "noemi@test.com", "This is my current address", "This is my permanent address"])]

    public void FillFormTest(string fullName, string email, string currentAddress, string permanentAddress)
    {
        JavascriptHelper.Scroll(0, 100);

        IWebElement textBoxOption = Driver.FindElement(By.XPath("//span[text()=\"Text Box\"]"));
        textBoxOption.Click();

        //v2
        IWebElement fullNameInput = Driver.FindElement(By.Id("userName"));
        IWebElement userEmailInput = Driver.FindElement(By.Id("userEmail"));
        IWebElement currentAddressInput = Driver.FindElement(By.Id("currentAddress"));
        IWebElement permanentAddressInput = Driver.FindElement(By.Id("permanentAddress"));
        IWebElement submitButton = Driver.FindElement(By.Id("submit"));

        // Fill in fields with values
        fullNameInput.SendKeys(fullName);
        userEmailInput.SendKeys(email);
        currentAddressInput.SendKeys(currentAddress);
        permanentAddressInput.SendKeys(permanentAddress);

        JavascriptHelper.Scroll(0, 500);

        //Submit la valori
        // submitButton.Click();
        JavascriptHelper.ForceClick(submitButton);


        Thread.Sleep(3000);





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
    [SetUp]
    public override void ExtraSetup()
    {
        HomePage.AccesPageByName(CardName.Elements);

    }

    [TearDown]
    public override void ExtraCleanup()
    {
        //add implementaiton here
    }
}

