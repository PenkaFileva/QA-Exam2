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
    class CheckoutPage :Page
    {
        [FindsBy(How = How.CssSelector, Using = ".button > a:nth-child(1)")]
        public IWebElement Checkoutbutton { get; set; }

        public static CheckoutPage NavigateTo(IWebDriver driver)
        {
            var animalVehiclePage = AnimalVehiclePage.NavigateTo(driver);
            Thread.Sleep(2000);
            animalVehiclePage.AddToCart.Click();
            Thread.Sleep(2000);
            var checkoutPageInstance = PageFactoryExtensions.InitPage<CheckoutPage>(driver);

            return checkoutPageInstance;
        }
    }
}
