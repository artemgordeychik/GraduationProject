using TechTalk.SpecFlow;
using СoVTesting.AppStructure.Pages;

namespace СoVTesting.Steps
{
    [Binding]
    class WhenSteps
    {
        [When(@"I go to the Sign In page")]
        public void OpenSignInPage()
        {
            new HomePage().GoToAuthorisationPage();
        }

        [When(@"I try Sign In with '(.*)' user and '(.*)' password")]
        public void SignIn(string login, string password)
        {
            new AuthorisationPage().MakeAuthorisation(login, password);
        }
    }
}
