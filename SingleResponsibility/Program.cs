using SingleResponsibility;
using System.Diagnostics;

Journal journal = new("MyJournal");
journal.AddEntry("I love money.");
journal.AddEntry("I love the world.");

Persistence persistance = new();
var file = $@"C:\Way\Temp\{journal.Name}.txt";
persistance.SaveToFile(journal, file, true); 

Process process = new()
{
    StartInfo = new ProcessStartInfo(file) { UseShellExecute = true }
};
process.Start();