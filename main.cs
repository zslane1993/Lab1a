using System;

class MainClass {
  public static void Main (string[] args) {
  Console.WriteLine ("Enter the name of item");
    var name = Console.ReadLine();
    Console.WriteLine("Enter the quantity");
    var x = Console.ReadLine();
    Console.WriteLine ("Enter the price");
    var y = Console.ReadLine();
    int x1 = Convert.ToInt32(x);
    double y1 = Convert.ToDouble(y);
    Console.WriteLine ("Total price of apple =");
    Console.WriteLine (x1*y1);
  }
}