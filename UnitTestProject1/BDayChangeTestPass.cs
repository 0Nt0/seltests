using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;

namespace UnitTestProject1
{
    [TestClass]
    public class BDayChangeTestPass
    {
        [TestMethod]
        public void BDayChangeTest()
        {
            IWebDriver webdriver = new ChromeDriver();
            webdriver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(30);
            By ButtonAgree = By.CssSelector("button[class='button agree']");
            By ProfileIcon = By.ClassName("c-icon--profile");
            By Email = By.Name("email");
             By Password = By.Name("password");
             By PressButtonToLogIn = By.CssSelector("input[class='btn btn-primary btn-full-width']");
             By ChangeProfile = By.CssSelector("a[href='u/info']");
             By BDaySelect = By.CssSelector("input[placeholder='YYYY-MM-DD']");
             By SaveChanges = By.CssSelector("input[class='btn btn-blue']");

            webdriver.Manage().Window.Maximize();

            webdriver.Navigate().GoToUrl("https://pigu.lt/lt/");
            webdriver.FindElement(ButtonAgree).Click();
            webdriver.FindElement(ProfileIcon).Click();
            webdriver.FindElement(Email).SendKeys("sereniumtest5@gmail.com");
            webdriver.FindElement(Password).SendKeys("serenium1+");
            webdriver.FindElement(PressButtonToLogIn).Click();
            webdriver.FindElement(ChangeProfile).Click();
            webdriver.FindElement(BDaySelect).SendKeys("1999-12-05");
            webdriver.FindElement(SaveChanges).Click();
        }
        // webdriver.FindElement(Email).SendKeys("forseleniumtesting111@gmail.com"); //forseleniumtesting111@gmail.com  sereniumtest5@gmail.com"
        // webdriver.FindElement(Password).SendKeys("123456789ac+");  // serenium1+  123456789ac+
    }
}
