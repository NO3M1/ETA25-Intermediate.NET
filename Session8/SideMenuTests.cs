using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium;
using ETA25_Intermediate_C_.Session8.HelperMethods;
using ETA25_Intermediate_C_.Session8.Pages;
using ETA25_Intermediate_C_.Session8.Enums;

namespace ETA25_Intermediate_C_.Session8;

public class SideMenuTests : BaseTest 
{

    [TestCase(ElementsMenuOption.TextBox, "text-box")]
    [TestCase(ElementsMenuOption.CheckBox, "checkbox")]
    [TestCase(ElementsMenuOption.RadioButton, "radio-button")]
    [TestCase(ElementsMenuOption.WebTables, "webtables")]
    [TestCase(ElementsMenuOption.Buttons, "buttons")]
    [TestCase(ElementsMenuOption.Links, "links")]
    [TestCase(ElementsMenuOption.BrokenLinks, "broken")]
    [TestCase(ElementsMenuOption.UploadAndDownload, "upload-download")]
    [TestCase(ElementsMenuOption.DynamicProperties, "dynamic-properties")]
    public void AccessElementsMenuOptionWithMenuExpandedTest(ElementsMenuOption menuOption, string expectedUrlPath)
    {
        HomePage.AccesPageByName(CardName.Elements);

        AlertsPage.AccessSideMenuOption(menuOption);

        var pageUrl = Driver.Url;

        Assert.That(pageUrl.Contains(expectedUrlPath));
    }

    [TestCase(FormsMenuOption.PracticeForm, "automation-practice-form")]
    public void AccessFormsMenuOptionWithMenuCollapsedTest(FormsMenuOption menuOption, string expectedUrlPath)
    {
        HomePage.AccesPageByName(CardName.Forms);

        // intetionally collapsing menu section
        //BasePage.FormsMenu.Click();
        AlertsPage.FormsMenu.Click();

        AlertsPage.AccessSideMenuOption(menuOption);

        var pageUrl = Driver.Url;

        Assert.That(pageUrl.Contains(expectedUrlPath));

    }
}