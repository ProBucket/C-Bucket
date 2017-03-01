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

// Object create
Animal dog = new Anumal();

// Object create with parameter
Anumal dog = new Anumal
{
   name = "Dog",
   height = 4,
   weight = 10
};

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

// Abstract class 
abstract class Shape
{
   public abstract double area();
   
   public vaid sayHi()
   {
      Console.WriteLine("Hellow");
   }
}
/* abstract class can have both abstract method and defined method */

// Interface
public interface ShapeItem
{
   double area();  
}
/* interface can only have abstract methods */

// Inheritance
class Rectangle: Shape
{
   private double n1;
   private double n2;
   
   public Rectangle(double num1, double num2)
   {
      n1 = num1;
      n2 = num2;
   }
   
   public override double area()
   {
      return n1 * n2;
   }
   
   // Operator overloadin
   public static Rectangle operator+ (Rectangle rect1, Rectangle rect2)
   {
      double restLength = rect1.length + rect2.length;
      double rectWidth = rect1.width + rect
   }
   
}


