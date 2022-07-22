using System;
class exercicio13 {
  static void Main() {
    Console.WriteLine("Digite uma frase:");
    string s = Console.ReadLine();
    int i = s.Length;
    int n = 0;
    while (0 < i) {
      i--;
      n = i-1;
      Console.Write(s.Substring(n,i));
    }
  }
}