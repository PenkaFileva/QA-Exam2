using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;
using SeleniumWebDriverTemplateProject.Helpers;
using SeleniumWebDriverTemplateProject.Pages.Abstract;

namespace SeleniumWebDriverTemplateProject.Pages
{
    class PopAlbumsPage :Page
    {
        [FindsBy(How = How.LinkText, Using = "Animal Vehicle")]
        public IWebElement AnimalVehicle { get; set; }

        public static PopAlbumsPage NavigateTo(IWebDriver driver)
        {
            var productPage = ProductPage.NavigateTo(driver);
            Thread.Sleep(2000);
            productPage.Pop.Click();
            Thread.Sleep(2000);
            var popAlbumsPageInstance = PageFactoryExtensions.InitPage<PopAlbumsPage>(driver);

            return popAlbumsPageInstance;
        }
    }
}
