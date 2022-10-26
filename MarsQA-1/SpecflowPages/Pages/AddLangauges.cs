using MarsQA_1.Helpers;
using NUnit.Framework;
using OpenQA.Selenium;
using System;
using System.Threading;

namespace MarsQA_1.Pages
{
    public  class AddLangauges
    {
        private static IWebElement TabsLangaugaes => Driver.driver.FindElement(By.XPath("//div[@class='ui top attached tabular menu']//a[text()='Languages']"));
        private static IWebElement AddNewLangaugeButton =>  Driver.driver.FindElement(By.XPath("//th[@class='right aligned']//div[@class='ui teal button ' and text()='Add New']"));
        private static IWebElement AddLanguageTextBox => Driver.driver.FindElement(By.XPath("//div[@class='five wide field']//input[@placeholder='Add Language']"));
        private static IWebElement LangaugeLevel => Driver.driver.FindElement(By.Name("level"));
        private static IWebElement ADDLanguageButton => Driver.driver.FindElement(By.XPath("//div[@class='six wide field']//input[1]"));

       
       
        public void Add_Langauge()
        {
            TabsLangaugaes.Click();
            Thread.Sleep(1000);
            AddNewLangaugeButton.Click();
            Thread.Sleep(1000);
            AddLanguageTextBox.SendKeys(ExcelLibHelper.ReadData(2,"Language"));
            Thread.Sleep(1000);
            LangaugeLevel.SendKeys(ExcelLibHelper.ReadData(2, "LanguageLevel"));
            Thread.Sleep(1000);
            ADDLanguageButton.Click();
        }

        public void VerifyTheDetails()
        {

            var outPutvalue = Driver.driver.FindElement(By.XPath("//tbody//tr//td[text()='" + (ExcelLibHelper.ReadData(2, "Language")) + "']")).Text;
            Assert.AreEqual(outPutvalue, (ExcelLibHelper.ReadData(2, "Language")));

        }
    }
}