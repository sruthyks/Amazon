using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Amazon.PageObjects
{
   public class LogOutPage
    {
        private IWebDriver driver;

        // logout
        [FindsBy(How = How.Id, Using = "nav-link-accountList")]
        public IWebElement AccountIcon { get; set; }

        [FindsBy(How = How.Id, Using = "nav-item-signout")]
        public IWebElement SignOut { get; set; }

    }
}
