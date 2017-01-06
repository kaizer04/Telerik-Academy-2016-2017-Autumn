namespace ImplementIEnumerableExtensions
{
    using System;
    using System.Collections.Generic;

    public static class IEnumerableExtensions
    {
        public static T Sum<T>(this IEnumerable<T> enumCollection)
        {
            bool emptyCollection = true;
            
            dynamic sum = 0;
            
            foreach (var item in enumCollection)
            {
                emptyCollection = false;
                sum += item;
            }

            if (emptyCollection)
            {
                throw new ArgumentException("Empty Collection");
            }
            
            return (T)sum;
        }

        public static T Product<T>(this IEnumerable<T> enumCollection)
        {
            bool emptyCollection = true;
            
            dynamic product = 1;
            
            foreach (var item in enumCollection)
            {
                emptyCollection = false;
                product *= item;
            }
            
            if (emptyCollection)
            {
                throw new ArgumentException("Empty Collection");
            }
            
            return (T)product;
        }

        public static T Average<T>(this IEnumerable<T> enumCollection)
        {
            dynamic sum = 0;
            
            dynamic count = 0;
            
            foreach (var item in enumCollection)
            {
                count++;
                sum += item;
            }
            
            if (count == 0)
            {
                throw new ArgumentException("Empty Collection");
            }
            
            return (T)(sum / count);
        }

        public static T GetMin<T>(this IEnumerable<T> enumCollection)
            where T : IComparable<T>
        {
            IEnumerator<T> enumerator = enumCollection.GetEnumerator();
            
            enumerator.MoveNext();
            
            T minElement = enumerator.Current;
            
            foreach (var item in enumCollection)
            {
                if (item.CompareTo(minElement) < 0)
                {
                    minElement = item;
                }
            }
           
            return minElement;
        }

        public static T GetMax<T>(this IEnumerable<T> enumCollection)
            where T : IComparable<T>
        {
            IEnumerator<T> enumerator = enumCollection.GetEnumerator();
            
            enumerator.MoveNext();
            
            T maxElement = enumerator.Current;
            
            foreach (var item in enumCollection)
            {
                if (item.CompareTo(maxElement) > 0)
                {
                    maxElement = item;
                }
            }
            
            return maxElement;
        }
    }
}