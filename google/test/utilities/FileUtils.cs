using System;

namespace google.test.Utilities
{
    class FileUtils
    {
        public static string UniqueFileName(string makeUnique)
        {
            return makeUnique + "_" + DateTime.Today.Ticks;
        }
    }
}
