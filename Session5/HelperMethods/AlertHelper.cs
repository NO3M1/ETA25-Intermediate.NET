using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;

namespace ETA25_Intermediate_C_.Session5.HelperMethods;

public class AlertHelper

{
    private readonly IWebDriver _driver;

    private readonly WebDriverWait _wait;

    //constructor
    public AlertHelper(IWebDriver driver)
    {
        _driver = driver;
        _wait = new WebDriverWait(_driver, TimeSpan.FromSeconds(5));
    }

    //metode pt alert

    public void AlertOk()
    {
        //IAlert alert = _driver.SwitchTo().Alert(); // in loc de linia asta, am facut o metoda privata
        IAlert alert = GetAlert();
        alert.Accept();
    }
   
    public void AlertCancel()
    {
        IAlert alert = GetAlert();
        alert.Dismiss();
    }

    public void AlertSendtext(string inputText)
    {
        IAlert alert = GetAlert();
        alert.SendKeys(inputText);
        alert.Accept();
    }

    public string GetAlertText()
    {
        IAlert alert = GetAlert();
        return alert.Text ?? string.Empty; // cerifica si intoarce empty
    }

    public string GetAlertTextWithDelay()
    {
        _wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.AlertIsPresent());
        return GetAlertText();

    }


    public void AlertOkWithDelay()
    {
        _wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.AlertIsPresent());
        AlertOk();
    }

    private IAlert GetAlert() => _driver.SwitchTo().Alert();






}
  

