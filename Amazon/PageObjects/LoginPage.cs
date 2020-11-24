using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Amazon.PageObjects
{
    public class LoginPage
    {

        private IWebDriver driver;
        [FindsBy(How = How.Id, Using = "nav-link-accountList")]
        public IWebElement Login { get; set; }

        ///[FindsBy(How=How.XPath, Using ="//input[@id='ap_email']")]
        [FindsBy(How = How.Id, Using = "ap_email")]
        public IWebElement Email { get; set; }

        [FindsBy(How = How.CssSelector, Using = ".a-button-inner > #continue")]
        public IWebElement ContinueButton { get; set; }
        [FindsBy(How = How.Id, Using = "ap_password")]
        public IWebElement Password { get; set; }
        [FindsBy(How = How.Id, Using = "signInSubmit")]
        public IWebElement SignIn { get; set; }


       
    }
}
