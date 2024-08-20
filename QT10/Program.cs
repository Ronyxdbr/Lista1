/*-------------------------------------------------------------------
Questão 10: Atualização de Pontos de Vida
• Contextualização: Em um jogo de estratégia, um personagem pode ganhar pontos de vida a
cada nível alcançado.
• Comando: Desenvolva um programa que receba os pontos de vida iniciais e o aumento de vida
por nível, e calcule a quantidade de pontos de vida após alcançar um novo nível.

@Lista: 01 - Lógica de Programação
@Autor: Milton Roney de Oliveira Nobre
@Data: 20/08/2024
---------------------------------------------------------------------*/
using System;
class Program
{
    static void Main(string[] args)
    {
        double pvi, apn, na;

        
        Console.Write("Pontos de vida iniciais: ");
        double.TryParse(Console.ReadLine(), out pvi);
        Console.Write("Aumento por nível: ");
        double.TryParse(Console.ReadLine(), out apn);
        Console.Write("Nível alcançado: ");
        double.TryParse(Console.ReadLine(), out na);
        
        System.Console.WriteLine($"Pontos de vida finais: {pvi + (apn * na)}");
       
        Console.WriteLine("\nPressione ENTER para fechar");
        Console.ReadLine();
    }
}