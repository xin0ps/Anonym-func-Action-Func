using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Action_Func_Delegates
{
    internal class Run
    {
        public void runFunc(Func func, string str)
        {
           
            func(str);
        }
    }
}
