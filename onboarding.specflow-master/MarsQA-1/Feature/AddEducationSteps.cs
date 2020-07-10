using MarsQA_1.Helpers;
using MarsQA_1.Pages;
using MarsQA_1.SpecflowPages.Pages;
using NUnit.Framework;
using System;
using TechTalk.SpecFlow;

namespace MarsQA_1.Feature
{
    [Binding]
    public class AddEducationSteps
    {
        [Given(@"I have logged in and am on the profile page")]
        public void GivenIHaveLoggedInAndAmOnTheProfilePage()
        {
			SignIn.SigninStep();
		}
        
        [When(@"I try to education details")]
        public void WhenITryToEducationDetails()
        {
			AddEducation.AddNewEdu();

		}
        
        [Then(@"Education details gets added")]
        public void ThenEducationDetailsGetsAdded()
        {
			Assert.AreEqual("Profile", Driver.driver.Title);
			CommonMethods.test.Log(RelevantCodes.ExtentReports.LogStatus.Pass, "Successful Login");
			Driver.driver.Close();
		}
    }
}
