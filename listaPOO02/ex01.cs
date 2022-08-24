using System;
class Exercicio01 {
  public static void Main() {
    Circulo c = new Circulo();
    Console.WriteLine("Digite o raio do círculo:");
    c.SetRaio(double.Parse(Console.ReadLine()));
    Console.WriteLine($"A circunferência do círculo é {c.CalcCircunferencia():0.00}");
    Console.WriteLine($"A área do círculo é {c.CalcArea():0.00}");
    Console.WriteLine($"O raio do círculo é {c.GetRaio():0.00}");
  }
}

class Circulo {
  private double raio = 1;
  public void SetRaio(double valor){
    if (valor > 0) raio = valor;
  }
  public double GetRaio(){
    return raio;
  }
  public double CalcArea(){
    return raio * raio * Math.PI;
  }
  public double CalcCircunferencia(){
    return raio * 2 * Math.PI;
  }
}