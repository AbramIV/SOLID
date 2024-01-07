using OpenClosed;
using OpenClosed.Enums;
using OpenClosed.Interfaces;
using OpenClosed.Specifications;
using static System.Console;

Product[] products =
        {
            new("Apple", Color.Green, Size.Small),
            new("Tree", Color.Green, Size.Large),
            new("House", Color.Blue, Size.Large),
        };

OldFilter pf = new();
WriteLine("Green products (old):");
foreach (var product in pf.FilterByColor(products, Color.Green))
    WriteLine(product.Name);

WriteLine();

NewFilter nf = new();
WriteLine("Green products (new):");
foreach (var product in nf.Filter(products, new ColorSpecification(Color.Green)))
    WriteLine(product.Name);

WriteLine();

WriteLine("Large blue products (new many):");
foreach (var product in nf.Filter(products,
    new ManySpecifications<Product>(new List<ISpecification<Product>>()
    {
                new ColorSpecification(Color.Blue),
                new SizeSpecification(Size.Large)
    })))
    WriteLine(product.Name);

ReadLine();