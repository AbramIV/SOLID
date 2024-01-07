using OpenClosed.Interfaces;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OpenClosed.Specifications;

public class ManySpecifications<T> : ISpecification<T>
{
    private readonly IEnumerable<ISpecification<T>> specs;

    public ManySpecifications(IEnumerable<ISpecification<T>> specifications)
        => specs = specifications ?? throw new ArgumentNullException(nameof(specifications));

    public bool IsSatisfied(T t)
    {
        foreach (var spec in specs)
            if (!spec.IsSatisfied(t)) return false;

        return true;
    }
}
