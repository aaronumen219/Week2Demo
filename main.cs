using System;

class MainClass {
  public static void Main (string[] args) {
    Console.WriteLine ("Enter Your Name");
    string name = Console.ReadLine();
    Console.WriteLine(name + ", nice to meet you!");
  
    Console.WriteLine("Enter your age");
    int age = Convert.ToInt32(Console.ReadLine());
    Console.WriteLine("You are " + age + " years closer to death!");

    Console.WriteLine("Enter what you paid for your shirt");
    double cost = Convert.ToDouble((Console.ReadLine()));
    Console.WriteLine("You wasted " + cost + " dollars on your shirt!");


    Console.WriteLine("Enter price of shirt, then your tax rate.");
    double price = Convert.ToDouble(Console.ReadLine());
    double tax = Convert.ToDouble((Console.ReadLine()));
    double finalprice = Convert.ToDouble(price + price * tax);
    Console.WriteLine("Final price is " + finalprice);
  }
}