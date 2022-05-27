using System;
class exercicio10{
  static void Main() {
    Console.WriteLine("Digite uma data no formato dd/mm/aaaa");
    string data = Console.ReadLine();
    string[] datas = data.Split("/");
    string resposta = "A data informada não é válida";
    int dia = int.Parse(datas[0]);
    int mes = int.Parse(datas[1]);
    int ano = int.Parse(datas[2]);
    if (mes <= 12 && mes >= 1 && ano >= 1900 && ano <= 2100) {
      switch (mes) {
        case 1:
        case 3:
        case 5:
        case 8:
        case 10:
        case 12:
          if (dia <= 31 && dia >= 1) resposta = "A data informada é válida";
          break;
        case 2:
          if (dia <= 28 && dia >= 1) resposta = "A data informada é válida";
          break;
        default:
          if (dia <= 30 && dia >= 1) resposta = "A data informada é válida";
          break;
      }
    } 
    
    Console.WriteLine(resposta);
  }
}