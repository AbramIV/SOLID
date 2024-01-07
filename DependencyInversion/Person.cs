using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DependencyInversion;

internal class Person
{
    internal readonly string Name;

    internal Person(string name)
    {
        Name = name;
    }
}
