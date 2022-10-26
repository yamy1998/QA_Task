using MarsQA_1.Helpers;
using NUnit.Framework;
using OpenQA.Selenium;
using System;
using System.Threading;

namespace MarsQA_1.Pages
{
    public  class Add_Certificates
    {
     
        private static IWebElement TabsCertificate => Driver.driver.FindElement(By.XPath("//div[@class='ui top attached tabular menu']//a[text()='Certifications']"));

        private static IWebElement AddNewSkillsButton => Driver.driver.FindElement(By.XPath("//tr//th[text()='Skill']//following-sibling::th[@class='right aligned']//div"));
        private static IWebElement AddNewCertificateButton => Driver.driver.FindElement(By.XPath("//tr//th[text()='Certificate']//following-sibling::th[@class='right aligned']//div"));


         private static IWebElement CertificateorAwardTextBox => Driver.driver.FindElement(By.XPath("//div[@class='sixteen wide field']//input[@placeholder='Certificate or Award']"));
        private static IWebElement CertifiedFromTextBox => Driver.driver.FindElement(By.XPath("//div[@class='eight wide field']//input"));
        private static IWebElement certificationYear => Driver.driver.FindElement(By.Name("certificationYear"));
       private static IWebElement ADDCertificationButton => Driver.driver.FindElement(By.XPath("//div[@class='five wide field']//input[@value='Add']"));

        
     
      

        public void Add_Certificate()
        {
            TabsCertificate.Click();
            Thread.Sleep(1000);
            AddNewCertificateButton.Click();
            Thread.Sleep(1000);
            CertificateorAwardTextBox.SendKeys(ExcelLibHelper.ReadData(2, "CertificateorAward"));
            Thread.Sleep(1000);
            CertifiedFromTextBox.SendKeys(ExcelLibHelper.ReadData(2, "received-from capitalize"));
            Thread.Sleep(1000);
            certificationYear.SendKeys(ExcelLibHelper.ReadData(2, "certificationYear"));
            Thread.Sleep(1000);
            ADDCertificationButton.Click();
        }

        public void VerifyTheDetails()
        {

            var outPutvalue = Driver.driver.FindElement(By.XPath("//tbody//tr//td[text()='" + (ExcelLibHelper.ReadData(2, "CertificateorAward")) + "']")).Text;
            Assert.AreEqual(outPutvalue, (ExcelLibHelper.ReadData(2, "CertificateorAward")));

        }
    }
}