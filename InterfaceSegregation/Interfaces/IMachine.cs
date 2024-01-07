using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfaceSegregation.Interfaces;

internal interface IMachine // in case of many functions the best solution to segregate interfaces
{
    void Print(Document document);
    void Scan(Document document);
}
