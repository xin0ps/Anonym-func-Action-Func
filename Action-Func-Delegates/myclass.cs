using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Action_Func_Delegates
{
    delegate void Func(string str);
    internal class MyClass
    {
        public string mystr { get; set; }
        public MyClass(string str) { mystr = str; }
        public void Space(string str)
        {

            string result = string.Join("_", str.ToCharArray());
            Console.WriteLine(result);
        }

        public void Reverse(string str)
        {

            char[] charArray = str.ToCharArray();
            Array.Reverse(charArray);
            string result = new string(charArray);
            Console.WriteLine(result);
        }
    }
}
