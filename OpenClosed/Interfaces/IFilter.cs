using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OpenClosed.Interfaces;

public interface IFilter<T>
{
    //IEnumerable<T> Filter(Func<T, bool> predicate);

    public IEnumerable<T> Filter(IEnumerable<T> items, ISpecification<T> specification);
}
