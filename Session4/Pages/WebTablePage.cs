using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;
using OpenQA.Selenium;

namespace ETA25_Intermediate_C_.Session4.Pages;
public class WebTablePage
{
    private readonly IWebDriver _driver;

    public WebTablePage(IWebDriver driver)
    {
        _driver = driver;
    }

    //WebElements -astea nu s-ar putea apela din PracticeFormPages daca au acelasi id?
    public IWebElement AddButton => _driver.FindElement(By.Id("addNewRecordButton"));
    //elemente pentru registration form
    public IWebElement FirstNameInput => _driver.FindElement(By.Id("firstName"));
    public IWebElement LastNameInput => _driver.FindElement(By.Id("lastName"));
    public IWebElement EmailInput => _driver.FindElement(By.Id("userEmail"));
    public IWebElement AgeInput => _driver.FindElement(By.Id("age"));
    public IWebElement SalaryInput => _driver.FindElement(By.Id("salary"));
    public IWebElement DepartmentInput => _driver.FindElement(By.Id("department"));
    public IWebElement RegistationSubmitButton => _driver.FindElement(By.Id("submit"));

  


    //metoda pentru complectarea fieldurilor de RegistrationForm
    public void RegistrationFormCompletion(string firstName, string lastName, string email, string age, string salary, string department)
    {
        FirstNameInput.SendKeys(firstName);
        LastNameInput.SendKeys(lastName);
        EmailInput.SendKeys(email);
        AgeInput.SendKeys(age);
        SalaryInput.SendKeys(salary); //nu ar trebui int?
        DepartmentInput.SendKeys(department);

    }

    //metoda pentru output
    public void ValidateRegistrationFormEntry(string firstName, string lastName, string email, string age, string salary, string department)
    {
        var nonEmptyRowsSelector = _driver.FindElements(By.XPath("//div[@class='rt-tbody']//div[@role='rowgroup'][.//div[@class='action-buttons']]"));
        var nonEmptyRowsSelector2 = _driver.FindElements(By.XPath("//div[@class='rt-tbody']//div[@role='row' and contains(@class,'-padRow') = false]"));

        By outputRowSelector = By.XPath("//div[@class='rt-tbody']//div[@role='rowgroup'][.//div[@class='action-buttons']][4]");
        IWebElement outputRow = _driver.FindElement(outputRowSelector);
        String outputRowText = outputRow.Text;

        // Assert
        Assert.That(nonEmptyRowsSelector.Count == 4);
        Assert.That(nonEmptyRowsSelector2.Count == 4);
        Assert.That(outputRowText.Contains(firstName));
        Assert.That(outputRowText.Contains(lastName));
        Assert.That(outputRowText.Contains(email));
        Assert.That(outputRowText.Contains(age));
        Assert.That(outputRowText.Contains(salary),Is.True);
        Assert.That(outputRowText.Contains(department));

        Console.WriteLine("Output Row: " + outputRowText);
    }

    

}



