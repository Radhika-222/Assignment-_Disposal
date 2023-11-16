using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment14
{
    class LargeDataCollection : IDisposable
    {
        private bool disposed = false;
        private int[] data; // You can replace int with the appropriate data type
        private int size;
        private int count;


        public LargeDataCollection(int size)
        {
            this.size = size;
            data = new int[size];
        }

        public void AddElement(int element)
        {
            if (count < size)
            {
                data[count] = element;
                count++;
            }
            else
            {
                Console.WriteLine("Collection is full. Cannot add more elements.");
            }

        }

        public void RemoveElement(int element)
        {
            int index = Array.IndexOf(data, element);
            if (index != -1)
            {
                // Shift elements to fill the gap
                for (int i = index; i < count - 1; i++)
                {
                    data[i] = data[i + 1];
                }
                count--;
            }
            else
            {
                Console.WriteLine("Element not found in the collection.");
            }
        }


        public int AccessElement(int index)
        {
            if (index >= 0 && index < count)
            {
                return data[index];
            }
            else
            {
                Console.WriteLine("Invalid index. Cannot access element.");
                return -1; // or throw an exception based on your design
            }
        }

        public void DisplayCollection()
        {
            Console.WriteLine("Collection elements:");
            for (int i = 0; i < count; i++)
            {
                Console.Write(data[i] + " ");
            }
            Console.WriteLine();
        }



        public void Dispose()
        {
            Dispose(true);
            GC.SuppressFinalize(this);
        }

        protected virtual void Dispose(bool disposing)
        {
            if (!disposed)
            {
                if (disposing)
                {
                    // Release managed resources
                    data = null;
                }

                data = null;

                disposed = true;
            }
        }

        ~LargeDataCollection()
        {
            Dispose(false);
        }
    }


}