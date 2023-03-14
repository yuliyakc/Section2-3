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
    public class RegistrationPageTests
    {
        public static IWebDriver driver = WebDriverFactory.GetDriver();

        [Test]
        public void RegistrationTest()
        {
            var targetEmail = Faker.Internet.Email();
            RegistrationPage registrationPage = new(driver);  
            registrationPage.Open();
            registrationPage.Cookies();
            registrationPage.FirstName("Yuliya"); 
            registrationPage.LastName("Kozina");
            registrationPage.EmailAddress(targetEmail);
            registrationPage.ConfirmEmailAddress(targetEmail);
            //registrationPage.Password();
            //registrationPage.ConfirmPassword();
            //registrationPage.сhkStatement();
            //registrationPage.chkPrivacy();
            //registrationPage.RegisterBtnClick();
            //driver.Quit();
        }

    }
}
