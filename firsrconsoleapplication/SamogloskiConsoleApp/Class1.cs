using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

internal class StringFunctions
{
    public static int CountVowels(string stringFromUser)
    {
        if (stringFromUser == null || stringFromUser == "")
        { return 0; }

        String vowelsString = "aąeęiouóyAĄEĘIOUÓY";

        int vowelsCount = 0;

        vowelsCount = stringFromUser.Where(c => vowelsString.Contains(c)).Count();
        return vowelsCount;
    }

    public static string RemoveRepeatCharacters(string stringFromUser)
    {
        if (stringFromUser == null || stringFromUser == "")
        { return ""; }

        List<char> listDistinctChars = stringFromUser.Distinct().ToList();

        string result = string.Join("", listDistinctChars);

        return result;
    }
}
