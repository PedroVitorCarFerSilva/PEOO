using System;
class exercicio7 {
  static void Main() {
    string f = Console.ReadLine();
    string[] frase = f.Split();
    int n = frase.Length;
    int z = 0;
    int m = n;
    while (n >= 0) {
      while (z < m) {
        Console.Write(frase[z]);
        z++;
        if (z < m) Console.Write(" ");
      }
      Console.WriteLine();
      n--;
      z = m-n;
    }
  }
}