using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;

namespace TextAnalysis
{
    public class Analysis
    {
        public double Sentences(string file)
        {
            char[] text = (File.ReadAllText(file)).ToCharArray();
            int sentencecount = 0;

            foreach (char letter in text)
            {
                if (letter == '.')
                {
                    sentencecount += 1;
                }
            }
            return sentencecount;
        }

        public double Words(string file)
        {
            char[] text = (File.ReadAllText(file)).ToCharArray();
            int wordcount = 0;
            bool new_word = true;

            foreach (char letter in text)
            {
                if (letter != ' ')
                {
                    if (new_word == true)
                    {
                        wordcount += 1;
                        new_word = false;
                    }
                }

                if (letter == ' ' | letter == '\n')
                {
                    new_word = true; 
                }
            }
            return wordcount;
        }

        public double Chars(string file)
        {
            char[] text = (File.ReadAllText(file)).ToCharArray();
            int charcount = 0;

            foreach (char letter in text)
            {
                if (letter != ' ' & letter != '\n')
                {
                    charcount += 1;
                }
            }
            return charcount;
        }
    }
}
