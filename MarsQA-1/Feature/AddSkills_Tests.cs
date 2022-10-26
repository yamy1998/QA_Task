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
    class AddSkills_Tests
    {
        AddSkills skills = new AddSkills();
        


        [Given(@"I Want to Add Skills In Profile Details")]
        public void GivenIWantToAddSkillsInProfileDetails()
        {
            ExcelLibHelper.PopulateInCollection(@"MarsQA-1\SpecflowTests\Data\Data.xlsx", "Skills");
            skills.Add_Skill();
        }

        [Then(@"The Skills should be added successfully")]
        public void ThenTheLangaugeShouldBeAddedSuccessfully()
        {
            skills.VerifyTheDetails();
        }
    }
}
