using NUnit.Framework;
using RestSharp;
using System;
using TechTalk.SpecFlow;

namespace GiftreteWebsitePostItem_Project.StepDefinitions
{
    [Binding]
    public class BasicAPISteps
    {
        RestClient client;
        RestRequest request;
        IRestResponse response;

        [Given(@"I navigate to Github")]
        public void GivenINavigateToGithub()
        {
            client = new RestClient("https://github.com/Rachaelfavour");
            client.Timeout = -1;
           
        }
        
        [When(@"I search for user")]
        public void WhenISearchForUser()
        {
            request = new RestRequest(Method.GET);
            request.AddHeader("Cookie", "_octo=GH1.1.1330731310.1592847096; logged_in=no; _gh_sess=10LuNKnTNe03%2BeDbdod5jMlMGMsFCKSXlfgTiCKAXqGOzpX4fHrzcKQ%2F5Jl%2FtGB%2FtLJYir54jpsJTZVnmXfUc4vT7eBUireoIhWfJN7VIEoImTO2pRDYbx%2F684UpY6q95LjpFbh64MR1poJzVZ1m5%2F7SQCBxHAuBrx66s2J8KwOnrNDop3LcwRC7QAzpvaQ8yzxAYy8GYEWSYQzb%2B36xcgEBm3xUYGHSzZ8VutqcahQxJSdFgWgwJo%2FT4rOoWpqeu6wlOoi%2F2cWmBJKht00niQ%3D%3D--8yskppSBdhM%2BXfbO--LzcALBvk1jhSBfq9KIMh%2BQ%3D%3D");
            response = client.Execute(request);
           
        }
        
        [Then(@"result is displyed")]
        public void ThenResultIsDisplyed()
        {
            Assert.That(response.Content.Length > 0);
        }
    }
}
