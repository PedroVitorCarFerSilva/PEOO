using System;
class Exercicio6 {
  static void Main() {
    double massa = double.Parse(Console.ReadLine());
    double distancia = double.Parse(Console.ReadLine());
    Console.WriteLine($"R${Frete(massa, distancia):0.00}");
  }
  public static double Frete(double massa, double distancia) {
    return massa*distancia/100;
  }
}