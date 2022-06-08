using System;
class uri1094 {
  static void Main() {
    int coelhos = 0;
    int sapos = 0;
    int ratos = 0;
    int tests = int.Parse(Console.ReadLine());
    for (int cobaia = 0; cobaia < tests; cobaia++) {
      string coba = Console.ReadLine();
      string[] cobai = coba.Split();
      int numcobai = int.Parse(cobai[0]);
      if (cobai[1] == "C") coelhos += numcobai;
      if (cobai[1] == "S") sapos += numcobai;
      if (cobai[1] == "R") ratos += numcobai;
    }
    int numtotal = coelhos+sapos+ratos;
    double percoe = (coelhos/1.0/numtotal)*100;
    double perrat = (ratos/1.0/numtotal)*100;
    double persap = (sapos/1.0/numtotal)*100;
    Console.WriteLine($"Total: {numtotal} cobaias");
    Console.WriteLine($"Total de coelhos: {coelhos}");
    Console.WriteLine($"Total de ratos: {ratos}");
    Console.WriteLine($"Total de sapos: {sapos}");
    Console.WriteLine($"Percentual de coelhos: {percoe:.00} %");
    Console.WriteLine($"Percentual de ratos: {perrat:.00} %");
    Console.WriteLine($"Percentual de sapos: {persap:.00} %");
  }
}