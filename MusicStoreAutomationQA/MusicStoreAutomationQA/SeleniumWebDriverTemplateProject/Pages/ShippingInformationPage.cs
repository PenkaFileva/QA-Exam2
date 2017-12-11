using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;
using SeleniumWebDriverTemplateProject.Helpers;
using SeleniumWebDriverTemplateProject.Pages.Abstract;

namespace SeleniumWebDriverTemplateProject.Pages
{
    class ShippingInformationPage :Page
    {
        [FindsBy(How = How.Id, Using = "FirstName")]
        public IWebElement FirstName { get; set; }

        [FindsBy(How = How.Id, Using = "LastName")]
        public IWebElement LastName { get; set; }

        [FindsBy(How = How.Id, Using = "Address")]
        public IWebElement Address { get; set; }

        [FindsBy(How = How.Id, Using = "City")]
        public IWebElement City { get; set; }

        [FindsBy(How = How.Id, Using = "State")]
        public IWebElement State { get; set; }

        [FindsBy(How = How.Id, Using = "PostalCode")]
        public IWebElement PostalCode { get; set; }

        [FindsBy(How = How.Id, Using = "Country")]
        public IWebElement Country { get; set; }

        [FindsBy(How = How.Id, Using = "Phone")]
        public IWebElement Phone { get; set; }

        [FindsBy(How = How.Id, Using = "Email")]
        public IWebElement Email { get; set; }

        [FindsBy(How = How.Id, Using = "PromoCode")]
        public IWebElement PromoCode { get; set; }

        [FindsBy(How = How.CssSelector, Using = "div.container:nth-child(2) > form:nth-child(1) > input:nth-child(6)")]
        public IWebElement Submit { get; set; }

        public static ShippingInformationPage NavigateTo(IWebDriver driver)
        {
            var checkoutPage = CheckoutPage.NavigateTo(driver);
            Thread.Sleep(2000);
            checkoutPage.Checkoutbutton.Click();
            Thread.Sleep(2000);
            var shippingInformationPageInstance = PageFactoryExtensions.InitPage<ShippingInformationPage>(driver);

            return shippingInformationPageInstance;
        }
    }
}
