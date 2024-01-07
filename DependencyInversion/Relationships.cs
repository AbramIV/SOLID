using DependencyInversion.Enums;
using DependencyInversion.Interfaces;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DependencyInversion;

internal class Relationships : IRelationShipBrowser
{
    private readonly List<(Person, Relationship, Person)> relations = new();
    internal List<(Person, Relationship, Person)> Relations => relations;

    internal Relationships() { }

    internal void AddParentAndChild(Person parent, Person child)
    {
        relations.Add((parent, Relationship.Parent, child));
        relations.Add((child, Relationship.Child, parent));
    }

    public IEnumerable<Person> FindAllChildrenOf(string name)
    {
        foreach (var relation in relations.Where(
            x => x.Item1.Name.Equals(name) &&
                  x.Item2.Equals(Relationship.Parent))) yield return relation.Item3;
    }
}
