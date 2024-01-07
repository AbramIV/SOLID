using InterfaceSegregation;

Document document = new("Data");
Printer printer = new();
Scanner scanner = new();
MultifunctionalDevice mfd = new(printer, scanner);
mfd.Print(document);
mfd.Scan(document);
Console.ReadKey();