using System.Collections.Generic;

namespace CombineLists.Data
{
    public interface IContent
    {
        IEnumerable<object> Content();
    }
}