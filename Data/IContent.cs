using System.Collections.Generic;

namespace CombineLists.Data
{
    public interface IContent
    {
        IEnumerable<object> Content();
        int Add(object item);
        int Remove(int index);
    }
}