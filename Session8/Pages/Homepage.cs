using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ETA25_Intermediate_C_.Session8.Enums;
using ETA25_Intermediate_C_.Session8.HelperMethods;
using OpenQA.Selenium;

namespace ETA25_Intermediate_C_.Session8.Pages;

public class Homepage : BasePage
{
    //private readonly IWebDriver _driver;
    //private readonly JavascriptHelper _javascriptHelper;

    //constructor 
    public Homepage(IWebDriver Driver) : base(Driver) { }
 

    //WebElements

    //public IWebElement ElementsCard => _driver.FindElement(By.XPath("//h5[text()=\"Elements\"]")); or ->
    public IWebElement ElementsCard => GetCard("Elements");
    public IWebElement FormsCard => GetCard("Forms");
    public IWebElement AlertsFramesWindowCard => GetCard("Alerts, Frame & Windows");
    public IWebElement WidgetsCard => GetCard("Widgets");
    public IWebElement InteractionsCard => GetCard("Interactions");
    public IWebElement BookStoreApplicationCard => GetCard("Book Store Application");


    // metoda de accesare a paginii de la carduri + click
    // apelam direct prin lambda functions 

    //public void AccessElementsPage() => GetCard("Elements").Click(); or ->
    public void AccessElementsPage() => ElementsCard.Click(); 
    public void AccessFormsPage() => FormsCard.Click();
    public void AccessAlertsFramesWindowsPage() => AlertsFramesWindowCard.Click();
    public void AccessWidgetsPage() => WidgetsCard.Click();
    public void AccessInteractionsPage() => InteractionsCard.Click();
    public void AccessBookStoreApplicationPage() => BookStoreApplicationCard.Click();

 

    //metoda ce imi intoarce elementul pe baza textului
    private IWebElement GetCard(string cardName)
    {
        return Driver.FindElement(By.XPath($"//h5[text()=\"{cardName}\"]"));
    }

    public void AccesPageByName(CardName cardName)
    {
        //_javascriptHelper.Scroll(1000, 1000);
        switch (cardName)
        {
            case CardName.Elements:
                GetCard("Elements").Click();
                break;
            case CardName.Forms:
                GetCard("Forms").Click();
                break;
            case CardName.AlertsFramesWindows:
                GetCard("Alerts, Frame & Windows").Click();
                break;
            case CardName.Widgets:
                GetCard("Widgets").Click();
                break;
            case CardName.Interactions:
                GetCard("Interactions").Click();
                break;
            case CardName.BookStoreApplication:
                GetCard("Book Store Application").Click();
                break;
            default:
                throw new ArgumentException("Non existing value");
        }
              
    }
}
