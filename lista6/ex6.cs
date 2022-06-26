using System;
class uri1151 {
  static void Main() {
    int quant = int.Parse(Console.ReadLine());
    int valor = 1;
    int antval = 0;
    int valorpos = valor;
    for (int pos = 0; pos < quant; pos++) {
      if (pos != quant-1) Console.Write($"{antval} ");
      else Console.Write($"{antval}\n");
      valorpos += antval;
      antval = valor;
      valor = valorpos;
    }
  }
}