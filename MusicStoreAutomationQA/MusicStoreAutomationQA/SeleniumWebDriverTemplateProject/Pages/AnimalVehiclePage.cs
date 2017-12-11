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
    class AnimalVehiclePage :Page
    {

        [FindsBy(How = How.CssSelector, Using = ".button > a:nth-child(1)")]
        public IWebElement AddToCart { get; set; }

        public static AnimalVehiclePage NavigateTo(IWebDriver driver)
        {
            var popAlbumsPage = PopAlbumsPage.NavigateTo(driver);
            Thread.Sleep(2000);
            popAlbumsPage.AnimalVehicle.Click();
            Thread.Sleep(2000);
            var animalVehiclePageInstance = PageFactoryExtensions.InitPage<AnimalVehiclePage>(driver);

            return animalVehiclePageInstance;
        }

    }
}
