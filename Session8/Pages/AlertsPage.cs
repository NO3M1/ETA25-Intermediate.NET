using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium;

namespace ETA25_Intermediate_C_.Session8.Pages;

public class AlertsPage : BasePage
{

    public AlertsPage(IWebDriver driver) : base(driver) { }
 
    public void OpenBasicAlert()
    {
        // varianta 1
       
        //IWebElement button = _driver.FindElement(By.Id("alertButton"));
        // button.Click();

        //varinata 2
        ClickOnElementById("alertButton");
    }

    public void OpenTimerAlert()
    {
        ClickOnElementById("timerAlertButton");
    }

    public void OpenConfirmationAlert()
    {
        ClickOnElementById("confirmButton");
    }

    public void OpenComplexAlert()
    {
    
        ClickOnElementById("promtButton");
    }

    public string GetComplexAlertResult()
    {
        /*    VAR1   
           //identificare element
                IWebElement result;
                var elements = _driver.FindElements(By.Id("confirmResult"));
           //in cazul in care driver-ul nostru nu gaseste elementul respectiv
                if (elements.Count > 0)
                {
                    result = elements[0]; 
                    return result.Text;
                }
                return string.Empty; */

        // VAR2

        return GetTextFromElementById("promptResult");
    }

    public string GetConfirmationAlertResult()
    {
        return GetTextFromElementById("confirmResult");
    }



    private string GetTextFromElementById(string elementId)
    {
        //IWebElement result;
        var elements = Driver.FindElements(By.Id("confirmResult"));
     
        if (elements.Count > 0)
        {
            IWebElement result = elements[0];
            return result.Text;
        }
        return string.Empty;
    }


    private void ClickOnElementById(string elementId)
    {
        IWebElement element = Driver.FindElement(By.Id(elementId));
        element.Click();
    }





}
