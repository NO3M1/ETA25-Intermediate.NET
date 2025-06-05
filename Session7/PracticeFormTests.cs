using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ETA25_Intermediate_C_.Session7.Enums;
using ETA25_Intermediate_C_.Session7.HelperMethods;
using ETA25_Intermediate_C_.Session7.Pages;
using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;

namespace ETA25_Intermediate_C_.Session7;

public class PracticeFormTests
{

    public IWebDriver Driver;
    public const string BaseUrl = "https://demoqa.com/";
    public JavascriptHelper JavascriptHelper;
    private readonly PracticeFormPage _practiceFormPage;
    private readonly Homepage _homePage;




    // constructor
    public PracticeFormTests()
    {
        //initializare driverului & others
        Driver = new ChromeDriver();
        JavascriptHelper = new JavascriptHelper(Driver);
        _practiceFormPage = new PracticeFormPage(Driver);
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
    public void PracticeFormTest1()
    {
        JavascriptHelper.ScrollVertically(300);
        _homePage.AccesPageByName(CardName.Forms);
   
        IWebElement practiceFormOption = Driver.FindElement(By.XPath("//span[text()=\"Practice Form\"]"));
        practiceFormOption.Click();

        JavascriptHelper.ScrollVertically(400);
        /*
                PracticeFormPage.FirstNameInput.SendKeys("Noemi");
                PracticeFormPage.LastNameInput.SendKeys("Sz");
                PracticeFormPage.EmailInput.SendKeys("test@test.com");
                PracticeFormPage.SelectGender(Gender.Male);
                PracticeFormPage.MobileInput.SendKeys("0748515895");
                PracticeFormPage.SetDateOfBirth("1992", "August", "31");
                PracticeFormPage.SelectSubjects(new List<string>() { "English", "Accounting", "Physics" });
                PracticeFormPage.SelectHobbies(new List<Hobby>() { Hobby.Music, Hobby.Reading });
                PracticeFormPage.CurrentAddressInput.SendKeys("Test address input");*/



        _practiceFormPage.FillInFormFields("Noemi", "Sz", "test@test.com", Gender.Male, "0748515895", "1992", "August", "31",
            new List<string>() { "English", "Accounting", "Physics" }, new List<Hobby>() { Hobby.Music, Hobby.Reading }, "Test address input");



        Thread.Sleep(8000);




    }

}

