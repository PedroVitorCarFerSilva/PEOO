using System;
class P1245 {
  public static void Main(){
    string s = Console.ReadLine();
    int qnt = int.Parse(s);
    string[] n = new string[qnt];
    string[] p = new string[qnt];
    int haha = 0;
    // while(!string.IsNullOrEmpty(s)) {
    for (int i = qnt; qnt > 0; qnt--) {
      string bota = Console.ReadLine();
      string[] arr = bota.Split("");
      n[i] = arr[0];
    }
    foreach(string c in p){
      foreach(string d in p){
        if (c != d) {
            foreach(string a in n){
              foreach(string b in n){
                if (a = b && a.IndexOf != b.IndexOf) {
                  haha++;
                }
              }
            }
          }
        }
      }
    Console.WriteLine(haha/2);
    }
  }
}