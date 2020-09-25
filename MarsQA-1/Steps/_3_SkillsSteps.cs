using MarsQA_1.Helpers;
using MarsQA_1.SpecflowPages.Pages;
using OpenQA.Selenium.Support.UI;
using TechTalk.SpecFlow;

namespace MarsQA_1.Steps
{
    [Binding]
    public class _3_SkillsSteps : Driver
    {
        [Given(@"I click on the Skills tab")]
        public void GivenIClickOnTheSkillsTab()
        {
            ProfilePage.skillsTab.Click();
        }
        
        [Given(@"I click on Add New skills button")]
        public void GivenIClickOnAddNewSkillsButton()
        {
            ProfilePage.addNewSkillButton.Click();
        }
        
        [Given(@"I add a new skill to my profile (.*), (.*)")]
        public void GivenIAddANewSkillToMyProfile(string skill, string skillLevel)
        {
            ProfilePage.addSkillTextbox.SendKeys(skill);
            SelectElement selectElement = new SelectElement(ProfilePage.skillLevelDropdown);
            selectElement.SelectByText("Beginner");
        }
        
        [Given(@"I click on Edit Skill icon")]
        public void GivenIClickOnEditSkillIcon()
        {
            ProfilePage.editSkillIcon.Click();
        }
        
        [Given(@"I update an existent Skill record")]
        public void GivenIUpdateAnExistentSkillRecord()
        {
            ProfilePage.editSkillTextbox.SendKeys("EDITED");
        }

        [Given(@"I click on the Delete Skill button")]
        public void GivenIClickOnTheDeleteSkillButton()
        {
            ProfilePage.deletSkillButton.Click();
        }
        
        [When(@"I click on Add skill button")]
        public void WhenIClickOnAddSkillButton()
        {
            ProfilePage.addSkillButton.Click();
        }
        
        [When(@"I click on Update Skill button")]
        public void WhenIClickOnUpdateSkillButton()
        {
            ProfilePage.updateSkillButton.Click();
        }
        
        [Then(@"I should be able to see a new skill record added")]
        public void ThenIShouldBeAbleToSeeANewSkillRecordAdded()
        {
            ProfilePage skillObject = new ProfilePage();
            skillObject.AddSkillAssertion();
        }
        
        [Then(@"I should be able to see the existent Skill record updated")]
        public void ThenIShouldBeAbleToSeeTheExistentSkillRecordUpdated()
        {
            ProfilePage skillObject = new ProfilePage();
            skillObject.EditSkillAssertion();
        }
        
        [Then(@"I should be able to validate that existent skill record has been deleted")]
        public void ThenIShouldBeAbleToValidateThatExistentSkillRecordHasBeenDeleted()
        {
            ProfilePage skillObject = new ProfilePage();
            skillObject.DeleteSkillAssertion();
        }
    }
}
