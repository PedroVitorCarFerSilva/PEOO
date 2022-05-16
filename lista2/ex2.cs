using System;
class Class0002 {
  public static void Main (string[] args) {
    Console.WriteLine ("Digite seu nome completo:");
    string[] primeironome = Console.ReadLine().Split();
    Console.WriteLine ("Bem-vindo ao C#, "+primeironome[0]);
  }
}
