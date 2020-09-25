using MarsQA_1.Helpers;
using NUnit.Framework;
using OpenQA.Selenium;


namespace MarsQA_1.SpecflowPages.Pages
{
    public class ProfilePage : Driver
        {
        // Languages

        public static IWebElement languageTab => driver.FindElement(By.XPath("//a[contains(text(),'Languages')]"));
        public static IWebElement addNewButton => driver.FindElement(By.XPath("//div[2]//div[1]//div[2]//div[1]//table[1]//thead[1]//tr[1]//th[3]//div[1]"));
        public static IWebElement languageTextbox => driver.FindElement(By.XPath("//input[@placeholder='Add Language']"));
        public static IWebElement languageLevelDropdown => driver.FindElement(By.XPath("//select[@class='ui dropdown']"));
        public static IWebElement addButton => driver.FindElement(By.XPath("//input[@value='Add']"));
        public static IWebElement editIcon => driver.FindElement(By.XPath("//div[@class='ui bottom attached tab segment active tooltip-target']//i[@class='outline write icon']"));
        public static IWebElement editLanguageTextbox => driver.FindElement(By.XPath("//input[@placeholder='Add Language']"));
        public static IWebElement deleteIcon => driver.FindElement(By.XPath("//span[2]//i[1]"));
        public static IWebElement updateButton => driver.FindElement(By.XPath("//input[@value='Update']"));

        public void AddAssertion()
        {
            IWebElement findNewLanguageCreated = driver.FindElement(By.XPath("//td[contains(text(),'English')]"));

            Assert.That(findNewLanguageCreated.Text, Is.EqualTo("English"));
        }

        public void EditAssertion()
        {
            IWebElement findEditedLanguage = driver.FindElement(By.XPath("//td[contains(text(),'EnglishEDITED')]"));

            Assert.That(findEditedLanguage.Text, Is.EqualTo("EnglishEDITED"));
        }

        public void DeleteAssertion()
        {
            IWebElement popUpDeletedLanguage = driver.FindElement(By.XPath(" //div[contains(text(),'EnglishEDITED has been deleted from your languages')]"));
            
            if (popUpDeletedLanguage.Text == "EnglishEDITED has been deleted from your languages")
            {
                Assert.Pass("Language record deleted successfully, test passed!");
            }
            else
            {
                Assert.Fail("Language record not deleted, test failed!");
            }
           
        }

        // Skills

        public static IWebElement skillsTab => driver.FindElement(By.XPath("//a[contains(text(),'Skills')]"));
        public static IWebElement addNewSkillButton => driver.FindElement(By.XPath("//div//div//div//div//div//div//div[3]//div[1]//div[2]//div[1]//table[1]//thead[1]//tr[1]//th[3]//div[1]"));
        public static IWebElement addSkillTextbox => driver.FindElement(By.XPath("//input[@placeholder='Add Skill']"));
        public static IWebElement skillLevelDropdown => driver.FindElement(By.XPath("//select[@name='level']"));
        public static IWebElement addSkillButton => driver.FindElement(By.XPath("//input[@value='Add']"));
        public static IWebElement editSkillIcon => driver.FindElement(By.XPath("//td[3]//span[1]//i[1]"));
        public static IWebElement editSkillTextbox => driver.FindElement(By.XPath("//input[@placeholder='Add Skill']"));
        public static IWebElement updateSkillButton => driver.FindElement(By.XPath("//input[@value='Update']"));
        public static IWebElement deletSkillButton => driver.FindElement(By.XPath("//td[3]//span[2]//i[1]"));

        public void AddSkillAssertion()
        {
            IWebElement findNewSkillCreated = driver.FindElement(By.XPath("//td[contains(text(),'C#')]"));

            Assert.That(findNewSkillCreated.Text, Is.EqualTo("C#"));
        }

        public void EditSkillAssertion()
        {
            IWebElement findEditedSkill = driver.FindElement(By.XPath("//td[contains(text(),'C#EDITED')]"));

            Assert.That(findEditedSkill.Text, Is.EqualTo("C#EDITED"));
        }

        public void DeleteSkillAssertion()
        {
            IWebElement popUpDeletedLanguage = driver.FindElement(By.XPath("//div[contains(text(),'C#EDITED has been deleted')]")); 

            if (popUpDeletedLanguage.Text == "C#EDITED has been deleted")
            {
                Assert.Pass("Language record deleted successfully, test passed!");
            }
            else
            {
                Assert.Fail("Language record not deleted, test failed!");
            }

        }


    }
}
