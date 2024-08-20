/*-------------------------------------------------------------------
Atividade 7: Experiência e Nível do Jogador após Batalha
• Contextualização: Em um jogo, o jogador enfrenta dois tipos diferentes de inimigos em uma
batalha. Cada tipo de inimigo concede uma quantidade específica de XP. Após a batalha, o
jogador ganha esse XP e precisa somá-lo ao XP total acumulado para determinar o nível atual
do personagem.
• Comando:Desenvolva um programa que receba a quantidade de XP acumulado, o XP concedido
pelo primeiro tipo de inimigo, o XP concedido pelo segundo tipo de inimigo, o número de cada
tipo de inimigo derrotado, e a constante de nível. O programa deve calcular o XP total
acumulado após a batalha e determinar o nível atual do jogador.

@Lista: 01 - Lógica de Programação
@Autor: Milton Roney de Oliveira Nobre
@Data: 20/08/2024
---------------------------------------------------------------------*/
using System;
class Program
{
    static void Main(string[] args)
    {
        double xp, constnivel, xpini1 , ini1 , xpini2, ini2 ;

        
        Console.Write("XP acumulado: ");
        double.TryParse(Console.ReadLine(), out xp);
        Console.Write("XP inimigo 1: ");
        double.TryParse(Console.ReadLine(), out xpini1);
        Console.Write("Inimigos 1 derrotados: ");
        double.TryParse(Console.ReadLine(), out ini1);
        Console.Write("XP inimigo 2: ");
        double.TryParse(Console.ReadLine(), out xpini2);
        Console.Write("Inimigos 2 derrotados: ");
        double.TryParse(Console.ReadLine(), out ini2);
        Console.Write("Constante de nível: ");
        double.TryParse(Console.ReadLine(), out constnivel);
        
        System.Console.WriteLine($"XP total: {xp + ini1 * xpini1 + ini2 * xpini2}");
        System.Console.WriteLine($"Nível: {(xp + ini1 * xpini1 + ini2 * xpini2) / constnivel}");
       
        Console.WriteLine("\nPressione ENTER para fechar");
        Console.ReadLine();
    }
}