using OpenQA.Selenium;
using RelevantCodes.ExtentReports;
using SpecflowPages;
using System;
using System.Threading;
using TechTalk.SpecFlow;
using static SpecflowPages.CommonMethods;

namespace SpecflowTests
{
    [Binding]
    public class SkillsSteps
    {
        [Given(@"I clicked on the skills tab under Profile page")]
        public void GivenIClickedOnTheSkillsTabUnderProfilePage()
        {
            //Wait
            Thread.Sleep(1500);

            // Click on Profile tab
            Driver.driver.FindElement(By.XPath(".//*[@id='account-profile-section']/div/section[2]/div/div/div/div[3]/form/div[1]/a[2]")).Click();

        }

        [When(@"I add a new skill")]
        public void WhenIAddANewSkill()
        {
            //Click on Add New button
            Driver.driver.FindElement(By.XPath(".//*[@id='account-profile-section']/div/section[2]/div/div/div/div[3]/form/div[3]/div/div[2]/div/table/thead/tr/th[3]/div")).Click();

            //Add skill
            Driver.driver.FindElement(By.XPath(".//*[@id='account-profile-section']/div/section[2]/div/div/div/div[3]/form/div[3]/div/div[2]/div/div/div[1]/input")).SendKeys("Manual");

            //Click on skill Level
            Driver.driver.FindElement(By.XPath(".//*[@id='account-profile-section']/div/section[2]/div/div/div/div[3]/form/div[3]/div/div[2]/div/div/div[2]/select")).Click();

            //Choose the skill level
            IWebElement Lang = Driver.driver.FindElements(By.XPath(".//*[@id='account-profile-section']/div/section[2]/div/div/div/div[3]/form/div[3]/div/div[2]/div/div/div[2]/select/option[3]"))[3];
            Lang.Click();

            //Click on Add button
            Driver.driver.FindElement(By.XPath(".//*[@id='account-profile-section']/div/section[2]/div/div/div/div[3]/form/div[3]/div/div[2]/div/div/span/input[1]")).Click();

        }

        [Then(@"that skill should be displayed on my listings")]
        public void ThenThatSkillShouldBeDisplayedOnMyListings()
        {
            try
            {
                //Start the Reports
                CommonMethods.ExtentReports();
                Thread.Sleep(1000);
                CommonMethods.test = CommonMethods.extent.StartTest("Add a skill");

                Thread.Sleep(1000);
                string ExpectedValue = "Manual";
                string ActualValue = Driver.driver.FindElement(By.XPath(".//*[@id='account-profile-section']/div/section[2]/div/div/div/div[3]/form/div[3]/div/div[2]/div/table/tbody[2]/tr/td[1]")).Text;
                Thread.Sleep(500);
                if (ExpectedValue == ActualValue)
                {
                    CommonMethods.test.Log(RelevantCodes.ExtentReports.LogStatus.Pass, "Test Passed, Added a skill Successfully");
                    SaveScreenShotClass.SaveScreenshot(Driver.driver, "Skill");
                }

                else
                    CommonMethods.test.Log(LogStatus.Fail, "Test Failed");

            }
            catch (Exception e)
            {
                CommonMethods.test.Log(LogStatus.Fail, "Test Failed", e.Message);
            }
        }

        //Scenario: Check if user could able to edit a skill
        [Given(@"I clicked on the skill tab")]
        public void GivenIClickedOnTheSkillTab()
        {

            //Wait
            Thread.Sleep(1500);

            // Click on Profile tab
            Driver.driver.FindElement(By.XPath(".//*[@id='account-profile-section']/div/section[2]/div/div/div/div[3]/form/div[1]/a[2]")).Click();

        }

        [When(@"I edit a new skill")]
        public void WhenIEditANewSkill()
        {
            //Edit icon
            Driver.driver.FindElement(By.XPath(".//*[@id='account-profile-section']/div/section[2]/div/div/div/div[3]/form/div[3]/div/div[2]/div/table/tbody[2]/tr/td[3]/span[1]/i")).Click();
            //clear
            Driver.driver.FindElement(By.XPath(".//*[@id='account-profile-section']/div/section[2]/div/div/div/div[3]/form/div[3]/div/div[2]/div/table/tbody[2]/tr/td/div/div[1]/input")).Clear();
            //add skill
            Driver.driver.FindElement(By.XPath(".//*[@id='account-profile-section']/div/section[2]/div/div/div/div[3]/form/div[3]/div/div[2]/div/table/tbody[2]/tr/td/div/div[1]/input")).SendKeys("API");


            //Click on skill Level

            Driver.driver.FindElement(By.XPath(".//*[@id='account-profile-section']/div/section[2]/div/div/div/div[3]/form/div[3]/div/div[2]/div/div/div[2]/select/option[3]")).SendKeys(Keys.ArrowDown + Keys.Enter);

            //Click on update button

            Driver.driver.FindElement(By.XPath(".//*[@id='account-profile-section']/div/section[2]/div/div/div/div[3]/form/div[3]/div/div[2]/div/table/tbody[2]/tr/td/div/span/input[1]")).Click();

        }

        [Then(@"that skill should be dispayed on my listing")]
        public void ThenThatSkillShouldBeDispayedOnMyListing()
        {
            try
            {
                //Start the Reports
                CommonMethods.ExtentReports();
                Thread.Sleep(1000);
                CommonMethods.test = CommonMethods.extent.StartTest("Edit a skill");

                Thread.Sleep(1000);
                string ExpectedValue = "API";
                string ActualValue = Driver.driver.FindElement(By.XPath(".//*[@id='account-profile-section']/div/section[2]/div/div/div/div[3]/form/div[3]/div/div[2]/div/table/tbody[2]/tr/td[1]")).Text;
                Thread.Sleep(500);
                if (ExpectedValue == ActualValue)
                {
                    CommonMethods.test.Log(RelevantCodes.ExtentReports.LogStatus.Pass, "Test Passed, Edit a skill Successfully");
                    SaveScreenShotClass.SaveScreenshot(Driver.driver, "Skill");
                }

                else
                    CommonMethods.test.Log(LogStatus.Fail, "Test Failed");

            }
            catch (Exception e)
            {
                CommonMethods.test.Log(LogStatus.Fail, "Test Failed", e.Message);
            }
        
    }
        //Scenario: check if user is able to delete a skill

        [Given(@"I click on Delete button of a skill")]
        public void GivenIClickOnDeleteButtonOfASkill()
        {
            //Wait
            Thread.Sleep(1500);

            // Click on Delete
            Driver.driver.FindElement(By.XPath(".//*[@id='account-profile-section']/div/section[2]/div/div/div/div[3]/form/div[3]/div/div[2]/div/table/tbody[2]/tr/td[3]/span[2]/i")).Click();

        }

        [Then(@"language is deleted is from the skill")]
        public void ThenLanguageIsDeletedIsFromTheSkill()
        {
            CommonMethods.ExtentReports();
            Thread.Sleep(1000);
            CommonMethods.test = CommonMethods.extent.StartTest("Delete a Language");


            Thread.Sleep(1000);

            try

            {

                var langtodelete = ScenarioContext.Current["ToDelete"];

                string ExpectedLanguageDeleted = langtodelete.ToString();

                bool LanguageDeleted = CommonMethods.ElementVisible(Driver.driver, "XPath", "//td[contains(text(),'" + ExpectedLanguageDeleted + "')]");

                if (LanguageDeleted)

                {
                    CommonMethods.test.Log(LogStatus.Fail, "Language Delete Failed");

                    SaveScreenShotClass.SaveScreenshot(Driver.driver, "LanguageDeleteFail");
                }
                else

                {
                    CommonMethods.test.Log(LogStatus.Pass, "Language Deleted successfully");
                    SaveScreenShotClass.SaveScreenshot(Driver.driver, "LanguageDeletedSuccessfully");
                }
            }
            catch (Exception e)
            {
                CommonMethods.test.Log(LogStatus.Fail, "Language Delete Failed" + e.Message);
            }

        }
    }
}
