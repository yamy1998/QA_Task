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
    class AddLangauges_Tests
    {
        AddLangauges add_langauges= new AddLangauges();
       

        [Given(@"I Want to Add Languages In Profile Details")]
        public void GivenIWantToAddLanguagesInProfileDetails()
        {
            ExcelLibHelper.PopulateInCollection(@"MarsQA-1\SpecflowTests\Data\Data.xlsx", "Language");
            add_langauges.Add_Langauge() ;

        }

        [Then(@"The Langauge should be added successfully")]
        public void ThenTheLangaugeShouldBeAddedSuccessfully()
        {
            add_langauges.VerifyTheDetails();
        }




    }
}
