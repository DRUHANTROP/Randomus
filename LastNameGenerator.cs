using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;

namespace RandomicGenerator
{
    class LastNameGenerator : IRandomGenerator
    {
        private Random r = new Random();
        private string[] syllable = { "ma", "lee", "cru", "ste", "ve", "la", "le", "si", "va", "mo", "mi", "lo" };
        private string lastName;
        public object Next()
        {
            lastName = "";
            for (int i = 0; i < r.Next(4)+1; i++)
            {
                lastName += syllable[r.Next(syllable.Length)];
            }
            //Преобразует первый символ получившейся строки в верхний регистр 
            lastName = Thread.CurrentThread.CurrentCulture.TextInfo.ToTitleCase(lastName);
         
            return lastName;
        }
    }
}
