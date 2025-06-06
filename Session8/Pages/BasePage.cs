﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ETA25_Intermediate_C_.Session8.Enums;
using ETA25_Intermediate_C_.Session8.HelperMethods;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;

namespace ETA25_Intermediate_C_.Session8.Pages;

public class BasePage
{
    protected IWebDriver Driver { get; init; }

    public BasePage(IWebDriver driver)
    {
        Driver = driver;
    }
    //WebElements
    public IWebElement ElementsMenu => GetMenuSection(1);
    public IWebElement FormsMenu => GetMenuSection(2);
    public IWebElement AlertFrameWindowsMenu => GetMenuSection(3);
    public IWebElement WidgetsMenu => GetMenuSection(4);
    public IWebElement InteractionsMenu => GetMenuSection(5);
    public IWebElement BookStoreApplicationMenu => GetMenuSection(6);


    private IWebElement GetMenuSection(int elementNo)
    {
        if (elementNo < 1 || elementNo > 6)
        {
            throw new ArgumentException("Element number out of valid range [1-6]");
        }
        return Driver.FindElement(By.XPath($"//div[@class=\"element-group\"][{elementNo}]"));
    }

    #region Enum tu string Dictionaries 


    // asociere intre enum si valoarea noastra string 
    public Dictionary<ElementsMenuOption, string> ElementsMenuOptionsText = new Dictionary<ElementsMenuOption, string>()
    {
        { ElementsMenuOption.TextBox,           "Text Box" },
        { ElementsMenuOption.CheckBox,          "Check Box" },
        { ElementsMenuOption.RadioButton,       "Radio Button" },
        { ElementsMenuOption.WebTables,         "Web Tables" },
        { ElementsMenuOption.Buttons,           "Buttons" },
        { ElementsMenuOption.Links,             "Links" },
        { ElementsMenuOption.BrokenLinks,       "Broken Links - Images" },
        { ElementsMenuOption.UploadAndDownload, "Upload and Download" },
        { ElementsMenuOption.DynamicProperties, "Dynamic Properties" }

    };

    public Dictionary<FormsMenuOption, string> FormsMenuOptionText = new Dictionary<FormsMenuOption, string>()
    {
        { FormsMenuOption.PracticeForm, "Practice Form" }
    };

    public Dictionary<AlertsFramesWindowsMenuOption, string> AlertsFramesWindowsMenuOptionsText = new Dictionary<AlertsFramesWindowsMenuOption, string>()
    {
        { AlertsFramesWindowsMenuOption.BrowserWindows, "Browser Windows" },
        { AlertsFramesWindowsMenuOption.Alerts,         "Alerts" },
        { AlertsFramesWindowsMenuOption.Frames,         "Frames" },
        { AlertsFramesWindowsMenuOption.NestedFrames,   "Nested Frames" },
        { AlertsFramesWindowsMenuOption.ModalDialogs,   "Modal Dialogs" }
    };

    public Dictionary<Widgets, string> WidgetsMenuOptionsText = new()
    {
        {Widgets.Accordian, "Accordian" },
        {Widgets.AutoComplete, "Auto Complete" },
        {Widgets.DatePicker, "Date Picker" },
        {Widgets.Slider, "Slider" },
        {Widgets.ProgressBar, "Progress Bar" },
        {Widgets.Tabs, "Tabs" },
        {Widgets.ToolTips, "Tool Tips" },
        {Widgets.Menu, "Menu" },
        {Widgets.SelectMenu, "Select Menu" },


    };

    public Dictionary<Interactions, string> InteractionsMenuOptionsText = new()
    {
        { Interactions.Sortable, "Sortable" },
        { Interactions.Selectable, "Selectable" },
        { Interactions.Resizable, "Resizable" },
        { Interactions.Droppable, "Droppable" },
        { Interactions.Draggable, "Dragabble" },
    };



    #endregion


    #region Access Side Menu Option

    public void AccessSideMenuOption(ElementsMenuOption menuOption)
    {

        ElementsMenuOptionsText.TryGetValue(menuOption, out string? menuOptionText);

        ClickOnSideMenuOption(menuOptionText, ElementsMenu);


    }

    public void AccessSideMenuOption(FormsMenuOption menuOption)
    {
        FormsMenuOptionText.TryGetValue(menuOption, out string? menuOptionText);


        ClickOnSideMenuOption(menuOptionText, FormsMenu);

    }

    public void AccessSideMenuOption(AlertsFramesWindowsMenuOption menuOption)
    {
        AlertsFramesWindowsMenuOptionsText.TryGetValue(menuOption, out string? menuOptionText);


        ClickOnSideMenuOption(menuOptionText, AlertFrameWindowsMenu);

    }

    public void AccessSideMenuOption(Widgets menuOption)
    {
        WidgetsMenuOptionsText.TryGetValue(menuOption, out string? menuOptionText);


        ClickOnSideMenuOption(menuOptionText, WidgetsMenu);

    }

    public void AccessSideMenuOption(Interactions menuOption)
    {
        InteractionsMenuOptionsText.TryGetValue(menuOption, out string? menuOptionText);


        ClickOnSideMenuOption(menuOptionText, InteractionsMenu);

    }



    private void ClickOnSideMenuOption(string? menuOptionText, IWebElement parentWebElement)
    {

        IWebElement menuOptionsContainer = parentWebElement.FindElement(By.XPath("./div[contains(@class, \"element-list\")]"));
        bool areMenuOptionsVisible = menuOptionsContainer.GetAttribute("class")!.Contains("show"); 

        if (menuOptionText is not null)
        {
            if (areMenuOptionsVisible)
            {
                IWebElement option = Driver.FindElement(By.XPath($"//span[text()=\"{menuOptionText}\"]"));
                option.Click();

            }
            else
            {
                parentWebElement.Click();

                IWebElement option = Driver.FindElement(By.XPath($"//span[text()=\"{menuOptionText}\"]"));
                option.Click();
            }
        }

    }

    #endregion




}

