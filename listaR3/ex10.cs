using System;
class exercicio10 {
  static void Main() {
    Console.WriteLine("Digite uma frase:");
    string s = Console.ReadLine();
    int i = s.Length;
    int z = 1;
    while (i >= z) {
      s = s.Substring(1,i-1) + s.Substring(0,1);
      Console.WriteLine(s);
      z++;
    }
  }
}