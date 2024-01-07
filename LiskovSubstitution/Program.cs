using LiskovSubstitution;
using static System.Console;

static int Area(Rectangle rectangle) => rectangle.Height * rectangle.Width;

Rectangle rc = new(2, 3);
WriteLine($"{rc} has area {Area(rc)}");

// should be able to substitute a base type for a subtype
/*Square*/
Rectangle sq = new Square { Width = 4 };

WriteLine($"{sq} has area {Area(sq)}");

ReadLine();