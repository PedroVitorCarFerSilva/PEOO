using System;
class exercicio13 {
  static void Main(){
    Console.WriteLine("Digite dez valores inteiros");
    string sequencia = Console.ReadLine();
    string[] seq = sequencia.Split();
    int[] num = Array.ConvertAll(seq, int.Parse);
    int maior = num[0];
    if (maior < num[1]) maior = num[1];
    if (maior < num[2]) maior = num[2];
    if (maior < num[3]) maior = num[3];
    if (maior < num[4]) maior = num[4];
    if (maior < num[5]) maior = num[5];
    if (maior < num[6]) maior = num[6];
    if (maior < num[7]) maior = num[7];
    if (maior < num[8]) maior = num[8];
    if (maior < num[9]) maior = num[9];
    int menor = num[0];
    if (menor > num[1]) menor = num[1];
    if (menor > num[2]) menor = num[2];
    if (menor > num[3]) menor = num[3];
    if (menor > num[4]) menor = num[4];
    if (menor > num[5]) menor = num[5];
    if (menor > num[6]) menor = num[6];
    if (menor > num[7]) menor = num[7];
    if (menor > num[8]) menor = num[8];
    if (menor > num[9]) menor = num[9];
    Console.WriteLine($"O maior valor é {maior} e o menor é {menor}");
  }
}