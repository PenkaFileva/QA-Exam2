using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using NUnit.Framework;
using OpenQA.Selenium;
using SeleniumWebDriverTemplateProject.Helpers;
using SeleniumWebDriverTemplateProject.Pages;
using SeleniumWebDriverTemplateProject.Tests.Abstract;

namespace SeleniumWebDriverTemplateProject.Tests
{
    class ProductTestss : DesktopSeleniumTestFixturePrototype
    {
        public ProductTestss(Browsers browser) : base(browser)
        {
        }

        [Test]
        public void StoreButtonTest()
        {
            var homePage = HomePage.NavigateTo(this.Driver);
            Thread.Sleep(3000);

            homePage.StoreButton.Click();
            Thread.Sleep(3000);

            homePage.MoreButton.Click();
            Thread.Sleep(3000);
            //var searchResults = this.Driver.FindElements(By.CssSelector(".prodtitle a"));
            //for (int i = 0; i < searchResults.Count; i++)
            //{
            //    string currentSearchReasult = searchResults[i].Text;
            //    Assert.IsTrue(currentSearchReasult.Contains(searchText));
            //}
            var productPage = PageFactoryExtensions.InitPage<ProductPage>(this.Driver);
        }

        [Test]
        public void AddProduct()
        {
            var productPageIns = ProductPage.NavigateTo(this.Driver);
            Thread.Sleep(2000);
            productPageIns.Pop.Click();
            //foreach (var album in productPageIns.GetAlbums())
            //{
            //    string text = album.Text;
            //    if (text == "Pop")
            //    {
            //        string url = productPageIns.GetAlbums()..GetAttribute("href");
            //        Driver.Navigate().GoToUrl(url);
            //    }
            //}

            Thread.Sleep(2000);
            var popAlbumPage = PageFactoryExtensions.InitPage<PopAlbumsPage>(this.Driver);

            var allPopAlbums = this.Driver.FindElement(By.LinkText("Animal Vehicle"));

            //string currentAlbum = allPopAlbums[1].Text;
            //Assert.AreEqual("Animal Vehicle", currentAlbum);
            allPopAlbums.Click();
            Thread.Sleep(2000);

            var animalVehicle = PageFactoryExtensions.InitPage<AnimalVehiclePage>(this.Driver);
            Thread.Sleep(1000);
        }

        [Test]
        public void AddToCart1()
        {
            var homePage = HomePage.NavigateTo(this.Driver);
            homePage.ProductButton.Click();
            Thread.Sleep(200);
        }

        [Test]
        public void AddToCart2()
        {
            var homePage = HomePage.NavigateTo(this.Driver);
            Thread.Sleep(3000);
            homePage.StoreButton.Click();
            Thread.Sleep(3000);
            homePage.MoreButton.Click();
            Thread.Sleep(3000);
            var productPage = PageFactoryExtensions.InitPage<ProductPage>(this.Driver);
            Thread.Sleep(2000);
            productPage.Pop.Click();

            Thread.Sleep(2000);
            var popAlbumPage = PageFactoryExtensions.InitPage<PopAlbumsPage>(this.Driver);

            var allPopAlbums = this.Driver.FindElement(By.LinkText("Animal Vehicle"));

            //string currentAlbum = allPopAlbums[1].Text;
            //Assert.AreEqual("Animal Vehicle", currentAlbum);
            allPopAlbums.Click();
            Thread.Sleep(2000);

            var animalVehicle = PageFactoryExtensions.InitPage<AnimalVehiclePage>(this.Driver);
            Thread.Sleep(1000);
            animalVehicle.AddToCart.Click();
            Thread.Sleep(2000);

            var checkoutPage = PageFactoryExtensions.InitPage<CheckoutPage>(this.Driver);
            checkoutPage.Checkoutbutton.Click();
            Thread.Sleep(2000);

            var shippingPage = PageFactoryExtensions.InitPage<ShippingInformationPage>(this.Driver);
            shippingPage.FirstName.SendKeys("penka");
            shippingPage.LastName.SendKeys("fileva");
            shippingPage.Address.SendKeys("Gorubliane");
            shippingPage.City.SendKeys("Sofia");
            shippingPage.State.SendKeys("Sofia");
            shippingPage.PostalCode.SendKeys("10000");
            shippingPage.Country.SendKeys("Bulgaria");
            shippingPage.Phone.SendKeys("0123456");
            shippingPage.Email.SendKeys("FranzFischbach@gmail.com");
            shippingPage.PromoCode.SendKeys("FREE");

            shippingPage.Submit.Click();
            Thread.Sleep(2000);
            var checkoutComplete = PageFactoryExtensions.InitPage<CheckoutComplete>(this.Driver);
            var text = checkoutComplete.CheckOutComplete.Text;
            Assert.AreEqual("Checkout Complete", text);
        }
    }
}
