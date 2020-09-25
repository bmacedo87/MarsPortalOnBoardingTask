using MarsQA_1.Helpers;
using MarsQA_1.Pages;
using TechTalk.SpecFlow;

namespace MarsQA_1.Steps
{
    [Binding]
    public class LoginSteps : Driver
    {
        [Given(@"I login to Mars Portal using valid credentials (.*), (.*)")]
        public void GivenILoginToMarsPortalUsingValidCredentials(string username, string password)
        {
            Initialize();
            NavigateUrl();
            SignIn signin = new SignIn();
            signin.Login(username, password);
        }
        
        [Then(@"I should be able to validade I logged into the portal successfully")]
        public void ThenIShouldBeAbleToValidadeILoggedIntoThePortalSuccessfully()
        {
            SignIn.LoginAssert();
            driver.Quit();
        }
    }
}
