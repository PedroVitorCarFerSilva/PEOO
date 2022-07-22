using System;
class exercicio8 {
  static void Main() {
    string fstr = Console.ReadLine();
    string[] ary = fstr.Split();
    int len = ary.Length;
    int z = 0;
    int i = 1;
    while (z < len) {
      string str = ary[z];
      char chr = str[str.Length-1];
      while (i > 0) {
        Console.Write(chr);
        i--;
      }
      z++;
      i = z+1;
      if (i <= len) Console.Write(" ");
    }
  }
}