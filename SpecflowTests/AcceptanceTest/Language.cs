using OpenQA.Selenium;
using RelevantCodes.ExtentReports;
using SpecflowPages;
using System;
using System.Threading;
using TechTalk.SpecFlow;
using static SpecflowPages.CommonMethods;

namespace SpecflowTests.AcceptanceTest
{
    [Binding]
    public class SpecFlowFeature1Steps : Utils.Start
    {
        [Given(@"I clicked on the Language tab under Profile page")]
        public void GivenIClickedOnTheLanguageTabUnderProfilePage()
        {
            //Wait
            Thread.Sleep(1500);

            // Click on Profile tab
            Driver.driver.FindElement(By.XPath("//*[@id='account-profile-section']/div/section[1]/div/a[2]")).Click();


        }

        [When(@"I add a new language")]
        public void WhenIAddANewLanguage()
        {
            //Click on Add New button
            Driver.driver.FindElement(By.XPath("//*[@id='account-profile-section']/div/section[2]/div/div/div/div[3]/form/div[2]/div/div[2]/div/table/thead/tr/th[3]/div")).Click();

            //Add Language
            Driver.driver.FindElement(By.XPath("//*[@id='account-profile-section']/div/section[2]/div/div/div/div[3]/form/div[2]/div/div[2]/div/div/div[1]/input")).SendKeys("English");

            //Click on Language Level
            Driver.driver.FindElement(By.XPath("//*[@id='account-profile-section']/div/section[2]/div/div/div/div[3]/form/div[2]/div/div[2]/div/div/div[2]/select")).Click();

            //Choose the language level
            IWebElement Lang = Driver.driver.FindElements(By.XPath("//*[@id='account-profile-section']/div/section[2]/div/div/div/div[3]/form/div[2]/div/div[2]/div/div/div[2]/select/option"))[1];
            Lang.Click();

            //Click on Add button
            Driver.driver.FindElement(By.XPath("//*[@id='account-profile-section']/div/section[2]/div/div/div/div[3]/form/div[2]/div/div[2]/div/div/div[3]/input[1]")).Click();

        }

        [Then(@"that language should be displayed on my listings")]
        public void ThenThatLanguageShouldBeDisplayedOnMyListings()
        {
            try
            {
                //Start the Reports
                CommonMethods.ExtentReports();
                Thread.Sleep(1000);
                CommonMethods.test = CommonMethods.extent.StartTest("Add a Language");

                Thread.Sleep(1000);
                string ExpectedValue = "English";
                string ActualValue = Driver.driver.FindElement(By.XPath("//*[@id='account-profile-section']/div/section[2]/div/div/div/div[3]/form/div[2]/div/div[2]/div/table/tbody/tr/td[1]")).Text;
                Thread.Sleep(500);
                if (ExpectedValue == ActualValue)
                {
                    CommonMethods.test.Log(LogStatus.Pass, "Test Passed, Added a Language Successfully");
                    SaveScreenShotClass.SaveScreenshot(Driver.driver, "LanguageAdded");
                }

                else
                    CommonMethods.test.Log(LogStatus.Fail, "Test Failed");

            }
            catch (Exception e)
            {
                CommonMethods.test.Log(LogStatus.Fail, "Test Failed", e.Message);
            }



        }
        //  Scenario Outline: Check if user could able to edit a language

        
        
            [Given(@"I clicked on the Language tab")]
            public void GivenIClickedOnTheLanguageTab(string edit)
            {
                //Wait
                Thread.Sleep(1500);

                // Click on Profile tab
                Driver.driver.FindElement(By.XPath("//*[@id='account-profile-section']/div/section[1]/div/a[2]")).Click();

            }

            [When(@"I edit a new language")]
            public void WhenIEditANewLanguage()
            {
                try

                {

                    //Enter Language

                    Driver.driver.FindElement(By.XPath(".//*[@id='account-profile-section']/div/section[2]/div/div/div/div[3]/form/div[2]/div/div[2]/div/table/tbody/tr/td[3]/span[1]/i")).Click();

                    Driver.driver.FindElement(By.XPath(".//*[@id='account-profile-section']/div/section[2]/div/div/div/div[3]/form/div[2]/div/div[2]/div/table/tbody/tr/td/div/div[1]/input")).Clear();

                    Driver.driver.FindElement(By.XPath(".//*[@id='account-profile-section']/div/section[2]/div/div/div/div[3]/form/div[2]/div/div[2]/div/table/tbody/tr/td/div/div[1]/input")).SendKeys("Malayalam");


                    //Click on Language Level

                    Driver.driver.FindElement(By.XPath(".//*[@id='account-profile-section']/div/section[2]/div/div/div/div[3]/form/div[2]/div/div[2]/div/table/tbody/tr/td/div/div[2]/select/option[4]")).SendKeys(Keys.ArrowDown + Keys.Enter);

                    //Click on update button

                    Driver.driver.FindElement(By.XPath("//input[@value='Update']")).Click();

                }

                catch (Exception e)

                {

                    CommonMethods.test.Log(LogStatus.Fail, "Language not found to edit", e.Message);

                    SaveScreenShotClass.SaveScreenshot(Driver.driver, "Languagenotfound");

                }
            }

            [Then(@"that language should be dispayed on my listing")]
            public void ThenThatLanguageShouldBeDispayedOnMyListing()
            {
                try
                {
                    //Start the Reports
                    CommonMethods.ExtentReports();
                    Thread.Sleep(1000);
                    CommonMethods.test = CommonMethods.extent.StartTest("Edit a Language");

                    Thread.Sleep(1000);
                    string ExpectedValue = "Malayalam";
                    string ActualValue = Driver.driver.FindElement(By.XPath(".//*[@id='account-profile-section']/div/section[2]/div/div/div/div[3]/form/div[2]/div/div[2]/div/table/tbody/tr/td[1]")).Text;
                    Thread.Sleep(500);
                    if (ExpectedValue == ActualValue)
                    {
                        CommonMethods.test.Log(LogStatus.Pass, "Test Passed, Edit a Language Successfully");
                        SaveScreenShotClass.SaveScreenshot(Driver.driver, "LanguageEdit");
                    }

                    else
                        CommonMethods.test.Log(LogStatus.Fail, "Test Failed");

                }
                catch (Exception e)
                {
                    CommonMethods.test.Log(LogStatus.Fail, "Test Failed", e.Message);
                }
            }
        //scenario check if user is able to delete a language
        [Given(@"I click on Delete button of a language")]
        public void GivenIClickOnDeleteButtonOfALanguage(string Delete)
        {
            //Wait
            Thread.Sleep(1500);

            // Click on Delete
            Driver.driver.FindElement(By.XPath(".//*[@id='account-profile-section']/div/section[2]/div/div/div/div[3]/form/div[2]/div/div[2]/div/table/tbody[1]/tr/td[3]/span[2]/i")).Click();

        }

        [Then(@"language is deleted is from the listings")]
        public void ThenLanguageIsDeletedIsFromTheListings()
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
