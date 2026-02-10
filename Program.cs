// See https://aka.ms/new-console-template for more information
using System.Net.WebSockets;
using _0902;

Numeros numeros = new Numeros();
// Console.WriteLine("digite o primeiro numero");
// numeros.Numero1=int.Parse(Console.ReadLine());
// Console.WriteLine("digite o segundo numero");
// numeros.Numero2=int.Parse(Console.ReadLine());
// numeros.Somar();
// numeros.Subtrair();
// numeros.Multiplicacao();
// numeros.Divisao();
// Console.WriteLine("digite seu numero");
// numeros.Num= int.Parse(Console.ReadLine());
// Console.WriteLine(numeros.Dobro());
// // Console.WriteLine(numeros.Triplo());
// Console.WriteLine("digite seu nome");
// numeros.Nome= Console.ReadLine();
// Console.WriteLine("digite sua idade");
// numeros.Idade= int.Parse(Console.ReadLine());
// numeros.Chama();
// numeros.Ida();
// Console.WriteLine("digite um numero");
// int numer = int.Parse(Console.ReadLine());
// if (numer%2 == 0)
// {
//     Console.WriteLine("seu numero e par");
// }
// else
// {
//     Console.WriteLine("seu numero e impar");
// }
// int n1 = 6;
// int n2 = 67;
// if (n1>n2)
// {
//     Console.WriteLine("o primeiro numero e maior");
// }
// else
// {
//     Console.WriteLine("o segundo numero e maior");
// }
// Console.WriteLine(" Insira sua nota");
// double nota = double.Parse(Console.ReadLine());

// if (nota > 7)
// {
//     Console.WriteLine("Parabéns, voce passou de ano");
// }

// else if(nota <7 && nota >4)
// {
//     Console.WriteLine("Voce esta de recuperação");
// }

// else
// {
//     Console.WriteLine("Voce estra reprovado");
// }

// Console.WriteLine("Insira sua idade");
//  double idade = double.Parse(Console.ReadLine());

//  if (idade < 18)
//  {
//     Console.WriteLine("Voce é menor de idade");
//  }

//  else if( idade > 18 && idade < 60)
// {
//     Console.WriteLine("Voce é adulto");
// }
// else 
// {
//      Console.WriteLine("Voce é idoso");
// }

// Console.WriteLine("Insira um numero");
// double numero = double.Parse(Console.ReadLine());

// if (numero == 0)
// {
//     Console.WriteLine("Seu numero é igual a zero");
// }
// else if (numero>0)
// {
//         Console.WriteLine("Seu numero e positivo");
// }
// else
// {
//         Console.WriteLine("Seu numero e negativo");
// }


// for (int i = 1; i <= 10; i++)
// {
//     Console.WriteLine(i);
// }

// for (int i = 1; i <= 50; i++)
// {
//     if (i % 2 == 0)
//     {
//         Console.WriteLine(i);
//     }
// }

// Console.Write("insira seu número: ");
// int numero = int.Parse(Console.ReadLine());

// for (int i = 1; i <= 10; i++)
// {
//     Console.WriteLine($"{numero} x {i} = {numero * i}");
// }


// double numero = 1;
// double soma = 0;

// while (numero != 0)
// {
//     Console.WriteLine("Digite um número (0 para parar): ");
//     numero = double.Parse(Console.ReadLine());

//     soma += numero;
// }
//  Console.WriteLine("Soma total = " + soma);
// int numerPositi = 0;
// for (int i = 0; i < 5; i++)
// {
//     Console.WriteLine("digite seu numero" );
// int numero = int.Parse(Console.ReadLine());
// if (numero >0)
//     {
//         numerPositi += 1;
//     }

// }
// Console.WriteLine(numerPositi);
// Console.WriteLine("digite 1 para somar 2 para subtrair 3 para multiplicar 4 para dividir");
// int escolha = int.Parse(Console.ReadLine());
// int resultado = 0;
// switch (escolha)
// {
//     case 1:
//     Console.WriteLine("digite seus dois numeros");
//     int n1 = int.Parse(Console.ReadLine());
//     int n2 = int.Parse(Console.ReadLine());
//      resultado = n1 + n2;
//     break;
//      case 2:
//     Console.WriteLine("digite seus dois numeros");
//     n1 = int.Parse(Console.ReadLine());
//      n2 = int.Parse(Console.ReadLine());
//      resultado = n1 - n2;
//     break;
//     case 3:
//     Console.WriteLine("digite seus dois numeros");
//     n1 = int.Parse(Console.ReadLine());
//      n2 = int.Parse(Console.ReadLine());
//      resultado = n1 * n2;
//     break;
//     case 4:
//     Console.WriteLine("digite seus dois numeros");
//     n1 = int.Parse(Console.ReadLine());
//      n2 = int.Parse(Console.ReadLine());
//      resultado = n1 / n2;
//     break;
// }
// Console.WriteLine(resultado);
// Console.WriteLine("digite um numero d 1 a 7");
// int dia = int.Parse(Console.ReadLine());
// switch (dia)
// {
    
//     case 1:
//     Console.WriteLine("domingo"); 
//     break;
//      case 2:
//     Console.WriteLine("segunda"); 
//     break; 
//     case 3:
//     Console.WriteLine("terça"); 
//     break;
//      case 4:
//     Console.WriteLine("quarta"); 
//     break;
//      case 5:
//     Console.WriteLine("quinta"); 
//     break;
//      case 6:
//     Console.WriteLine("sexta"); 
//     break;
//      case 7:
//     Console.WriteLine("sabado"); 
//     break;
// }
Console.WriteLine("digite  1 pra alimento 2 bebida e 3 limpesa");
int produto = int.Parse(Console.ReadLine());
switch (produto)
{
    case 1:
    Console.WriteLine("alimento");
     break;
       case 2:
    Console.WriteLine("bebida");
     break;
       case 3:
    Console.WriteLine("limpesa");
     break;
    
}