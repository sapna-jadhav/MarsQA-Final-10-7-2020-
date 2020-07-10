using MarsQA_1.Helpers;
using MarsQA_1.Pages;
using MarsQA_1.SpecflowPages.Pages;
using NUnit.Framework;
using System;
using TechTalk.SpecFlow;

namespace MarsQA_1.Feature
{
    [Binding]
    public class AddEditDeleteSkillSteps
    {
        [Given(@"I  logged in with valid credentials and navigate to profile page")]
        public void GivenILoggedInWithValidCredentialsAndNavigateToProfilePage()
        {
			//call the SignIn class
			SignIn.Login();
		}
        
        [Given(@"I have logged in and trying to edit Skill Details")]
        public void GivenIHaveLoggedInAndTryingToEditSkillDetails()
        {
			//call the SignIn class
			SignIn.Login();
		}
        
        [Given(@"I have logged in with given credentails and im on the profile page")]
        public void GivenIHaveLoggedInWithGivenCredentailsAndImOnTheProfilePage()
        {
			//call the SignIn class
			SignIn.Login();
		}

		[When(@"I try to add Skill Details")]
		public void WhenITryToAddSkillDetails()
		{
			//call the add skill class
			AddSellerSkill.AddSkill();
		}


		[When(@"I try to Edit Skill Details")]
        public void WhenITryToEditSkillDetails()
        {
			AddSellerSkill.EditSkill();
		}
        
        [When(@"I try to delete Skill Details")]
        public void WhenITryToDeleteSkillDetails()
        {
			AddSellerSkill.DeleteSkill();
		}
        
        [Then(@"A Skill Details gets added Successfully")]
        public void ThenASkillDetailsGetsAddedSuccessfully()
        {
			//verification assertion
			Assert.AreEqual("profile", Driver.driver.Title);
			CommonMethods.test.Log(RelevantCodes.ExtentReports.LogStatus.Pass, "Details added Successfully");
		}
        
        [Then(@"Skill Details gets Updated Successfully")]
        public void ThenSkillDetailsGetsUpdatedSuccessfully()
        {
			//verification assertion
			Assert.AreEqual("profile", Driver.driver.Title);
			CommonMethods.test.Log(RelevantCodes.ExtentReports.LogStatus.Pass, "Details edited Successfully");
		}
        
        [Then(@"Skill Details gets deleted successfully")]
        public void ThenSkillDetailsGetsDeletedSuccessfully()
        {
			//verification assertion
			Assert.AreEqual("Profile", Driver.driver.Title);
			CommonMethods.test.Log(RelevantCodes.ExtentReports.LogStatus.Pass, "Details deleted Successfully");
		}
    }
}
