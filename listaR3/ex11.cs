using System;
class exercicio11 {
  static void Main() {
    Console.WriteLine("Digite uma frase:");
    string s = Console.ReadLine();
    int i = s.Length;
    int z = 1;
    bool t;
    int x = 0;
    while (i >= z){
      t = int.TryParse(s.Substring(0,1), out int n);
      if (t) {
        x += n;
      }
      s = s.Substring(1,i-z);
      z++;
    }
    Console.WriteLine(x);
  }
}