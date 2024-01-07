using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfaceSegregation;

internal class Document
{
    public string? Name;
    public string? Description;

    public Document() { }

    public Document(string name) => Name = name;

    public Document(string name, string description) 
    {
        Name = name;
        Description = description;
    }
}
