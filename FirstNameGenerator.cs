using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RandomicGenerator
{
    class FirstNameGenerator : IRandomGenerator
    {
        private Random rnd = new Random();
        private string[] names = {"Mike","Rose","John","Andrew","Danny","Duke","James","Jotaro","Mitchell","Gordon","Kate" };
        public object Next()
        {
            return names[rnd.Next(names.Length)];
        }
    }
}
