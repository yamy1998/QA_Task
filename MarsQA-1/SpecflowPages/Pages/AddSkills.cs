using MarsQA_1.Helpers;
using NUnit.Framework;
using OpenQA.Selenium;
using System;
using System.Threading;

namespace MarsQA_1.Pages
{
    public  class AddSkills
    {
       private static IWebElement TabsSkills => Driver.driver.FindElement(By.XPath("//div[@class='ui top attached tabular menu']//a[text()='Skills']"));

        private static IWebElement AddNewSkillsButton => Driver.driver.FindElement(By.XPath("//tr//th[text()='Skill']//following-sibling::th[@class='right aligned']//div"));
        
        private static IWebElement AddSkillsTextBox => Driver.driver.FindElement(By.XPath("//div[@class='five wide field']//input[@placeholder='Add Skill']"));
        private static IWebElement SkillsLevel => Driver.driver.FindElement(By.Name("level"));
        private static IWebElement ADDSkillsButton => Driver.driver.FindElement(By.XPath("//span[@class='buttons-wrapper']//input[1]"));
        
        
       

        public void Add_Skill()
        {
            TabsSkills.Click();
            Thread.Sleep(1000);
            AddNewSkillsButton.Click();
            Thread.Sleep(1000);
            AddSkillsTextBox.SendKeys(ExcelLibHelper.ReadData(2, "Skills"));
            Thread.Sleep(1000);
            SkillsLevel.SendKeys(ExcelLibHelper.ReadData(2, "SkillsLevel"));
            Thread.Sleep(1000);
            ADDSkillsButton.Click();
        }

        public void VerifyTheDetails()
        {

            var outPutvalue = Driver.driver.FindElement(By.XPath("//tbody//tr//td[text()='"+(ExcelLibHelper.ReadData(2, "Skills")) +"']")).Text;
            Assert.AreEqual(outPutvalue, (ExcelLibHelper.ReadData(2, "Skills")));

        }

    }
}