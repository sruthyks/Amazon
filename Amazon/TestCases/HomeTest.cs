////using Amazon.PageObjects;
//using Amazon.PageObjects;
//using OpenQA.Selenium;
//using OpenQA.Selenium.Chrome;
//using OpenQA.Selenium.Support.PageObjects;
//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;
//using Xunit;

//namespace Amazon.TestCases
//{
//   public class HomeTest
//    {
//       [Fact]
//        [Obsolete]
//        public void HomepageTest()
//      {
//            IWebDriver driver = new ChromeDriver();
//            driver.Url = "https://www.amazon.com/";
//            var homePage = new HomePage();
//            PageFactory.InitElements(driver, homePage);
//            homePage.Menu.Click();
//            homePage.ShopByCategory.Click();
//            homePage.ShopBySubCategory.Click();
//            homePage.Rating.Click();
//            homePage.Brand.Click();
//            homePage.LowPrice.SendKeys("19000");
//            homePage.HighPrice.SendKeys("500000");
//        }
//    }
//}
