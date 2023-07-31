using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day9Assignment
{
    public class LargeDataCollection : IDisposable
    {
        private List<int> data;

        public LargeDataCollection(IEnumerable<int> initialData)
        {
            data = new List<int>(initialData);
        }

        public void Add(int item)
        {
            data.Add(item);
        }

        public bool Remove(int item)
        {
            return data.Remove(item);
        }

        public int this[int index]
        {
            get { return data[index]; }
        }

        public int Count => data.Count;

        public void DisplayAllElements()
        {
            Console.WriteLine("All elements in the collection:");
            foreach (int item in data)
            {
                Console.Write(item + " ");
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
            if (disposing)
            {
                data.Clear();
                data = null;
            }
        }
    }
}
