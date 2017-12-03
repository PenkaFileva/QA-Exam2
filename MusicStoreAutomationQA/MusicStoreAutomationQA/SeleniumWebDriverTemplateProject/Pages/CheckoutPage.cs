using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;
using SeleniumWebDriverTemplateProject.Pages.Abstract;

namespace SeleniumWebDriverTemplateProject.Pages
{
    class CheckoutPage :Page
    {
        [FindsBy(How = How.CssSelector, Using = ".button > a:nth-child(1)")]
        public IWebElement Checkoutbutton { get; set; }

    }
}
