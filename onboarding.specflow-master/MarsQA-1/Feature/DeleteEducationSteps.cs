using MarsQA_1.Helpers;
using MarsQA_1.Pages;
using MarsQA_1.SpecflowPages.Pages;
using NUnit.Framework;
using System;
using TechTalk.SpecFlow;

namespace MarsQA_1.Feature
{
    [Binding]
    public class DeleteEducationSteps
    {
        [Given(@"I have logged in and on the profile on")]
        public void GivenIHaveLoggedInAndOnTheProfileOn()
        {
			SignIn.SigninStep();
		}
        
        [When(@"I try to delete education")]
        public void WhenITryToDeleteEducation()
        {
			AddEducation.DeleteEducation();
		}
        
        [Then(@"education gets delete")]
        public void ThenEducationGetsDelete()
        {
			Assert.AreEqual("Profile", Driver.driver.Title);
			CommonMethods.test.Log(RelevantCodes.ExtentReports.LogStatus.Pass, "Successful Login");
			Driver.driver.Close();
		}
    }
}
