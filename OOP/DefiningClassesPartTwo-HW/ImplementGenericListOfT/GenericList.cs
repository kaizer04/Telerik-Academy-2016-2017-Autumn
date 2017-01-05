namespace ImplementGenericListOfT
{
    using System;
    using System.Linq;
    using System.Text;

    public class GenericList<T> where T : IComparable
    {
        private T[] listOfElements;
        private int lastIndex;

        public GenericList(int size)
        {
            this.listOfElements = new T[size];
            this.lastIndex = 0;
        }
        
        public T this[int position]
        {
            get
            {
                CheckPositionValidity(position);
                return this.listOfElements[position];
            }

            set
            {
                CheckPositionValidity(position);
                this.listOfElements[position] = value;
            }
        }

        public int Find(T element)
        {
            return Array.IndexOf(this.listOfElements, element);
        }

        public void Clear()
        {
            for (int i = 0; i <= this.lastIndex; i++)
            {
                this.listOfElements[i] = default(T);
            }

            this.lastIndex = 0;
        }

        public void InsertAtPosition(T element, int position)
        {
            CheckPositionValidity(position);
            T[] newList = new T[this.listOfElements.Length + 1];
            this.lastIndex++;
            Array.Copy(this.listOfElements, 0, newList, 0, position);
            newList[position] = element;
            Array.Copy(this.listOfElements, position, newList, position + 1, this.listOfElements.Length - position);
            this.listOfElements = newList;
        }

        public void RemoveByIndex(int index)
        {
            CheckPositionValidity(index);
            T[] newList = new T[this.listOfElements.Length - 1];
            this.lastIndex--;
            Array.Copy(this.listOfElements, 0, newList, 0, index);
            Array.Copy(this.listOfElements, index + 1, newList, index, this.listOfElements.Length - 1 - index);
            this.listOfElements = newList;
        }
        
        public T FindByIndex(int index)
        {
            return this.listOfElements[index];
        }

        public void Add(T element)
        {
            if (this.lastIndex == this.listOfElements.Length)
            {
                this.AutoGrow();
            }

            listOfElements[lastIndex] = element;
            lastIndex++;
        }

        public T Min()
        {
            T minElement = this.listOfElements[0];

            for (int i = 1; i < this.listOfElements.Length; i++)
            {
                if (minElement.CompareTo(this.listOfElements[i]) > 0)
                {
                    minElement = this.listOfElements[i];
                }
            }

            return minElement;
        }

        public T Max()
        {
            T maxElement = this.listOfElements[0];

            for (int i = 1; i < this.listOfElements.Length; i++)
            {
                if (maxElement.CompareTo(this.listOfElements[i]) < 0)
                {
                    maxElement = this.listOfElements[i];
                }
            }

            return maxElement;
        }

        private void CheckPositionValidity(int index)
        {
            if (index < 0 || index >= this.lastIndex)
            {
                throw new IndexOutOfRangeException();
            }
        }

        private void AutoGrow()
        {
            T[] newList = new T[this.listOfElements.Length * 2];
            Array.Copy(this.listOfElements, newList, this.listOfElements.Length);
            this.listOfElements = newList;
        }

        public override string ToString()
        {
            var result = new StringBuilder();
            for (int i = 0; i <= this.lastIndex; i++)
            {
                result.AppendLine(String.Format("{0,-5}{1}", String.Format("[{0}]", i), this.listOfElements[i]));
            }

            return result.ToString().Trim();
        }
    }
}