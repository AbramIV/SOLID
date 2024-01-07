using OpenClosed.Enums;
using OpenClosed.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OpenClosed.Specifications;

public class SizeSpecification : ISpecification<Product>
{
    public Size Size;

    public SizeSpecification(Size size) => Size = size;

    public bool IsSatisfied(Product product) => product.Size.Equals(Size);
}
