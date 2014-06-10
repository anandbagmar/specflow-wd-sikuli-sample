using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading;
using System.Threading.Tasks;
using google.test.utilities;
using OpenQA.Selenium;

namespace google.test.pages
{
    internal class SearchPage
    {
        private const string SearchInputBoxId = "gbqfq";
        private const string SearchButtonId = "gbqfb";
        private const string NumberOfSearchResultsId = "resultStats";

        public void SearchFor(string searchCriteria)
        {
            IWebDriver driver = RuntimeData.Get("driver") as IWebDriver;
            driver.FindElement(By.Id(SearchInputBoxId)).SendKeys(searchCriteria);
            driver.FindElement(By.Id(SearchButtonId)).Click();
            
        }

        public long GetNumberOfSearchResults()
        {
            IWebDriver driver = RuntimeData.Get("driver") as IWebDriver;
            string numberOfResults = driver.FindElement(By.Id(NumberOfSearchResultsId)).Text;
            long numberOfSearchResults = Convert.ToInt32(new Regex(" results.*").Replace(numberOfResults, "").Replace("About ", "").Replace(",", ""));
            Console.WriteLine("Number of Search Results: " + numberOfSearchResults);
            return numberOfSearchResults;
        }
    }
}
