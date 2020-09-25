using MarsQA_1.Helpers;
using MarsQA_1.SpecflowPages.Pages;
using OpenQA.Selenium.Support.UI;
using TechTalk.SpecFlow;

namespace MarsQA_1.Steps
{
    [Binding]
    public class _2_LanguagesSteps : Driver
    {
        [Given(@"I click on Add New button")]
        public void GivenIClickOnAddNewButton()
        {
            TurnOnWait();
            ProfilePage.addNewButton.Click();
        }
        
        [Given(@"I enter language details (.*), (.*)")]
        public void GivenIEnterLanguageDetails(string language, string languageLevel)
        {
            TurnOnWait();
            ProfilePage.languageTextbox.SendKeys(language);
            SelectElement selectElement = new SelectElement(ProfilePage.languageLevelDropdown);
            selectElement.SelectByText("Native/Bilingual");

        }
        
        [Given(@"I click on the Edit icon")]
        public void GivenIClickOnTheEditIcon()
        {
            TurnOnWait();
            ProfilePage.editIcon.Click();
        }
        
        [Given(@"I edit existent record")]
        public void GivenIEditExistentRecord()
        {
            TurnOnWait();
            ProfilePage.editLanguageTextbox.SendKeys("EDITED");
        }
        
        [Given(@"I click on delete icon")]
        public void GivenIClickOnDeleteIcon()
        {
            TurnOnWait();
            ProfilePage.deleteIcon.Click();
        }
        
        [When(@"I click on Add button")]
        public void WhenIClickOnAddButton()
        {
            TurnOnWait();
            ProfilePage.addButton.Click();
        }
        
        [When(@"I click on Update button")]
        public void WhenIClickOnUpdateButton()
        {
            TurnOnWait();
            ProfilePage.updateButton.Click();
        }
        
        [Then(@"I should be able to see a new language record created")]
        public void ThenIShouldBeAbleToSeeANewLanguageRecordCreated()
        {
            TurnOnWait();
            ProfilePage languageObject = new ProfilePage();
            languageObject.AddAssertion();
        }
        
        [Then(@"I should be able to see the existent record updated")]
        public void ThenIShouldBeAbleToSeeTheExistentRecordUpdated()
        {
            TurnOnWait();
            ProfilePage languageObject = new ProfilePage();
            languageObject.EditAssertion();
        }
        
        [Then(@"I should be able to validate that existent language record has been deleted")]
        public void ThenIShouldBeAbleToValidateThatExistentLanguageRecordHasBeenDeleted()
        {
            TurnOnWait();
            ProfilePage languageObject = new ProfilePage();
            languageObject.DeleteAssertion();
        }
    }
}
