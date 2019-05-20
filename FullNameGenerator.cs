using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RandomicGenerator
{
    class FullNameGenerator : IRandomGenerator
    {
        string fullName;
        FirstNameGenerator fng = new FirstNameGenerator();
        LastNameGenerator lng = new LastNameGenerator();

        string IRandomGenerator.Name => "Full Name";

        public object Next()
        {
            fullName = fng.Next() + " " + lng.Next();
            return fullName;
        }
    }
}
