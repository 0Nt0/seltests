using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;

namespace UnitTestProject1
{
    [TestClass]
    public class CreateNewAddressAndDeleteOneAdress
    {
        [TestMethod]
        public void ChangeAddress()
        {
            IWebDriver webdriver = new ChromeDriver();
            webdriver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(30);

            By ProfileIcon = By.ClassName("c-icon--profile");
            By ButtonAgree = By.CssSelector("button[class='button agree']");
            By Email = By.Name("email");
            By Password = By.Name("password");
            By PressButtonToLogIn = By.CssSelector("input[class='btn btn-primary btn-full-width']");
            By GoToAddressess = By.XPath(".//li//a[@href='u/addresses/customers']");
            By GoToAddNewAddress = By.XPath(".//div//a[@class='btn btn-blue position_relative']");

            By EnterName = By.XPath(".//div//input[@name='name']");
            By EnterSurname = By.XPath(".//div//input[@name='surname']");
            By enterPhone = By.XPath(".//div//input[@name='phone']");
            By EnterAddress = By.XPath(".//div//input[@name='address']");
            By EnterPostalCode = By.XPath(".//div//input[@name='post_code']");
            By SelectArrowPressed = By.XPath(".//div//div//div//div//b[@class='custom-dropdown-arrow']");
            By SelectCity = By.XPath(".//div//div//div//ul//li[@id='city_id7']");
            By SaveChanges= By.XPath(".//div//a[@class='btn btn-rounded-blue']");

            By GoBack = By.XPath(".//li//a[@href='u/addresses/customers']");
            By DeleteAdress= By.XPath(".//li//div//div//a[@title='Ištrinti adresą']");
            By PressAgree = By.XPath(".//div//div//div//a[@class='btn btn-primary btn-full-width btn-blue']");



            webdriver.Manage().Window.Maximize();

            webdriver.Navigate().GoToUrl("https://pigu.lt/lt/");
            webdriver.FindElement(ButtonAgree).Click();
            webdriver.FindElement(ProfileIcon).Click();
            webdriver.FindElement(Email).SendKeys("sereniumtest5@gmail.com"); //sereniumtest5@gmail.com   testseleniumtesttry@gmail.com
            webdriver.FindElement(Password).SendKeys("serenium1+");  //serenium1+   112233445566l+
            webdriver.FindElement(PressButtonToLogIn).Click();

            webdriver.FindElement(GoToAddressess).Click();
            webdriver.FindElement(GoToAddNewAddress).Click();

            webdriver.FindElement(EnterName).SendKeys("Jjjis");
            webdriver.FindElement(EnterSurname).SendKeys("Jonaskko");
            webdriver.FindElement(enterPhone).SendKeys("+37068554840");
            webdriver.FindElement(EnterAddress).SendKeys("JonaviciausMiestas");
            webdriver.FindElement(EnterPostalCode).SendKeys("79517");

            webdriver.FindElement(SelectArrowPressed).Click();
            webdriver.FindElement(SelectCity).Click();
            webdriver.FindElement(SaveChanges).Click();

            webdriver.FindElement(GoBack).Click();
            webdriver.FindElement(DeleteAdress).Click();
            webdriver.FindElement(PressAgree).Click();




        }
    }
}
