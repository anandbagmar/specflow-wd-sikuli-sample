using System;
using google.test.Utilities;
using TechTalk.SpecFlow;

namespace google.test.utilities
{
    [Binding]
    class Hooks
    {
        [BeforeTestRun]
        public static void BeforeTestRun()
        {
            Console.WriteLine("1 Hooks.cs - Before Test Run");
        }

        [BeforeFeature]
        public static void BeforeFeature()
        {
            Console.WriteLine("2 Hooks.cs - Before Feature");
            Driver.CreateChromeDriver();
        }

        [Before]
        public static void Before()
        {
            Console.WriteLine("3 Hook.cs - Before");
        }

        [BeforeScenario]
        public static void BeforeScenario()
        {
            Console.WriteLine("4 Hook.cs - Before Scenario");
            VerificationFailures.Clear();
        }

        [BeforeStep]
        public static void BeforeStep()
        {
            Console.WriteLine("5 Hook.cs - Before Step");
        }


        [AfterStep]
        public static void AfterStep()
        {
            Console.WriteLine("_5 Hook.cs - After Step");
        }

        [AfterScenario]
        public static void AfterScenario()
        {
            Console.WriteLine("_4 Hook.cs - After Scenario");
            CustomAsserts.AssertTrue(!VerificationFailures.HasVerificationFailures(), "Verification failures in the scenario." + VerificationFailures.DumpFailures());
        }

        [After]
        public static void After()
        {
            Console.WriteLine("_3 Hook.cs - After ...");
        }

        [AfterFeature]
        public static void AfterFeature()
        {
            Console.WriteLine("_2 Hooks.cs - After Feature");
            Driver.CloseChromeDriver();
        }

        [AfterTestRun]
        public static void AfterTestRun()
        {
            Console.WriteLine("_1 Hooks.cs - After Test Run");
        }


    }
}
