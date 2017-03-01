// C# code demo
using System;
namespace HelloWorldApplication
{
   class HelloWorld
   {
      static void Main(string[] args)
      {
         /* my first program in C# */
         Console.WriteLine("Hello World");
         Console.ReadKey();
      }
   }
}

// Print
Console.WriterLine("Welcome to c#");

// Create List
List<string> strList = new List<string>();
List<string> strList = new List<string>(new string[] {"Tom", "Hasan"});

// String sorting
strList.Sort();

// Exception handle
try{
  Console.Write("Divide 10 By");
  int num = int.Parse(Console.ReadLine());
  Console.WriteLine("10 / {0} = {1}",num, (10/num));
} catch(DivideByZeroException ex){
  Console.WriteLine("Cant divide by zero");
  Console.WriteLine(ex.getType().Name);
  Console.WriteLine(ex.Message);
} catch(Exception ex){
  Console.WriteLine(ex.getType().Name);
  Console.WriteLine(ex.Message);
}
  


