using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using NUnit.Framework;
using SeleniumWebDriverTemplateProject.Helpers;
using SeleniumWebDriverTemplateProject.Pages;
using SeleniumWebDriverTemplateProject.Tests.Abstract;

namespace SeleniumWebDriverTemplateProject.Tests
{
    class LoginTests : DesktopSeleniumTestFixturePrototype
    {
        public LoginTests(Browsers browser) : base(browser)
        { }

        [Test]
        public void LoginTest()
        {
            var loginPageInstanc = LoginPage.NavigateTo(this.Driver);
            loginPageInstanc.LogIn();
            Thread.Sleep(3000);

            var homePageIns = PageFactoryExtensions.InitPage<HomePage>(this.Driver);
            string text = homePageIns.UserGreetingTextBox.Text;
            Assert.AreEqual("Hello Administrator@test.com!", text);
        }

        [Test]
        public void LogoutTest()
        {
            var homePageInstance = HomePage.NavigateTo(this.Driver);
            homePageInstance.LogoutButton.Click();
            Thread.Sleep(3000);

            var loginPage = PageFactoryExtensions.InitPage<LoginPage>(this.Driver);
            string word = loginPage.LogInTop.Text;
            Assert.AreEqual("Log in", word);

        }
    }
}
