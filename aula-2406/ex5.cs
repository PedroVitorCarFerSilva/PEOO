using System;
class IsNullOrEmpty {
  static void Main() {
    string s = Console.ReadLine();
    while (string.IsNullOrEmpty(s) == false) {
      int m = int.Parse(s);
      string l = Console.ReadLine();
      string[] ls = l.Split();
      int l1 = int.Parse(ls[0]);
      int l2 = int.Parse(ls[1]);
      int l3 = int.Parse(ls[2]);
      Console.WriteLine(m);
    }
  }
}