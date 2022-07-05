using System;
class exercicio1 {
  static void Main() {
    int rep = 1;
    while (rep <= 10) {
      Console.Write(rep);
      if (rep != 10) Console.Write(" ");
      rep++;
    }
  }
}