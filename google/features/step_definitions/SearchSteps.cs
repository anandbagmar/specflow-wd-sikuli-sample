using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using google.test.utilities;
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
            var _driver = Driver.CreateChromeDriver();
            
        }
    }
}
