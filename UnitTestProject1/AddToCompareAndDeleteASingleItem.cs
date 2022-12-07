using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;

namespace UnitTestProject1
{
    [TestClass]
    public class AddToCompareAndDeleteASingleItem
    {
        [TestMethod]
        public void SearchAndAdd3ThingsToCompare()
        {
            IWebDriver webdriver = new ChromeDriver();
            webdriver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(40);
            By ButtonAgree = By.CssSelector("button[class='button agree']");
          /*  By ProfileIcon = By.ClassName("c-icon--profile");
            By Email = By.Name("email");
            By Password = By.Name("password");
            By PressButtonToLogIn = By.CssSelector("input[class='btn btn-primary btn-full-width']");*/
            By SearchBar = By.Name("q");
            By SearchIcon = By.ClassName("c-icon--search");

            /* By AddToCompare1 = By.XPath(".//div//a[@id='add-to-compare-btn-53962824']");
             By AddToCompare2 = By.XPath(".//div//a[@id='add-to-compare-btn-51629584']");
             By AddToCompare3 = By.XPath(".//div//a[@id='add-to-compare-btn-52824669']");*/

            By Select1Item = By.XPath(".//div//a//img[@src='https://lt3.pigugroup.eu/colours/547/459/89/54745989/samsung-galaxy-a33-5g-128gb-dual-sim-46831-uzsakyti_large.jpg']");
            By Select2Item = By.XPath(".//div//a//img[@src='https://lt2.pigugroup.eu/colours/523/918/94/52391894/samsung-galaxy-a53-5g-128-gb-dual-64246-online_large.jpg']");
            By Select3Item = By.XPath(".//div//a//img[@src='https://lt1.pigugroup.eu/colours/535/973/09/53597309/apple-iphone-13-128gb-green-34c95-vertinimai_large.jpg']");

            By Add1Item = By.XPath(".//div//div//div[@class='btn btn-full-width btn-blue-border ']");
            By Add2Item = By.XPath(".//div//div//div[@class='btn btn-full-width btn-blue-border ']");
            By Add3Item = By.XPath(".//div//div//div[@class='btn btn-full-width btn-blue-border ']");

            By EnterCompareScreen = By.XPath(".//a[@id='compare']");
            By DeleteFromCompare = By.XPath(".//div//a[@class='btn-small btn-rounded btn-icon-right btn-content-grey remove-compare']");


            webdriver.Manage().Window.Maximize();

            webdriver.Navigate().GoToUrl("https://pigu.lt/lt/");
            webdriver.FindElement(ButtonAgree).Click();
            
            webdriver.FindElement(SearchBar).SendKeys("telefonas");
            webdriver.FindElement(SearchIcon).Click();

            webdriver.FindElement(Select1Item).Click();
            webdriver.FindElement(Add1Item).Click();

            webdriver.FindElement(SearchBar).SendKeys("telefonas");
            webdriver.FindElement(SearchIcon).Click();
            webdriver.FindElement(Select2Item).Click();
            webdriver.FindElement(Add2Item).Click();

            webdriver.FindElement(SearchBar).SendKeys("telefonas");
            webdriver.FindElement(SearchIcon).Click();
            webdriver.FindElement(Select3Item).Click();
            webdriver.FindElement(Add3Item).Click();

/*            webdriver.FindElement(AddToCompare1).Click();
           webdriver.FindElement(AddToCompare2).Click();
            webdriver.FindElement(AddToCompare3).Click();*/

            webdriver.FindElement(EnterCompareScreen).Click();
            webdriver.FindElement(DeleteFromCompare).Click();
          

        }
    }
}
