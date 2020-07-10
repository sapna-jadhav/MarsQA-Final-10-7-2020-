using MarsQA_1.Helpers;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace MarsQA_1.SpecflowPages.Pages
{

	public static class AddSellerSkill
	{
		private static IWebElement SkillLink => Driver.driver.FindElement(By.XPath("//a[contains(text(),'Skills')]"));
		private static IWebElement AddNewSkillBtn => Driver.driver.FindElement(By.XPath("//div[@class='ui teal button']"));
		private static IWebElement TxtSkill => Driver.driver.FindElement(By.XPath("//input[@placeholder='Add Skill']"));
		private static IWebElement DdlSkillLevel => Driver.driver.FindElement(By.XPath("//div[@class='ui bottom attached tab segment tooltip-target active']//select[@name='level']"));
		private static IWebElement AddSkillBtn => Driver.driver.FindElement(By.XPath("//div[@class='ui bottom attached tab segment tooltip-target active']//input[contains(@class,'ui teal button')]"));
		private static IWebElement SkillEdit => Driver.driver.FindElement(By.XPath("//div[@data-tab='second']//table//tbody//tr//td[3]//i[@class='outline write icon']"));
		private static IWebElement UpdateSkill => Driver.driver.FindElement(By.XPath("//div[@class='ui bottom attached tab segment tooltip-target active']//input[@class='ui teal button']"));
		private static IWebElement DelSkill => Driver.driver.FindElement(By.XPath("//div[@data-tab='second']//table//tbody//tr//td[3]//i[@class='remove icon']"));

		public static void AddSkill()
		{
			//for adding skill details
			Thread.Sleep(500);
			SkillLink.Click();
			Thread.Sleep(500);
			AddNewSkillBtn.Click();
			TxtSkill.SendKeys("c#");
			DdlSkillLevel.SendKeys("Intermediate");
			AddSkillBtn.Click();
			CommonMethods.test.Log(RelevantCodes.ExtentReports.LogStatus.Pass, "Skills added successfully");
		}
		public static void EditSkill()
		{
			//for editing skill details
			Thread.Sleep(1000);
			SkillLink.Click();
			SkillEdit.Click();
			TxtSkill.Clear();
			TxtSkill.SendKeys("selenium");
			DdlSkillLevel.SendKeys("Expert");
			UpdateSkill.Click();
			CommonMethods.test.Log(RelevantCodes.ExtentReports.LogStatus.Pass, "Skills edited successfully");

		}
		public static void DeleteSkill()
		{
			//for deleting skill details
			Thread.Sleep(1000);
			SkillLink.Click();
			DelSkill.Click();
			CommonMethods.test.Log(RelevantCodes.ExtentReports.LogStatus.Pass, "Skills deleted successfully");
		}
	}
}
