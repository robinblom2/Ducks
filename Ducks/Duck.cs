using System;
using System.Collections.Generic;
using System.Text;

namespace Ducks
{
    class Duck : IComparable<Duck>                      // Your Duck-class implements the ICompareable-interface, so List.Sort knows how to sort a List of Duck objects. We specify the type being compared when we have the class implement the ICompareable<T>-interface.   
    {
        public int Size { get; set; }
        public KindOfDuck Kind { get; set; }

        public int CompareTo(Duck duckToCompare)        // Most CompareTo()-methods look a lot like this. This method first compares the Size-field against the other Duck's Size-field. The method takes one duck after another from the List. 
        {
            if (this.Size > duckToCompare.Size)         // If the duck to compare should come after the current duck in the sorted list, CompareTo() needs to return a positive number. (If you want to change the sorting order, so it sorts from biggest duck to smallest instead, then change this to return "-1".
            {
                return 1;
            }
            else if (this.Size < duckToCompare.Size)    // If the duck to compare should come before the current duck in the sorted list, CompareTo() needs to return a negative number. (And change this to "1"). 
            {
                return -1; 
            }
            else
            {
                return 0;                               // If the ducks are the same size, it returns 0.
            }
        }
    }

    enum KindOfDuck         // We use the KindOfDuck-enum to keep track of what sorts of ducks are in our collection. Notice that we're not assigning values - that's very typical. We won't need numerical values for ducks, so the default enum values (0, 1, 2, ...) will be just fine.  
    {
        Mallard,            // Index value: 0
        Muscovy,            // Index value: 1
        Loon,               // Index value: 2
    }
}
