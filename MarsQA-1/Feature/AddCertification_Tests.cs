using MarsQA_1.Helpers;
using MarsQA_1.Pages;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TechTalk.SpecFlow;

namespace MarsQA_1.Feature
{
    [Binding]
    class AddCertification_Tests
    {
        Add_Certificates certificate = new Add_Certificates();
        
        [Given(@"I Want to Add Certification In Profile Details")]
        public void GivenIWantToAddCertificationInProfileDetails()
        {
            ExcelLibHelper.PopulateInCollection(@"MarsQA-1\SpecflowTests\Data\Data.xlsx", "Certificate");
           certificate.Add_Certificate();
        }

        [Then(@"The Certificate should be added successfully")]
        public void ThenTheCertificateShouldBeAddedSuccessfully()
        {
           certificate.VerifyTheDetails();
        }


        

    }
}
