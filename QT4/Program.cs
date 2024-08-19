/*-------------------------------------------------------------------
Questão 4: Somatório de Moedas
• Contextualização: No seu jogo, o jogador coleta moedas durante uma fase. A cada coleta, o total
de moedas aumenta.
• Comando: Desenvolva um programa que receba cinco valores de moedas coletadas e some-os,
exibindo o total de moedas coletadas ao final.

@Lista: 01 - Lógica de Programação
@Autor: Milton Roney de Oliveira Nobre
@Data: 19/08/2024
---------------------------------------------------------------------*/
using System;
class Program
{
    static void Main(string[] args)
    {
        int m1, m2, m3, m4, m5;

        Console.Write("Moedas coletadas 1: ");
        int.TryParse(Console.ReadLine(), out m1);
        Console.Write("Moedas coletadas 2: ");
        int.TryParse(Console.ReadLine(), out m2);
        Console.Write("Moedas coletadas 3: ");
        int.TryParse(Console.ReadLine(), out m3);
        Console.Write("Moedas coletadas 4: ");
        int.TryParse(Console.ReadLine(), out m4);
        Console.Write("Moedas coletadas 5: ");
        int.TryParse(Console.ReadLine(), out m5);
        
        System.Console.WriteLine($"Nome: {m1 + m2 + m3 + m4 + m5}");
        
        Console.WriteLine("\nPressione ENTER para fechar");
        Console.ReadLine();
    }
}