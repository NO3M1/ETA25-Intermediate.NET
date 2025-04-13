using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ETA25_Intermediate_C_.HelperMethods;
using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;

namespace ETA25_Intermediate_C_.Session2;
public class TextBoxTests
{
    public IWebDriver Driver;
    public const string BaseUrl = "https://demoqa.com/";
    public JavascriptHelper JavascriptHelper;

    //input field values
    public const string FullName = "Noemi Sz";
    public const string Email = "noemi@test.com";
    public const string CurrentAddress = "This is my current address";
    public const string PermanentAddress = "This is my permanent address";

    //constructor default
    public TextBoxTests()
    {
        Driver = new ChromeDriver();
        JavascriptHelper = new JavascriptHelper(Driver);

    }

    //metoda
    [SetUp]
    public void Setup()
    {
    
        Driver.Navigate().GoToUrl(BaseUrl);
        Driver.Manage().Window.Maximize();


    }

    [Test]
    public void FillFormTest()
    {

        IJavaScriptExecutor jsExecutor = (IJavaScriptExecutor)Driver;
        jsExecutor.ExecuteScript("window.scrollTo(0,1000)");

        IWebElement elementButton = Driver.FindElement(By.XPath("//h5[text()=\"Elements\"]"));
        elementButton.Click();

        IWebElement textBoxOption = Driver.FindElement(By.XPath("//span[text()=\"Text Box\"]"));
        textBoxOption.Click();


        //initializam un webelement pentru inputul Full Name

        /*v1
        By fullNameInputSelector = By.Id("userName");
        IWebElement fullNameInput = Driver.FindElement(fullNameInputSelector);*/

        //v2
        IWebElement fullNameInput = Driver.FindElement(By.Id("userName"));
        IWebElement userEmailInput = Driver.FindElement(By.Id("userEmail"));
        IWebElement currentAddressInput = Driver.FindElement(By.Id("currentAddress"));
        IWebElement permanentAddressInput = Driver.FindElement(By.Id("permanentAddress"));
        IWebElement submitButton = Driver.FindElement(By.Id("submit"));

        // Fill in fields with values
        fullNameInput.SendKeys(FullName);
        userEmailInput.SendKeys(Email);
        currentAddressInput.SendKeys(CurrentAddress);
        permanentAddressInput.SendKeys(PermanentAddress);

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
}

