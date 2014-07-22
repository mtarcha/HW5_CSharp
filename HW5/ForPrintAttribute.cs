using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HW5
{
    [AttributeUsage(AttributeTargets.Property)]
    class ForPrintAttribute : Attribute
    {
        public ConsoleColor Color { get; set; }

        public ForPrintAttribute()
        {
            Color = ConsoleColor.White;
        }
    }
}
