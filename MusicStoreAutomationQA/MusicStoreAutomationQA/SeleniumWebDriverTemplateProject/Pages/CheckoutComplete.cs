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
    class CheckoutComplete : Page
    {
        [FindsBy(How = How.CssSelector, Using = "div.container:nth-child(2) > h2:nth-child(1)")]
        public IWebElement CheckOutComplete { get; set; }

        public static CheckoutComplete NavigateTo(IWebDriver driver)
        {
            var shippingInformationPage = ShippingInformationPage.NavigateTo(driver);
            Thread.Sleep(2000);
            shippingInformationPage.Submit.Click();
            Thread.Sleep(2000);
            var checkoutCompleteInstance = PageFactoryExtensions.InitPage<CheckoutComplete>(driver);

            return checkoutCompleteInstance;
        }
    }
}
