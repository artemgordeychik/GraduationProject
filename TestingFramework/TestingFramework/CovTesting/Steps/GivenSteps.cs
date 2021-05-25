using TechTalk.SpecFlow;
using TestingFramework.CovTesting.AppStructure.Pages;
using TestingFramework.Framework.BrowserUtils;
using TestingFramework.Framework.Resources;

namespace СoVTesting.Steps
{
    [Binding]
    class GivenSteps
    {
        [Given(@"Cloud of Views is opened")]
        public void OpenWebApplication()
        {
            BrowserManager.GoToAddress(ConfigurationsWorker.getConfigProperties("url"));
            FormsPage page = new FormsPage();
        }
    }
}
