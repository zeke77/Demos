using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace Demos.Abbreviate.Extensions
{
    public static class EnlivantExtensions
    {
        public static string UpperCaseFirst(this string input)
        {
            return Regex.Replace(input, @"\b\w", (Match match) => match.ToString().ToUpper());
}
    }
}
