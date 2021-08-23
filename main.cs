using System;

class MainClass {
  public static void Main (string[] args) {
    /*
    8- Implemente um código em C# que leia um  número inteiro (assuma números com 
    apenas três dígitos) e imprima a saída com as centenas, dezenas e unidades 
    conforme o exemplo. Ex.: número lido 769Saída: 7 centenas –6 dezenas –9 unidades
    */

    Console.WriteLine ("Digite um número inteiro com 3 dígitos");
    int nmrPedido = int.Parse(Console.ReadLine());

    int centena = nmrPedido / 100;
    int dezena = (nmrPedido % 100) /10;
    int unidade = (nmrPedido % 100) %10;

    Console.WriteLine ($"{centena} centenas - {dezena} dezenas - {unidade} unidades.");    
    
  }
}