using System;
using System.Collections;
using System.Collections.Concurrent;
using System.Linq;
using System.Runtime.Remoting.Messaging;

namespace google.test.Utilities
{
    class VerificationFailures
    {
        private static readonly ArrayList ListOfVerificationFailures = new ArrayList();

        public static void Add(string message)
        {
            ListOfVerificationFailures.Add(message);
        }

        public static bool HasVerificationFailures()
        {
            return ListOfVerificationFailures.Count > 0;
        }

        public static void Clear()
        {
            Console.WriteLine("Clearing Verification Failures List");
            ListOfVerificationFailures.Clear();
        }

        public static string DumpFailures()
        {
            string allFailures = "";
            allFailures += "\n-----------------------------------------";
            allFailures += string.Format("\tVerification Failures ({0})\n", ListOfVerificationFailures.Count);
            allFailures = ListOfVerificationFailures.Cast<string>().Aggregate(allFailures, (current, verificationFailure) => current + ("\n\t" + verificationFailure));
            allFailures += "\n-----------------------------------------";
            allFailures += "\tEnd of Verification Failures (" + ListOfVerificationFailures.Count + ")";
            return allFailures;
        }
    }
}
