using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Reflection;

namespace HW5
{
    class Program
    {
        static void Main(string[] args)
        {
            MyClass myClass = new MyClass();

            PropertyInfo[] properties = myClass.GetType().GetProperties();
            foreach (PropertyInfo property in properties)
            {
                if (Attribute.IsDefined(property, typeof(ForPrintAttribute))) 
                {
                    string value = Convert.ToString(property.GetValue(myClass));
                    ConsoleColor color = ConsoleColor.White;
                    object[] attrs = property.GetCustomAttributes(true);
                    foreach (object attr in attrs)
                    {
                        ForPrintAttribute printAttribute = attr as ForPrintAttribute;
                        if (printAttribute != null)
                            color = printAttribute.Color;
                    }
            
                    Console.ForegroundColor = color;
                    Console.WriteLine(value);
                }
            }
            Console.ReadLine();
        }
    }
}
