using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RandomicGenerator
{
    class MixedGenerator : IRandomGenerator
    {
        private IRandomGenerator[] generators = { new IntGenerator(), new FirstNameGenerator(), new LastNameGenerator(), new FullNameGenerator() };
        private Random r = new Random();
        public object Next()
        {  
            return generators[r.Next(generators.Length)].Next();
        }
    }
}
