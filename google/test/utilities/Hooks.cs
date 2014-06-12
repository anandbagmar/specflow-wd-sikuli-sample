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
            Console.WriteLine("Hooks.cs - Before Test Run");
            Driver.CreateChromeDriver();
        }

        //[BeforeFeature]
        //public static void BeforeFeature()
        //{
        //    Console.WriteLine("Hooks.cs - Before Feature");
        //}

        [BeforeScenario]
        public static void BeforeScenario()
        {
            Console.WriteLine("Hook.cs - Before Scenario");
            VerificationFailures.Clear();
        }

        //[Before]
        //public static void Before()
        //{
        //    Console.WriteLine("Hook.cs - Before");
        //}

        //[BeforeStep]
        //public static void BeforeStep()
        //{
        //    Console.WriteLine("Hook.cs - Before Step");
        //}

        //[AfterTestRun]
        //public static void AfterTestRun()
        //{
        //    Console.WriteLine("Hooks.cs - After Test Run");
        //}

        //[AfterFeature]
        //public static void AfterFeature()
        //{
        //    Console.WriteLine("Hooks.cs - After Feature");
        //}

        [AfterScenario]
        public static void AfterScenario()
        {
            Console.WriteLine("Hook.cs - After Scenario");
            CustomAsserts.AssertTrue(!VerificationFailures.HasVerificationFailures(), "Verification failures in the scenario."+VerificationFailures.DumpFailures());
        }

        [After]
        public static void After()
        {
            Console.WriteLine("Hook.cs - After");
            Driver.CloseChromeDriver();
        }

        //[AfterStep]
        //public static void AfterStep()
        //{
        //    Console.WriteLine("Hook.cs - After Step");
        //}
    }
}
