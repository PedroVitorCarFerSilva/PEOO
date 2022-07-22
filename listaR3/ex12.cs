using System;
class exercicio12 {
  static void Main() {
    Console.WriteLine("Digite uma frase:");
    string str = Console.ReadLine();
    string[] ary = str.Split();
    int i = 0;
    foreach (string s in ary) {
      i++;
    }
    Console.WriteLine(i);
  }
}