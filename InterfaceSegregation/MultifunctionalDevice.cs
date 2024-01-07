using InterfaceSegregation.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfaceSegregation;

internal class MultifunctionalDevice : IMultifunctional
{
    private readonly IPrinter printer;
    private readonly IScanner scanner;

    public MultifunctionalDevice(IPrinter printer, IScanner scanner)
    {
        if (printer is null)
            throw new ArgumentException("Printer is null.", nameof(printer));

        if (scanner is null)
            throw new ArgumentException("Scanner is null.", nameof(scanner));

        this.printer = printer;
        this.scanner = scanner;
    }

    public void Print(Document document) => printer.Print(document);

    public void Scan(Document document) => scanner.Scan(document);
}
