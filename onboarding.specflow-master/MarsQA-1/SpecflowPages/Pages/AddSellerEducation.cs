using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using MarsQA_1.Helpers;
using MarsQA_1.SpecflowPages.Helpers;
using OpenQA.Selenium;

namespace MarsQA_1.SpecflowPages.Pages
{

	public static class AddSellerEducation
	{
		private static IWebElement EduLink => Driver.driver.FindElement(By.XPath("//a[@class='item'][contains(text(),'Education')]"));
		private static IWebElement BtnAddNewEdu => Driver.driver.FindElement(By.XPath("//div[@class='ui bottom attached tab segment tooltip-target active']//div[contains(@class,'ui teal button')][contains(text(),'Add New')]"));
		private static IWebElement TxtCollege => Driver.driver.FindElement(By.XPath("//input[@placeholder='College/University Name']"));
		private static IWebElement DdlCountry => Driver.driver.FindElement(By.XPath("//select[@name='country']"));
		private static IWebElement DdlTitle => Driver.driver.FindElement(By.XPath("//select[@name='title']"));
		private static IWebElement TxtDegree => Driver.driver.FindElement(By.XPath("//input[@placeholder='Degree']"));
		private static IWebElement DdlYear => Driver.driver.FindElement(By.XPath("//select[@name='yearOfGraduation']"));
		private static IWebElement BtnAddEdu => Driver.driver.FindElement(By.XPath("//div[@class='sixteen wide field']//input[contains(@class,'ui teal button')]"));
		private static IWebElement EditBtn => Driver.driver.FindElement(By.XPath("//div[@data-tab='third']//table//tbody//tr//td[6]//i[@class='outline write icon']"));
		private static IWebElement BtnUpdate => Driver.driver.FindElement(By.XPath("//div[@class='sixteen wide field']//input[@class='ui teal button']"));
		//private static IWebElement BtnDelete => Driver.driver.FindElement(By.XPath("//input[@placeholder='Degree']"));
		private static IWebElement BtnDelete => Driver.driver.FindElement(By.XPath("//div[@data-tab='third']//table//tbody//tr//td[6]//i[@class='remove icon']"));
		
		public static void AddEducation()
		{
			//for adding education details
			Thread.Sleep(1000);
			EduLink.Click();
			BtnAddNewEdu.Click();
			TxtCollege.SendKeys("MIT");
			DdlCountry.SendKeys("India");
			DdlTitle.SendKeys("B.Tech");
			TxtDegree.SendKeys("Enggineering");
			DdlYear.SendKeys("2014");
			BtnAddEdu.Click();

			CommonMethods.test.Log(RelevantCodes.ExtentReports.LogStatus.Pass, "Education details added successfully");
		}
		public static void EditEducation()
		{
			//for editing education details
			Thread.Sleep(1000);
			EduLink.Click();
			EditBtn.Click();
			TxtCollege.Clear();
			TxtDegree.Clear();
			TxtCollege.SendKeys("Raisoni");
			TxtDegree.SendKeys("Masters");
			BtnUpdate.Click();
			CommonMethods.test.Log(RelevantCodes.ExtentReports.LogStatus.Pass, "Education details edited successfully");
		}
		public static void DeleteEducation()
		{
			//for deleting education details
			Thread.Sleep(1000);
			EduLink.Click();
			BtnDelete.Click();
			CommonMethods.test.Log(RelevantCodes.ExtentReports.LogStatus.Pass, "Education details deleted successfully");
		}

	}
}
