using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium;
using ETA25_Intermediate_C_.Session7.HelperMethods;
using ETA25_Intermediate_C_.Session7.Pages;
using ETA25_Intermediate_C_.Session7.Enums;

namespace ETA25_Intermediate_C_.Session7;

public class SideMenuTests
{

    public IWebDriver Driver;
    public const string BaseUrl = "https://demoqa.com/";
    public JavascriptHelper JavascriptHelper;
    private Homepage _homePage;
    private BasePage _basePage;





    // constructor
    public SideMenuTests()
    {

        //moved initializations to Setup method tu support running multiple  tests from the same test class 
        //initializare driverului & others

    }

    [SetUp]
    public void Setup()
    {
        Driver = new ChromeDriver();
        JavascriptHelper = new JavascriptHelper(Driver);
        _homePage = new Homepage(Driver);
        _basePage = new BasePage(Driver);

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

    [TestCase(ElementsMenuOption.TextBox, "text-box")]
    [TestCase(ElementsMenuOption.CheckBox, "checkbox")]
    [TestCase(ElementsMenuOption.RadioButton, "radio-button")]
    [TestCase(ElementsMenuOption.WebTables, "webtables")]
    [TestCase(ElementsMenuOption.Buttons, "buttons")]
    [TestCase(ElementsMenuOption.Links, "links")]
    [TestCase(ElementsMenuOption.BrokenLinks, "broken")]
    [TestCase(ElementsMenuOption.UploadAndDownload, "upload-download")]
    [TestCase(ElementsMenuOption.DynamicProperties, "dynamic-properties")]
    public void AccessElementsMenuOptionsWithMenuExpandedTest(ElementsMenuOption menuOption, string expectedUrlPath)
    {
        _homePage.AccesPageByName(CardName.Elements);
        _basePage.AccessSideMenuOption(menuOption);

        var pageUrl = Driver.Url;

        Assert.That(pageUrl.Contains(expectedUrlPath));
    }

    [TestCase(FormsMenuOption.PracticeForm, "automation-practice-form")]
    public void AccessFormsMenuOptionWithMenuCollapsedTest(FormsMenuOption menuOption, string expectedUrlPath)
    {
        _homePage.AccesPageByName(CardName.Forms);

        //intentionally collapsing menu section
        _basePage.FormsMenu.Click();

    }
}