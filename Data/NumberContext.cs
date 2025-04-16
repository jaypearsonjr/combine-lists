using System.Collections.Generic;

namespace CombineLists.Data
{
    public class NumberContext : IContent
    {
        private readonly List<object> _contents;

        public NumberContext()
        {
            _contents = new List<object>();
        }

        public IEnumerable<object> Content()
        {
            return _contents;
        }

        public int Add(object item)
        {
            if (item is int) // Ensure only integers are added
            {
                _contents.Add(item);
                return _contents.Count;
            }
            return -1; // Return -1 if the item is not an integer
        }

        public int Add(IEnumerable<object> items)
        {
            foreach (var item in items)
            {
                _contents.Add(item);
            }
            return _contents.Count;
        }

        public int Remove(int index)
        {
            if (index >= 0 && index < _contents.Count)
            {
                _contents.RemoveAt(index);
                return _contents.Count;
            }
            return -1; // Return -1 if the index is invalid
        }
    }
}