using MarsQA_1.Helpers;
using MarsQA_1.SpecflowPages.Helpers;
using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace MarsQA_1.SpecflowPages.Pages
{

	public static class AddSellerProfile
	{
		private static IWebElement BtnAddNew => Driver.driver.FindElement(By.XPath("//div[@class='ui bottom attached tab segment active tooltip-target']//div[contains(@class,'ui teal button')][contains(text(),'Add New')]"));
		private static IWebElement TxtLanguage => Driver.driver.FindElement(By.XPath("//input[@placeholder='Add Language']"));
		private static IWebElement DdlLevel => Driver.driver.FindElement(By.XPath("//select[@name='level']"));
		private static IWebElement AddBtn => Driver.driver.FindElement(By.XPath("//input[@class='ui teal button']"));
		private static IWebElement BtnEdit => Driver.driver.FindElement(By.XPath("//div[@data-tab='first']//table//tbody//tr//td[3]//i[@class='outline write icon']"));
		private static IWebElement BtnUpdate => Driver.driver.FindElement(By.XPath("//input[@class='ui teal button']"));
		private static IWebElement BtnDelete => Driver.driver.FindElement(By.XPath("//div[@data-tab='first']//table//tbody//tr//td[3]//i[@class='remove icon']"));
		

		public static void AddLanguage()
		{
			//driver.FindElement(By.Name("q")).SendKeys("LambdaTest" + Keys.Enter);
			//for adding language details
			Driver.driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(5);
			BtnAddNew.Click();
			//TxtLanguage.SendKeys(ExcelLibHelper.ReadData(2, "Language"));
			TxtLanguage.SendKeys("French");
			//GenericMethods.CheckLength(4, 30, "Language", "French");
			Driver.driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(5);
			DdlLevel.SendKeys("Conversational");
			AddBtn.Click();
		}

		public static void EditLanguage()
		{

			//for editing language details
			Driver.driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(5);
			BtnEdit.Click();
			TxtLanguage.Clear();
			TxtLanguage.SendKeys("Hindi");
			Driver.driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(5);
			DdlLevel.SendKeys("Fluent");
			BtnUpdate.Click();
			
		}
		public static void DeleteLangauge()
		{
			//for deleting language details
			Driver.driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(5);
			IList<IWebElement> rowDeleteButtons = Driver.driver.FindElements(By.XPath("//div[@data-tab='first']//table//tbody//tr//td[3]//i[@class='remove icon']"));
			rowDeleteButtons[0].Click();
			
		}
	}
}
