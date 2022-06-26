using System;
class exercicio1{
  static void Main(){
    double x = double.Parse(Console.ReadLine());
    double y = double.Parse(Console.ReadLine());
    double z = double.Parse(Console.ReadLine());
    double maior = Mat.Maior(x, y, z);
    Console.WriteLine(maior);
  }
}

class Mat{
  public static double Maior(double x, double y, double z) {
    double maior;
    maior = x;
    if (maior < y) maior = y;
    if (maior < z) maior = z;
    return maior;
  }
}