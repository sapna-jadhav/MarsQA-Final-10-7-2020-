﻿using MarsQA_1.Helpers;
using MarsQA_1.Pages;
using MarsQA_1.SpecflowPages.Pages;
using RelevantCodes.ExtentReports;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using TechTalk.SpecFlow;
using static MarsQA_1.Helpers.CommonMethods;

namespace MarsQA_1.Utils
{
    [Binding]
    public class Start : Driver
    {

        [BeforeScenario]
        public void Setup()
        {
            //launch the browser
            Initialize();
            ExcelLibHelper.PopulateInCollection(@"C:\Users\gupta\source\repos\onboarding.specflow-master\MarsQA-1\SpecflowTests\Data\Mars.xlsx", "Credentials");
            //call the SignIn class
            SignIn.Login();
			ExcelLibHelper.PopulateInCollection(@"C:\Users\gupta\source\repos\onboarding.specflow-master\MarsQA-1\SpecflowTests\Data\Data.xlsx", "Language");
			AddSellerProfile.AddLanguage();
			//AddSellerProfile.EditLanguage();
			AddSellerProfile.DeleteLangauge();
			//AddSellerSkill.AddSkill();
			//AddSellerSkill.EditSkill();
			//AddSellerSkill.DeleteSkill();
			//AddSellerEducation.AddEducation();
			//AddSellerEducation.EditEducation();
			//AddSellerEducation.DeleteEducation();

		}		

        [AfterScenario]
        public void TearDown()
        {

            // Screenshot
            string img = SaveScreenShotClass.SaveScreenshot(Driver.driver, "Report");
           test.Log(LogStatus.Info, "Snapshot below: " + test.AddScreenCapture(img));
            //Close the browser
            Close();
             
            // end test. (Reports)
            CommonMethods.Extent.EndTest(test);
            
            // calling Flush writes everything to the log file (Reports)
            CommonMethods.Extent.Flush();
           

        }
    }
}
