using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ETA25_Intermediate_C_.Session7.Enums;
using OpenQA.Selenium;

namespace ETA25_Intermediate_C_.Session7.Pages;

public class BasePage
{
    public BasePage(IWebDriver driver)
    {
        Driver = driver;
    }

    // va fi initializat o singura data
    protected IWebDriver Driver { get; }

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



    #endregion

    public void AccessSideMenuOption(ElementsMenuOption menuOption)
    {
        //verificam daca elementsmenu este expandat sau nu
        IWebElement menuOptionsContainer = ElementsMenu.FindElement(By.XPath("./div[contains(@class, \"element-list\")]"));
        bool areMenuOptionsVisible = menuOptionsContainer.GetAttribute("class")!.Contains("show"); //ne intoarce un string 


        //string menuOptionText = ElementsMenuOptionsText[menuOtion];
        ElementsMenuOptionsText.TryGetValue(menuOption, out string? menuOptionText);

        //varianta1
/*        if (areMenuOptionsVisible)
        {
            if (menuOptionText is not null)
            {
                IWebElement option = Driver.FindElement(By.XPath($"//span[text()=\"{menuOptionText}\"]")); //ea va cauta in disctionar valoarea pe care am obtinut-o in baza enumului
                option.Click();                                                                                   
            }
     
            else
            {
                ElementsMenu.Click();
                if (menuOptionText is not null)
                {
                    IWebElement option = Driver.FindElement(By.XPath($"//span[text()=\"{menuOptionText}\"]")); 
                    option.Click();
                }
            }
        }*/

        //varianta2

        if (menuOptionText is not null)
        {
            if (areMenuOptionsVisible)
            {
                IWebElement option = Driver.FindElement(By.XPath($"//span[text()=\"{menuOptionText}\"]")); //ea va cauta in disctionar valoarea pe care am obtinut-o in baza enumului
                option.Click();

            }
            else
            {
                //expand menu section 
                ElementsMenu.Click();

                IWebElement option = Driver.FindElement(By.XPath($"//span[text()=\"{menuOptionText}\"]"));
                option.Click();
            }
        }


    }

    public void AccessSideMenuOption(FormsMenuOption menuOption)
    {
        //verificam daca elementsmenu este expandat sau nu
        IWebElement menuOptionsContainer = ElementsMenu.FindElement(By.XPath("./div[contains(@class, \"element-list\")]"));
        bool areMenuOptionsVisible = menuOptionsContainer.GetAttribute("class")!.Contains("show"); //ne intoarce un string 


        //string menuOptionText = ElementsMenuOptionsText[menuOtion];
        FormsMenuOptionText.TryGetValue(menuOption, out string? menuOptionText);

        if (menuOptionText is not null)
        {
            if (areMenuOptionsVisible)
            {
                IWebElement option = Driver.FindElement(By.XPath($"//span[text()=\"{menuOptionText}\"]")); //ea va cauta in disctionar valoarea pe care am obtinut-o in baza enumului
                option.Click();

            }
            else
            {
                //expand menu section 
                FormsMenu.Click();

                IWebElement option = Driver.FindElement(By.XPath($"//span[text()=\"{menuOptionText}\"]"));
                option.Click();
            }
        }

    }




}

