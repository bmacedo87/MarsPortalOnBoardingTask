using MarsQA_1.Helpers;
using NUnit.Framework;
using OpenQA.Selenium;


namespace MarsQA_1.Pages
{
    public class SignIn : Driver
    {

        
        public void Login(string username, string password)
        {
            //Clicking SignIn button
            driver.FindElement(By.XPath("//a[@class='item']")).Click();

            //Enter Username
            driver.FindElement(By.XPath("//input[@placeholder='Email address']")).SendKeys(username);

            //Enter Password
            driver.FindElement(By.XPath("//input[@placeholder='Password']")).SendKeys(password);

            //Clicking Login Button
            driver.FindElement(By.XPath("//button[@class='fluid ui teal button']")).Click();

        }

        public static void LoginAssert()
        {
            IWebElement findUsernameOnPage = driver.FindElement(By.XPath("//div[@class='ui eight item menu']//a[@class='item'][contains(text(),'Profile')]"));

            Assert.That(findUsernameOnPage.Text, Is.EqualTo("Profile"));
        }
    }
}