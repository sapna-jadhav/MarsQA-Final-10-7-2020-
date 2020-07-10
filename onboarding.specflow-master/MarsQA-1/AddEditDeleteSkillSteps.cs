using System;
using TechTalk.SpecFlow;

namespace MarsQA_1
{
    [Binding]
    public class AddEditDeleteSkillSteps
    {
        [Given(@"I  logged in with valid credentials and navigate to profile page")]
        public void GivenILoggedInWithValidCredentialsAndNavigateToProfilePage()
        {
            ScenarioContext.Current.Pending();
        }
        
        [Given(@"I have logged in with given credentails and im on the profile page")]
        public void GivenIHaveLoggedInWithGivenCredentailsAndImOnTheProfilePage()
        {
            ScenarioContext.Current.Pending();
        }
    }
}
