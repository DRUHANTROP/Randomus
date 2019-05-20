using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RandomicGenerator
{
    class MixedGenerator : IRandomGenerator
    {
        IRandomGenerator[] generators = { new IntGenerator(), new FirstNameGenerator(), new LastNameGenerator(), new FullNameGenerator() };
        private Random r = new Random();

        public string Name => "Mixed (in progress)";

        public object Next()
        {
            IRandomGenerator generator = generators[r.Next(generators.Length)];
            return generator.Next();
        }

    }
}
