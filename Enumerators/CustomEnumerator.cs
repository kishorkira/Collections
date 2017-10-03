using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Enumerators
{
    
    class CustomEnumerator : IEnumerable<string>
    {
        public IEnumerator<string> GetEnumerator()
        {
            yield return "A";
            yield return "B";
            yield return "C";
            yield return "D";


        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }
    }
}
