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
    public class ProfileSteps : Utils.Start
    {
        [Given(@"Click Edit icon")]
        public void GivenClickEditIcon()
        {

            //Wait
            Thread.Sleep(6000);

            // Click on Profile tab
            Driver.driver.FindElement(By.XPath("//*[@id='account-profile-section']/div/section[2]/div/div/div/div[2]/div/div/div/div/div/div[3]/div/div[2]/div/span/i")).Click();
                //*[@id='account - profile - section']/div/section[2]/div/div/div/div[2]/div/div/div/div/div/div[3]/div/div[2]/div/span/i")).Click();
                //.//*[@id='account-profile-section']/div/section[2]/div/div/div/div[2]/div/div/div/div/div/div[3]/div/div[2]/div/span/i

        }

        [Given(@"Select availability")]
        public void GivenSelectAvailability()
        {
            // select availability
            Driver.driver.FindElement(By.XPath("//*[@id='account-profile-section']/div/section[2]/div/div/div/div[2]/div/div/div/div/div/div[3]/div/div[2]/div/span")).SendKeys(Keys.ArrowDown + Keys.Enter);

        }

        [Then(@"the availability should display")]
        public void ThenTheAvailabilityShouldDisplay()
        {
            try
            {
                //Start the Reports
                CommonMethods.ExtentReports();
                Thread.Sleep(1000);
                CommonMethods.test = CommonMethods.extent.StartTest("Add Availability");

                Thread.Sleep(1000);
                string ExpectedValue = "PartTime";
                string ActualValue = Driver.driver.FindElement(By.XPath("//*[@id='account-profile-section']/div/section[2]/div/div/div/div[2]/div/div/div/div/div/div[3]/div/div[2]/div/span/select")).Text;
                Thread.Sleep(500);
                if (ExpectedValue == ActualValue)
                {
                    CommonMethods.test.Log(LogStatus.Pass, "Test Passed, Availability");
                    SaveScreenShotClass.SaveScreenshot(Driver.driver, "Availability");
                }

                else
                    CommonMethods.test.Log(LogStatus.Fail, "Test Failed");
            }
            catch (Exception e)
            {
                CommonMethods.test.Log(LogStatus.Fail, "Test Failed", e.Message);
            }
        }

        [Given(@"Click Edit icon for hours")]
        public void GivenClickEditIconForHours()
        {
            //Wait
            Thread.Sleep(6000);

            // Click on Profile tab
            Driver.driver.FindElement(By.XPath(".//*[@id='account-profile-section']/div/section[2]/div/div/div/div[2]/div/div/div/div/div/div[3]/div/div[3]/div/span/i")).Click();
                                              //*[@id='account-profile-section']/div/section[2]/div/div/div/div[2]/div/div/div/div/div/div[3]/div/div[3]/div/span/i
        }

        [Given(@"Select hours")]
        public void GivenSelectHours()
        {
            // select hours
            Driver.driver.FindElement(By.XPath(".//*[@id='account-profile-section']/div/section[2]/div/div/div/div[2]/div/div/div/div/div/div[3]/div/div[3]/div/span/select")).SendKeys(Keys.ArrowDown + Keys.Enter);

        }

        [Then(@"the hours should be display")]
        public void ThenTheHoursShouldBeDisplay()
        {
            try
            {
                //Start the Reports
                CommonMethods.ExtentReports();
                Thread.Sleep(1000);
                CommonMethods.test = CommonMethods.extent.StartTest("Add Hour");

                Thread.Sleep(1000);
                string ExpectedValue = "Less than 30 hours a week";
                string ActualValue = Driver.driver.FindElement(By.XPath(".//*[@id='account-profile-section']/div/section[2]/div/div/div/div[2]/div/div/div/div/div/div[3]/div/div[3]/div/span/select")).Text;
                Thread.Sleep(500);
                if (ExpectedValue == ActualValue)
                {
                    CommonMethods.test.Log(LogStatus.Pass, "Test Passed, Hour");
                    SaveScreenShotClass.SaveScreenshot(Driver.driver, "Hour");
                }

                else
                    CommonMethods.test.Log(LogStatus.Fail, "Test Failed");
            }
            catch (Exception e)
            {
                CommonMethods.test.Log(LogStatus.Fail, "Test Failed", e.Message);
            }
        }

        [Given(@"click Edit icon for Earn Target")]
        public void GivenClickEditIconForEarnTarget()
        {

            //Wait
            Thread.Sleep(6000);

            // Click on Profile tab
            Driver.driver.FindElement(By.XPath(".//*[@id='account-profile-section']/div/section[2]/div/div/div/div[2]/div/div/div/div/div/div[3]/div/div[4]/div/span/i")).Click();

        }

        [Given(@"select Earn Target")]
        public void GivenSelectEarnTarget()
        {
            // select hours
            Driver.driver.FindElement(By.XPath(".//*[@id='account-profile-section']/div/section[2]/div/div/div/div[2]/div/div/div/div/div/div[3]/div/div[4]/div/span/select")).SendKeys(Keys.ArrowDown + Keys.Enter);

        }

        [Then(@"the earn target should be dispaly")]
        public void ThenTheEarnTargetShouldBeDispaly()
        {
            try
            {
                //Start the Reports
                CommonMethods.ExtentReports();
                Thread.Sleep(1000);
                CommonMethods.test = CommonMethods.extent.StartTest("Earn Target");

                Thread.Sleep(1000);
                string ExpectedValue = "Less than $5000 per month";
                string ActualValue = Driver.driver.FindElement(By.XPath(".//*[@id='account-profile-section']/div/section[2]/div/div/div/div[2]/div/div/div/div/div/div[3]/div/div[4]/div/span/select")).Text;
                Thread.Sleep(500);
                if (ExpectedValue == ActualValue)
                {
                    CommonMethods.test.Log(LogStatus.Pass, "Test Passed, Earn Target");
                    SaveScreenShotClass.SaveScreenshot(Driver.driver, "Earn Target");
                }

                else
                    CommonMethods.test.Log(LogStatus.Fail, "Test Failed");
            }
            catch (Exception e)
            {
                CommonMethods.test.Log(LogStatus.Fail, "Test Failed", e.Message);
            }
        }
    }
}
