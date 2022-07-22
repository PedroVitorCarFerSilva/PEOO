using System;
class exercicio9 {
  static void Main() {
    Console.WriteLine("Digite uma frase:");
    string s = Console.ReadLine();
    int i = s.Length;
    int z = 1;
    while (i >= z) {
      Console.WriteLine($"{z} - {s}");
      z++;
    }
  }
}