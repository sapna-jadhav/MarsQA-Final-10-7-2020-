using MarsQA_1.Helpers;
using MarsQA_1.Pages;
using MarsQA_1.SpecflowPages.Pages;
using NUnit.Framework;
using System;
using TechTalk.SpecFlow;

namespace MarsQA_1.Feature
{
    [Binding]
    public class AddEditDeleteEducationSteps
    {
        [Given(@"I have logged in with username and pwd")]
        public void GivenIHaveLoggedInWithUsernameAndPwd()
        {
			//call the SignIn class
			SignIn.Login();
		}
        
        [Given(@"I have logged in and trying to edit Education details")]
        public void GivenIHaveLoggedInAndTryingToEditEducationDetails()
        {
			//call the SignIn class
			SignIn.Login();
		}
        
        [Given(@"I have logged in and navigate to profile page")]
        public void GivenIHaveLoggedInAndNavigateToProfilePage()
        {
			//call the SignIn class
			SignIn.Login();
		}
        
        [When(@"I try to add Education details")]
        public void WhenITryToAddEducationDetails()
        {
			//call the add education class
			AddSellerEducation.AddEducation();
		}
        
        [When(@"I try to Edit Education details")]
        public void WhenITryToEditEducationDetails()
        {
			AddSellerEducation.EditEducation();
		}
        
        [When(@"I try to delete Education details")]
        public void WhenITryToDeleteEducationDetails()
        {
			AddSellerEducation.DeleteEducation();
		}
        
        [Then(@"A Education details gets added successfully")]
        public void ThenAEducationDetailsGetsAddedSuccessfully()
        {
			//verification assertion
			Assert.AreEqual("profile", Driver.driver.Title);
			CommonMethods.test.Log(RelevantCodes.ExtentReports.LogStatus.Pass, "Details added Successfully");
		}
        
        [Then(@"Education details gets Updated Successfully")]
        public void ThenEducationDetailsGetsUpdatedSuccessfully()
        {
			//verification assertion
			Assert.AreEqual("profile", Driver.driver.Title);
			CommonMethods.test.Log(RelevantCodes.ExtentReports.LogStatus.Pass, "Details edited Successfully");
		}
        
        [Then(@"Education details gets deleted successfully")]
        public void ThenEducationDetailsGetsDeletedSuccessfully()
        {
			//verification assertion
			Assert.AreEqual("Profile", Driver.driver.Title);
			CommonMethods.test.Log(RelevantCodes.ExtentReports.LogStatus.Pass, "Details deleted Successfully");
		}
    }
}
