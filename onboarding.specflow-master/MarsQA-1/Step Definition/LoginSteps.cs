using System;
using TechTalk.SpecFlow;
using MarsQA_1.Helpers;
using OpenQA.Selenium;
using MarsQA_1.Pages;
using NUnit.Framework;

namespace MarsQA_1.Feature
{
    [Binding]
    public class LoginSteps
    {
        [Given(@"I have open the browser and I have navigated to the url")]
        public void GivenIHaveOpenTheBrowserAndIHaveNavigatedToTheUrl()
        {
		
			Driver.NavigateUrl();
			//Assertion and reporting comments
			Assert.AreEqual("Home",Driver.driver.Title);
			CommonMethods.test.Log(RelevantCodes.ExtentReports.LogStatus.Pass, "Navigation Successful");

		}
        
        [When(@"I provide correct user name and password and press sign in")]
        public void WhenIProvideCorrectUserNameAndPasswordAndPressSignIn()
        {
			//call the SignIn class
			SignIn.SigninStep();
		}
        
        [Then(@"I succesfully login to home page")]
        public void ThenISuccesfullyLoginToHomePage()
        {
			//verification assertion
			Assert.AreEqual("Profile", Driver.driver.Title);
			CommonMethods.test.Log(RelevantCodes.ExtentReports.LogStatus.Pass, "Successful Login");
			Driver.driver.Close();
		}
    }
}
