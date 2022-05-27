using System;
class exercicio12 {
  static void Main(){
    Console.WriteLine("Digite dois valores inteiros separados por um operador +, -, * ou /");
    string conta = Console.ReadLine();
    bool soma = conta.Contains("+");
    bool subt = conta.Contains("-");
    bool mult = conta.Contains("*");
    bool divi = conta.Contains("/");
    string[] v = conta.Split();
    double resultado = 0;
    if (soma) {
      v = conta.Split("+");
      int[] val = Array.ConvertAll(v, int.Parse);
      resultado = val[0]+val[1];
    }
    if (subt) {
      v = conta.Split("-");
      int[] val = Array.ConvertAll(v, int.Parse);
      resultado = val[0]-val[1];
    }
    if (mult) {
      v = conta.Split("*");
      int[] val = Array.ConvertAll(v, int.Parse);
      resultado = val[0]*val[1];
    }
    if (divi) {
      v = conta.Split("/");
      int[] val = Array.ConvertAll(v, int.Parse);
      resultado = val[0]/val[1];
    }
    Console.WriteLine($"O resultado da operação é {resultado}");
  }
}