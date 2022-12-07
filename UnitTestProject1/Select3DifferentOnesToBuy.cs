using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Support.UI;
using System;

namespace UnitTestProject1
{
    [TestClass]
    public class Select3DifferentOnesToBuy
    {
        [TestMethod]
        public void SearchAndAdd3ThingsToBasket()
        {
            IWebDriver webdriver = new ChromeDriver();
            webdriver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(40);
            By ButtonAgree = By.CssSelector("button[class='button agree']");
           /* By ProfileIcon = By.ClassName("c-icon--profile");
            By Email = By.Name("email");
            By Password = By.Name("password");
            By PressButtonToLogIn = By.CssSelector("input[class='btn btn-primary btn-full-width']")*/
            By SearchBar = By.Name("q");
            By SearchIcon = By.ClassName("c-icon--search");

            By Item1Select = By.CssSelector("img[src='https://lt3.pigugroup.eu/colours/349/600/16/34960016/moteriska-medicinine-palaidine-5105-teal_large.jpg']");
            By Item1SizeSelect = By.XPath(".//*[@id='product-modifications']");
            By ItemSizeSSelect = By.XPath(".//div//div//ul//li[@tabindex='1']");
            By Item1AddToCart = By.CssSelector("button[class='btn btn-big-icon-inline btn-green']");

            By PressOnItem2 = By.CssSelector("img[src='https://lt3.pigugroup.eu/colours/231/847/55/23184755/bcf6a5e390fbe3cdfb4d114fbe6d85bd_large.jpg']");
            By Item2AddToCart = By.CssSelector("button[class='btn btn-big-icon-inline btn-green'");

            By Item3Select= By.CssSelector("img[src='https://lt3.pigugroup.eu/colours/592/178/43/59217843/andrzej-sapkowskis-the-witcher-a-grain-of-3439d_large.jpg']");
            By Item3AddToCart = By.CssSelector("button[class='btn btn-big-icon-inline btn-green']");


            webdriver.Manage().Window.Maximize();

            webdriver.Navigate().GoToUrl("https://pigu.lt/lt/");
            webdriver.FindElement(ButtonAgree).Click();
            /*webdriver.FindElement(ProfileIcon).Click();
            webdriver.FindElement(Email).SendKeys("sereniumtest5@gmail.com");
            webdriver.FindElement(Password).SendKeys("serenium1+");
            webdriver.FindElement(PressButtonToLogIn).Click();*/

            webdriver.FindElement(SearchBar).SendKeys("Palaidine");
            webdriver.FindElement(SearchIcon).Click();

            webdriver.FindElement(Item1Select).Click();
            webdriver.FindElement(Item1SizeSelect).Click();
            webdriver.FindElement(ItemSizeSSelect).Click();
            webdriver.FindElement(Item1AddToCart).Click();

            webdriver.FindElement(SearchBar).SendKeys("zaislai");
            webdriver.FindElement(SearchIcon).Click();
            webdriver.Navigate().GoToUrl("https://pigu.lt/lt/kudikiams-ir-vaikams/zaislai/zaislai-kudikiams/vonios-zaislai-gyvuneliai-tullo-4-vnt-034?id=22091750&feat=search&keyword=zaislai");
            webdriver.FindElement(Item2AddToCart).Click();

            webdriver.FindElement(SearchBar).SendKeys("knygos witcher");
            webdriver.FindElement(SearchIcon).Click();
            webdriver.Navigate().GoToUrl("https://pigu.lt/lt/knygos/grozine-literatura/fantastika-mistika/sword-of-destiny-tales-of-the-witcher?id=58695133&feat=search&keyword=knygos+witcher");
            webdriver.FindElement(Item3AddToCart).Click();




            // webdriver.FindElement(Email).SendKeys("forseleniumtesting111@gmail.com"); //forseleniumtesting111@gmail.com  sereniumtest5@gmail.com"
            // webdriver.FindElement(Password).SendKeys("123456789ac+");  // serenium1+  123456789ac+






        }
    }
}
