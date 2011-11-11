using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;

namespace TextAnalysis
{
    class Program
    {
        static void Main(string[] args)
        {
            string file = "text.txt";

            Analysis analyze = new TextAnalysis.Analysis();
            Console.WriteLine(analyze.Words(file));
            Console.WriteLine(analyze.Sentences(file));
            Console.WriteLine(analyze.Chars(file));

            #region Variables
            double chars = analyze.Chars(file);
            double words = analyze.Words(file);
            double sentences = analyze.Sentences(file);
            double average = chars / words;
            double average1 = words / sentences;
            #endregion

            Console.WriteLine(average1);
            Console.ReadKey();
        }
    }
}
