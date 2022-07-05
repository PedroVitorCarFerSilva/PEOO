using System;
class uri1165 {
  static void Main() {
    int repet = int.Parse(Console.ReadLine());
    for (int vez = 0; vez < repet; vez++){
      int numero = int.Parse(Console.ReadLine());
      int games = 0;
      for (int v = 2; v <= numero+1; v++){
        double numbdiv = (double)numero / (double)v;
        if (numbdiv == numero / v) {
          games++;
        }
      }
      if (games <= 1)
        Console.WriteLine($"{numero} eh primo");
      else {
        Console.WriteLine($"{numero} nao eh primo");
      }
    }
  }
}