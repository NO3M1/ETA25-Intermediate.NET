using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ETA25_Intermediate_C_.Session5.Enums;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;

namespace ETA25_Intermediate_C_.Session5.Pages;

public class PracticeFormPage
{
    private readonly IWebDriver _driver;

    public PracticeFormPage(IWebDriver driver)
    {
        _driver = driver;
    }

    // WebElements
    public IWebElement FirstNameInput => _driver.FindElement(By.Id("firstName"));
    public IWebElement LastNameInput => _driver.FindElement(By.Id("lastName"));
    public IWebElement EmailInput => _driver.FindElement(By.Id("userEmail"));
    public IWebElement MobileInput => _driver.FindElement(By.Id("userNumber"));
    public IWebElement DateOfBirthInput => _driver.FindElement(By.Id("dateOfBirthInput"));
    //public IWebElement SubjectsInput => _driver.FindElement(By.Id("subjectsInput"));
    public IWebElement CurrentAddressInput => _driver.FindElement(By.Id("currentAddress"));

    //metoda 1 pentru Gender
    public void SelectGender(Gender gender)
    {
        switch (gender)
        {
            case Gender.Male:
                //_driver.FindElement(By.XPath("//label[@for=\"gender-radio-1\"]")).Click();
                GetGenderElement(1).Click();
                break;
            case Gender.Female:
                //_driver.FindElement(By.XPath("//label[@for=\"gender-radio-2\"]")).Click();
                GetGenderElement(2).Click();
                break;
            case Gender.Other:
                //_driver.FindElement(By.XPath("//label[@for=\"gender-radio-3\"]")).Click();
                GetGenderElement(3).Click();
                break;
            default:
                break;
        }
    }

    //Metoda 1 hobbies
    public void SelectHobbies(List<Hobby> hobbies)
    {
        foreach(Hobby hobby in hobbies)
        {
            switch (hobby)
            {
                case Hobby.Sports:
                    //_driver.FindElement(By.XPath("//label[@for=\"gender-radio-1\"]")).Click();
                    GetHobbyElement(1).Click();
                    break;
                case Hobby.Reading:
                    //_driver.FindElement(By.XPath("//label[@for=\"gender-radio-2\"]")).Click();
                    GetHobbyElement(2).Click();
                    break;
                case Hobby.Music:
                    //_driver.FindElement(By.XPath("//label[@for=\"gender-radio-3\"]")).Click();
                    GetHobbyElement(3).Click();
                    break;
                default:
                    break;
            }
        }
 
    }




/*    public void SetDateOfBirth(string dateOfBirth)
    {
        DateOfBirthInput.Click();
        DateOfBirthInput.SendKeys("");
        DateOfBirthInput.SendKeys(dateOfBirth);
        DateOfBirthInput.SendKeys(Keys.Enter);

    }*/

    public void SetDateOfBirth(string currentYear, string currentMonthName, string currentMonthDay)
    {
        // Identificam si initializam dateOfBirth input
        IWebElement dateOfBirthInput = _driver.FindElement(By.Id("dateOfBirthInput"));

        // Deschidem calendarul
        dateOfBirthInput.Click();

        // Initializam un Select element pentru year dropown
        IWebElement yearDropdownWe = _driver.FindElement(By.XPath("//select[contains(@class, \"year-select\")]"));
        var yearDropdown = new SelectElement(yearDropdownWe);

        // Selectam luna
        yearDropdown.SelectByValue(currentYear);

        // Initializam un Select element pentru month dropown
        IWebElement monthDropdownWe = _driver.FindElement(By.XPath("//select[contains(@class, \"month-select\")]"));
        var monthDropdown = new SelectElement(monthDropdownWe);

        // Selectam luna
        monthDropdown.SelectByText(currentMonthName);

        // Selectam ziua
        IWebElement dayOfCurrentMonth = _driver.FindElement(By.XPath($"//div[text()=\"{currentMonthDay}\" and not(contains(@class, \"--outside-month\"))]"));
        dayOfCurrentMonth.Click();
    }

    //metoda pentru 
    public void SelectSubjects(List<string> subjects)
    {
        var subjectInput = _driver.FindElement(By.Id("subjectsInput"));
        foreach (var subject in subjects)
        {
            subjectInput.SendKeys(subject);
            subjectInput.SendKeys(Keys.Enter);
        }

    }



    //metoda private  1.1 pentru Gender
    private IWebElement GetGenderElement(int index)
    {
        if (index <1 || index > 3)
        {
            throw new ArgumentException("The index is outside of valid range [1-3].");
        }
        return _driver.FindElement(By.XPath($"//label[@for=\"gender-radio-{index}\"]"));
    }

    //metoda private  1.1 hobbies
    private IWebElement GetHobbyElement(int index)
    {
        if (index < 1 || index > 3)
        {
            throw new ArgumentException("The index is outside of valid range [1-3].");
        }
        return _driver.FindElement(By.XPath($"//label[@for=\"hobbies-checkbox-{index}\"]"));
    }

    //metoda pentru fill in de campuri 
    public void FillInFormFields(string firstName, string lastName, string email, Gender gender, string mobileNumber, 
        string dateOfBirthYear, string dateOfBirthMonthName, string dateOfBirthDay, List<string> subjects, List<Hobby> hobbies, string address)
    {
        FirstNameInput.SendKeys(firstName);
        LastNameInput.SendKeys(lastName);
        EmailInput.SendKeys(email);
        SelectGender(gender);
        MobileInput.SendKeys(mobileNumber);
        SetDateOfBirth(dateOfBirthYear, dateOfBirthMonthName, dateOfBirthDay);
        SelectSubjects(subjects);
        SelectHobbies(hobbies);
        CurrentAddressInput.SendKeys(address);
    }
}
  

