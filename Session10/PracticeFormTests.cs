using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ETA25_Intermediate_C_.Session10.Enums;
using ETA25_Intermediate_C_.Session10.HelperMethods;
using ETA25_Intermediate_C_.Session10.Pages;
using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;

namespace ETA25_Intermediate_C_.Session10;

public class PracticeFormTests : BaseTest
{

    protected PracticeFormPage PracticeFormPage { get; private set; } = null!;

    [TearDown]
    public override void ExtraCleanup()
    {
        //add implementaiton here
    }

    [SetUp]
    public override void ExtraSetup()
    {
        PracticeFormPage = new PracticeFormPage(Driver);

        HomePage.AccesPageByName(CardName.Forms);

        JavascriptHelper.ScrollVertically(700);

        PracticeFormPage.AccessSideMenuOption(FormsMenuOption.PracticeForm);

        JavascriptHelper.ScrollVertically(400);
    }

    [Test]
    public void PracticeFormTest1()
    {
             
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



        PracticeFormPage.FillInFormFields("Noemi", "Sz", "test@test.com", Gender.Female, "00010305", "1992", "April", "16",
             new List<string>() { "English", "Accounting", "Physics" }, new List<Hobby>() { Hobby.Music, Hobby.Reading }, "Test Address 123, &*()");



        Thread.Sleep(3000);
    }

    [Test]
    public void PracticeFormTest2()
    {

        PracticeFormPage.FillInFormFields("Noee", "Sz", "test@test.com", Gender.Female, "00010305", "1992", "April", "16",
           new List<string>() { "English", "Accounting", "Physics" }, new List<Hobby>() { Hobby.Music, Hobby.Reading }, "Test Address 123, &*()");



        Thread.Sleep(3000);
    }

}

