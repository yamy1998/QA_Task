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
    class Login
    {
       
        [Given(@"I login to the website")]
        public void GivenILoginToTheWebsite()
        {
            //ScenarioContext.Current.Pending();
        }


        [Then(@"The User should be Login successfully")]
        public void ThenTheUserShouldBeLoginSuccessfully()
        {
            SignIn.VerifyTheDetails();
        }


    }
}
