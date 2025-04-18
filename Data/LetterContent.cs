using System.Collections.Generic;

namespace CombineLists.Data
{
    public class LetterContent : IContent
    {
        private List<object> _contents;

        public LetterContent()
        {
            Hydrate();
        }

        public IEnumerable<object> Content()
        {
            return _contents;
        }

        public int Add(string item)
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
                "a", "b", "c", "d"
            };
        }
    }
}