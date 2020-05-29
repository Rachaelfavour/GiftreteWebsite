using GiftreteWebsitePostItem_Project.Hooks;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using System;
using System.Collections.Generic;
using System.Text;

namespace GiftreteWebsitePostItem_Project.PageObjects
{
    class PostItemPage
    {
        IWebDriver driver;


        public PostItemPage()
        { 
            driver = Hook.driver;
        }  

        IWebElement SignIn => driver.FindElement(By.XPath("//a[text()='Sign In']"));

        IWebElement EmailAddress => driver.FindElement(By.XPath("//input[@name = 'user_email']"));

        IWebElement Password => driver.FindElement(By.XPath("//input[@id='user_password']"));

        IWebElement SignInButton => driver.FindElement(By.CssSelector("#btn_signin"));

        IWebElement Postitem => driver.FindElement(By.CssSelector("a[href='/post/create']"));

        IWebElement ItemName => driver.FindElement(By.XPath("//input[@id = 'title']"));

        IWebElement ItemDescription => driver.FindElement(By.XPath("/html"));

        IWebElement SelectFurnitureItemCategory => driver.FindElement(By.XPath("//*[@id='categoryone']"));

        IWebElement OffereditemType => driver.FindElement(By.XPath("//select[@id = 'type']"));

        IWebElement ItemWeight => driver.FindElement(By.XPath("//input[@id = 'weight']"));

        IWebElement Location => driver.FindElement(By.XPath("//input[@id = 'autocomplete']"));

        IWebElement UploadItem => driver.FindElement(By.XPath("//*[@id='files']"));

        IWebElement AddItem => driver.FindElement(By.XPath("//*[@id='btn_create']"));

        

        public void EnterLocation()
        {
            Location.SendKeys("London, uk");
        }


        public void EnterItemWeight()
        {
            ItemWeight.SendKeys("25kg");
        }

        public void SelectOfferedFromItemType()
        {
            SelectElement select = new SelectElement(OffereditemType);
            select.SelectByValue("Offered");
        }


        public void SelectFurnitureFromItemCategory()
        {
            SelectElement select = new SelectElement(SelectFurnitureItemCategory);
            select.SelectByValue("4");

        }   

        public void EnterItemDescription()
        {
            ItemDescription.SendKeys("Armchair for your lounge");
        }

        public void EnterItemName()
        {
            ItemName.SendKeys("Chair");
        }

        public void ClickOnPostItem()
        {
            Postitem.Click();
        }


        public void ClickOnSignInButton()
        {
            SignInButton.Click();
        }

        internal void UploadImage()
        {
            UploadItem.SendKeys("C:\\Users\\Favour\\Desktop\\Armchair.png");
        }

        public void EnterPassword()
        {
            Password.SendKeys("favour123");
        }

        internal void ClickAddItem()
        {
            AddItem.Click();
        }

        public void EnterEmailAddess()
        {
            EmailAddress.SendKeys("richkome@yahoo.com");
        }
        public void ClickOnSignIn()
        {
            SignIn.Click();
        }
        
        public void NavigateToWebsite(string url)
        {
            driver.Navigate().GoToUrl(url);
        }




















            












            



























    }
}
