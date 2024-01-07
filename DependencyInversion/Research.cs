using DependencyInversion.Enums;
using DependencyInversion.Interfaces;

namespace DependencyInversion;

internal class Research
{
    internal Research(IRelationShipBrowser browser, string fatherName) 
    {
        foreach (var child in browser.FindAllChildrenOf(fatherName))
            Console.WriteLine($"{fatherName} is father of {child.Name}");
    }
}