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
    class ProductPage : Page
    {
        [FindsBy(How = How.LinkText, Using = "Pop")]
        public IWebElement  Pop{ get; set; }

        [FindsBy(How = How.ClassName, Using = "list-group")]
        public IWebElement AllAlbums { get; set; }

        public static ProductPage NavigateTo(IWebDriver driver)
        {
            var homePage  = HomePage.NavigateTo(driver);
            Thread.Sleep(3000);

            homePage.StoreButton.Click();
            Thread.Sleep(3000);

            homePage.MoreButton.Click();
            Thread.Sleep(3000);
            var productPageInstance = PageFactoryExtensions.InitPage<ProductPage>(driver);

            return productPageInstance;
        }

        public IList<IWebElement> GetAlbums()
        {
            IList<IWebElement> list = AllAlbums.FindElements(By.ClassName("list-group-item")).ToList();
            return list;
        }
    }


}
