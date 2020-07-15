using MarsQA_1.Helpers;
using MarsQA_1.Pages;
using MarsQA_1.SpecflowPages.Pages;
using NUnit.Framework;
using OpenQA.Selenium;
using System;
using TechTalk.SpecFlow;

namespace MarsQA_1.Step_Definition
{
    [Binding]
    public class AddEditDeleteLanguageSteps
    {
        [Given(@"I logged in with valid credentails")]
        public void GivenILoggedInWithValidCredentails()
        {
			SignIn.Login();
		}
        
        [When(@"I try to add new language on the profile page")]
        public void WhenITryToAddNewLanguageOnTheProfilePage()
        {
			AddSellerProfile.AddLanguage();
		}
        
        [When(@"I try to Edit language Details")]
        public void WhenITryToEditLanguageDetails()
        {
			AddSellerProfile.EditLanguage();
		}
        
        [When(@"I try to delete Seller language details")]
        public void WhenITryToDeleteSellerLanguageDetails()
        {
			AddSellerProfile.DeleteLangauge();
		}
        
        [Then(@"A new language gets added successfully")]
        public void ThenANewLanguageGetsAddedSuccessfully()
        {
				string searchInput = Driver.driver.FindElement(By.XPath("//tbody//tr[1]//td[1]")).Text;
				Assert.AreEqual(searchInput, "French");
			string searchLevel = Driver.driver.FindElement(By.XPath("//tbody//tr[1]//td[2]")).Text;
			Assert.AreEqual(searchLevel, "Conversational");



			CommonMethods.test.Log(RelevantCodes.ExtentReports.LogStatus.Pass, "Language added Successfully");
		}
        
        [Then(@"A Seller Language gets Updated Successfully")]
        public void ThenASellerLanguageGetsUpdatedSuccessfully()
        {
			
				string searchInput2 = Driver.driver.FindElement(By.XPath("///tbody//tr[1]//td[1]")).Text;
				Assert.AreEqual(searchInput2, "Hindi");
			string searchLevel = Driver.driver.FindElement(By.XPath("//tbody//tr[1]//td[2]")).Text;
			Assert.AreEqual(searchLevel, "Fluent");


			CommonMethods.test.Log(RelevantCodes.ExtentReports.LogStatus.Pass, "Language edited Successfully");
		}
        
        [Then(@"The Seller language deatils gets deleted successfully")]
        public void ThenTheSellerLanguageDeatilsGetsDeletedSuccessfully()
        {
			try
			{
				String ActLang2 = (Driver.driver.FindElement(By.XPath("//tbody//tr[1]//td[1]"))).Text;
				Assert.AreNotEqual(ActLang2, "Hindi");
			}
			catch
			{
				Assert.True(true, "Element not found");
			}
		
		CommonMethods.test.Log(RelevantCodes.ExtentReports.LogStatus.Pass, "Language deleted Successfully");
		}
    }
}
