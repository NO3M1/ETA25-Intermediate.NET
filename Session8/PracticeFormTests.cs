using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ETA25_Intermediate_C_.Session8.Enums;
using ETA25_Intermediate_C_.Session8.HelperMethods;
using ETA25_Intermediate_C_.Session8.Pages;
using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;

namespace ETA25_Intermediate_C_.Session8;

public class PracticeFormTests : BaseTest
{


    [Test]
    public void PracticeFormTest1()
    {
        JavascriptHelper.ScrollVertically(300);
        HomePage.AccesPageByName(CardName.Forms);
   
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



       PracticeFormPage.FillInFormFields("Noemi", "Sz", "test@test.com", Gender.Male, "0748515895", "1992", "August", "31",
            new List<string>() { "English", "Accounting", "Physics" }, new List<Hobby>() { Hobby.Music, Hobby.Reading }, "Test address input");



        Thread.Sleep(8000);




    }

}

