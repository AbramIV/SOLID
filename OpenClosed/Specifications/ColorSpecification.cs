using OpenClosed.Enums;
using OpenClosed.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OpenClosed.Specifications;

public class ColorSpecification : ISpecification<Product>
{
    public Color Color;

    public ColorSpecification(Color color) => Color = color;

    public bool IsSatisfied(Product product) => product.Color.Equals(Color);
}
