using Microsoft.VisualStudio.TestTools.UnitTesting;
using TechTalk.SpecFlow;
using TestingFramework.CovTesting.AppStructure.Menues;
using СoVTesting.AppStructure.Pages;

namespace СoVTesting.Steps
{
    [Binding]
    class ThenSteps
    {
        [Then(@"Authorisation page is '(.*)'")]
        public void CheckSignInPageState(string state)
        {
            Assert.AreEqual(new HomePage().IsOpened, state.Equals("opened"), "Home page is opened");
        }

        [Then(@"'(.*)' user signed in")]
        public void CheckSignInUser(string user)
        {
            Assert.IsTrue(new MainMenu().GetUserName().Contains(user), user + "is logged");
        }
    }
}
