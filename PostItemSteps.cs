using GiftreteWebsitePostItem_Project.PageObjects;
using NUnit.Framework;
using System;
using TechTalk.SpecFlow;

namespace GiftreteWebsitePostItem_Project.StepDefinitions
{
    [Binding]
    public class PostItemSteps
    {
        PostItemPage postItempage;
        public PostItemSteps()
        {
            postItempage = new PostItemPage();
        }

        [Given(@"I click on Signin")]
        public void GivenIClickOnSignin()
        {
            postItempage.ClickOnSignIn();
        }

        [When(@"I click on Signin button")]
        public void WhenIClickOnSigninButton()
        {
            postItempage.ClickOnSignInButton();
        }

        [Given(@"I navigate to the site ""(.*)""")]
        public void GivenINavigateToTheSite(string url)
        {
            postItempage.NavigateToWebsite(url);
        }
        
        [When(@"I enter Emailaddress")]
        public void WhenIEnterEmailaddress()
        {
            postItempage.EnterEmailAddess();
        }
        
        [When(@"I enter Password")]
        public void WhenIEnterPassword()
        {
            postItempage.EnterPassword();
        }
        
        
        [When(@"I click on PostItem")]
        public void WhenIClickOnPostItem()
        {
            postItempage.ClickOnPostItem();
        }
        
        [When(@"I enter ItemName")]
        public void WhenIEnterItemName()
        {
            postItempage.EnterItemName();

        }
        
        [When(@"I enter ItemDescription")]
        public void WhenIEnterItemDescription()
        {
            postItempage.EnterItemDescription();
        }
        
        [When(@"I select ItemCategory")]
        public void WhenISelectItemCategory()
        {
         postItempage.SelectFurnitureFromItemCategory();
        }
        
        [When(@"I select ItemType")]
        public void WhenISelectItemType()
        {
            postItempage.SelectOfferedFromItemType();
        }
        
        [When(@"I enter ItemWeight")]
        public void WhenIEnterItemWeight()
        {
            postItempage.EnterItemWeight();
        }
        
        [When(@"I enter Location")]
        public void WhenIEnterLocation()
        {
            postItempage.EnterLocation();
        }

        [When(@"I upload image")]
        public void WhenIUploadImage()
        {
            postItempage.UploadImage();
        }

        [When(@"I click on add item")]
        public void WhenIClickOnAddItem()
        {
            postItempage.ClickAddItem();
        }

        [Then(@"Item image is displayed")]
        public void ThenItemImageIsDisplayed()
        {
           // Assert.IsTrue(postItempage.itemImageIsDisplayed());
        }




    }
}
