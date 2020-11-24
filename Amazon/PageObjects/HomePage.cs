using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Amazon.PageObjects
{
   public class HomePage
    {
         private IWebDriver driver;


        [FindsBy(How = How.CssSelector, Using = "#nav-hamburger-menu")]
        public IWebElement Menu { get; set; }

        [FindsBy(How = How.XPath, Using = "/html/body/div[3]/div[2]/div/ul[1]/li[7]/a/div")]
        public IWebElement ShopByCategory { get; set; }

        [FindsBy(How = How.LinkText, Using = "Accessories & Supplies")]
        public IWebElement ShopBySubCategory { get; set; }



        [FindsBy(How= How.XPath, Using = "/html/body/div[1]/div[1]/div[1]/div[1]/div/div[3]/span/div[1]/span/div/div/div[2]/ul/li[1]/span/a/section/i")] 
        public IWebElement Rating { get; set; }

        [FindsBy(How = How.XPath, Using = "/html/body/div[1]/div[1]/div[1]/div[1]/div/div[3]/span/div[1]/span/div/div/div[3]/ul/li[2]/span/a/span")]
        public IWebElement Brand { get; set; }

        [FindsBy(How = How.Id, Using = "low-price")]
        public IWebElement LowPrice { get; set; }

        [FindsBy(How = How.Id, Using = "high-price")]
        public IWebElement HighPrice { get; set; }

        [FindsBy(How = How.CssSelector, Using = ".a-button-input")]
        public IWebElement Go { get; set; }
        [FindsBy(How = How.XPath, Using = "/html/body/div[1]/div[1]/div[1]/div[2]/div/span[3]/div[2]/div[1]/div/span/div/div/div[2]/div[2]/div/div[1]/div/div/div[1]/h2/a")]
        public IWebElement Item { get; set; }
        [FindsBy(How = How.Id, Using = "add-to-cart-button")]
        public IWebElement AddToCart { get; set; }

        [FindsBy(How = How.CssSelector, Using = "#nav-cart-count-container > span.nav-cart-icon.nav-sprite")]
        public IWebElement CartIcon { get; set; }
        [FindsBy(How = How.XPath, Using = "/html/body/div[8]/div/div/ul/li[3]/a")]
        public IWebElement Quantity { get; set; }

        [FindsBy(How = How.XPath, Using = "/html/body/div[8]/div/div/ul/li[3]/a")]
        public IWebElement Price { get; set; }

        //Process of adding an item from womens clothing 
        //navigate to category page

        [FindsBy(How = How.XPath, Using = "/html/body/div[1]/div[1]/header/div/div[1]/div[1]/a/i")]
        public IWebElement Menu1 { get; set; }

        [FindsBy(How = How.XPath, Using = "/html/body/div[4]/div[2]/div/ul[1]/li[11]/a[1]")]
        public IWebElement SeeAll { get; set; }


        [FindsBy(How = How.XPath, Using = "/html/body/div[5]/div[2]/div/ul[1]/ul[1]/li[5]/a/div")]/// xpath of womens fashion
        public IWebElement ShopByCategory1 { get; set; }

        [FindsBy(How = How.LinkText, Using = "Shoes")]
        public IWebElement ShopBySubCategory1 { get; set; }

        [FindsBy(How = How.XPath, Using = "/html/body/div[1]/div[1]/div[1]/div[1]/div/div[3]/span/div/span/div/div/div[2]/ul/li[1]/span/a/section")]
        public IWebElement Rating1 { get; set; }

        [FindsBy(How = How.XPath, Using = "/html/body/div[1]/div[1]/div[1]/div[1]/div/div[3]/span/div[1]/span/div/div/div[3]/ul[2]/li[1]/span/a/span")]
        public IWebElement Brand1 { get; set; }

        [FindsBy(How = How.Id, Using = "low-price")]
        public IWebElement LowPrice1 { get; set; }

        [FindsBy(How = How.Id, Using = "high-price")]
        public IWebElement HighPrice1 { get; set; }

        [FindsBy(How = How.CssSelector, Using = ".a-button-input")]
        public IWebElement Go1 { get; set; }
        [FindsBy(How = How.XPath, Using = "/html/body/div[1]/div[1]/div[1]/div[2]/div/span[3]/div[2]/div[2]/div/span/div/div/div[2]/h2/a")]
        public IWebElement Item1 { get; set; }

        [FindsBy(How = How.XPath, Using = "/html/body/div[7]/div/div/ul/li[2]/a")]
        public IWebElement Size { get; set; }
       
        
        [FindsBy(How = How.Id, Using = "add-to-cart-button")]
        public IWebElement AddToCart1 { get; set; }
        [FindsBy(How = How.XPath, Using = "/html/body/div[1]/div/div[2]/div[2]/div[1]/div/div/div[4]/div/div/div/span[1]/span/span/a")]
        public IWebElement Cart { get; set; }

        [FindsBy(How = How.XPath, Using = "/html/body/div[1]/div[1]/header/div/div[1]/div[3]/div/a[5]/div[1]/span[2]")]
        public IWebElement ViewCart { get; set; }
    }
}
