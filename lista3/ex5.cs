using System;

class uri1015{
  static void Main(){
    string posicao1 = Console.ReadLine();
    string posicao2 = Console.ReadLine();
    string[] pos1 = posicao1.Split();
    string[] pos2 = posicao2.Split();
    double xs1 = double.Parse(pos1[0]);
    double xs2 = double.Parse(pos2[0]);
    double ys1 = double.Parse(pos1[1]);
    double ys2 = double.Parse(pos2[1]);
    double valor = Math.Sqrt(Math.Pow(xs2-xs1,2) + Math.Pow(ys2-ys1,2));
    Console.WriteLine($"{valor:0.0000}");
  }
}
