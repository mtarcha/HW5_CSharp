using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HW5
{
    class MyClass
    {
        [ForPrint(Color = ConsoleColor.Green)]
        public string Property1 { get; set; }
        [ForPrint(Color = ConsoleColor.Blue)]
        public string Property2 { get; set; }
        [ForPrint]
        public string Property3 { get; set; }
        public string Property4 { get; set; }
        public string Property5 { get; set; }

        public MyClass()
        {
            Property1 = "Property1";
            Property2 = "Property2";
            Property3 = "Property3";
            Property4 = "Property4";
            Property5 = "Property5";
        }
    }
}
