using System;
using System.Collections.Generic;
using System.Text;

namespace Ducks
{
    class DuckComparerByKind : IComparer<Duck>          // You can create multiple IComparer<Duck> classes with different sorting logic to sort the ducks in different ways. Then you can use the comparer you want when you need to sort in that particular way. 
    {

        public int Compare(Duck x, Duck y)              // The comparer sorts by duck type. Remember, when you compare the enum Kind, you're comparing their enum index values. We didn't assign values when we declared the KindOfDuck enum, so they're given the values 0, 1, 2, in the order they appear in the enum declaration (so Mallard is 0, Muscovy is 1, and Loon is 2). 
        {
            if (x.Kind < y.Kind)                        // We compare the ducks' Kind-properties, so the ducks are sorted based on the index value of the Kind-property, a KindOfDuck-enum. 
            {
                return -1;
            }
            if (x.Kind > y.Kind)                        // Notice how "greater than" and "less than" have a different meaning here. Here we use < and > to compare enum index values, which lets us put the ducks in order.  
            {                                           // This is an example of how enums and lists work together. Enums stand in for numbers, and are used in sorting lists. 
                return 1;
            }
            else
            {
                return 0;
            }
        }

    }
}
