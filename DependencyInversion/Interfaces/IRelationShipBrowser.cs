using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DependencyInversion.Interfaces;

internal interface IRelationShipBrowser
{
    IEnumerable<Person> FindAllChildrenOf(string name);
}
