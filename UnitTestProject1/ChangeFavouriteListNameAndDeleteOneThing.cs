using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;

namespace UnitTestProject1
{
    [TestClass]
    public class ChangeFavouriteListNameAndDeleteOneThing
    {
        [TestMethod]
        public void SearchAndAdd3ThingsToBasket()
        {
            IWebDriver webdriver = new ChromeDriver();
            webdriver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(40);
            By ButtonAgree = By.CssSelector("button[class='button agree']");
            By ProfileIcon = By.ClassName("c-icon--profile");
            By Email = By.Name("email");
            By Password = By.Name("password");
            By PressButtonToLogIn = By.CssSelector("input[class='btn btn-primary btn-full-width']");
            By SearchBar = By.Name("q");
            By SearchIcon = By.ClassName("c-icon--search");
            By SearchClearIcon = By.ClassName("c-icon--close");

            By Search1stItem = By.ClassName("add-to-favorites");
            By Search2ndItem = By.ClassName("add-to-favorites");
            By Search3rdItem = By.ClassName("add-to-favorites");

            By GotoFavourites = By.XPath(".//li//a[@href='https://pigu.lt/lt/u/wishlist']");
            By EditFavouritesName = By.XPath(".//section//div//h1//span[@id='edit_wishlist_title']");
            By InputNewName = By.CssSelector("input[id='input_wishlist_rename']");
            By SaveNewNameOfFavourites = By.CssSelector("button[id='accept_wishlist_rename']");

            By DeleteFromFavourites = By.ClassName("add-to-favorites");


            webdriver.Manage().Window.Maximize();

            webdriver.Navigate().GoToUrl("https://pigu.lt/lt/");
            webdriver.FindElement(ButtonAgree).Click();
            webdriver.FindElement(ProfileIcon).Click();
            webdriver.FindElement(Email).SendKeys("forseleniumtesting111@gmail.com"); //forseleniumtesting111@gmail.com  sereniumtest5@gmail.com"
            webdriver.FindElement(Password).SendKeys("123456789ac+");  // serenium1+  123456789ac+
            webdriver.FindElement(PressButtonToLogIn).Click();

            webdriver.FindElement(SearchBar).SendKeys("Pakabukas");
            webdriver.FindElement(SearchIcon).Click();

            webdriver.FindElement(Search1stItem).Click();

            webdriver.FindElement(SearchClearIcon).Click();
            webdriver.FindElement(SearchBar).SendKeys("ziedai");
            webdriver.FindElement(SearchIcon).Click();

            webdriver.FindElement(Search2ndItem).Click();

            webdriver.FindElement(SearchClearIcon).Click();
            webdriver.FindElement(SearchBar).SendKeys("telefonas");
            webdriver.FindElement(SearchIcon).Click();

            webdriver.FindElement(Search3rdItem).Click();

            webdriver.Navigate().GoToUrl("https://pigu.lt/lt/u/wishlist/3160162?page=1");
            webdriver.FindElement(EditFavouritesName).Click();
            webdriver.FindElement(InputNewName).SendKeys("NAUJAS");
            webdriver.FindElement(SaveNewNameOfFavourites).Click();

            webdriver.FindElement(DeleteFromFavourites).Click();


            // webdriver.FindElement(Email).SendKeys("forseleniumtesting111@gmail.com"); //forseleniumtesting111@gmail.com  sereniumtest5@gmail.com"
            // webdriver.FindElement(Password).SendKeys("123456789ac+");  // serenium1+  123456789ac+








        }
    }
}
