using System;
class Teste {
  public static void Main() {
    Circulo c = new Circulo();
    Console.WriteLine("Digite o raio do círculo:");
    c.raio = double.Parse(Console.ReadLine());
    Console.WriteLine($"A circunferência do círculo é {c.circunferencia():0.00}");
    Console.WriteLine($"A área do círculo é {c.area():0.00}");
  }
}

class Circulo {
  public double raio;
  public double circunferencia(){
    return raio * 2 * Math.PI;
  }
  public double area(){
    return raio * raio * Math.PI;
  }
}