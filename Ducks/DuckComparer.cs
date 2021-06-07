using System;
using System.Collections.Generic;
using System.Text;

namespace Ducks                 // Here's a more complex class to compare ducks. 
{
    enum SortCriteria           // This enum tells the comparer object which may sort the ducks. 
    {
        SizeThenKind,
        KindThenSize,
    }

    class DuckComparer : IComparer<Duck>
    {

        public SortCriteria SortBy = SortCriteria.SizeThenKind;

        public int Compare (Duck x, Duck y)
        {
            if (SortBy == SortCriteria.SizeThenKind)        // This IF-statement checks the SortBy-field. If it's set to SizeThenKind, then it first sorts the ducks by size, and then within each size it'll sort the ducks by their kind. 
            {
                if (x.Size > y.Size)
                {
                    return 1;
                }
                else if (x.Size < y.Size)
                {
                    return -1;
                }
                else
                {
                    if (x.Kind > y.Kind)                    // Instead of just returning 0 if the two ducks are the same size, the comparer checks their kind, and only returns 0 if the two ducks are both the same size and the same kind. 
                    {
                        return 1;
                    }
                    else if (x.Kind < y.Kind)
                    {
                        return -1;
                    }
                    else
                    {
                        return 0;
                    }
                }
            }
            else                                            // If SortBy isn't set to SizeThenKind, then the comparer first sorts by the kind of duck. If the two ducks are the same kind, then it compares their size.  
            {
                if (x.Kind > y.Kind)
                {
                    return 1;
                }
                else if (x.Kind < y.Kind)
                {
                    return -1;
                }
                else
                {
                    if (x.Size > y.Size)
                    {
                        return 1;
                    }
                    else if (x.Size < y.Size)
                    {
                        return -1;
                    }
                    else
                    {
                        return 0;
                    }
                }
            }
        }

    }
}
