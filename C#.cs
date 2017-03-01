-------------------------------------
   /* C# Basics */
-------------------------------------
   
/*
  // Naming convention
  Camel Case: firstName
  Pascal Case: FirstName
  Hungarian Notation: strFirstName (do not use in C#)
*/

// Primitive types in C#
C# type  .NET Type  Byte
byte      Byte       1
short     Int16      2
int       Int32      4
long      Int64      8
float     Single     4
double    Double     8
decimal   Decimal    16
char      Char       2
bool      Boolean    1
   
/* Non-Premitive Types: String, Array, Enum, class */

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

// String to number convert
string num = "12";
int number = Convert.ToInt32(num);
int numbeer = int.Parse(num);

// Print data
Console.WriterLine("Welcome to c#");
Console.Log("Your age is {0}", age);

// Get data from console
streing player = Console.ReadLine();

// Comparison
player.Equals("AI");

// Variable getter setter
public string firstName { get; set; } 

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


------------------------------------------------
   /* C# Data Structure */
------------------------------------------------

// Create List
List<string> strList = new List<string>();
List<string> strList = new List<string>(new string[] {"Tom", "Hasan"});


------------------------------------------------
   /* C# Object Oriented Programming */  
------------------------------------------------
   
// Object create
Animal dog = new Anumal();

// Object create with parameter
Anumal dog = new Anumal
{
   name = "Dog",
   height = 4,
   weight = 10
};

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


