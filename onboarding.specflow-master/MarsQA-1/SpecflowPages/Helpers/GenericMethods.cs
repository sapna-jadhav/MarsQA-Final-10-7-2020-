using MarsQA_1.Helpers;
using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MarsQA_1.SpecflowPages.Helpers
{
	class GenericMethods
	{
		// character length validation
		public static void CheckLength(int minLength, int maxLength, string inputText, string fieldName)
		{
			try
			{
				Assert.LessOrEqual(inputText.Length, maxLength);
				Assert.GreaterOrEqual(inputText.Length, minLength);
				//CommonFeatures.test.Log(RelevantCodes.ExtentReports.LogStatus.Skip, passMessage);
			}
			catch (Exception ex)
			{
				//CommonFeatures.test.Log(RelevantCodes.ExtentReports.LogStatus.Fail, failMessage);
				Console.WriteLine("exception message:" + ex.Message + "Inner exception:" + ex.InnerException);
				Console.WriteLine("The field must be between " + minLength + " - " + maxLength + " alphanumeric characters.");
				CommonMethods.test.Log(RelevantCodes.ExtentReports.LogStatus.Fail, fieldName + " must be between " + minLength + " - " + maxLength + " alphanumeric characters.");
				Driver.driver.Close();
			}

		}
	}
}
