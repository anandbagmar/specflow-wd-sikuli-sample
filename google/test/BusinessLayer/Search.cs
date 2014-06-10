using google.test.Utilities;

namespace google.test.BusinessLayer
{
    class Search
    {
        internal void NavigateToSearchPage()
        {
            PageUtils.NavigateTo("http://www.google.com");
        }
    }
}
