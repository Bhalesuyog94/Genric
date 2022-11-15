// See https://aka.ms/new-console-template for more information
using Generics;
using static Generics.GenericsClass;
//int[] arr = { 112, 344, 432, 555, 678 };
//GenericMaximum<int> generic = new GenericMaximum<int>(arr);
//generic.PrintMaxvalue();
Console.WriteLine("Find MAX Number");
int output = MaximumInt.MaximumIntegerNumber(11, 22, 33);
Console.WriteLine(output);
double doubleoutput = MaxiumFloat.MaximumfloatNumber(11.22, 22.33, 33.44);
Console.WriteLine(doubleoutput);
string stringoutput = MaximumStrings.MaximumString("22", "33", "44");
Console.WriteLine(stringoutput);


