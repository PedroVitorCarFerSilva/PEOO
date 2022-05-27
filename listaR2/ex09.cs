using System;
class exercicio9 {
  static void Main() {
    Console.WriteLine("Digite o horário no formato hh:mm");
    string hor = Console.ReadLine();
    string[] hora = hor.Split(":");
    int phor = int.Parse(hora[0]);
    int pmin = int.Parse(hora[1]);
    if (phor >= 12) phor -= 12;
    int dist = Math.Abs((phor*30 + pmin/2)-(pmin*6));
    if (dist > 180) dist = 360 - dist;
    Console.WriteLine($"Menor ângulo entre os ponteiros = {dist} graus");
  }
}