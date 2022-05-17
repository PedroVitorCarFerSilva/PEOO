using System;
class uri1017{
  static void Main(){
    double tempo = double.Parse(Console.ReadLine());
    double veloc = double.Parse(Console.ReadLine());
    double dista = tempo*veloc;
    double litro = dista/12;
    Console.WriteLine($"{litro:0.000}");
  }
}