using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace My_Protject
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Dictionary dict = new Dictionary();
            Console.WriteLine(dict["blue"]); // синий
            dict["blue"] = "голубой";
            Console.WriteLine(dict["blue"]); // голубой
        }
    }
}
