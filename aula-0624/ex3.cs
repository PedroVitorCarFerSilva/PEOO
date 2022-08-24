using System;
class uri1028 {
  static void Main() {
    int vezes = int.Parse(Console.ReadLine());
    for (int x = 0; x < vezes; x++) {
      string n = Console.ReadLine();
      string[] num = n.Split();
      int num1 = int.Parse(num[0]);
      int num2 = int.Parse(num[1]);
      int div = num1;
      if (div > num2) div = num2;
      while (!(0 == num1%div && 0 == num2%div)) {
        div--;
      }
      Console.WriteLine(div);
    }
  }
}