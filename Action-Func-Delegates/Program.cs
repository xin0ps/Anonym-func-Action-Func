using System.Diagnostics;
using System;
using Action_Func_Delegates;



Console.WriteLine("Enter string");

    var str = Console.ReadLine();
MyClass cls = new MyClass(str);
Func funcDell = cls.Space;
funcDell += cls.Reverse;

Run run = new Run();
run.runFunc(funcDell, str);




