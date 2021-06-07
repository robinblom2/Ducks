using System;
using System.Collections.Generic;
using System.Text;

namespace Ducks
{
    class DuckComparerBySize : IComparer<Duck>      // A comparer object is an instance of a class that implements IComparer<T> that you can pass as a reference to List.Sort. Its Compare method works just like the CompareTo method in the IComparable<T> interface.   
    {                                               // When List.Sort compares its elements to sort them, it passes pairs of objects to the Compare method in your comparer object, so your List will sort differently depening on how you implement the comparer.  

        public int Compare(Duck x, Duck y)
        {
            if (x.Size < y.Size)
            {
                return -1;                          // If Compare returns a negative number, that means object x should go before object y. (x is "less than" y).
            }
            if (x.Size > y.Size)
            {
                return 1;                           // Any positive value means object x should go after object y. (x is "greater than" y). 
            }
            else
            {
                return 0;                           // Zero means they're "equal".
            }
        }

    }
}
