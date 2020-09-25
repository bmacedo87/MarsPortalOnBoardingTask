using MarsQA_1.Helpers;
using MarsQA_1.Pages;
using TechTalk.SpecFlow;


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
            NavigateUrl();
            //call the SignIn class
            SignIn signin = new SignIn();
            signin.Login("bmacedo1987@gmail.com", "industryconnect");
        }

        [AfterScenario]
        public void TearDown()
        {
                
            driver.Quit();

        }
    }
}
