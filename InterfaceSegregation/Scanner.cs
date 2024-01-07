using InterfaceSegregation.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfaceSegregation;

internal class Scanner : IScanner
{
    public void Scan(Document document) => 
        Console.WriteLine($"Document \"{document.Name}\" is scanned.");
}
