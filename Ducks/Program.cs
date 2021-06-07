using System;
using System.Collections.Generic;

namespace Ducks
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Duck> ducks = new List<Duck>                               // Here we create our List of duck-objects.
            {
                new Duck() { Kind = KindOfDuck.Mallard, Size = 17},         // Here we add duck-objects to our List using a collection initializer. We add 6 ducks, and we specify the Kind and the Size for every duck. 
                new Duck() { Kind = KindOfDuck.Muscovy, Size = 18},
                new Duck() { Kind = KindOfDuck.Loon, Size = 14},
                new Duck() { Kind = KindOfDuck.Muscovy, Size = 11},
                new Duck() { Kind = KindOfDuck.Mallard, Size = 14},
                new Duck() { Kind = KindOfDuck.Loon, Size = 13},
            };


            // ducks.Sort();                                                   // This line tells your list of ducks to sort itself. Now it sorts the ducks by size before printing them to console. When this line is executed the compiler runs the CompareTo()-method in the Duck-class.

            // IComparer<Duck> sizeComparer = new DuckComparerBySize();        // Here we use the IComparer to sort the list, instead of the CompareTo()-method. It still sorts the ducks, but now it uses the comparer object. 
            // ducks.Sort(sizeComparer);                                       // We pass the Sort()-method a reference to the new DuckComparerBySize-object as its parameter. 

            // IComparer<Duck> kindComparer = new DuckComparerByKind();
            // ducks.Sort(kindComparer);

            // PrintDucks(ducks);                                              // After we have added all the duck-objects to the "ducks"-List, we call on the PrintDucks()-method. We pass the list as argument.





            DuckComparer comparer = new DuckComparer();                         // Here we use the Comparer-object instead, setting its SortBy-field before calling ducks.Sort. Now you can change the way the list sorts its ducks by changning a property in the comparer. 
            Console.WriteLine("\nSorting by kind then size\n");
            comparer.SortBy = SortCriteria.KindThenSize;

            ducks.Sort(comparer);
            PrintDucks(ducks);

            Console.WriteLine("\nSorting by size then kind\n");
            comparer.SortBy = SortCriteria.SizeThenKind;

            ducks.Sort(comparer);
            PrintDucks(ducks);






             

        }

        public static void PrintDucks(List<Duck> ducks)                     // The PrintDucks()-method takes the ducks-List as parameter. 
        {
            foreach (Duck duck in ducks)                                    // For every duck-object in the ducks-List we print the Size and Kind. 
            {
                Console.WriteLine($"{duck.Size} inch {duck.Kind}");
            }
        }
    }
}
