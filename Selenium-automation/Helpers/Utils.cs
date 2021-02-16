using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Selenium_automation.Helpers
{
    public class Utils
    {
        public static string AppRelativeToFullPath(string relativePath)
        {
            if (string.IsNullOrEmpty(relativePath) || Path.IsPathRooted(relativePath))
                return relativePath;

            var path = Path.Combine(TestContext.CurrentContext.TestDirectory, relativePath);
            return Path.GetFullPath(path);
        }
    }
}
