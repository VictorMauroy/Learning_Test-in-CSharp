using System.Xml.Linq;
using Testing_CSharp;

float quotient = Computation.GetDivision(19, 13);
Console.WriteLine(quotient);

Cat kitty = new Cat("Kitty", 1, 1.5f);
kitty.RaiseWeigth(0.5f);
kitty.UpdateAge(2);

Console.WriteLine(kitty.GetCatProfile());