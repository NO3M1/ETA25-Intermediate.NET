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
using OpenQA.Selenium.DevTools.V133.Storage;

namespace ETA25_Intermediate_C_.Session5;
public class TextBoxTests
{
    public IWebDriver Driver;
    public const string BaseUrl = "https://demoqa.com/";
    public JavascriptHelper JavascriptHelper;
    private readonly Homepage _homepage;

    //input field values
    //public const string FullName = "Noemi Sz";
    //public const string Email = "noemi@test.com";
    //public const string CurrentAddress = "This is my current address";
    //public const string PermanentAddress = "This is my permanent address";

    //constructor default
    public TextBoxTests()
    {
        Driver = new ChromeDriver();
        JavascriptHelper = new JavascriptHelper(Driver);
        _homepage = new Homepage(Driver);

    }

    //metoda
    [SetUp]
    public void Setup()
    {
    
        Driver.Navigate().GoToUrl(BaseUrl);
        Driver.Manage().Window.Maximize();


    }

    [TestCase(["Noemi Sz", "noemi@test.com", "This is my current address", "This is my permanent address"])]

    public void FillFormTest(string fullName, string email, string currentAddress, string permanentAddress)
    {
        JavascriptHelper.Scroll(0, 100);

        //HomePage varianta 1
        //_homepage.ElementsCard.Click();

        //HomePage varianta 2
        //_homepage.AccessElementsPage();

        //HomePage varianta 3
        _homepage.AccesPageByName(CardName.Elements);


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
}

