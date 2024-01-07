using OpenClosed.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OpenClosed;

public class Product
{
    public string Name;
    public Color Color;
    public Size Size;

    public Product(string name, Color color, Size size)
    {
        if (name is null) 
            throw new ArgumentNullException(paramName: nameof(name));

        Name = name;
        Color = color;
        Size = size;
    }
}
