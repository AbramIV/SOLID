using OpenClosed.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OpenClosed;

public class OldFilter
{
    public IEnumerable<Product> FilterByColor(IEnumerable<Product> products, Color color)
        => products.Where(p => p.Color.Equals(color));

    public IEnumerable<Product> FilterBySize(IEnumerable<Product> products, Size size) 
        => products.Where(p => p.Size.Equals(size));

    public IEnumerable<Product> FilterByColorAndSize(IEnumerable<Product> products, Color color, Size size)
        => products.Where(p => p.Color.Equals(color) && p.Size.Equals(size));
}
