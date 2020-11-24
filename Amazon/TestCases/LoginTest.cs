using Amazon.PageObjects;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Support.PageObjects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xunit;

namespace Amazon.TestCases
{
   public class LoginTest
    {
        [Fact]
        [Obsolete]
        public void TestLogin()
        {
            IWebDriver driver = new ChromeDriver();
            driver.Navigate().GoToUrl("https://www.amazon.com/");
            driver.Manage().Window.Maximize();
            ///driver.Url.Navigate.Maximize();
            var loginPage = new LoginPage();
            PageFactory.InitElements(driver, loginPage);
            loginPage.Login.Click();
            loginPage.Email.SendKeys("sruthyks.393@gmail.com");
            loginPage.ContinueButton.Click();
            loginPage.Password.SendKeys("amazon");
            loginPage.SignIn.Click();
           // loginPage.Menu.Click();
           // loginPage.ShopByCategory.Click();
           // loginPage.ShopBySubCategory.Click();

            var homePage = new HomePage();
            PageFactory.InitElements(driver, homePage);
            homePage.Menu.Click();
            homePage.ShopByCategory.Click();
            homePage.ShopBySubCategory.Click();
            homePage.Rating.Click();
            homePage.Brand.Click();
            homePage.LowPrice.SendKeys("100");
            homePage.HighPrice.SendKeys("1000");
            homePage.Go.Click();
            homePage.Item.Click();
            homePage.AddToCart.Click();
            homePage.CartIcon.Click();
            homePage.Quantity.Click();
            homePage.Menu1.Click();
            homePage.SeeAll.Click();
            homePage.ShopByCategory1.Click();
            homePage.ShopBySubCategory1.Click();
            homePage.Rating1.Click();
            homePage.Brand1.Click();
            homePage.LowPrice1.SendKeys("1000");
            homePage.HighPrice1.SendKeys("3000");
            homePage.Go1.Click();
            homePage.Item1.Click();
            homePage.Size.Click();
            homePage.AddToCart1.Click();
            homePage.Cart.Click();

            var logoutPage = new LogOutPage();
            PageFactory.InitElements(driver, logoutPage);
            logoutPage.AccountIcon.Click();
            logoutPage.SignOut.Click();

            //var loginPage = new LoginPage();
            PageFactory.InitElements(driver, loginPage);
            loginPage.Login.Click();
            loginPage.Email.SendKeys("sruthyks.393@gmail.com");
            loginPage.ContinueButton.Click();
            loginPage.Password.SendKeys("amazon");
            loginPage.SignIn.Click();

            PageFactory.InitElements(driver, homePage);
            homePage.ViewCart.Click();
        }
    }
}
