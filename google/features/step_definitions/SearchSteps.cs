using google.test.BusinessLayer;
using TechTalk.SpecFlow;

namespace google.features.step_definitions
{
    [Binding]
    public class SearchSteps
    {
        // For additional details on SpecFlow step definitions see http://go.specflow.org/doc-stepdef

        [Given(@"I am on the google search page")]
        public void GivenIAmOnTheGoogleSearchPage()
        {
            var search = new Search();
            search.NavigateToSearchPage();
        }

        [StepDefinition(@"I search for '(.*)'")]
        public void WhenISearchFor(string content)
        {
            var search = new Search();
            search.SearchFor(content);
        }

        [StepDefinition(@"I see a list of related posts")]
        public void ThenISeeAListOfRelatedPosts()
        {
            var search = new Search();
            search.AssertSearchResultsFound();
        }

        [StepDefinition(@"I should see at least '(.*)' search results found")]
        public void ThenIShouldSeeAtLeastSearchResultsFound(int expectedNumberOfResults)
        {
            var search = new Search();
            search.AssertSearchResultsFound(expectedNumberOfResults);
        }
    }
}