using System;

  class MainClass {
  public static void Main (string[] args) {
    int n, maior, cont=0;
 

 Console.Write("Digite o 1º número inteiro: ");
 n = int.Parse(Console.ReadLine());
 maior=n;
 do{
   cont++;
 Console.Write("\nDigite o {0}º número inteiro: ",cont+1);
 n = int.Parse(Console.ReadLine());
 if(n>maior)
 maior=n;
 } 
  while(n>=0);
Console.Write("\nO maior numero digitado é: {0}", maior);
}
}