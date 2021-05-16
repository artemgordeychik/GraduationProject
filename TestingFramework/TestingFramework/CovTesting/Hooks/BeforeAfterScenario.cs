using TechTalk.SpecFlow;
using TestingFramework.Framework.BrowserUtils;

namespace СoVTesting.Steps
{
    [Binding]
    class BeforeAfterScenario
    {
        [BeforeScenario]
        public void Preconditions(ScenarioContext defaultContext)
        {
            BrowserManager.Setup();
            BrowserManager.Maximize();
        }

        [AfterScenario]
        public void PostConditions()
        {
            BrowserManager.Quit();
        }
    }
}
