using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _732_2AlphSort
{
    public class Sorter
    {
        public string MakeSort(string input)
        {
            char[] strChars = input.ToCharArray();
            Array.Sort(strChars);
            return new string(strChars);
        }
    }
}
