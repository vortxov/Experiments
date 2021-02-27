using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DI
{
    public interface IData<T>
    {
        IEnumerable<T> ReadList();
        void Add(T item);
        void Remove(T item);
    }
}
