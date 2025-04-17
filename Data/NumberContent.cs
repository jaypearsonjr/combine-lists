using System.Collections.Generic;
using System.Linq;

namespace CombineLists.Data
{
    public class NumberContent : IContent
    {
        private List<object> _contents;

        public NumberContent()
        {
            Hydrate();
        }

        public IEnumerable<object> Content()
        {
            return _contents;
        }

        public int Add(int item)
        {
            _contents.Add(item);

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

        private void Hydrate()
        {
            _contents = new List<object>
            {
                1, 2, 3, 4
            };
        }
    }
}