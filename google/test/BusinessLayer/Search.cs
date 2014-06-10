using google.test.pages;
using google.test.Utilities;
using NUnit.Framework;

namespace google.test.BusinessLayer
{
    class Search
    {
        internal void NavigateToSearchPage()
        {
            PageUtils.NavigateTo("http://www.google.com");
        }

        public void SearchFor(string content)
        {
            SearchPage searchPage = new SearchPage();
            searchPage.SearchFor(content);
        }

        public void AssertSearchResultsFound()
        {
            SearchPage searchPage = new SearchPage();
            long numberOfSearchResults = searchPage.GetNumberOfSearchResults();
            Assert.True(numberOfSearchResults>100, "Number of Search Results less than 100. Actual number: " + numberOfSearchResults);
        }
    }
}
