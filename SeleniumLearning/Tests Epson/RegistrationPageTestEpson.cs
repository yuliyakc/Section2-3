﻿using NUnit.Allure.Core;
using OpenQA.Selenium;
using SeleniumLearning.Core;
using SeleniumLearning.Pages;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SeleniumLearning.Tests
{
    [AllureNUnit]
    public class RegistrationPageTestEpson
    {
        public static IWebDriver driver = WebDriverFactory.GetDriver();

        [Test]
        public void RegistrationTestEpson()
        {
            var targetEmail = Faker.Internet.Email();
            var targetPassword = "Password1!";
            RegistrationPageEpson registrationPage = new(driver);
            registrationPage.Open();
            registrationPage.Cookies();
            registrationPage.FirstName("Yuliya");
            registrationPage.LastName("Kozina");
            registrationPage.EmailAddress(targetEmail);
            registrationPage.ConfirmEmailAddress(targetEmail);
            registrationPage.TypePassword(targetPassword);
            registrationPage.TypeConfirmPassword(targetPassword);
            registrationPage.CustomerPersonal();
            registrationPage.termsAndConditions();
            registrationPage.RegisterBtnClick();
        }

    }
}
