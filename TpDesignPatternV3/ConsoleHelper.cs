using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;

namespace Views
{
    public static class ConsoleHelper
    {
        public static string GetInputString(string question)
        {
            WriteLine(question);
            string s = ReadLine();

            return s;
        }

        public static int GetInputInt(string question)
        {
            WriteLine(question);
            string result = ReadLine();
            int nb;
            int.TryParse(result, out nb);         
                       
            return nb;
        }

        public static double GetInputDouble(string question)
        {
            WriteLine(question);
            string result = ReadLine();
            double nb;
            double.TryParse(result, out nb);

            return nb;
        }
    }
}
